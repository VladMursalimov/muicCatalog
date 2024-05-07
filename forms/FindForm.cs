using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace forms
{
    public partial class FindForm : Form
    {   DataBase dataBase = new DataBase();
        public FindForm()
        {
            InitializeComponent();
        }


        private void textBox3Artist_TextChanged(object sender, EventArgs e)
        {
            dataBase.openConnection();
            DataTable table = new DataTable();
            string q1 = "SELECT distinct Исполнитель.[Имя], Альбом.[Название альбома], " +
                "Песня.[Название песни],Исполнитель.[Количество альбомов], Исполнитель.[Количество песен] " +
                "FROM Исполнитель " +
                "INNER JOIN [Список песен] ON Исполнитель.[id исполнителя] = [Список песен].[id исполнителя] " +
                "INNER JOIN Альбом ON [Список песен].[id альбома] = Альбом.[id альбома] " +
                "INNER JOIN Песня ON Песня.[id альбома] = Альбом.[id альбома] " +
                $"WHERE Исполнитель.Имя like '{textBox3Artist.Text}%'; ";
            string q = $"select url from Исполнитель where [Имя] like '{textBox3Artist.Text}%'";
            SqlCommand command = new SqlCommand(q, dataBase.getConnection());
            SqlDataReader reader = command.ExecuteReader();
            try
            {
                if (reader.Read())
                {
                    string url = reader.GetString(0);
                    if (url != "")
                    {
                        WebRequest request = WebRequest.Create("http://" + url);
                        WebResponse response = request.GetResponse();
                        Stream stream = response.GetResponseStream();
                        pictureBox1.Image = Bitmap.FromStream(stream);
                    }
                }
                else
                {
                    pictureBox1.Image = pictureBox1.InitialImage;
                }

            }
            catch (Exception error) { Console.WriteLine(error.Message.ToString()); }
            reader.Close();
            SqlCommand command1 = new SqlCommand(q1, dataBase.getConnection());
            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = command1;

            // Очистка таблицы перед заполнением новыми данными
            adapter.Fill(table);


            // Установка источника данных для DataGridView вне цикла, чтобы отобразить все результаты
            dataGridView1.DataSource = table;
            dataBase.closeConnection();
        }

        private void textBox2Album_TextChanged(object sender, EventArgs e)
        {
            dataBase.openConnection();
            DataTable table = new DataTable();
            string q1 = "SELECT distinct Альбом.[Название альбома], Исполнитель.[Имя] as Исполнитель, Альбом.[Дата выпуска], " +
              "Песня.[Название песни], Альбом.[Длительность альбома в сек], Альбом.[Количество песен] " +
              "FROM Исполнитель " +
              "INNER JOIN [Список песен] ON Исполнитель.[id исполнителя] = [Список песен].[id исполнителя] " +
              "INNER JOIN Альбом ON [Список песен].[id альбома] = Альбом.[id альбома] " +
              $"INNER JOIN Песня ON Песня.[Название альбома] like '{textBox2Album.Text}%' " +
              $"WHERE Альбом.[Название альбома] like '{textBox2Album.Text}%' " +
              "GROUP BY  Альбом.[Название альбома], Исполнитель.[Имя], Альбом.[Дата выпуска], " +
              "Песня.[Название песни], Альбом.[Длительность альбома в сек], Альбом.[Количество песен];";

            string q = $"select url from Альбом where [Название альбома] like '{textBox2Album.Text}%'";
            SqlCommand command = new SqlCommand(q, dataBase.getConnection());
            SqlDataReader reader = command.ExecuteReader();
            try
            {
                if (reader.Read())
                {
                    string url = reader.GetString(0);
                    if (url != "")
                    {
                        WebRequest request = WebRequest.Create("http://" + url);
                        WebResponse response = request.GetResponse();
                        Stream stream = response.GetResponseStream();
                        pictureBox1.Image = Bitmap.FromStream(stream);
                    }
                }
                else
                {
                    pictureBox1.Image = pictureBox1.InitialImage;
                }

            }
            catch (Exception error) { Console.WriteLine(error.Message.ToString()); }

            reader.Close();
            SqlCommand command1 = new SqlCommand(q1, dataBase.getConnection());
            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = command1;

            // Очистка таблицы перед заполнением новыми данными
            adapter.Fill(table);


            // Установка источника данных для DataGridView вне цикла, чтобы отобразить все результаты
            dataGridView1.DataSource = table;
            dataBase.closeConnection();
        }

        private void textBox1Song_TextChanged(object sender, EventArgs e)
        {
            dataBase.openConnection();
            DataTable table = new DataTable();
            string q1 =
                "SELECT distinct Песня.[Название песни], Исполнитель.[Имя] as Исполнитель, Песня.[Название альбома],  " +
                 "Песня.[Дата], Песня.[Длительность в сек], Жанр.[Название жанра] " +
                 "FROM Исполнитель " +
                 "INNER JOIN[Список песен] ON Исполнитель.[id исполнителя] = [Список песен].[id исполнителя] " +
                 "INNER JOIN Песня ON[Список песен].[id песни] = Песня.[ID песни] " +
                 "INNER JOIN Жанр ON[Жанр].[id жанра] = Песня.[id жанра] " +
                 $"WHERE Песня.[Название песни] like '{textBox1Song.Text}%';";

            string q = $"select url from Песня where [Название песни] like '{textBox1Song.Text}%'";
            SqlCommand command = new SqlCommand(q, dataBase.getConnection());
            SqlDataReader reader = command.ExecuteReader();
            try
            {
                if (reader.Read())
                {
                    string url = reader.GetString(0);
                    if (url != "")
                    {
                        WebRequest request = WebRequest.Create("http://" + url);
                        WebResponse response = request.GetResponse();
                        Stream stream = response.GetResponseStream();
                        pictureBox1.Image = Bitmap.FromStream(stream);
                    }
                }
                else
                {
                    pictureBox1.Image = pictureBox1.InitialImage;
                }

            }
            catch (Exception error) { Console.WriteLine(error.Message.ToString()); }

            reader.Close();
            SqlCommand command1 = new SqlCommand(q1, dataBase.getConnection());
            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = command1;

            // Очистка таблицы перед заполнением новыми данными
            adapter.Fill(table);


            // Установка источника данных для DataGridView вне цикла, чтобы отобразить все результаты
            dataGridView1.DataSource = table;
            dataBase.closeConnection();
        }
    }
}
