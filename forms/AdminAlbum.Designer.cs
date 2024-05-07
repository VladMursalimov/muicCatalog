namespace forms
{
    partial class AdminAlbum
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminAlbum));
            System.Windows.Forms.Label название_альбомаLabel;
            System.Windows.Forms.Label дата_выпускаLabel;
            System.Windows.Forms.Label длительность_альбома_в_секLabel;
            System.Windows.Forms.Label количество_песенLabel;
            System.Windows.Forms.Label количество_прослушиваний_альбомаLabel;
            this.музыкальный_каталогDataSet = new forms.Музыкальный_каталогDataSet();
            this.альбомBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.альбомTableAdapter = new forms.Музыкальный_каталогDataSetTableAdapters.АльбомTableAdapter();
            this.tableAdapterManager = new forms.Музыкальный_каталогDataSetTableAdapters.TableAdapterManager();
            this.альбомBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.альбомBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.альбомDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.название_альбомаTextBox = new System.Windows.Forms.TextBox();
            this.дата_выпускаTextBox = new System.Windows.Forms.TextBox();
            this.длительность_альбома_в_секTextBox = new System.Windows.Forms.TextBox();
            this.количество_песенTextBox = new System.Windows.Forms.TextBox();
            this.количество_прослушиваний_альбомаTextBox = new System.Windows.Forms.TextBox();
            название_альбомаLabel = new System.Windows.Forms.Label();
            дата_выпускаLabel = new System.Windows.Forms.Label();
            длительность_альбома_в_секLabel = new System.Windows.Forms.Label();
            количество_песенLabel = new System.Windows.Forms.Label();
            количество_прослушиваний_альбомаLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.музыкальный_каталогDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.альбомBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.альбомBindingNavigator)).BeginInit();
            this.альбомBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.альбомDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // музыкальный_каталогDataSet
            // 
            this.музыкальный_каталогDataSet.DataSetName = "Музыкальный_каталогDataSet";
            this.музыкальный_каталогDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // альбомBindingSource
            // 
            this.альбомBindingSource.DataMember = "Альбом";
            this.альбомBindingSource.DataSource = this.музыкальный_каталогDataSet;
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
            // альбомBindingNavigator
            // 
            this.альбомBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.альбомBindingNavigator.BindingSource = this.альбомBindingSource;
            this.альбомBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.альбомBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
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
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.альбомBindingNavigatorSaveItem});
            this.альбомBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.альбомBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.альбомBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.альбомBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.альбомBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.альбомBindingNavigator.Name = "альбомBindingNavigator";
            this.альбомBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.альбомBindingNavigator.Size = new System.Drawing.Size(814, 25);
            this.альбомBindingNavigator.TabIndex = 0;
            this.альбомBindingNavigator.Text = "bindingNavigator1";
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
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(39, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
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
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(25, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(25, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // альбомBindingNavigatorSaveItem
            // 
            this.альбомBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.альбомBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("альбомBindingNavigatorSaveItem.Image")));
            this.альбомBindingNavigatorSaveItem.Name = "альбомBindingNavigatorSaveItem";
            this.альбомBindingNavigatorSaveItem.Size = new System.Drawing.Size(25, 22);
            this.альбомBindingNavigatorSaveItem.Text = "Save Data";
            this.альбомBindingNavigatorSaveItem.Click += new System.EventHandler(this.альбомBindingNavigatorSaveItem_Click);
            // 
            // альбомDataGridView
            // 
            this.альбомDataGridView.AutoGenerateColumns = false;
            this.альбомDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.альбомDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.альбомDataGridView.DataSource = this.альбомBindingSource;
            this.альбомDataGridView.Location = new System.Drawing.Point(12, 334);
            this.альбомDataGridView.Name = "альбомDataGridView";
            this.альбомDataGridView.RowHeadersWidth = 45;
            this.альбомDataGridView.Size = new System.Drawing.Size(790, 341);
            this.альбомDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "id альбома";
            this.dataGridViewTextBoxColumn1.HeaderText = "id альбома";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 110;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Название альбома";
            this.dataGridViewTextBoxColumn2.HeaderText = "Название альбома";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 110;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Дата выпуска";
            this.dataGridViewTextBoxColumn3.HeaderText = "Дата выпуска";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 110;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Длительность альбома в сек";
            this.dataGridViewTextBoxColumn4.HeaderText = "Длительность альбома в сек";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 110;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Количество песен";
            this.dataGridViewTextBoxColumn5.HeaderText = "Количество песен";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 110;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Количество прослушиваний альбома";
            this.dataGridViewTextBoxColumn6.HeaderText = "Количество прослушиваний альбома";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.Width = 110;
            // 
            // название_альбомаLabel
            // 
            название_альбомаLabel.AutoSize = true;
            название_альбомаLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.22642F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            название_альбомаLabel.Location = new System.Drawing.Point(68, 75);
            название_альбомаLabel.Name = "название_альбомаLabel";
            название_альбомаLabel.Size = new System.Drawing.Size(174, 22);
            название_альбомаLabel.TabIndex = 2;
            название_альбомаLabel.Text = "Название альбома:";
            // 
            // название_альбомаTextBox
            // 
            this.название_альбомаTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.альбомBindingSource, "Название альбома", true));
            this.название_альбомаTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.22642F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.название_альбомаTextBox.Location = new System.Drawing.Point(458, 69);
            this.название_альбомаTextBox.Name = "название_альбомаTextBox";
            this.название_альбомаTextBox.Size = new System.Drawing.Size(302, 28);
            this.название_альбомаTextBox.TabIndex = 3;
            // 
            // дата_выпускаLabel
            // 
            дата_выпускаLabel.AutoSize = true;
            дата_выпускаLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.22642F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            дата_выпускаLabel.Location = new System.Drawing.Point(68, 126);
            дата_выпускаLabel.Name = "дата_выпускаLabel";
            дата_выпускаLabel.Size = new System.Drawing.Size(132, 22);
            дата_выпускаLabel.TabIndex = 4;
            дата_выпускаLabel.Text = "Дата выпуска:";
            // 
            // дата_выпускаTextBox
            // 
            this.дата_выпускаTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.альбомBindingSource, "Дата выпуска", true));
            this.дата_выпускаTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.22642F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.дата_выпускаTextBox.Location = new System.Drawing.Point(458, 116);
            this.дата_выпускаTextBox.Name = "дата_выпускаTextBox";
            this.дата_выпускаTextBox.Size = new System.Drawing.Size(302, 28);
            this.дата_выпускаTextBox.TabIndex = 5;
            // 
            // длительность_альбома_в_секLabel
            // 
            длительность_альбома_в_секLabel.AutoSize = true;
            длительность_альбома_в_секLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.22642F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            длительность_альбома_в_секLabel.Location = new System.Drawing.Point(68, 174);
            длительность_альбома_в_секLabel.Name = "длительность_альбома_в_секLabel";
            длительность_альбома_в_секLabel.Size = new System.Drawing.Size(257, 22);
            длительность_альбома_в_секLabel.TabIndex = 6;
            длительность_альбома_в_секLabel.Text = "Длительность альбома в сек:";
            // 
            // длительность_альбома_в_секTextBox
            // 
            this.длительность_альбома_в_секTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.альбомBindingSource, "Длительность альбома в сек", true));
            this.длительность_альбома_в_секTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.22642F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.длительность_альбома_в_секTextBox.Location = new System.Drawing.Point(458, 168);
            this.длительность_альбома_в_секTextBox.Name = "длительность_альбома_в_секTextBox";
            this.длительность_альбома_в_секTextBox.Size = new System.Drawing.Size(302, 28);
            this.длительность_альбома_в_секTextBox.TabIndex = 7;
            // 
            // количество_песенLabel
            // 
            количество_песенLabel.AutoSize = true;
            количество_песенLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.22642F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            количество_песенLabel.Location = new System.Drawing.Point(68, 229);
            количество_песенLabel.Name = "количество_песенLabel";
            количество_песенLabel.Size = new System.Drawing.Size(168, 22);
            количество_песенLabel.TabIndex = 8;
            количество_песенLabel.Text = "Количество песен:";
            // 
            // количество_песенTextBox
            // 
            this.количество_песенTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.альбомBindingSource, "Количество песен", true));
            this.количество_песенTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.22642F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.количество_песенTextBox.Location = new System.Drawing.Point(458, 223);
            this.количество_песенTextBox.Name = "количество_песенTextBox";
            this.количество_песенTextBox.Size = new System.Drawing.Size(302, 28);
            this.количество_песенTextBox.TabIndex = 9;
            // 
            // количество_прослушиваний_альбомаLabel
            // 
            количество_прослушиваний_альбомаLabel.AutoSize = true;
            количество_прослушиваний_альбомаLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.22642F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            количество_прослушиваний_альбомаLabel.Location = new System.Drawing.Point(68, 282);
            количество_прослушиваний_альбомаLabel.Name = "количество_прослушиваний_альбомаLabel";
            количество_прослушиваний_альбомаLabel.Size = new System.Drawing.Size(328, 22);
            количество_прослушиваний_альбомаLabel.TabIndex = 10;
            количество_прослушиваний_альбомаLabel.Text = "Количество прослушиваний альбома:";
            // 
            // количество_прослушиваний_альбомаTextBox
            // 
            this.количество_прослушиваний_альбомаTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.альбомBindingSource, "Количество прослушиваний альбома", true));
            this.количество_прослушиваний_альбомаTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.22642F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.количество_прослушиваний_альбомаTextBox.Location = new System.Drawing.Point(458, 279);
            this.количество_прослушиваний_альбомаTextBox.Name = "количество_прослушиваний_альбомаTextBox";
            this.количество_прослушиваний_альбомаTextBox.Size = new System.Drawing.Size(302, 28);
            this.количество_прослушиваний_альбомаTextBox.TabIndex = 11;
            // 
            // AdminAlbum
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(814, 687);
            this.Controls.Add(количество_прослушиваний_альбомаLabel);
            this.Controls.Add(this.количество_прослушиваний_альбомаTextBox);
            this.Controls.Add(количество_песенLabel);
            this.Controls.Add(this.количество_песенTextBox);
            this.Controls.Add(длительность_альбома_в_секLabel);
            this.Controls.Add(this.длительность_альбома_в_секTextBox);
            this.Controls.Add(дата_выпускаLabel);
            this.Controls.Add(this.дата_выпускаTextBox);
            this.Controls.Add(название_альбомаLabel);
            this.Controls.Add(this.название_альбомаTextBox);
            this.Controls.Add(this.альбомDataGridView);
            this.Controls.Add(this.альбомBindingNavigator);
            this.Name = "AdminAlbum";
            this.Text = "AdminAlbum";
            this.Load += new System.EventHandler(this.AdminAlbum_Load);
            ((System.ComponentModel.ISupportInitialize)(this.музыкальный_каталогDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.альбомBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.альбомBindingNavigator)).EndInit();
            this.альбомBindingNavigator.ResumeLayout(false);
            this.альбомBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.альбомDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Музыкальный_каталогDataSet музыкальный_каталогDataSet;
        private System.Windows.Forms.BindingSource альбомBindingSource;
        private Музыкальный_каталогDataSetTableAdapters.АльбомTableAdapter альбомTableAdapter;
        private Музыкальный_каталогDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator альбомBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton альбомBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView альбомDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.TextBox название_альбомаTextBox;
        private System.Windows.Forms.TextBox дата_выпускаTextBox;
        private System.Windows.Forms.TextBox длительность_альбома_в_секTextBox;
        private System.Windows.Forms.TextBox количество_песенTextBox;
        private System.Windows.Forms.TextBox количество_прослушиваний_альбомаTextBox;
    }
}