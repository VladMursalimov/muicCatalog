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
    public partial class AdminSong : Form
    {
        public AdminSong()
        {
            InitializeComponent();
        }

        private void песняBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.песняBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.музыкальный_каталогDataSet);

        }

        private void AdminSong_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'музыкальный_каталогDataSet.Песня' table. You can move, or remove it, as needed.
            this.песняTableAdapter.Fill(this.музыкальный_каталогDataSet.Песня);

        }
    }
}
