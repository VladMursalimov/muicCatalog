namespace forms
{
    partial class AdminForm
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
            System.Windows.Forms.Label название_альбомаLabel;
            System.Windows.Forms.Label дата_выпускаLabel;
            System.Windows.Forms.Label длительность_в_секLabel;
            System.Windows.Forms.Label количество_прослушиванийLabel;
            System.Windows.Forms.Label id_жанраLabel;
            this.Музыкальный_каталогDataSet = new forms.Музыкальный_каталогDataSet();
            this.песняBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.песняTableAdapter = new forms.Музыкальный_каталогDataSetTableAdapters.ПесняTableAdapter();
            this.tableAdapterManager = new forms.Музыкальный_каталогDataSetTableAdapters.TableAdapterManager();
            this.artistTab = new System.Windows.Forms.TabPage();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.textBox17CountAlbum = new System.Windows.Forms.TextBox();
            this.textBox16CountSong = new System.Windows.Forms.TextBox();
            this.textBox15Name = new System.Windows.Forms.TextBox();
            this.textBox14Name = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.albumTab = new System.Windows.Forms.TabPage();
            this.button4 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox13 = new System.Windows.Forms.TextBox();
            this.textBox11 = new System.Windows.Forms.TextBox();
            this.textBox12 = new System.Windows.Forms.TextBox();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.songTab = new System.Windows.Forms.TabPage();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.songNameTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            название_песниLabel = new System.Windows.Forms.Label();
            название_альбомаLabel = new System.Windows.Forms.Label();
            дата_выпускаLabel = new System.Windows.Forms.Label();
            длительность_в_секLabel = new System.Windows.Forms.Label();
            количество_прослушиванийLabel = new System.Windows.Forms.Label();
            id_жанраLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Музыкальный_каталогDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.песняBindingSource)).BeginInit();
            this.artistTab.SuspendLayout();
            this.albumTab.SuspendLayout();
            this.songTab.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // название_песниLabel
            // 
            название_песниLabel.AutoSize = true;
            название_песниLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.18868F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            название_песниLabel.Location = new System.Drawing.Point(363, 22);
            название_песниLabel.Name = "название_песниLabel";
            название_песниLabel.Size = new System.Drawing.Size(123, 18);
            название_песниLabel.TabIndex = 11;
            название_песниLabel.Text = "Название песни:";
            // 
            // название_альбомаLabel
            // 
            название_альбомаLabel.AutoSize = true;
            название_альбомаLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.18868F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            название_альбомаLabel.Location = new System.Drawing.Point(363, 73);
            название_альбомаLabel.Name = "название_альбомаLabel";
            название_альбомаLabel.Size = new System.Drawing.Size(145, 18);
            название_альбомаLabel.TabIndex = 12;
            название_альбомаLabel.Text = "Название альбома:";
            // 
            // дата_выпускаLabel
            // 
            дата_выпускаLabel.AutoSize = true;
            дата_выпускаLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.18868F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            дата_выпускаLabel.Location = new System.Drawing.Point(363, 118);
            дата_выпускаLabel.Name = "дата_выпускаLabel";
            дата_выпускаLabel.Size = new System.Drawing.Size(109, 18);
            дата_выпускаLabel.TabIndex = 13;
            дата_выпускаLabel.Text = "Дата выпуска:";
            // 
            // длительность_в_секLabel
            // 
            длительность_в_секLabel.AutoSize = true;
            длительность_в_секLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.18868F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            длительность_в_секLabel.Location = new System.Drawing.Point(363, 176);
            длительность_в_секLabel.Name = "длительность_в_секLabel";
            длительность_в_секLabel.Size = new System.Drawing.Size(153, 18);
            длительность_в_секLabel.TabIndex = 14;
            длительность_в_секLabel.Text = "Длительность в сек:";
            // 
            // количество_прослушиванийLabel
            // 
            количество_прослушиванийLabel.AutoSize = true;
            количество_прослушиванийLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.18868F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            количество_прослушиванийLabel.Location = new System.Drawing.Point(363, 225);
            количество_прослушиванийLabel.Name = "количество_прослушиванийLabel";
            количество_прослушиванийLabel.Size = new System.Drawing.Size(208, 18);
            количество_прослушиванийLabel.TabIndex = 15;
            количество_прослушиванийLabel.Text = "Количество прослушиваний:";
            // 
            // id_жанраLabel
            // 
            id_жанраLabel.AutoSize = true;
            id_жанраLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.18868F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            id_жанраLabel.Location = new System.Drawing.Point(363, 276);
            id_жанраLabel.Name = "id_жанраLabel";
            id_жанраLabel.Size = new System.Drawing.Size(70, 18);
            id_жанраLabel.TabIndex = 16;
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
            // artistTab
            // 
            this.artistTab.Controls.Add(this.button9);
            this.artistTab.Controls.Add(this.button6);
            this.artistTab.Controls.Add(this.button5);
            this.artistTab.Controls.Add(this.textBox17CountAlbum);
            this.artistTab.Controls.Add(this.textBox16CountSong);
            this.artistTab.Controls.Add(this.textBox15Name);
            this.artistTab.Controls.Add(this.textBox14Name);
            this.artistTab.Controls.Add(this.label12);
            this.artistTab.Controls.Add(this.label11);
            this.artistTab.Controls.Add(this.label10);
            this.artistTab.Controls.Add(this.label9);
            this.artistTab.Location = new System.Drawing.Point(4, 22);
            this.artistTab.Name = "artistTab";
            this.artistTab.Size = new System.Drawing.Size(819, 438);
            this.artistTab.TabIndex = 2;
            this.artistTab.Text = "Исполнитель";
            this.artistTab.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.18868F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button6.Location = new System.Drawing.Point(413, 189);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(365, 41);
            this.button6.TabIndex = 9;
            this.button6.Text = "Добавить исполнителя";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.18868F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button5.Location = new System.Drawing.Point(32, 94);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(186, 39);
            this.button5.TabIndex = 8;
            this.button5.Text = "Удалить исполнителя";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // textBox17CountAlbum
            // 
            this.textBox17CountAlbum.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.18868F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox17CountAlbum.Location = new System.Drawing.Point(582, 138);
            this.textBox17CountAlbum.Name = "textBox17CountAlbum";
            this.textBox17CountAlbum.Size = new System.Drawing.Size(196, 24);
            this.textBox17CountAlbum.TabIndex = 7;
            // 
            // textBox16CountSong
            // 
            this.textBox16CountSong.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.18868F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox16CountSong.Location = new System.Drawing.Point(582, 88);
            this.textBox16CountSong.Name = "textBox16CountSong";
            this.textBox16CountSong.Size = new System.Drawing.Size(196, 24);
            this.textBox16CountSong.TabIndex = 5;
            // 
            // textBox15Name
            // 
            this.textBox15Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.18868F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox15Name.Location = new System.Drawing.Point(582, 35);
            this.textBox15Name.Name = "textBox15Name";
            this.textBox15Name.Size = new System.Drawing.Size(196, 24);
            this.textBox15Name.TabIndex = 3;
            // 
            // textBox14Name
            // 
            this.textBox14Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.18868F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox14Name.Location = new System.Drawing.Point(118, 38);
            this.textBox14Name.Name = "textBox14Name";
            this.textBox14Name.Size = new System.Drawing.Size(100, 24);
            this.textBox14Name.TabIndex = 1;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.18868F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label12.Location = new System.Drawing.Point(410, 144);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(167, 18);
            this.label12.TabIndex = 6;
            this.label12.Text = "Количество альбомов";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.18868F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label11.Location = new System.Drawing.Point(410, 94);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(136, 18);
            this.label11.TabIndex = 4;
            this.label11.Text = "Количество песен";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.18868F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.Location = new System.Drawing.Point(410, 41);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(42, 18);
            this.label10.TabIndex = 2;
            this.label10.Text = "Имя ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.18868F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(29, 41);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(42, 18);
            this.label9.TabIndex = 0;
            this.label9.Text = "Имя ";
            // 
            // albumTab
            // 
            this.albumTab.Controls.Add(this.button8);
            this.albumTab.Controls.Add(this.button4);
            this.albumTab.Controls.Add(this.label8);
            this.albumTab.Controls.Add(this.textBox13);
            this.albumTab.Controls.Add(this.textBox11);
            this.albumTab.Controls.Add(this.textBox12);
            this.albumTab.Controls.Add(this.textBox10);
            this.albumTab.Controls.Add(this.textBox9);
            this.albumTab.Controls.Add(this.textBox8);
            this.albumTab.Controls.Add(this.label6);
            this.albumTab.Controls.Add(this.label7);
            this.albumTab.Controls.Add(this.label2);
            this.albumTab.Controls.Add(this.button3);
            this.albumTab.Controls.Add(this.label5);
            this.albumTab.Controls.Add(this.label4);
            this.albumTab.Location = new System.Drawing.Point(4, 22);
            this.albumTab.Name = "albumTab";
            this.albumTab.Padding = new System.Windows.Forms.Padding(3);
            this.albumTab.Size = new System.Drawing.Size(819, 438);
            this.albumTab.TabIndex = 1;
            this.albumTab.Text = "Альбом";
            this.albumTab.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.18868F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button4.Location = new System.Drawing.Point(367, 302);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(429, 37);
            this.button4.TabIndex = 13;
            this.button4.Text = "Добавить альбом";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.18868F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(364, 247);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(204, 18);
            this.label8.TabIndex = 12;
            this.label8.Text = "Количество прослушиваний";
            // 
            // textBox13
            // 
            this.textBox13.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.18868F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox13.Location = new System.Drawing.Point(597, 247);
            this.textBox13.Name = "textBox13";
            this.textBox13.Size = new System.Drawing.Size(199, 24);
            this.textBox13.TabIndex = 11;
            // 
            // textBox11
            // 
            this.textBox11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.18868F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox11.Location = new System.Drawing.Point(597, 141);
            this.textBox11.Name = "textBox11";
            this.textBox11.Size = new System.Drawing.Size(199, 24);
            this.textBox11.TabIndex = 9;
            // 
            // textBox12
            // 
            this.textBox12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.18868F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox12.Location = new System.Drawing.Point(597, 193);
            this.textBox12.Name = "textBox12";
            this.textBox12.Size = new System.Drawing.Size(199, 24);
            this.textBox12.TabIndex = 7;
            // 
            // textBox10
            // 
            this.textBox10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.18868F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox10.Location = new System.Drawing.Point(597, 93);
            this.textBox10.Name = "textBox10";
            this.textBox10.Size = new System.Drawing.Size(199, 24);
            this.textBox10.TabIndex = 5;
            // 
            // textBox9
            // 
            this.textBox9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.18868F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox9.Location = new System.Drawing.Point(597, 44);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(199, 24);
            this.textBox9.TabIndex = 1;
            // 
            // textBox8
            // 
            this.textBox8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.18868F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox8.Location = new System.Drawing.Point(187, 41);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(149, 24);
            this.textBox8.TabIndex = 0;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.18868F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(364, 195);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(136, 18);
            this.label6.TabIndex = 10;
            this.label6.Text = "Количество песен";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.18868F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(364, 144);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(109, 18);
            this.label7.TabIndex = 8;
            this.label7.Text = "Длительность";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.18868F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(364, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 18);
            this.label2.TabIndex = 6;
            this.label2.Text = "Дата выпуска";
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.18868F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button3.Location = new System.Drawing.Point(29, 84);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(307, 37);
            this.button3.TabIndex = 4;
            this.button3.Text = "Удалить альбом";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.18868F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(364, 46);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 18);
            this.label5.TabIndex = 3;
            this.label5.Text = "Название";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.18868F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(26, 44);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(141, 18);
            this.label4.TabIndex = 2;
            this.label4.Text = "Название альбома";
            // 
            // songTab
            // 
            this.songTab.AutoScroll = true;
            this.songTab.Controls.Add(this.button7);
            this.songTab.Controls.Add(this.textBox7);
            this.songTab.Controls.Add(this.textBox6);
            this.songTab.Controls.Add(this.textBox5);
            this.songTab.Controls.Add(this.textBox4);
            this.songTab.Controls.Add(this.textBox3);
            this.songTab.Controls.Add(this.textBox2);
            this.songTab.Controls.Add(this.textBox1);
            this.songTab.Controls.Add(this.songNameTextBox);
            this.songTab.Controls.Add(this.label3);
            this.songTab.Controls.Add(this.button2);
            this.songTab.Controls.Add(id_жанраLabel);
            this.songTab.Controls.Add(количество_прослушиванийLabel);
            this.songTab.Controls.Add(длительность_в_секLabel);
            this.songTab.Controls.Add(дата_выпускаLabel);
            this.songTab.Controls.Add(название_альбомаLabel);
            this.songTab.Controls.Add(название_песниLabel);
            this.songTab.Controls.Add(this.button1);
            this.songTab.Controls.Add(this.label1);
            this.songTab.Location = new System.Drawing.Point(4, 22);
            this.songTab.Name = "songTab";
            this.songTab.Padding = new System.Windows.Forms.Padding(3);
            this.songTab.Size = new System.Drawing.Size(819, 438);
            this.songTab.TabIndex = 0;
            this.songTab.Text = "Песни";
            this.songTab.UseVisualStyleBackColor = true;
            // 
            // textBox7
            // 
            this.textBox7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.18868F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox7.Location = new System.Drawing.Point(604, 310);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(196, 24);
            this.textBox7.TabIndex = 19;
            // 
            // textBox6
            // 
            this.textBox6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.18868F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox6.Location = new System.Drawing.Point(604, 271);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(196, 24);
            this.textBox6.TabIndex = 11;
            // 
            // textBox5
            // 
            this.textBox5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.18868F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox5.Location = new System.Drawing.Point(604, 222);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(196, 24);
            this.textBox5.TabIndex = 9;
            // 
            // textBox4
            // 
            this.textBox4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.18868F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox4.Location = new System.Drawing.Point(604, 174);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(196, 24);
            this.textBox4.TabIndex = 8;
            // 
            // textBox3
            // 
            this.textBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.18868F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox3.Location = new System.Drawing.Point(604, 116);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(196, 24);
            this.textBox3.TabIndex = 7;
            // 
            // textBox2
            // 
            this.textBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.18868F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox2.Location = new System.Drawing.Point(604, 68);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(196, 24);
            this.textBox2.TabIndex = 6;
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.18868F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox1.Location = new System.Drawing.Point(604, 23);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(196, 24);
            this.textBox1.TabIndex = 5;
            // 
            // songNameTextBox
            // 
            this.songNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.18868F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.songNameTextBox.Location = new System.Drawing.Point(89, 48);
            this.songNameTextBox.Name = "songNameTextBox";
            this.songNameTextBox.Size = new System.Drawing.Size(151, 24);
            this.songNameTextBox.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.18868F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(363, 316);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 18);
            this.label3.TabIndex = 18;
            this.label3.Text = "Исполнитель";
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.18868F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.Location = new System.Drawing.Point(366, 353);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(428, 31);
            this.button2.TabIndex = 17;
            this.button2.Text = "Добавить песню";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.18868F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(11, 88);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(229, 32);
            this.button1.TabIndex = 4;
            this.button1.Text = "Удалить песню";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.18868F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(8, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 18);
            this.label1.TabIndex = 2;
            this.label1.Text = "Название";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.songTab);
            this.tabControl1.Controls.Add(this.albumTab);
            this.tabControl1.Controls.Add(this.artistTab);
            this.tabControl1.Location = new System.Drawing.Point(2, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(827, 464);
            this.tabControl1.TabIndex = 0;
            // 
            // button7
            // 
            this.button7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.18868F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button7.Location = new System.Drawing.Point(11, 139);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(229, 38);
            this.button7.TabIndex = 20;
            this.button7.Text = "Редактировать песню";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button8
            // 
            this.button8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.18868F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button8.Location = new System.Drawing.Point(29, 138);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(307, 46);
            this.button8.TabIndex = 14;
            this.button8.Text = "Редактировать альбом";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button9
            // 
            this.button9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.18868F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button9.Location = new System.Drawing.Point(32, 156);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(186, 34);
            this.button9.TabIndex = 10;
            this.button9.Text = "Редактировать";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(823, 459);
            this.Controls.Add(this.tabControl1);
            this.Name = "AdminForm";
            this.Text = "Панель администратора";
            this.Load += new System.EventHandler(this.AdminForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Музыкальный_каталогDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.песняBindingSource)).EndInit();
            this.artistTab.ResumeLayout(false);
            this.artistTab.PerformLayout();
            this.albumTab.ResumeLayout(false);
            this.albumTab.PerformLayout();
            this.songTab.ResumeLayout(false);
            this.songTab.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private Музыкальный_каталогDataSet Музыкальный_каталогDataSet;
        private System.Windows.Forms.BindingSource песняBindingSource;
        private Музыкальный_каталогDataSetTableAdapters.ПесняTableAdapter песняTableAdapter;
        private Музыкальный_каталогDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TabPage artistTab;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.TextBox textBox17CountAlbum;
        private System.Windows.Forms.TextBox textBox16CountSong;
        private System.Windows.Forms.TextBox textBox15Name;
        private System.Windows.Forms.TextBox textBox14Name;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TabPage albumTab;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox13;
        private System.Windows.Forms.TextBox textBox11;
        private System.Windows.Forms.TextBox textBox12;
        private System.Windows.Forms.TextBox textBox10;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TabPage songTab;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox songNameTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
    }
}