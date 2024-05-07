namespace forms
{
    partial class AdminArtist
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminArtist));
            System.Windows.Forms.Label имяLabel;
            System.Windows.Forms.Label количество_песенLabel;
            System.Windows.Forms.Label количество_альбомовLabel;
            this.музыкальный_каталогDataSet = new forms.Музыкальный_каталогDataSet();
            this.исполнительBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.исполнительTableAdapter = new forms.Музыкальный_каталогDataSetTableAdapters.ИсполнительTableAdapter();
            this.tableAdapterManager = new forms.Музыкальный_каталогDataSetTableAdapters.TableAdapterManager();
            this.исполнительBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.исполнительBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.исполнительDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.имяTextBox = new System.Windows.Forms.TextBox();
            this.количество_песенTextBox = new System.Windows.Forms.TextBox();
            this.количество_альбомовTextBox = new System.Windows.Forms.TextBox();
            this.список_песенBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.список_песенTableAdapter = new forms.Музыкальный_каталогDataSetTableAdapters.Список_песенTableAdapter();
            имяLabel = new System.Windows.Forms.Label();
            количество_песенLabel = new System.Windows.Forms.Label();
            количество_альбомовLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.музыкальный_каталогDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.исполнительBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.исполнительBindingNavigator)).BeginInit();
            this.исполнительBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.исполнительDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.список_песенBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // музыкальный_каталогDataSet
            // 
            this.музыкальный_каталогDataSet.DataSetName = "Музыкальный_каталогDataSet";
            this.музыкальный_каталогDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // исполнительBindingSource
            // 
            this.исполнительBindingSource.DataMember = "Исполнитель";
            this.исполнительBindingSource.DataSource = this.музыкальный_каталогDataSet;
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
            this.tableAdapterManager.Список_песенTableAdapter = this.список_песенTableAdapter;
            // 
            // исполнительBindingNavigator
            // 
            this.исполнительBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.исполнительBindingNavigator.BindingSource = this.исполнительBindingSource;
            this.исполнительBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.исполнительBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
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
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.исполнительBindingNavigatorSaveItem});
            this.исполнительBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.исполнительBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.исполнительBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.исполнительBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.исполнительBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.исполнительBindingNavigator.Name = "исполнительBindingNavigator";
            this.исполнительBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.исполнительBindingNavigator.Size = new System.Drawing.Size(800, 25);
            this.исполнительBindingNavigator.TabIndex = 0;
            this.исполнительBindingNavigator.Text = "bindingNavigator1";
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
            // исполнительBindingNavigatorSaveItem
            // 
            this.исполнительBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.исполнительBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("исполнительBindingNavigatorSaveItem.Image")));
            this.исполнительBindingNavigatorSaveItem.Name = "исполнительBindingNavigatorSaveItem";
            this.исполнительBindingNavigatorSaveItem.Size = new System.Drawing.Size(25, 22);
            this.исполнительBindingNavigatorSaveItem.Text = "Save Data";
            this.исполнительBindingNavigatorSaveItem.Click += new System.EventHandler(this.исполнительBindingNavigatorSaveItem_Click);
            // 
            // исполнительDataGridView
            // 
            this.исполнительDataGridView.AutoGenerateColumns = false;
            this.исполнительDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.исполнительDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.исполнительDataGridView.DataSource = this.исполнительBindingSource;
            this.исполнительDataGridView.Location = new System.Drawing.Point(22, 224);
            this.исполнительDataGridView.Name = "исполнительDataGridView";
            this.исполнительDataGridView.RowHeadersWidth = 45;
            this.исполнительDataGridView.Size = new System.Drawing.Size(746, 272);
            this.исполнительDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "id исполнителя";
            this.dataGridViewTextBoxColumn1.HeaderText = "id исполнителя";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 110;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Имя";
            this.dataGridViewTextBoxColumn2.HeaderText = "Имя";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 110;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Id списка песен по прослушиваниям";
            this.dataGridViewTextBoxColumn3.HeaderText = "Id списка песен по прослушиваниям";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 110;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Количество песен";
            this.dataGridViewTextBoxColumn4.HeaderText = "Количество песен";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 110;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Количество альбомов";
            this.dataGridViewTextBoxColumn5.HeaderText = "Количество альбомов";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 110;
            // 
            // имяLabel
            // 
            имяLabel.AutoSize = true;
            имяLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.22642F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            имяLabel.Location = new System.Drawing.Point(30, 74);
            имяLabel.Name = "имяLabel";
            имяLabel.Size = new System.Drawing.Size(51, 22);
            имяLabel.TabIndex = 2;
            имяLabel.Text = "Имя:";
            // 
            // имяTextBox
            // 
            this.имяTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.исполнительBindingSource, "Имя", true));
            this.имяTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.22642F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.имяTextBox.Location = new System.Drawing.Point(262, 74);
            this.имяTextBox.Name = "имяTextBox";
            this.имяTextBox.Size = new System.Drawing.Size(258, 28);
            this.имяTextBox.TabIndex = 3;
            // 
            // количество_песенLabel
            // 
            количество_песенLabel.AutoSize = true;
            количество_песенLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.22642F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            количество_песенLabel.Location = new System.Drawing.Point(30, 119);
            количество_песенLabel.Name = "количество_песенLabel";
            количество_песенLabel.Size = new System.Drawing.Size(168, 22);
            количество_песенLabel.TabIndex = 4;
            количество_песенLabel.Text = "Количество песен:";
            // 
            // количество_песенTextBox
            // 
            this.количество_песенTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.исполнительBindingSource, "Количество песен", true));
            this.количество_песенTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.22642F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.количество_песенTextBox.Location = new System.Drawing.Point(262, 119);
            this.количество_песенTextBox.Name = "количество_песенTextBox";
            this.количество_песенTextBox.Size = new System.Drawing.Size(258, 28);
            this.количество_песенTextBox.TabIndex = 5;
            // 
            // количество_альбомовLabel
            // 
            количество_альбомовLabel.AutoSize = true;
            количество_альбомовLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.22642F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            количество_альбомовLabel.Location = new System.Drawing.Point(30, 169);
            количество_альбомовLabel.Name = "количество_альбомовLabel";
            количество_альбомовLabel.Size = new System.Drawing.Size(201, 22);
            количество_альбомовLabel.TabIndex = 6;
            количество_альбомовLabel.Text = "Количество альбомов:";
            // 
            // количество_альбомовTextBox
            // 
            this.количество_альбомовTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.исполнительBindingSource, "Количество альбомов", true));
            this.количество_альбомовTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.22642F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.количество_альбомовTextBox.Location = new System.Drawing.Point(262, 162);
            this.количество_альбомовTextBox.Name = "количество_альбомовTextBox";
            this.количество_альбомовTextBox.Size = new System.Drawing.Size(258, 28);
            this.количество_альбомовTextBox.TabIndex = 7;
            // 
            // список_песенBindingSource
            // 
            this.список_песенBindingSource.DataMember = "FK_Список песен_Исполнитель";
            this.список_песенBindingSource.DataSource = this.исполнительBindingSource;
            // 
            // список_песенTableAdapter
            // 
            this.список_песенTableAdapter.ClearBeforeFill = true;
            // 
            // AdminArtist
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 516);
            this.Controls.Add(количество_альбомовLabel);
            this.Controls.Add(this.количество_альбомовTextBox);
            this.Controls.Add(количество_песенLabel);
            this.Controls.Add(this.количество_песенTextBox);
            this.Controls.Add(имяLabel);
            this.Controls.Add(this.имяTextBox);
            this.Controls.Add(this.исполнительDataGridView);
            this.Controls.Add(this.исполнительBindingNavigator);
            this.Name = "AdminArtist";
            this.Text = "AdminArtist";
            this.Load += new System.EventHandler(this.AdminArtist_Load);
            ((System.ComponentModel.ISupportInitialize)(this.музыкальный_каталогDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.исполнительBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.исполнительBindingNavigator)).EndInit();
            this.исполнительBindingNavigator.ResumeLayout(false);
            this.исполнительBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.исполнительDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.список_песенBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Музыкальный_каталогDataSet музыкальный_каталогDataSet;
        private System.Windows.Forms.BindingSource исполнительBindingSource;
        private Музыкальный_каталогDataSetTableAdapters.ИсполнительTableAdapter исполнительTableAdapter;
        private Музыкальный_каталогDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator исполнительBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton исполнительBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView исполнительDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private Музыкальный_каталогDataSetTableAdapters.Список_песенTableAdapter список_песенTableAdapter;
        private System.Windows.Forms.TextBox имяTextBox;
        private System.Windows.Forms.TextBox количество_песенTextBox;
        private System.Windows.Forms.TextBox количество_альбомовTextBox;
        private System.Windows.Forms.BindingSource список_песенBindingSource;
    }
}