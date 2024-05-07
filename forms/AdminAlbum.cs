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
    public partial class AdminAlbum : Form
    {
        public AdminAlbum()
        {
            InitializeComponent();
        }

        private void альбомBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.альбомBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.музыкальный_каталогDataSet);

        }

        private void AdminAlbum_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'музыкальный_каталогDataSet.Альбом' table. You can move, or remove it, as needed.
            this.альбомTableAdapter.Fill(this.музыкальный_каталогDataSet.Альбом);

        }
    }
}
