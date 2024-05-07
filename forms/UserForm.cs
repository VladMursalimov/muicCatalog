using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace forms
{
    public partial class UserForm : Form
    {   public bool isSigned = false;
        public string userid;
        public bool isAdmin = false;
        DataBase dataBase = new DataBase();
        public UserForm()
        {
            InitializeComponent();
        }

        private void пользовательBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.пользовательBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.Музыкальный_каталогDataSet);

        }

        private void UserForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'Музыкальный_каталогDataSet.Пользователь' table. You can move, or remove it, as needed.
            this.пользовательTableAdapter.Fill(this.Музыкальный_каталогDataSet.Пользователь);
            id_пользователяTextBox.Text = "";
            id_сборника_ИзбранныеTextBox.Text = "";
            имяTextBox.Text = "";
            почта_пользователяTextBox.Text = "";
            логинTextBox.Text = "";
            парольTextBox.Text = "";

        }

        private void button1_Click(object sender, EventArgs e)//регистрация
        {
            RegistrationForm registrationForm = new RegistrationForm();
            registrationForm.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e) //вход
        {   
            dataBase.openConnection();
            string query = $"use [Музыкальный каталог];" +
                $" select * from Пользователь where [Логин] = '{логинTextBox.Text}' and " +
                $"[Пароль] = '{парольTextBox.Text}'";
            SqlCommand command1 = new SqlCommand(query, dataBase.getConnection());
            SqlDataReader reader = command1.ExecuteReader();

            if (reader.Read())
            {
                id_пользователяTextBox.Text = reader.GetInt32(0).ToString();
                id_сборника_ИзбранныеTextBox.Text = reader.GetInt32(1).ToString();
                имяTextBox.Text = reader.GetString(2).ToString();
                почта_пользователяTextBox.Text = reader.GetString(3).ToString();
                
                isSigned = true;
                userid = id_пользователяTextBox.Text;
                isAdmin = имяTextBox.Text.Contains("admin");
            }
            else
            {
                MessageBox.Show("неверный логин или пароль");
            }
            dataBase.closeConnection();

            if (isSigned)
            {
                isAdmin = имяTextBox.Text.Contains("admin");
                string albumid = id_сборника_ИзбранныеTextBox.Text;
                DataTable table = new DataTable();
                string querystring = $"select [id песни] from [Список песен] where [id альбома] = {albumid}";
                SqlCommand command = new SqlCommand(querystring, dataBase.getConnection());
                dataBase.openConnection();
                List<string> songs = new List<string>();
                string songid;
                using (SqlDataReader reader1 = command.ExecuteReader())
                {
                    while (reader1.Read())
                    {

                        songid = reader1.GetInt32(0).ToString();
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

                    SqlCommand command2 = new SqlCommand(querystring1, dataBase.getConnection());
                    SqlDataAdapter adapter = new SqlDataAdapter();
                    adapter.SelectCommand = command2;

                    // Очистка таблицы перед заполнением новыми данными
                    adapter.Fill(table);
                }

                // Установка источника данных для DataGridView вне цикла, чтобы отобразить все результаты
                dataGridView1.DataSource = table;
                dataBase.closeConnection();

            }
        }

        private void id_пользователяTextBox_TextChanged(object sender, EventArgs e)
        {  
            

        }
    }
}
