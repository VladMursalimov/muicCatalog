namespace forms
{
    partial class ArtistForm
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
            System.Windows.Forms.Label id_исполнителяLabel1;
            System.Windows.Forms.Label количество_песенLabel;
            System.Windows.Forms.Label количество_альбомовLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ArtistForm));
            this.Музыкальный_каталогDataSet = new forms.Музыкальный_каталогDataSet();
            this.исполнительBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.исполнительTableAdapter = new forms.Музыкальный_каталогDataSetTableAdapters.ИсполнительTableAdapter();
            this.tableAdapterManager = new forms.Музыкальный_каталогDataSetTableAdapters.TableAdapterManager();
            this.исполнительBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.labelaArtistName = new System.Windows.Forms.Label();
            this.id_исполнителяTextBox = new System.Windows.Forms.TextBox();
            this.имяTextBox = new System.Windows.Forms.TextBox();
            this.количество_песенTextBox = new System.Windows.Forms.TextBox();
            this.количество_альбомовTextBox = new System.Windows.Forms.TextBox();
            this.список_песенTableAdapter = new forms.Музыкальный_каталогDataSetTableAdapters.Список_песенTableAdapter();
            this.список_песенBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.urlTextBox = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            id_исполнителяLabel1 = new System.Windows.Forms.Label();
            количество_песенLabel = new System.Windows.Forms.Label();
            количество_альбомовLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Музыкальный_каталогDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.исполнительBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.исполнительBindingNavigator)).BeginInit();
            this.исполнительBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.список_песенBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // id_исполнителяLabel1
            // 
            id_исполнителяLabel1.AutoSize = true;
            id_исполнителяLabel1.Location = new System.Drawing.Point(822, 32);
            id_исполнителяLabel1.Name = "id_исполнителяLabel1";
            id_исполнителяLabel1.Size = new System.Drawing.Size(86, 13);
            id_исполнителяLabel1.TabIndex = 14;
            id_исполнителяLabel1.Text = "id исполнителя:";
            // 
            // количество_песенLabel
            // 
            количество_песенLabel.AutoSize = true;
            количество_песенLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.26415F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            количество_песенLabel.Location = new System.Drawing.Point(28, 138);
            количество_песенLabel.Name = "количество_песенLabel";
            количество_песенLabel.Size = new System.Drawing.Size(200, 25);
            количество_песенLabel.TabIndex = 16;
            количество_песенLabel.Text = "Количество песен:";
            // 
            // количество_альбомовLabel
            // 
            количество_альбомовLabel.AutoSize = true;
            количество_альбомовLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.26415F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            количество_альбомовLabel.Location = new System.Drawing.Point(29, 192);
            количество_альбомовLabel.Name = "количество_альбомовLabel";
            количество_альбомовLabel.Size = new System.Drawing.Size(238, 25);
            количество_альбомовLabel.TabIndex = 17;
            количество_альбомовLabel.Text = "Количество альбомов:";
            // 
            // Музыкальный_каталогDataSet
            // 
            this.Музыкальный_каталогDataSet.DataSetName = "Музыкальный_каталогDataSet";
            this.Музыкальный_каталогDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // исполнительBindingSource
            // 
            this.исполнительBindingSource.DataMember = "Исполнитель";
            this.исполнительBindingSource.DataSource = this.Музыкальный_каталогDataSet;
            // 
            // исполнительTableAdapter
            // 
            this.исполнительTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.UpdateOrder = forms.Музыкальный_каталогDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.АльбомTableAdapter = null;
            this.tableAdapterManager.ЖанрTableAdapter = null;
            this.tableAdapterManager.ИсполнительTableAdapter = this.исполнительTableAdapter;
            this.tableAdapterManager.ПесняTableAdapter = null;
            this.tableAdapterManager.ПользовательTableAdapter = null;
            this.tableAdapterManager.Список_песенTableAdapter = null;
            // 
            // исполнительBindingNavigator
            // 
            this.исполнительBindingNavigator.AddNewItem = null;
            this.исполнительBindingNavigator.BindingSource = this.исполнительBindingSource;
            this.исполнительBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.исполнительBindingNavigator.DeleteItem = null;
            this.исполнительBindingNavigator.ImageScalingSize = new System.Drawing.Size(18, 18);
            this.исполнительBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2});
            this.исполнительBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.исполнительBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.исполнительBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.исполнительBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.исполнительBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.исполнительBindingNavigator.Name = "исполнительBindingNavigator";
            this.исполнительBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.исполнительBindingNavigator.Size = new System.Drawing.Size(1049, 26);
            this.исполнительBindingNavigator.TabIndex = 1;
            this.исполнительBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(39, 23);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(25, 23);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(25, 23);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 26);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9.509434F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 26);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 26);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(25, 23);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(25, 23);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 26);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(33, 305);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 45;
            this.dataGridView1.Size = new System.Drawing.Size(981, 240);
            this.dataGridView1.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.30189F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(29, 248);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 29);
            this.label2.TabIndex = 13;
            this.label2.Text = "Песни";
            // 
            // labelaArtistName
            // 
            this.labelaArtistName.AutoSize = true;
            this.labelaArtistName.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.81132F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelaArtistName.Location = new System.Drawing.Point(26, 53);
            this.labelaArtistName.Name = "labelaArtistName";
            this.labelaArtistName.Size = new System.Drawing.Size(115, 44);
            this.labelaArtistName.TabIndex = 14;
            this.labelaArtistName.Text = "name";
            // 
            // id_исполнителяTextBox
            // 
            this.id_исполнителяTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.исполнительBindingSource, "id исполнителя", true));
            this.id_исполнителяTextBox.Location = new System.Drawing.Point(914, 29);
            this.id_исполнителяTextBox.Name = "id_исполнителяTextBox";
            this.id_исполнителяTextBox.Size = new System.Drawing.Size(100, 20);
            this.id_исполнителяTextBox.TabIndex = 15;
            this.id_исполнителяTextBox.TextChanged += new System.EventHandler(this.id_исполнителяTextBox_TextChanged_1);
            // 
            // имяTextBox
            // 
            this.имяTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.исполнительBindingSource, "Имя", true));
            this.имяTextBox.Location = new System.Drawing.Point(1019, 525);
            this.имяTextBox.Name = "имяTextBox";
            this.имяTextBox.Size = new System.Drawing.Size(10, 20);
            this.имяTextBox.TabIndex = 16;
            // 
            // количество_песенTextBox
            // 
            this.количество_песенTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.исполнительBindingSource, "Количество песен", true));
            this.количество_песенTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.26415F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.количество_песенTextBox.Location = new System.Drawing.Point(278, 135);
            this.количество_песенTextBox.Name = "количество_песенTextBox";
            this.количество_песенTextBox.Size = new System.Drawing.Size(50, 31);
            this.количество_песенTextBox.TabIndex = 17;
            // 
            // количество_альбомовTextBox
            // 
            this.количество_альбомовTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.исполнительBindingSource, "Количество альбомов", true));
            this.количество_альбомовTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.26415F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.количество_альбомовTextBox.Location = new System.Drawing.Point(278, 189);
            this.количество_альбомовTextBox.Name = "количество_альбомовTextBox";
            this.количество_альбомовTextBox.Size = new System.Drawing.Size(50, 31);
            this.количество_альбомовTextBox.TabIndex = 18;
            // 
            // список_песенTableAdapter
            // 
            this.список_песенTableAdapter.ClearBeforeFill = true;
            // 
            // список_песенBindingSource
            // 
            this.список_песенBindingSource.DataMember = "FK_Список песен_Исполнитель";
            this.список_песенBindingSource.DataSource = this.исполнительBindingSource;
            // 
            // urlTextBox
            // 
            this.urlTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.исполнительBindingSource, "url", true));
            this.urlTextBox.Location = new System.Drawing.Point(914, 72);
            this.urlTextBox.Name = "urlTextBox";
            this.urlTextBox.Size = new System.Drawing.Size(100, 20);
            this.urlTextBox.TabIndex = 19;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(814, 72);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(200, 200);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 20;
            this.pictureBox1.TabStop = false;
            // 
            // ArtistForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1049, 590);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.urlTextBox);
            this.Controls.Add(количество_альбомовLabel);
            this.Controls.Add(this.количество_альбомовTextBox);
            this.Controls.Add(количество_песенLabel);
            this.Controls.Add(this.количество_песенTextBox);
            this.Controls.Add(this.имяTextBox);
            this.Controls.Add(id_исполнителяLabel1);
            this.Controls.Add(this.id_исполнителяTextBox);
            this.Controls.Add(this.labelaArtistName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.исполнительBindingNavigator);
            this.Name = "ArtistForm";
            this.Text = "Исполнитель";
            this.Load += new System.EventHandler(this.Form4_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Музыкальный_каталогDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.исполнительBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.исполнительBindingNavigator)).EndInit();
            this.исполнительBindingNavigator.ResumeLayout(false);
            this.исполнительBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.список_песенBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Музыкальный_каталогDataSet Музыкальный_каталогDataSet;

        private System.Windows.Forms.BindingSource исполнительBindingSource;
        private Музыкальный_каталогDataSetTableAdapters.ИсполнительTableAdapter исполнительTableAdapter;
        private Музыкальный_каталогDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator исполнительBindingNavigator;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelaArtistName;
        private System.Windows.Forms.TextBox id_исполнителяTextBox;
        private System.Windows.Forms.TextBox имяTextBox;
        private System.Windows.Forms.TextBox количество_песенTextBox;
        private System.Windows.Forms.TextBox количество_альбомовTextBox;
        private System.Windows.Forms.BindingSource список_песенBindingSource;
        private Музыкальный_каталогDataSetTableAdapters.Список_песенTableAdapter список_песенTableAdapter;
        private System.Windows.Forms.TextBox urlTextBox;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}