using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace forms
{
    public partial class SongForm : Form
    {   
        bool isSigned = false;
        string userId;
        DataBase dataBase = new DataBase();
        public SongForm(bool isSigned, string userId)
        {
            InitializeComponent();
            this.isSigned = isSigned;
            this.userId = userId;   
        }

        private void песняBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.песняBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.музыкальный_каталогDataSet);

        }

        private void Form3_Load(object sender, EventArgs e)
        {
           

            // TODO: This line of code loads data into the 'музыкальный_каталогDataSet.Песня' table. You can move, or remove it, as needed.
            this.песняTableAdapter.Fill(this.Музыкальный_каталогDataSet.Песня);
            if (isSigned)
            {
                button1.Visible = true;
                button2.Visible = true;
            }

        }

        private void button1_Click(object sender, EventArgs e)//add song to favorites
        {
            dataBase.openConnection();
            string query = $"select [id исполнителя] from [Список песен] where [id песни] = {id_песниTextBox.Text};";
            SqlCommand command = new SqlCommand(query, dataBase.getConnection());
            List<string> artists = new List<string>();
            string artistid;
            using (SqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {

                    artistid = reader.GetInt32(0).ToString();
                    artists.Add(artistid);
                }
            }
            foreach (string aid in artists)
            {
                string query1 = $"IF NOT EXISTS (SELECT 1 FROM [Список песен] " +
                    $"WHERE [id песни] = {id_песниTextBox.Text} AND [id альбома] = {userId} AND [id исполнителя] = {aid}) " +
                $"INSERT INTO [Список песен] ([id песни], [id альбома], [id исполнителя])" +
                $" VALUES ({id_песниTextBox.Text}, {userId}, {aid})";

                SqlCommand command1 = new SqlCommand(query1, dataBase.getConnection());
                command1.ExecuteNonQuery();

            }
            dataBase.closeConnection();

        }


        private void button2_Click(object sender, EventArgs e)//delete from fav
        {
            dataBase.openConnection();
            string query = $"delete from [Список песен] where [id песни] = {id_песниTextBox.Text} "+
                $"and [id альбома] = {userId}"; 
            SqlCommand command = new SqlCommand(query, dataBase.getConnection());
            command.ExecuteNonQuery();
            
            dataBase.closeConnection();
        }


        private void id_песниTextBox_TextChanged_1(object sender, EventArgs e)
        {
            try
            {
                if (urlTextBox.Text != "")
                {
                    WebRequest request = WebRequest.Create("http://" + urlTextBox.Text);
                    WebResponse response = request.GetResponse();
                    Stream stream = response.GetResponseStream();
                    pictureBox1.Image = Bitmap.FromStream(stream);
                }
                else
                {
                    pictureBox1.Image = pictureBox1.InitialImage;

                }
            }
            catch { Console.WriteLine(urlTextBox.Text); }
            имяTextBox.Text = "";
            dataBase.openConnection();
            string query1 = $"SELECT distinct i.[Имя] as [Имя исполнителя] " +
                $"FROM [Песня] s " +
                $"INNER JOIN [Список песен] sp ON s.[id песни] = sp.[id песни] " +
                $"INNER JOIN [Исполнитель] i ON sp.[id исполнителя] = i.[id исполнителя] " +
                $"WHERE s.[id песни] = {id_песниTextBox.Text};";
            SqlCommand command1 = new SqlCommand(query1, dataBase.getConnection());
            SqlDataReader reader = command1.ExecuteReader();
            int count = 0;
            while (reader.Read())
            {
                if (count > 0)
                {
                    имяTextBox.Text += ", ";
                }
                имяTextBox.Text += reader.GetString(0).Trim();

                count++;
            }
            reader.Close();
            query1 = $"select [Название жанра] " +
                $"from [Жанр]" +
                $"where [Жанр].[id жанра] = {id_жанраTextBox.Text};";
            SqlCommand command2 = new SqlCommand(query1, dataBase.getConnection());
            SqlDataReader reader2 = command2.ExecuteReader();
            while (reader2.Read())
            {
                genre_textBox.Text = reader2.GetString(0);
            }


            dataBase.closeConnection();
        }

        private void название_песниTextBox_TextChanged_1(object sender, EventArgs e)
        {
            label1.Text = название_песниTextBox.Text;
            label1.Text = label1.Text.Trim().Replace("\n", "");
            label1.Text += " \n" + имяTextBox.Text;
        }

        private void датаDateTimePicker_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
