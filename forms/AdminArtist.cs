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
    public partial class AdminArtist : Form
    {
        public AdminArtist()
        {
            InitializeComponent();
        }

        private void исполнительBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.исполнительBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.музыкальный_каталогDataSet);

        }

        private void AdminArtist_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'музыкальный_каталогDataSet.Список_песен' table. You can move, or remove it, as needed.
            this.список_песенTableAdapter.Fill(this.музыкальный_каталогDataSet.Список_песен);
            // TODO: This line of code loads data into the 'музыкальный_каталогDataSet.Исполнитель' table. You can move, or remove it, as needed.
            this.исполнительTableAdapter.Fill(this.музыкальный_каталогDataSet.Исполнитель);

        }
    }
}
