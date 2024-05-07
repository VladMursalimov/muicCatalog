namespace forms
{
    partial class AlbumForm1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label id_альбомаLabel;
            System.Windows.Forms.Label дата_выпускаLabel;
            System.Windows.Forms.Label длительность_альбома_в_секLabel;
            System.Windows.Forms.Label количество_прослушиваний_альбомаLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AlbumForm1));
            this.альбомBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.id_альбомаTextBox = new System.Windows.Forms.TextBox();
            this.название_альбомаTextBox = new System.Windows.Forms.TextBox();
            this.дата_выпускаTextBox = new System.Windows.Forms.TextBox();
            this.длительность_альбома_в_секTextBox = new System.Windows.Forms.TextBox();
            this.количество_прослушиваний_альбомаTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.urlTextBox = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.альбомBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.музыкальный_каталогDataSet = new forms.Музыкальный_каталогDataSet();
            this.альбомTableAdapter = new forms.Музыкальный_каталогDataSetTableAdapters.АльбомTableAdapter();
            this.tableAdapterManager = new forms.Музыкальный_каталогDataSetTableAdapters.TableAdapterManager();
            id_альбомаLabel = new System.Windows.Forms.Label();
            дата_выпускаLabel = new System.Windows.Forms.Label();
            длительность_альбома_в_секLabel = new System.Windows.Forms.Label();
            количество_прослушиваний_альбомаLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.альбомBindingNavigator)).BeginInit();
            this.альбомBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.альбомBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.музыкальный_каталогDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // id_альбомаLabel
            // 
            id_альбомаLabel.AutoSize = true;
            id_альбомаLabel.Location = new System.Drawing.Point(619, 14);
            id_альбомаLabel.Name = "id_альбомаLabel";
            id_альбомаLabel.Size = new System.Drawing.Size(65, 13);
            id_альбомаLabel.TabIndex = 1;
            id_альбомаLabel.Text = "id альбома:";
            // 
            // дата_выпускаLabel
            // 
            дата_выпускаLabel.AutoSize = true;
            дата_выпускаLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.22642F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            дата_выпускаLabel.Location = new System.Drawing.Point(31, 148);
            дата_выпускаLabel.Name = "дата_выпускаLabel";
            дата_выпускаLabel.Size = new System.Drawing.Size(137, 24);
            дата_выпускаLabel.TabIndex = 5;
            дата_выпускаLabel.Text = "Дата выпуска:";
            // 
            // длительность_альбома_в_секLabel
            // 
            длительность_альбома_в_секLabel.AutoSize = true;
            длительность_альбома_в_секLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.22642F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            длительность_альбома_в_секLabel.Location = new System.Drawing.Point(31, 184);
            длительность_альбома_в_секLabel.Name = "длительность_альбома_в_секLabel";
            длительность_альбома_в_секLabel.Size = new System.Drawing.Size(145, 24);
            длительность_альбома_в_секLabel.TabIndex = 7;
            длительность_альбома_в_секLabel.Text = "Длительность ";
            // 
            // количество_прослушиваний_альбомаLabel
            // 
            количество_прослушиваний_альбомаLabel.AutoSize = true;
            количество_прослушиваний_альбомаLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.22642F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            количество_прослушиваний_альбомаLabel.Location = new System.Drawing.Point(31, 223);
            количество_прослушиваний_альбомаLabel.Name = "количество_прослушиваний_альбомаLabel";
            количество_прослушиваний_альбомаLabel.Size = new System.Drawing.Size(152, 24);
            количество_прослушиваний_альбомаLabel.TabIndex = 11;
            количество_прослушиваний_альбомаLabel.Text = "Прослушивания";
            // 
            // альбомBindingNavigator
            // 
            this.альбомBindingNavigator.AddNewItem = null;
            this.альбомBindingNavigator.BindingSource = this.альбомBindingSource;
            this.альбомBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.альбомBindingNavigator.DeleteItem = null;
            this.альбомBindingNavigator.ImageScalingSize = new System.Drawing.Size(18, 18);
            this.альбомBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2});
            this.альбомBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.альбомBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.альбомBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.альбомBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.альбомBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.альбомBindingNavigator.Name = "альбомBindingNavigator";
            this.альбомBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.альбомBindingNavigator.Size = new System.Drawing.Size(810, 25);
            this.альбомBindingNavigator.TabIndex = 0;
            this.альбомBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(39, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(25, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(25, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 8.830189F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 25);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(25, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(25, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // id_альбомаTextBox
            // 
            this.id_альбомаTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.альбомBindingSource, "id альбома", true));
            this.id_альбомаTextBox.Location = new System.Drawing.Point(690, 11);
            this.id_альбомаTextBox.Name = "id_альбомаTextBox";
            this.id_альбомаTextBox.Size = new System.Drawing.Size(100, 20);
            this.id_альбомаTextBox.TabIndex = 2;
            this.id_альбомаTextBox.TextChanged += new System.EventHandler(this.id_альбомаTextBox_TextChanged);
            // 
            // название_альбомаTextBox
            // 
            this.название_альбомаTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.альбомBindingSource, "Название альбома", true));
            this.название_альбомаTextBox.Location = new System.Drawing.Point(151, 45);
            this.название_альбомаTextBox.Name = "название_альбомаTextBox";
            this.название_альбомаTextBox.Size = new System.Drawing.Size(10, 20);
            this.название_альбомаTextBox.TabIndex = 4;
            // 
            // дата_выпускаTextBox
            // 
            this.дата_выпускаTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.альбомBindingSource, "Дата выпуска", true));
            this.дата_выпускаTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.22642F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.дата_выпускаTextBox.Location = new System.Drawing.Point(201, 144);
            this.дата_выпускаTextBox.Name = "дата_выпускаTextBox";
            this.дата_выпускаTextBox.Size = new System.Drawing.Size(100, 28);
            this.дата_выпускаTextBox.TabIndex = 6;
            // 
            // длительность_альбома_в_секTextBox
            // 
            this.длительность_альбома_в_секTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.альбомBindingSource, "Длительность альбома в сек", true));
            this.длительность_альбома_в_секTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.22642F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.длительность_альбома_в_секTextBox.Location = new System.Drawing.Point(201, 186);
            this.длительность_альбома_в_секTextBox.Name = "длительность_альбома_в_секTextBox";
            this.длительность_альбома_в_секTextBox.Size = new System.Drawing.Size(100, 28);
            this.длительность_альбома_в_секTextBox.TabIndex = 8;
            // 
            // количество_прослушиваний_альбомаTextBox
            // 
            this.количество_прослушиваний_альбомаTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.альбомBindingSource, "Количество прослушиваний альбома", true));
            this.количество_прослушиваний_альбомаTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.22642F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.количество_прослушиваний_альбомаTextBox.Location = new System.Drawing.Point(201, 222);
            this.количество_прослушиваний_альбомаTextBox.Name = "количество_прослушиваний_альбомаTextBox";
            this.количество_прослушиваний_альбомаTextBox.Size = new System.Drawing.Size(100, 28);
            this.количество_прослушиваний_альбомаTextBox.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 23.77358F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(28, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 39);
            this.label1.TabIndex = 13;
            this.label1.Text = "Album";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(35, 260);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 45;
            this.dataGridView1.Size = new System.Drawing.Size(755, 165);
            this.dataGridView1.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.26415F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(624, 214);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(166, 25);
            this.label2.TabIndex = 15;
            this.label2.Text = "Песни альбома";
            // 
            // urlTextBox
            // 
            this.urlTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.альбомBindingSource, "url", true));
            this.urlTextBox.Location = new System.Drawing.Point(690, 63);
            this.urlTextBox.Name = "urlTextBox";
            this.urlTextBox.Size = new System.Drawing.Size(100, 20);
            this.urlTextBox.TabIndex = 16;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(624, 45);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(166, 159);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            // 
            // альбомBindingSource
            // 
            this.альбомBindingSource.DataMember = "Альбом";
            this.альбомBindingSource.DataSource = this.музыкальный_каталогDataSet;
            // 
            // музыкальный_каталогDataSet
            // 
            this.музыкальный_каталогDataSet.DataSetName = "Музыкальный_каталогDataSet";
            this.музыкальный_каталогDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // альбомTableAdapter
            // 
            this.альбомTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.UpdateOrder = forms.Музыкальный_каталогDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.АльбомTableAdapter = this.альбомTableAdapter;
            this.tableAdapterManager.ЖанрTableAdapter = null;
            this.tableAdapterManager.ИсполнительTableAdapter = null;
            this.tableAdapterManager.ПесняTableAdapter = null;
            this.tableAdapterManager.ПользовательTableAdapter = null;
            this.tableAdapterManager.Список_песенTableAdapter = null;
            // 
            // AlbumForm1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(810, 456);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.urlTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Controls.Add(количество_прослушиваний_альбомаLabel);
            this.Controls.Add(this.количество_прослушиваний_альбомаTextBox);
            this.Controls.Add(длительность_альбома_в_секLabel);
            this.Controls.Add(this.длительность_альбома_в_секTextBox);
            this.Controls.Add(дата_выпускаLabel);
            this.Controls.Add(this.дата_выпускаTextBox);
            this.Controls.Add(this.название_альбомаTextBox);
            this.Controls.Add(id_альбомаLabel);
            this.Controls.Add(this.id_альбомаTextBox);
            this.Controls.Add(this.альбомBindingNavigator);
            this.Name = "AlbumForm1";
            this.Text = "Альбом";
            this.Load += new System.EventHandler(this.AlbumForm1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.альбомBindingNavigator)).EndInit();
            this.альбомBindingNavigator.ResumeLayout(false);
            this.альбомBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.альбомBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.музыкальный_каталогDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Музыкальный_каталогDataSet музыкальный_каталогDataSet;
        private System.Windows.Forms.BindingSource альбомBindingSource;
        private Музыкальный_каталогDataSetTableAdapters.АльбомTableAdapter альбомTableAdapter;
        private Музыкальный_каталогDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator альбомBindingNavigator;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.TextBox id_альбомаTextBox;
        private System.Windows.Forms.TextBox название_альбомаTextBox;
        private System.Windows.Forms.TextBox дата_выпускаTextBox;
        private System.Windows.Forms.TextBox длительность_альбома_в_секTextBox;
        private System.Windows.Forms.TextBox количество_прослушиваний_альбомаTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox urlTextBox;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}