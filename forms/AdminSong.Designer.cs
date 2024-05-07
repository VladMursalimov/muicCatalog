namespace forms
{
    partial class AdminSong
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
            System.Windows.Forms.Label название_песниLabel;
            System.Windows.Forms.Label датаLabel;
            System.Windows.Forms.Label длительность_в_секLabel;
            System.Windows.Forms.Label количество_прослушиванийLabel;
            System.Windows.Forms.Label id_жанраLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminSong));
            this.музыкальный_каталогDataSet = new forms.Музыкальный_каталогDataSet();
            this.песняBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.песняTableAdapter = new forms.Музыкальный_каталогDataSetTableAdapters.ПесняTableAdapter();
            this.tableAdapterManager = new forms.Музыкальный_каталогDataSetTableAdapters.TableAdapterManager();
            this.песняBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.песняBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.название_песниTextBox = new System.Windows.Forms.TextBox();
            this.датаDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.длительность_в_секTextBox = new System.Windows.Forms.TextBox();
            this.количество_прослушиванийTextBox = new System.Windows.Forms.TextBox();
            this.id_жанраTextBox = new System.Windows.Forms.TextBox();
            this.песняDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            название_песниLabel = new System.Windows.Forms.Label();
            датаLabel = new System.Windows.Forms.Label();
            длительность_в_секLabel = new System.Windows.Forms.Label();
            количество_прослушиванийLabel = new System.Windows.Forms.Label();
            id_жанраLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.музыкальный_каталогDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.песняBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.песняBindingNavigator)).BeginInit();
            this.песняBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.песняDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // название_песниLabel
            // 
            название_песниLabel.AutoSize = true;
            название_песниLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.22642F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            название_песниLabel.Location = new System.Drawing.Point(165, 59);
            название_песниLabel.Name = "название_песниLabel";
            название_песниLabel.Size = new System.Drawing.Size(151, 22);
            название_песниLabel.TabIndex = 1;
            название_песниLabel.Text = "Название песни:";
            // 
            // датаLabel
            // 
            датаLabel.AutoSize = true;
            датаLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.22642F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            датаLabel.Location = new System.Drawing.Point(167, 116);
            датаLabel.Name = "датаLabel";
            датаLabel.Size = new System.Drawing.Size(57, 22);
            датаLabel.TabIndex = 5;
            датаLabel.Text = "Дата:";
            // 
            // длительность_в_секLabel
            // 
            длительность_в_секLabel.AutoSize = true;
            длительность_в_секLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.22642F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            длительность_в_секLabel.Location = new System.Drawing.Point(167, 174);
            длительность_в_секLabel.Name = "длительность_в_секLabel";
            длительность_в_секLabel.Size = new System.Drawing.Size(180, 22);
            длительность_в_секLabel.TabIndex = 7;
            длительность_в_секLabel.Text = "Длительность в сек:";
            // 
            // количество_прослушиванийLabel
            // 
            количество_прослушиванийLabel.AutoSize = true;
            количество_прослушиванийLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.22642F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            количество_прослушиванийLabel.Location = new System.Drawing.Point(166, 231);
            количество_прослушиванийLabel.Name = "количество_прослушиванийLabel";
            количество_прослушиванийLabel.Size = new System.Drawing.Size(251, 22);
            количество_прослушиванийLabel.TabIndex = 9;
            количество_прослушиванийLabel.Text = "Количество прослушиваний:";
            // 
            // id_жанраLabel
            // 
            id_жанраLabel.AutoSize = true;
            id_жанраLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.22642F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            id_жанраLabel.Location = new System.Drawing.Point(166, 281);
            id_жанраLabel.Name = "id_жанраLabel";
            id_жанраLabel.Size = new System.Drawing.Size(88, 22);
            id_жанраLabel.TabIndex = 11;
            id_жанраLabel.Text = "id жанра:";
            // 
            // музыкальный_каталогDataSet
            // 
            this.музыкальный_каталогDataSet.DataSetName = "Музыкальный_каталогDataSet";
            this.музыкальный_каталогDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // песняBindingSource
            // 
            this.песняBindingSource.DataMember = "Песня";
            this.песняBindingSource.DataSource = this.музыкальный_каталогDataSet;
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
            this.песняBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.песняBindingNavigator.BindingSource = this.песняBindingSource;
            this.песняBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.песняBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
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
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.песняBindingNavigatorSaveItem});
            this.песняBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.песняBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.песняBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.песняBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.песняBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.песняBindingNavigator.Name = "песняBindingNavigator";
            this.песняBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.песняBindingNavigator.Size = new System.Drawing.Size(961, 28);
            this.песняBindingNavigator.TabIndex = 0;
            this.песняBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(25, 25);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(39, 25);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(25, 25);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(25, 25);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(25, 25);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 28);
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
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 28);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(25, 25);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(25, 25);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 28);
            // 
            // песняBindingNavigatorSaveItem
            // 
            this.песняBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.песняBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("песняBindingNavigatorSaveItem.Image")));
            this.песняBindingNavigatorSaveItem.Name = "песняBindingNavigatorSaveItem";
            this.песняBindingNavigatorSaveItem.Size = new System.Drawing.Size(25, 25);
            this.песняBindingNavigatorSaveItem.Text = "Save Data";
            this.песняBindingNavigatorSaveItem.Click += new System.EventHandler(this.песняBindingNavigatorSaveItem_Click);
            // 
            // название_песниTextBox
            // 
            this.название_песниTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.песняBindingSource, "Название песни", true));
            this.название_песниTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.22642F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.название_песниTextBox.Location = new System.Drawing.Point(450, 53);
            this.название_песниTextBox.Name = "название_песниTextBox";
            this.название_песниTextBox.Size = new System.Drawing.Size(270, 28);
            this.название_песниTextBox.TabIndex = 2;
            // 
            // датаDateTimePicker
            // 
            this.датаDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.песняBindingSource, "Дата", true));
            this.датаDateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.22642F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.датаDateTimePicker.Location = new System.Drawing.Point(450, 110);
            this.датаDateTimePicker.Name = "датаDateTimePicker";
            this.датаDateTimePicker.Size = new System.Drawing.Size(270, 28);
            this.датаDateTimePicker.TabIndex = 6;
            // 
            // длительность_в_секTextBox
            // 
            this.длительность_в_секTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.песняBindingSource, "Длительность в сек", true));
            this.длительность_в_секTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.22642F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.длительность_в_секTextBox.Location = new System.Drawing.Point(450, 172);
            this.длительность_в_секTextBox.Name = "длительность_в_секTextBox";
            this.длительность_в_секTextBox.Size = new System.Drawing.Size(270, 28);
            this.длительность_в_секTextBox.TabIndex = 8;
            // 
            // количество_прослушиванийTextBox
            // 
            this.количество_прослушиванийTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.песняBindingSource, "Количество прослушиваний", true));
            this.количество_прослушиванийTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.22642F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.количество_прослушиванийTextBox.Location = new System.Drawing.Point(450, 225);
            this.количество_прослушиванийTextBox.Name = "количество_прослушиванийTextBox";
            this.количество_прослушиванийTextBox.Size = new System.Drawing.Size(270, 28);
            this.количество_прослушиванийTextBox.TabIndex = 10;
            // 
            // id_жанраTextBox
            // 
            this.id_жанраTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.песняBindingSource, "id жанра", true));
            this.id_жанраTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.22642F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.id_жанраTextBox.Location = new System.Drawing.Point(450, 279);
            this.id_жанраTextBox.Name = "id_жанраTextBox";
            this.id_жанраTextBox.Size = new System.Drawing.Size(270, 28);
            this.id_жанраTextBox.TabIndex = 12;
            // 
            // песняDataGridView
            // 
            this.песняDataGridView.AutoGenerateColumns = false;
            this.песняDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.песняDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8});
            this.песняDataGridView.DataSource = this.песняBindingSource;
            this.песняDataGridView.Location = new System.Drawing.Point(12, 344);
            this.песняDataGridView.Name = "песняDataGridView";
            this.песняDataGridView.RowHeadersWidth = 45;
            this.песняDataGridView.Size = new System.Drawing.Size(930, 256);
            this.песняDataGridView.TabIndex = 12;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "id песни";
            this.dataGridViewTextBoxColumn1.HeaderText = "id песни";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 110;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Название песни";
            this.dataGridViewTextBoxColumn2.HeaderText = "Название песни";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 110;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Название альбома";
            this.dataGridViewTextBoxColumn3.HeaderText = "Название альбома";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 110;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Дата";
            this.dataGridViewTextBoxColumn4.HeaderText = "Дата";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 110;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Длительность в сек";
            this.dataGridViewTextBoxColumn5.HeaderText = "Длительность в сек";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 110;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Количество прослушиваний";
            this.dataGridViewTextBoxColumn6.HeaderText = "Количество прослушиваний";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.Width = 110;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "id альбома";
            this.dataGridViewTextBoxColumn7.HeaderText = "id альбома";
            this.dataGridViewTextBoxColumn7.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.Width = 110;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "id жанра";
            this.dataGridViewTextBoxColumn8.HeaderText = "id жанра";
            this.dataGridViewTextBoxColumn8.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.Width = 110;
            // 
            // AdminSong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(961, 612);
            this.Controls.Add(this.песняDataGridView);
            this.Controls.Add(id_жанраLabel);
            this.Controls.Add(this.id_жанраTextBox);
            this.Controls.Add(количество_прослушиванийLabel);
            this.Controls.Add(this.количество_прослушиванийTextBox);
            this.Controls.Add(длительность_в_секLabel);
            this.Controls.Add(this.длительность_в_секTextBox);
            this.Controls.Add(датаLabel);
            this.Controls.Add(this.датаDateTimePicker);
            this.Controls.Add(название_песниLabel);
            this.Controls.Add(this.название_песниTextBox);
            this.Controls.Add(this.песняBindingNavigator);
            this.Name = "AdminSong";
            this.Text = "AdminSong";
            this.Load += new System.EventHandler(this.AdminSong_Load);
            ((System.ComponentModel.ISupportInitialize)(this.музыкальный_каталогDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.песняBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.песняBindingNavigator)).EndInit();
            this.песняBindingNavigator.ResumeLayout(false);
            this.песняBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.песняDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Музыкальный_каталогDataSet музыкальный_каталогDataSet;
        private System.Windows.Forms.BindingSource песняBindingSource;
        private Музыкальный_каталогDataSetTableAdapters.ПесняTableAdapter песняTableAdapter;
        private Музыкальный_каталогDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator песняBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton песняBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox название_песниTextBox;
        private System.Windows.Forms.DateTimePicker датаDateTimePicker;
        private System.Windows.Forms.TextBox длительность_в_секTextBox;
        private System.Windows.Forms.TextBox количество_прослушиванийTextBox;
        private System.Windows.Forms.TextBox id_жанраTextBox;
        private System.Windows.Forms.DataGridView песняDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
    }
}