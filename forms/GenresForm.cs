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
    public partial class GenresForm : Form
    {
        public GenresForm()
        {
            InitializeComponent();
        }

        private void жанрBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.жанрBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.Музыкальный_каталогDataSet);

        }

        private void Form5_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'музыкальный_каталогDataSet.Жанр' table. You can move, or remove it, as needed.
            this.жанрTableAdapter.Fill(this.Музыкальный_каталогDataSet.Жанр);
        }
    }
}
