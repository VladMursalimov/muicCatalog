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
    public partial class RegistrationForm : Form
    {
        DataBase dataBase = new DataBase();

        public RegistrationForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataBase.openConnection();  
            Random random = new Random();
            int randomNumber = 0;
            int count = 1;
            do
            {
                randomNumber = random.Next(1, 1000000);

                string query2 = $"use [Музыкальный каталог] select count(*) " +
                    $"from [Альбом]" +
                    $"where [id альбома] = {randomNumber};";
                SqlCommand command2 = new SqlCommand(query2, dataBase.getConnection());

                count = (int)command2.ExecuteScalar();
            } while (count != 0);

            if (count == 0)
            {
                string query = $"SET IDENTITY_INSERT Альбом ON; insert into [Альбом] ([id альбома], [Название альбома], [Дата выпуска], [Длительность альбома в сек]," +
                    $"[Количество песен],[Количество прослушиваний альбома])" +
                    $" values ({randomNumber}, 'Избранные {textBox1.Text}', {1}, {1}, {1}, {1})";
                SqlCommand command1 = new SqlCommand(query, dataBase.getConnection());
                command1.ExecuteNonQuery();

                string querystring = $"SET IDENTITY_INSERT Альбом OFF; SET IDENTITY_INSERT Пользователь ON; insert into [Пользователь] ([id пользователя],[id сборника Избранные], [Имя], [Почта пользователя], [Логин], [Пароль])" +
                    $"values (@iduser,@idalbum, @name, @email, @login, @password)";
                SqlCommand command = new SqlCommand(querystring, dataBase.getConnection());
                command.Parameters.AddWithValue("@iduser", randomNumber);
                command.Parameters.AddWithValue("@idalbum", randomNumber);
                command.Parameters.AddWithValue("@name", textBox1.Text);
                command.Parameters.AddWithValue("@email", textBox2.Text);
                command.Parameters.AddWithValue("@login", textBox3.Text);
                command.Parameters.AddWithValue("@password", textBox4.Text);
                command.ExecuteNonQuery();
            }
            dataBase.closeConnection();
        }

        private void пользовательBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.пользовательBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.Музыкальный_каталогDataSet);

        }

        private void RegistrationForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'Музыкальный_каталогDataSet.Пользователь' table. You can move, or remove it, as needed.
            this.пользовательTableAdapter.Fill(this.Музыкальный_каталогDataSet.Пользователь);

        }
    }
}
