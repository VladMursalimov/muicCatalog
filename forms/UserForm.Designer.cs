namespace forms
{
    partial class UserForm
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
            System.Windows.Forms.Label id_пользователяLabel;
            System.Windows.Forms.Label id_сборника_ИзбранныеLabel;
            System.Windows.Forms.Label имяLabel;
            System.Windows.Forms.Label почта_пользователяLabel;
            System.Windows.Forms.Label логинLabel;
            System.Windows.Forms.Label парольLabel;
            this.Музыкальный_каталогDataSet = new forms.Музыкальный_каталогDataSet();
            this.пользовательBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.пользовательTableAdapter = new forms.Музыкальный_каталогDataSetTableAdapters.ПользовательTableAdapter();
            this.tableAdapterManager = new forms.Музыкальный_каталогDataSetTableAdapters.TableAdapterManager();
            this.id_пользователяTextBox = new System.Windows.Forms.TextBox();
            this.id_сборника_ИзбранныеTextBox = new System.Windows.Forms.TextBox();
            this.имяTextBox = new System.Windows.Forms.TextBox();
            this.почта_пользователяTextBox = new System.Windows.Forms.TextBox();
            this.логинTextBox = new System.Windows.Forms.TextBox();
            this.парольTextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            id_пользователяLabel = new System.Windows.Forms.Label();
            id_сборника_ИзбранныеLabel = new System.Windows.Forms.Label();
            имяLabel = new System.Windows.Forms.Label();
            почта_пользователяLabel = new System.Windows.Forms.Label();
            логинLabel = new System.Windows.Forms.Label();
            парольLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Музыкальный_каталогDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.пользовательBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // id_пользователяLabel
            // 
            id_пользователяLabel.AutoSize = true;
            id_пользователяLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.22642F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            id_пользователяLabel.Location = new System.Drawing.Point(29, 170);
            id_пользователяLabel.Name = "id_пользователяLabel";
            id_пользователяLabel.Size = new System.Drawing.Size(161, 24);
            id_пользователяLabel.TabIndex = 1;
            id_пользователяLabel.Text = "id пользователя:";
            // 
            // id_сборника_ИзбранныеLabel
            // 
            id_сборника_ИзбранныеLabel.AutoSize = true;
            id_сборника_ИзбранныеLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.22642F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            id_сборника_ИзбранныеLabel.Location = new System.Drawing.Point(30, 216);
            id_сборника_ИзбранныеLabel.Name = "id_сборника_ИзбранныеLabel";
            id_сборника_ИзбранныеLabel.Size = new System.Drawing.Size(225, 24);
            id_сборника_ИзбранныеLabel.TabIndex = 3;
            id_сборника_ИзбранныеLabel.Text = "id сборника Избранные:";
            // 
            // имяLabel
            // 
            имяLabel.AutoSize = true;
            имяLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.22642F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            имяLabel.Location = new System.Drawing.Point(29, 265);
            имяLabel.Name = "имяLabel";
            имяLabel.Size = new System.Drawing.Size(51, 24);
            имяLabel.TabIndex = 5;
            имяLabel.Text = "Имя:";
            // 
            // почта_пользователяLabel
            // 
            почта_пользователяLabel.AutoSize = true;
            почта_пользователяLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.22642F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            почта_пользователяLabel.Location = new System.Drawing.Point(29, 306);
            почта_пользователяLabel.Name = "почта_пользователяLabel";
            почта_пользователяLabel.Size = new System.Drawing.Size(200, 24);
            почта_пользователяLabel.TabIndex = 7;
            почта_пользователяLabel.Text = "Почта пользователя:";
            // 
            // логинLabel
            // 
            логинLabel.AutoSize = true;
            логинLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.22642F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            логинLabel.Location = new System.Drawing.Point(29, 35);
            логинLabel.Name = "логинLabel";
            логинLabel.Size = new System.Drawing.Size(69, 24);
            логинLabel.TabIndex = 9;
            логинLabel.Text = "Логин:";
            // 
            // парольLabel
            // 
            парольLabel.AutoSize = true;
            парольLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.22642F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            парольLabel.Location = new System.Drawing.Point(29, 80);
            парольLabel.Name = "парольLabel";
            парольLabel.Size = new System.Drawing.Size(81, 24);
            парольLabel.TabIndex = 11;
            парольLabel.Text = "Пароль:";
            // 
            // Музыкальный_каталогDataSet
            // 
            this.Музыкальный_каталогDataSet.DataSetName = "Музыкальный_каталогDataSet";
            this.Музыкальный_каталогDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // пользовательBindingSource
            // 
            this.пользовательBindingSource.DataMember = "Пользователь";
            this.пользовательBindingSource.DataSource = this.Музыкальный_каталогDataSet;
            // 
            // пользовательTableAdapter
            // 
            this.пользовательTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.UpdateOrder = forms.Музыкальный_каталогDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.АльбомTableAdapter = null;
            this.tableAdapterManager.ЖанрTableAdapter = null;
            this.tableAdapterManager.ИсполнительTableAdapter = null;
            this.tableAdapterManager.ПесняTableAdapter = null;
            this.tableAdapterManager.ПользовательTableAdapter = this.пользовательTableAdapter;
            this.tableAdapterManager.Список_песенTableAdapter = null;
            // 
            // id_пользователяTextBox
            // 
            this.id_пользователяTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.пользовательBindingSource, "id пользователя", true));
            this.id_пользователяTextBox.Location = new System.Drawing.Point(268, 170);
            this.id_пользователяTextBox.Name = "id_пользователяTextBox";
            this.id_пользователяTextBox.Size = new System.Drawing.Size(172, 20);
            this.id_пользователяTextBox.TabIndex = 5;
            this.id_пользователяTextBox.TextChanged += new System.EventHandler(this.id_пользователяTextBox_TextChanged);
            // 
            // id_сборника_ИзбранныеTextBox
            // 
            this.id_сборника_ИзбранныеTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.пользовательBindingSource, "id сборника Избранные", true));
            this.id_сборника_ИзбранныеTextBox.Location = new System.Drawing.Point(268, 213);
            this.id_сборника_ИзбранныеTextBox.Name = "id_сборника_ИзбранныеTextBox";
            this.id_сборника_ИзбранныеTextBox.Size = new System.Drawing.Size(172, 20);
            this.id_сборника_ИзбранныеTextBox.TabIndex = 6;
            // 
            // имяTextBox
            // 
            this.имяTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.пользовательBindingSource, "Имя", true));
            this.имяTextBox.Location = new System.Drawing.Point(268, 258);
            this.имяTextBox.Name = "имяTextBox";
            this.имяTextBox.Size = new System.Drawing.Size(172, 20);
            this.имяTextBox.TabIndex = 7;
            // 
            // почта_пользователяTextBox
            // 
            this.почта_пользователяTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.пользовательBindingSource, "Почта пользователя", true));
            this.почта_пользователяTextBox.Location = new System.Drawing.Point(268, 306);
            this.почта_пользователяTextBox.Name = "почта_пользователяTextBox";
            this.почта_пользователяTextBox.Size = new System.Drawing.Size(172, 20);
            this.почта_пользователяTextBox.TabIndex = 8;
            // 
            // логинTextBox
            // 
            this.логинTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.пользовательBindingSource, "Логин", true));
            this.логинTextBox.Location = new System.Drawing.Point(267, 35);
            this.логинTextBox.Name = "логинTextBox";
            this.логинTextBox.Size = new System.Drawing.Size(172, 20);
            this.логинTextBox.TabIndex = 2;
            // 
            // парольTextBox
            // 
            this.парольTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.пользовательBindingSource, "Пароль", true));
            this.парольTextBox.Location = new System.Drawing.Point(267, 80);
            this.парольTextBox.Name = "парольTextBox";
            this.парольTextBox.Size = new System.Drawing.Size(172, 20);
            this.парольTextBox.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(183, 388);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(114, 23);
            this.button1.TabIndex = 13;
            this.button1.Text = "Регистрация";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(183, 125);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(114, 23);
            this.button2.TabIndex = 4;
            this.button2.Text = "Вход";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(522, 80);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 45;
            this.dataGridView1.Size = new System.Drawing.Size(532, 295);
            this.dataGridView1.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.81132F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(664, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(219, 44);
            this.label2.TabIndex = 21;
            this.label2.Text = "Избранные";
            // 
            // UserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1084, 448);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(парольLabel);
            this.Controls.Add(this.парольTextBox);
            this.Controls.Add(логинLabel);
            this.Controls.Add(this.логинTextBox);
            this.Controls.Add(почта_пользователяLabel);
            this.Controls.Add(this.почта_пользователяTextBox);
            this.Controls.Add(имяLabel);
            this.Controls.Add(this.имяTextBox);
            this.Controls.Add(id_сборника_ИзбранныеLabel);
            this.Controls.Add(this.id_сборника_ИзбранныеTextBox);
            this.Controls.Add(id_пользователяLabel);
            this.Controls.Add(this.id_пользователяTextBox);
            this.Name = "UserForm";
            this.Text = "Пользователь";
            this.Load += new System.EventHandler(this.UserForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Музыкальный_каталогDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.пользовательBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Музыкальный_каталогDataSet Музыкальный_каталогDataSet;
        private System.Windows.Forms.BindingSource пользовательBindingSource;
        private Музыкальный_каталогDataSetTableAdapters.ПользовательTableAdapter пользовательTableAdapter;
        private Музыкальный_каталогDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator пользовательBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton пользовательBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox id_пользователяTextBox;
        private System.Windows.Forms.TextBox id_сборника_ИзбранныеTextBox;
        private System.Windows.Forms.TextBox имяTextBox;
        private System.Windows.Forms.TextBox почта_пользователяTextBox;
        private System.Windows.Forms.TextBox логинTextBox;
        private System.Windows.Forms.TextBox парольTextBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label2;
    }
}