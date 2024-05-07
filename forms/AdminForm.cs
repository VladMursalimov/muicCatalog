using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace forms
{
    public partial class AdminForm : Form
    {
        DataBase dataBase = new DataBase();

        public AdminForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)//delete song
        {
            try
            {
                int songid = 0;
                string songname = songNameTextBox.Text;

                string query1 = $"select [id песни]" +
                    $"from Песня where [Название песни] = '{songname}';";

                dataBase.openConnection();
                using (SqlCommand command1 = new SqlCommand(query1, dataBase.getConnection()))
                {
                    using (SqlDataReader reader = command1.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            songid = reader.GetInt32(0);
                        }
                    }
                }


                string query = $"delete from [Список песен]" +
                    $"where [id песни] = {songid};" +
                    $"delete from [Песня]" +
                    $"where [id песни] = '{songid}';";
                using (SqlCommand command = new SqlCommand(query, dataBase.getConnection()))
                {
                    command.ExecuteNonQuery();
                }


                dataBase.closeConnection();
            }
            catch (Exception error){ MessageBox.Show(error.Message.ToString()); }
        }


        private void песняBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.песняBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.Музыкальный_каталогDataSet);

        }

        private void AdminForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'Музыкальный_каталогDataSet.Песня' table. You can move, or remove it, as needed.
            this.песняTableAdapter.Fill(this.Музыкальный_каталогDataSet.Песня);

        }

        private void button2_Click(object sender, EventArgs e)//add song
        {
            try
            {
                Random random = new Random();
                int songid = random.Next(1, 1000000);
                string songname = textBox1.Text;
                string albumname = textBox2.Text;
                string date = textBox3.Text;
                int songduration = Int32.Parse(textBox4.Text);
                int viewcount = Int32.Parse(textBox5.Text);
                int genreid = Int32.Parse(textBox6.Text);
                string artist = textBox7.Text;
                int albumid = 0;
                int artistid = 0;
                bool newartist = false;
                bool newalbum = false;
                dataBase.openConnection();
                string query = $"select (select top 1 [id альбома]" +
                    $"from [Альбом] " +
                    $"where [Название альбома] = '{albumname}') " +
                    $"as AlbumId, count(*) as Count from [Альбом] where [Название альбома] = '{albumname}';";

                using (SqlCommand command = new SqlCommand(query, dataBase.getConnection()))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            if (!reader.IsDBNull(0))
                            {
                                albumid = reader.GetInt32(0);
                            }
                            int count = reader.GetInt32(1); // читаем count
                            if (count == 0)
                            {
                                newalbum = true;
                                albumid = random.Next(1, 1000000);
                            }
                        }
                    }
                }

                if (newalbum)
                {
                    addAlbum(albumid, albumname, date, 1, songduration, viewcount);
                }

                string query2 = $"select (select top 1 [id исполнителя]" +
                   $"from [Исполнитель] " +
                   $"where [Имя] = '{artist}') " +
                   $"as artistid, count(*) as Count from [Исполнитель] where [Имя] = '{artist}';";

                using (SqlCommand command = new SqlCommand(query2, dataBase.getConnection()))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            if (!reader.IsDBNull(0))
                            {
                                artistid = reader.GetInt32(0);
                            }
                            int count = reader.GetInt32(1); // читаем count
                            if (count == 0)
                            {
                                newartist = true;
                                artistid = random.Next(1, 1000000);
                            }
                        }
                    }
                }
                if (newartist)
                {
                    addArtist(artistid, artist, random.Next(1, 1000000), 1, 1);

                }
                string sql1 = "SET IDENTITY_INSERT Альбом OFF; INSERT INTO [Песня] ([id песни],[Название песни],[Название альбома],[Дата],[Длительность в сек]" +
                    ",[Количество прослушиваний],[id альбома],[id жанра]) " +
                    "VALUES (@songid, @songname, @albumname, @date, @songduration, @viewcount, @albumid, @genreid);";

                using (SqlCommand command = new SqlCommand(sql1, dataBase.getConnection()))
                {
                    command.Parameters.AddWithValue("@songid", songid);
                    command.Parameters.AddWithValue("@songname", songname);
                    command.Parameters.AddWithValue("@albumname", albumname);
                    command.Parameters.AddWithValue("@date", date);
                    command.Parameters.AddWithValue("@songduration", songduration);
                    command.Parameters.AddWithValue("@viewcount", viewcount);
                    command.Parameters.AddWithValue("@genreid", genreid);
                    command.Parameters.AddWithValue("@albumid", albumid);
                    command.ExecuteNonQuery();
                }



                string sql3 = "INSERT INTO [Список песен] ([id песни] ,[id альбома],[id исполнителя]) " +
                   "VALUES (@songid, @albumid, @artistid);";

                using (SqlCommand command = new SqlCommand(sql3, dataBase.getConnection()))
                {
                    command.Parameters.AddWithValue("@songid", songid);
                    command.Parameters.AddWithValue("@albumid", albumid);
                    command.Parameters.AddWithValue("@artistid", artistid);
                    command.ExecuteNonQuery();
                }

                dataBase.closeConnection();
            }
            catch (Exception error) { MessageBox.Show(error.Message.ToString()); }

        }

        private void addArtist(int artistid, string artist, int topid, int songcount, int albumcount)
        {
            try
            {
                string sql2 = "INSERT INTO [Исполнитель] ([id исполнителя]" +
                                        ",[Имя]" +
                                        ",[Id списка песен по прослушиваниям]" +
                                        ",[Количество песен]" +
                                        ",[Количество альбомов]) " +
                               "VALUES (@id, @name, @topid, @songcount, @albumcount);";

                using (SqlCommand command1 = new SqlCommand(sql2, dataBase.getConnection()))
                {
                    command1.Parameters.AddWithValue("@id", artistid);
                    command1.Parameters.AddWithValue("@name", artist);
                    command1.Parameters.AddWithValue("@topid", topid);
                    command1.Parameters.AddWithValue("@songcount", songcount);
                    command1.Parameters.AddWithValue("@albumcount", albumcount);
                    command1.ExecuteNonQuery();
                }
            }
            catch (Exception error) { MessageBox.Show(error.Message.ToString()); }


        }

        private void addAlbum(int albumid, string albumname, string date, int songduration, int songcount, int viewcount)
        {
            try
            {
                string sql = "SET IDENTITY_INSERT Альбом ON; INSERT INTO [Альбом] ([id альбома],[Название альбома],[Дата выпуска]" +
                    ",[Длительность альбома в сек],[Количество песен],[Количество прослушиваний альбома]) " +
                    "VALUES (@albumid, @albumname, @date, @duration, @songcount,@viewcount);";

                using (SqlCommand command1 = new SqlCommand(sql, dataBase.getConnection()))
                {
                    command1.Parameters.AddWithValue("@albumid", albumid);
                    command1.Parameters.AddWithValue("@albumname", albumname);
                    command1.Parameters.AddWithValue("@date", date);
                    command1.Parameters.AddWithValue("@duration", songduration);
                    command1.Parameters.AddWithValue("@songcount", songcount);
                    command1.Parameters.AddWithValue("@viewcount", viewcount);

                    command1.ExecuteNonQuery();
                }
            }
            catch (Exception error) { MessageBox.Show(error.Message.ToString()); }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                dataBase.openConnection();

                string albumname = textBox8.Text;

                int albumid = 0;

                string query = $"delete from [Список песен] " +
                   $"where [id альбома] in " +
                   $"(select [id альбома] from Альбом " +
                   $"where [Название альбома] = '{albumname}');" +
                   $"delete from Песня " +
                   $"where [id альбома] in " +
                   $"(select [id альбома] from Альбом " +
                   $"where [Название альбома] = '{albumname}');" +
                   $"delete from Альбом " +
                   $"where [Название альбома] = '{albumname}';";

                using (SqlCommand command = new SqlCommand(query, dataBase.getConnection()))
                {
                    command.ExecuteNonQuery();
                }
                dataBase.closeConnection();
            }
            catch (Exception error) { MessageBox.Show(error.Message.ToString()); }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                dataBase.openConnection();
                string albumname = textBox9.Text;
                Random random = new Random();
                int albumid = random.Next(0, 10000000);

                addAlbum(albumid, albumname, textBox10.Text, Int32.Parse(textBox11.Text),
                    Int32.Parse(textBox12.Text), Int32.Parse(textBox13.Text));
                dataBase.closeConnection();
            }
            catch (Exception error) { MessageBox.Show(error.Message.ToString()); }

        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                dataBase.openConnection();

                string artistname = textBox14Name.Text;

                string query = $"delete from [Список песен] " +
                               $"where [id исполнителя] in " +
                               $"(select [id исполнителя] from Исполнитель " +
                               $"where [Имя] = '{artistname}');" +
                               $"delete from Песня " +
                               $"where [id песни] in " +
                               $"(select [id песни] from [Список песен] " +
                               $"where [id исполнителя] in " +
                               $"(select [id исполнителя] from Исполнитель " +
                               $"where [Имя] = '{artistname}'));" +
                               $"delete from Альбом " +
                               $"where [id альбома] in " +
                               $"(select [id альбома] from [Список песен] " +
                               $"where [id исполнителя] in " +
                               $"(select [id исполнителя] from Исполнитель " +
                               $"where [Имя] = '{artistname}'));" +
                               $"delete from Исполнитель " +
                               $"where [Имя] = '{artistname}'";


                using (SqlCommand command = new SqlCommand(query, dataBase.getConnection()))
                {
                    command.ExecuteNonQuery();
                }
                dataBase.closeConnection();
            }
            catch (Exception error) { MessageBox.Show(error.Message.ToString()); }

        }

        private void button6_Click(object sender, EventArgs e)
        {
            try
            {
                dataBase.openConnection();
                Random rnd = new Random();
                addArtist(rnd.Next(1, 1000000), textBox15Name.Text, rnd.Next(1, 1000000), Int32.Parse(textBox16CountSong.Text), Int32.Parse(textBox17CountAlbum.Text));
                dataBase.closeConnection();
            }
            catch (Exception error) { MessageBox.Show(error.Message.ToString()); }

        }

        private void button7_Click(object sender, EventArgs e)
        {
            AdminSong adminSong = new AdminSong();
            adminSong.Show();

        }

        private void button8_Click(object sender, EventArgs e)
        {
            AdminAlbum adminAlbum = new AdminAlbum();
            adminAlbum.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            AdminArtist adminArtist = new AdminArtist();
            adminArtist.Show();
        }
    }
}
