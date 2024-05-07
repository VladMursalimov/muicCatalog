using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using RestSharp;


namespace forms
{
    public partial class AlbumForm1 : Form
    {
        DataBase dataBase = new DataBase();

        public AlbumForm1()
        {
            InitializeComponent();
        }

        private void альбомBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.альбомBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.музыкальный_каталогDataSet);

        }

        private void AlbumForm1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'музыкальный_каталогDataSet.Альбом' table. You can move, or remove it, as needed.
            this.альбомTableAdapter.Fill(this.музыкальный_каталогDataSet.Альбом);

        }

        private void id_альбомаTextBox_TextChanged(object sender, EventArgs e)
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
            catch (Exception error) { Console.WriteLine(error.Message.ToString()); }

            string albumid = id_альбомаTextBox.Text;

            label1.Text = название_альбомаTextBox.Text;
            DataTable table = new DataTable();
            string querystring = $"select [id песни] from [Список песен] where [id альбома] = {albumid}";
            SqlCommand command = new SqlCommand(querystring, dataBase.getConnection());
            dataBase.openConnection();
            List<string> songs = new List<string>();
            string songid;
            using (SqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {

                    songid = reader.GetInt32(0).ToString();
                    songs.Add(songid);

                }
            }
            HashSet<string> uniqueSongs = new HashSet<string>(songs);

            // Преобразование уникальных элементов обратно в список, если это необходимо
            List<string> uniqueSongsList = uniqueSongs.ToList();
            foreach (string song in uniqueSongsList)
            {
                string querystring1 = $"SELECT DISTINCT i.[Имя] as [Имя исполнителя], s.[Название песни], s.[Название альбома], g.[Название жанра] " +
                        $"FROM[Песня] s " +
                        $"INNER JOIN[Жанр] g ON s.[id жанра] = g.[id жанра] " +
                        $"INNER JOIN [Список песен] sp ON s.[id песни] = sp.[id песни] " +
                        $"INNER JOIN [Исполнитель] i ON sp.[id исполнителя] = i.[id исполнителя]" +
                        $"WHERE s.[id песни] = {song};";
                SqlCommand command1 = new SqlCommand(querystring1, dataBase.getConnection());
                SqlDataAdapter adapter = new SqlDataAdapter();
                adapter.SelectCommand = command1;

                adapter.Fill(table);

            }
            string artistName = table.Rows[0]["Имя исполнителя"].ToString();
            label1.Text = label1.Text.Trim().Replace("\n", "");
            label1.Text += $" \n{artistName}";
            // Установка источника данных для DataGridView вне цикла, чтобы отобразить все результаты
            dataGridView1.DataSource = table;
        }
    }
}
