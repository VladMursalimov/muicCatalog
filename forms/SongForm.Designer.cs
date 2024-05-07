namespace forms
{
    partial class SongForm
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
            System.Windows.Forms.Label название_альбомаLabel;
            System.Windows.Forms.Label дата_выпускаLabel;
            System.Windows.Forms.Label длительность_в_секLabel;
            System.Windows.Forms.Label количество_прослушиванийLabel;
            System.Windows.Forms.Label id_песниLabel;
            System.Windows.Forms.Label id_альбомаLabel;
            System.Windows.Forms.Label id_жанраLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SongForm));
            this.Музыкальный_каталогDataSet = new forms.Музыкальный_каталогDataSet();
            this.песняBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.песняTableAdapter = new forms.Музыкальный_каталогDataSetTableAdapters.ПесняTableAdapter();
            this.tableAdapterManager = new forms.Музыкальный_каталогDataSetTableAdapters.TableAdapterManager();
            this.песняBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.button1 = new System.Windows.Forms.Button();
            this.исполнительBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.исполнительTableAdapter = new forms.Музыкальный_каталогDataSetTableAdapters.ИсполнительTableAdapter();
            this.tableAdapterManager1 = new forms.Музыкальный_каталогDataSetTableAdapters.TableAdapterManager();
            this.genre_label = new System.Windows.Forms.Label();
            this.genre_textBox = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.id_песниTextBox = new System.Windows.Forms.TextBox();
            this.id_альбомаTextBox = new System.Windows.Forms.TextBox();
            this.id_жанраTextBox = new System.Windows.Forms.TextBox();
            this.количество_прослушиванийTextBox = new System.Windows.Forms.TextBox();
            this.длительность_в_секTextBox = new System.Windows.Forms.TextBox();
            this.датаDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.название_альбомаTextBox = new System.Windows.Forms.TextBox();
            this.название_песниTextBox = new System.Windows.Forms.TextBox();
            this.имяTextBox = new System.Windows.Forms.TextBox();
            this.urlTextBox = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            название_альбомаLabel = new System.Windows.Forms.Label();
            дата_выпускаLabel = new System.Windows.Forms.Label();
            длительность_в_секLabel = new System.Windows.Forms.Label();
            количество_прослушиванийLabel = new System.Windows.Forms.Label();
            id_песниLabel = new System.Windows.Forms.Label();
            id_альбомаLabel = new System.Windows.Forms.Label();
            id_жанраLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Музыкальный_каталогDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.песняBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.песняBindingNavigator)).BeginInit();
            this.песняBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.исполнительBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // название_альбомаLabel
            // 
            название_альбомаLabel.AutoSize = true;
            название_альбомаLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.33962F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            название_альбомаLabel.Location = new System.Drawing.Point(14, 198);
            название_альбомаLabel.Name = "название_альбомаLabel";
            название_альбомаLabel.Size = new System.Drawing.Size(163, 31);
            название_альбомаLabel.TabIndex = 3;
            название_альбомаLabel.Text = "Из альбома";
            // 
            // дата_выпускаLabel
            // 
            дата_выпускаLabel.AutoSize = true;
            дата_выпускаLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.18868F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            дата_выпускаLabel.Location = new System.Drawing.Point(17, 269);
            дата_выпускаLabel.Name = "дата_выпускаLabel";
            дата_выпускаLabel.Size = new System.Drawing.Size(109, 18);
            дата_выпускаLabel.TabIndex = 7;
            дата_выпускаLabel.Text = "Дата выпуска:";
            // 
            // длительность_в_секLabel
            // 
            длительность_в_секLabel.AutoSize = true;
            длительность_в_секLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.18868F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            длительность_в_секLabel.Location = new System.Drawing.Point(17, 325);
            длительность_в_секLabel.Name = "длительность_в_секLabel";
            длительность_в_секLabel.Size = new System.Drawing.Size(153, 18);
            длительность_в_секLabel.TabIndex = 9;
            длительность_в_секLabel.Text = "Длительность в сек:";
            // 
            // количество_прослушиванийLabel
            // 
            количество_прослушиванийLabel.AutoSize = true;
            количество_прослушиванийLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.18868F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            количество_прослушиванийLabel.Location = new System.Drawing.Point(12, 414);
            количество_прослушиванийLabel.Name = "количество_прослушиванийLabel";
            количество_прослушиванийLabel.Size = new System.Drawing.Size(116, 18);
            количество_прослушиванийLabel.TabIndex = 11;
            количество_прослушиванийLabel.Text = "прослушивания";
            // 
            // id_песниLabel
            // 
            id_песниLabel.AutoSize = true;
            id_песниLabel.Location = new System.Drawing.Point(643, 383);
            id_песниLabel.Name = "id_песниLabel";
            id_песниLabel.Size = new System.Drawing.Size(51, 13);
            id_песниLabel.TabIndex = 26;
            id_песниLabel.Text = "id песни:";
            // 
            // id_альбомаLabel
            // 
            id_альбомаLabel.AutoSize = true;
            id_альбомаLabel.Location = new System.Drawing.Point(641, 412);
            id_альбомаLabel.Name = "id_альбомаLabel";
            id_альбомаLabel.Size = new System.Drawing.Size(65, 13);
            id_альбомаLabel.TabIndex = 27;
            id_альбомаLabel.Text = "id альбома:";
            // 
            // id_жанраLabel
            // 
            id_жанраLabel.AutoSize = true;
            id_жанраLabel.Location = new System.Drawing.Point(641, 440);
            id_жанраLabel.Name = "id_жанраLabel";
            id_жанраLabel.Size = new System.Drawing.Size(53, 13);
            id_жанраLabel.TabIndex = 28;
            id_жанраLabel.Text = "id жанра:";
            // 
            // Музыкальный_каталогDataSet
            // 
            this.Музыкальный_каталогDataSet.DataSetName = "Музыкальный_каталогDataSet";
            this.Музыкальный_каталогDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // песняBindingSource
            // 
            this.песняBindingSource.DataMember = "Песня";
            this.песняBindingSource.DataSource = this.Музыкальный_каталогDataSet;
            // 
            // песняTableAdapter
            // 
            this.песняTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.UpdateOrder = forms.Музыкальный_каталогDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.АльбомTableAdapter = null;
            this.tableAdapterManager.ЖанрTableAdapter = null;
            this.tableAdapterManager.ИсполнительTableAdapter = null;
            this.tableAdapterManager.ПесняTableAdapter = this.песняTableAdapter;
            this.tableAdapterManager.ПользовательTableAdapter = null;
            this.tableAdapterManager.Список_песенTableAdapter = null;
            // 
            // песняBindingNavigator
            // 
            this.песняBindingNavigator.AddNewItem = null;
            this.песняBindingNavigator.BindingSource = this.песняBindingSource;
            this.песняBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.песняBindingNavigator.DeleteItem = null;
            this.песняBindingNavigator.ImageScalingSize = new System.Drawing.Size(18, 18);
            this.песняBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2});
            this.песняBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.песняBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.песняBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.песняBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.песняBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.песняBindingNavigator.Name = "песняBindingNavigator";
            this.песняBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.песняBindingNavigator.Size = new System.Drawing.Size(834, 26);
            this.песняBindingNavigator.TabIndex = 0;
            this.песняBindingNavigator.Text = "bindingNavigator1";
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
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.18868F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(0, 29);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(218, 28);
            this.button1.TabIndex = 1;
            this.button1.Text = "Добавить в Избранные";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Visible = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
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
            // tableAdapterManager1
            // 
            this.tableAdapterManager1.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager1.UpdateOrder = forms.Музыкальный_каталогDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager1.АльбомTableAdapter = null;
            this.tableAdapterManager1.ЖанрTableAdapter = null;
            this.tableAdapterManager1.ИсполнительTableAdapter = this.исполнительTableAdapter;
            this.tableAdapterManager1.ПесняTableAdapter = null;
            this.tableAdapterManager1.ПользовательTableAdapter = null;
            this.tableAdapterManager1.Список_песенTableAdapter = null;
            // 
            // genre_label
            // 
            this.genre_label.AutoSize = true;
            this.genre_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.18868F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.genre_label.Location = new System.Drawing.Point(17, 377);
            this.genre_label.Name = "genre_label";
            this.genre_label.Size = new System.Drawing.Size(46, 18);
            this.genre_label.TabIndex = 22;
            this.genre_label.Text = "Жанр";
            // 
            // genre_textBox
            // 
            this.genre_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.18868F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.genre_textBox.Location = new System.Drawing.Point(203, 374);
            this.genre_textBox.Name = "genre_textBox";
            this.genre_textBox.Size = new System.Drawing.Size(200, 24);
            this.genre_textBox.TabIndex = 24;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.18868F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.Location = new System.Drawing.Point(582, 29);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(218, 28);
            this.button2.TabIndex = 25;
            this.button2.Text = "Удалить из Избранных";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Visible = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.81132F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 44);
            this.label1.TabIndex = 26;
            this.label1.Text = "Song";
            // 
            // id_песниTextBox
            // 
            this.id_песниTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.песняBindingSource, "id песни", true));
            this.id_песниTextBox.Location = new System.Drawing.Point(714, 376);
            this.id_песниTextBox.Name = "id_песниTextBox";
            this.id_песниTextBox.Size = new System.Drawing.Size(100, 20);
            this.id_песниTextBox.TabIndex = 27;
            this.id_песниTextBox.TextChanged += new System.EventHandler(this.id_песниTextBox_TextChanged_1);
            // 
            // id_альбомаTextBox
            // 
            this.id_альбомаTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.песняBindingSource, "id альбома", true));
            this.id_альбомаTextBox.Location = new System.Drawing.Point(714, 405);
            this.id_альбомаTextBox.Name = "id_альбомаTextBox";
            this.id_альбомаTextBox.Size = new System.Drawing.Size(100, 20);
            this.id_альбомаTextBox.TabIndex = 28;
            // 
            // id_жанраTextBox
            // 
            this.id_жанраTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.песняBindingSource, "id жанра", true));
            this.id_жанраTextBox.Location = new System.Drawing.Point(714, 437);
            this.id_жанраTextBox.Name = "id_жанраTextBox";
            this.id_жанраTextBox.Size = new System.Drawing.Size(100, 20);
            this.id_жанраTextBox.TabIndex = 29;
            // 
            // количество_прослушиванийTextBox
            // 
            this.количество_прослушиванийTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.песняBindingSource, "Количество прослушиваний", true));
            this.количество_прослушиванийTextBox.Location = new System.Drawing.Point(151, 415);
            this.количество_прослушиванийTextBox.Name = "количество_прослушиванийTextBox";
            this.количество_прослушиванийTextBox.Size = new System.Drawing.Size(100, 20);
            this.количество_прослушиванийTextBox.TabIndex = 30;
            // 
            // длительность_в_секTextBox
            // 
            this.длительность_в_секTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.песняBindingSource, "Длительность в сек", true));
            this.длительность_в_секTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.18868F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.длительность_в_секTextBox.Location = new System.Drawing.Point(203, 326);
            this.длительность_в_секTextBox.Name = "длительность_в_секTextBox";
            this.длительность_в_секTextBox.Size = new System.Drawing.Size(200, 24);
            this.длительность_в_секTextBox.TabIndex = 31;
            // 
            // датаDateTimePicker
            // 
            this.датаDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.песняBindingSource, "Дата", true));
            this.датаDateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.18868F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.датаDateTimePicker.Location = new System.Drawing.Point(203, 269);
            this.датаDateTimePicker.Name = "датаDateTimePicker";
            this.датаDateTimePicker.Size = new System.Drawing.Size(200, 24);
            this.датаDateTimePicker.TabIndex = 32;
            this.датаDateTimePicker.ValueChanged += new System.EventHandler(this.датаDateTimePicker_ValueChanged);
            // 
            // название_альбомаTextBox
            // 
            this.название_альбомаTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.песняBindingSource, "Название альбома", true));
            this.название_альбомаTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.69811F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.название_альбомаTextBox.Location = new System.Drawing.Point(203, 194);
            this.название_альбомаTextBox.Name = "название_альбомаTextBox";
            this.название_альбомаTextBox.Size = new System.Drawing.Size(597, 40);
            this.название_альбомаTextBox.TabIndex = 33;
            // 
            // название_песниTextBox
            // 
            this.название_песниTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.песняBindingSource, "Название песни", true));
            this.название_песниTextBox.Location = new System.Drawing.Point(48, 100);
            this.название_песниTextBox.Name = "название_песниTextBox";
            this.название_песниTextBox.Size = new System.Drawing.Size(14, 20);
            this.название_песниTextBox.TabIndex = 34;
            this.название_песниTextBox.TextChanged += new System.EventHandler(this.название_песниTextBox_TextChanged_1);
            // 
            // имяTextBox
            // 
            this.имяTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.исполнительBindingSource, "Имя", true));
            this.имяTextBox.Location = new System.Drawing.Point(88, 100);
            this.имяTextBox.Name = "имяTextBox";
            this.имяTextBox.Size = new System.Drawing.Size(11, 20);
            this.имяTextBox.TabIndex = 35;
            // 
            // urlTextBox
            // 
            this.urlTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.песняBindingSource, "url", true));
            this.urlTextBox.Location = new System.Drawing.Point(700, 78);
            this.urlTextBox.Name = "urlTextBox";
            this.urlTextBox.Size = new System.Drawing.Size(100, 20);
            this.urlTextBox.TabIndex = 36;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(666, 63);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(134, 125);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 37;
            this.pictureBox1.TabStop = false;
            // 
            // SongForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(834, 477);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.urlTextBox);
            this.Controls.Add(this.название_альбомаTextBox);
            this.Controls.Add(this.датаDateTimePicker);
            this.Controls.Add(this.длительность_в_секTextBox);
            this.Controls.Add(this.количество_прослушиванийTextBox);
            this.Controls.Add(id_жанраLabel);
            this.Controls.Add(this.id_жанраTextBox);
            this.Controls.Add(id_альбомаLabel);
            this.Controls.Add(this.id_альбомаTextBox);
            this.Controls.Add(id_песниLabel);
            this.Controls.Add(this.id_песниTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.genre_textBox);
            this.Controls.Add(this.genre_label);
            this.Controls.Add(this.button1);
            this.Controls.Add(количество_прослушиванийLabel);
            this.Controls.Add(длительность_в_секLabel);
            this.Controls.Add(дата_выпускаLabel);
            this.Controls.Add(название_альбомаLabel);
            this.Controls.Add(this.песняBindingNavigator);
            this.Controls.Add(this.имяTextBox);
            this.Controls.Add(this.название_песниTextBox);
            this.Name = "SongForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Песня";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Музыкальный_каталогDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.песняBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.песняBindingNavigator)).EndInit();
            this.песняBindingNavigator.ResumeLayout(false);
            this.песняBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.исполнительBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Музыкальный_каталогDataSet музыкальный_каталогDataSet;

        private System.Windows.Forms.BindingSource песняBindingSource;
        private Музыкальный_каталогDataSetTableAdapters.ПесняTableAdapter песняTableAdapter;
        private Музыкальный_каталогDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator песняBindingNavigator;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.Button button1;
        private Музыкальный_каталогDataSet Музыкальный_каталогDataSet;
        private System.Windows.Forms.BindingSource исполнительBindingSource;
        private Музыкальный_каталогDataSetTableAdapters.ИсполнительTableAdapter исполнительTableAdapter;
        private Музыкальный_каталогDataSetTableAdapters.TableAdapterManager tableAdapterManager1;
        private System.Windows.Forms.Label genre_label;
        private System.Windows.Forms.TextBox genre_textBox;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox id_песниTextBox;
        private System.Windows.Forms.TextBox id_альбомаTextBox;
        private System.Windows.Forms.TextBox id_жанраTextBox;
        private System.Windows.Forms.TextBox количество_прослушиванийTextBox;
        private System.Windows.Forms.TextBox длительность_в_секTextBox;
        private System.Windows.Forms.DateTimePicker датаDateTimePicker;
        private System.Windows.Forms.TextBox название_альбомаTextBox;
        private System.Windows.Forms.TextBox название_песниTextBox;
        private System.Windows.Forms.TextBox имяTextBox;
        private System.Windows.Forms.TextBox urlTextBox;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}