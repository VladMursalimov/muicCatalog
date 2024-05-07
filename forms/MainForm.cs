using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace forms
{
    public partial class MainForm : Form
    {
        UserForm userForm = new UserForm();
        bool isAdmin = false;
        bool isSigned = false;
        string userid;
        public MainForm()
        {   
            InitializeComponent();
        }

        private void альбомBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();

        }


        private void button1_Click(object sender, EventArgs e)
        {
            AlbumForm1 albumForm = new AlbumForm1();
            albumForm.StartPosition = FormStartPosition.CenterScreen;
            albumForm.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ArtistForm artistForm = new ArtistForm();
            artistForm.StartPosition = FormStartPosition.CenterScreen;

            artistForm.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            GenresForm genresForm = new GenresForm();
            genresForm.StartPosition = FormStartPosition.CenterScreen;
            genresForm.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {   
            userForm = new UserForm();
            userForm.StartPosition = FormStartPosition.CenterScreen;

            userForm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            userid = userForm.userid;
            isSigned = userForm.isSigned;
            SongForm songForm = new SongForm(isSigned, userid);
            songForm.StartPosition = FormStartPosition.CenterScreen;

            songForm.Show();
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            isAdmin = userForm.isAdmin;
            isAdmin = true;

            if (isAdmin)
            {
                AdminForm adminForm = new AdminForm();
                adminForm.StartPosition = FormStartPosition.CenterScreen;

                adminForm.Show();
            }
            else
            {
                MessageBox.Show("У Вас нет прав администратора");
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            FindForm findForm = new FindForm();
            findForm.StartPosition = FormStartPosition.CenterScreen;

            findForm.Show();
        }

       
    }
}
