using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using RestSharp;


namespace forms
{
    public partial class ArtistForm : Form
    {
        DataBase dataBase = new DataBase();

        public ArtistForm()
        {
            InitializeComponent();
        }

        private void исполнительBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.исполнительBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.Музыкальный_каталогDataSet);

        }

        private void Form4_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'Музыкальный_каталогDataSet.Список_песен' table. You can move, or remove it, as needed.
            this.список_песенTableAdapter.Fill(this.Музыкальный_каталогDataSet.Список_песен);
            // TODO: This line of code loads data into the 'музыкальный_каталогDataSet.Исполнитель' table. You can move, or remove it, as needed.
            this.исполнительTableAdapter.Fill(this.Музыкальный_каталогDataSet.Исполнитель);
        }


        private void id_исполнителяTextBox_TextChanged_1(object sender, EventArgs e)
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
            
            string artistid = id_исполнителяTextBox.Text;
            labelaArtistName.Text = имяTextBox.Text;
            DataTable table = new DataTable();
            string querystring = $"select [id песни] from [Список песен] where [id исполнителя] = {artistid}";
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

                    // Закрытие DataReader после использования
                }
            }
            HashSet<string> uniqueSongs = new HashSet<string>(songs);
            //количество_песенTextBox.Text = uniqueSongs.Count.ToString();
            // Преобразование уникальных элементов обратно в список, если это необходимо
            List<string> uniqueSongsList = uniqueSongs.ToList();
            foreach (string song in uniqueSongsList)
            {
                string querystring1 = $"select * from [Песня] where [id песни] = {song}";
                SqlCommand command1 = new SqlCommand(querystring1, dataBase.getConnection());
                SqlDataAdapter adapter = new SqlDataAdapter();
                adapter.SelectCommand = command1;

                // Очистка таблицы перед заполнением новыми данными
                adapter.Fill(table);
            }
            // Установка источника данных для DataGridView вне цикла, чтобы отобразить все результаты
            dataGridView1.DataSource = table;
        }
        private void updateUrl()
        {

        }
    }
}
