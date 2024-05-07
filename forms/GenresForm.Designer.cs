namespace forms
{
    partial class GenresForm
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
            System.Windows.Forms.Label id_жанраLabel;
            System.Windows.Forms.Label название_жанраLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GenresForm));
            this.label1 = new System.Windows.Forms.Label();
            this.Музыкальный_каталогDataSet = new forms.Музыкальный_каталогDataSet();
            this.жанрBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.жанрTableAdapter = new forms.Музыкальный_каталогDataSetTableAdapters.ЖанрTableAdapter();
            this.tableAdapterManager = new forms.Музыкальный_каталогDataSetTableAdapters.TableAdapterManager();
            this.жанрBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.id_жанраTextBox = new System.Windows.Forms.TextBox();
            this.название_жанраTextBox = new System.Windows.Forms.TextBox();
            id_жанраLabel = new System.Windows.Forms.Label();
            название_жанраLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Музыкальный_каталогDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.жанрBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.жанрBindingNavigator)).BeginInit();
            this.жанрBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // id_жанраLabel
            // 
            id_жанраLabel.AutoSize = true;
            id_жанраLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.26415F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            id_жанраLabel.Location = new System.Drawing.Point(140, 141);
            id_жанраLabel.Name = "id_жанраLabel";
            id_жанраLabel.Size = new System.Drawing.Size(104, 25);
            id_жанраLabel.TabIndex = 2;
            id_жанраLabel.Text = "id жанра:";
            // 
            // название_жанраLabel
            // 
            название_жанраLabel.AutoSize = true;
            название_жанраLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.26415F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            название_жанраLabel.Location = new System.Drawing.Point(140, 204);
            название_жанраLabel.Name = "название_жанраLabel";
            название_жанраLabel.Size = new System.Drawing.Size(184, 25);
            название_жанраLabel.TabIndex = 4;
            название_жанраLabel.Text = "Название жанра:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.81132F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(335, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 44);
            this.label1.TabIndex = 0;
            this.label1.Text = "Жанр";
            // 
            // Музыкальный_каталогDataSet
            // 
            this.Музыкальный_каталогDataSet.DataSetName = "Музыкальный_каталогDataSet";
            this.Музыкальный_каталогDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // жанрBindingSource
            // 
            this.жанрBindingSource.DataMember = "Жанр";
            this.жанрBindingSource.DataSource = this.Музыкальный_каталогDataSet;
            // 
            // жанрTableAdapter
            // 
            this.жанрTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.UpdateOrder = forms.Музыкальный_каталогDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.АльбомTableAdapter = null;
            this.tableAdapterManager.ЖанрTableAdapter = this.жанрTableAdapter;
            this.tableAdapterManager.ИсполнительTableAdapter = null;
            this.tableAdapterManager.ПесняTableAdapter = null;
            this.tableAdapterManager.ПользовательTableAdapter = null;
            this.tableAdapterManager.Список_песенTableAdapter = null;
            // 
            // жанрBindingNavigator
            // 
            this.жанрBindingNavigator.AddNewItem = null;
            this.жанрBindingNavigator.BindingSource = this.жанрBindingSource;
            this.жанрBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.жанрBindingNavigator.DeleteItem = null;
            this.жанрBindingNavigator.ImageScalingSize = new System.Drawing.Size(18, 18);
            this.жанрBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2});
            this.жанрBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.жанрBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.жанрBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.жанрBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.жанрBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.жанрBindingNavigator.Name = "жанрBindingNavigator";
            this.жанрBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.жанрBindingNavigator.Size = new System.Drawing.Size(800, 26);
            this.жанрBindingNavigator.TabIndex = 1;
            this.жанрBindingNavigator.Text = "bindingNavigator1";
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
            // id_жанраTextBox
            // 
            this.id_жанраTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.жанрBindingSource, "id жанра", true));
            this.id_жанраTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.26415F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.id_жанраTextBox.Location = new System.Drawing.Point(343, 141);
            this.id_жанраTextBox.Name = "id_жанраTextBox";
            this.id_жанраTextBox.Size = new System.Drawing.Size(251, 31);
            this.id_жанраTextBox.TabIndex = 5;
            // 
            // название_жанраTextBox
            // 
            this.название_жанраTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.жанрBindingSource, "Название жанра", true));
            this.название_жанраTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.26415F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.название_жанраTextBox.Location = new System.Drawing.Point(343, 198);
            this.название_жанраTextBox.Name = "название_жанраTextBox";
            this.название_жанраTextBox.Size = new System.Drawing.Size(251, 31);
            this.название_жанраTextBox.TabIndex = 6;
            // 
            // GenresForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.название_жанраTextBox);
            this.Controls.Add(this.id_жанраTextBox);
            this.Controls.Add(название_жанраLabel);
            this.Controls.Add(id_жанраLabel);
            this.Controls.Add(this.жанрBindingNavigator);
            this.Controls.Add(this.label1);
            this.Name = "GenresForm";
            this.Text = "Жанр";
            this.Load += new System.EventHandler(this.Form5_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Музыкальный_каталогDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.жанрBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.жанрBindingNavigator)).EndInit();
            this.жанрBindingNavigator.ResumeLayout(false);
            this.жанрBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private Музыкальный_каталогDataSet Музыкальный_каталогDataSet;
        private Музыкальный_каталогDataSet музыкальный_каталогDataSet;

        private System.Windows.Forms.BindingSource жанрBindingSource;
        private Музыкальный_каталогDataSetTableAdapters.ЖанрTableAdapter жанрTableAdapter;
        private Музыкальный_каталогDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator жанрBindingNavigator;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.TextBox id_жанраTextBox;
        private System.Windows.Forms.TextBox название_жанраTextBox;
    }
}