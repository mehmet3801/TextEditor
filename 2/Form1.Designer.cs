namespace _2
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.yeniToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kesToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.kopyalaToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.yapışturToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.açToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.sağaHizalaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.solaHizalaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ortalaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.açToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kaydetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.renkToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yazıTipiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ekleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fotoğrafEkleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yeniToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.tabloEkleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label7 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.lblItelik = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.comboBoxFont = new System.Windows.Forms.ComboBox();
            this.comboBoxFontSize = new System.Windows.Forms.ComboBox();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.yeniToolStripMenuItem,
            this.açToolStripMenuItem,
            this.kaydetToolStripMenuItem,
            this.renkToolStripMenuItem,
            this.yazıTipiToolStripMenuItem,
            this.ekleToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(12, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(365, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.toolTip1.SetToolTip(this.menuStrip1, "Seçenekler");
            // 
            // yeniToolStripMenuItem
            // 
            this.yeniToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kesToolStripMenuItem1,
            this.kopyalaToolStripMenuItem1,
            this.yapışturToolStripMenuItem,
            this.açToolStripMenuItem1,
            this.sağaHizalaToolStripMenuItem,
            this.solaHizalaToolStripMenuItem,
            this.ortalaToolStripMenuItem});
            this.yeniToolStripMenuItem.Name = "yeniToolStripMenuItem";
            this.yeniToolStripMenuItem.Size = new System.Drawing.Size(65, 24);
            this.yeniToolStripMenuItem.Text = "Düzen";
            this.yeniToolStripMenuItem.Click += new System.EventHandler(this.yeniToolStripMenuItem_Click);
            // 
            // kesToolStripMenuItem1
            // 
            this.kesToolStripMenuItem1.Name = "kesToolStripMenuItem1";
            this.kesToolStripMenuItem1.Size = new System.Drawing.Size(171, 26);
            this.kesToolStripMenuItem1.Text = "Kes";
            this.kesToolStripMenuItem1.Click += new System.EventHandler(this.kesToolStripMenuItem1_Click);
            // 
            // kopyalaToolStripMenuItem1
            // 
            this.kopyalaToolStripMenuItem1.Name = "kopyalaToolStripMenuItem1";
            this.kopyalaToolStripMenuItem1.Size = new System.Drawing.Size(171, 26);
            this.kopyalaToolStripMenuItem1.Text = "Kopyala";
            this.kopyalaToolStripMenuItem1.Click += new System.EventHandler(this.kopyalaToolStripMenuItem1_Click);
            // 
            // yapışturToolStripMenuItem
            // 
            this.yapışturToolStripMenuItem.Name = "yapışturToolStripMenuItem";
            this.yapışturToolStripMenuItem.Size = new System.Drawing.Size(171, 26);
            this.yapışturToolStripMenuItem.Text = "Yapıstır";
            this.yapışturToolStripMenuItem.Click += new System.EventHandler(this.yapışturToolStripMenuItem_Click);
            // 
            // açToolStripMenuItem1
            // 
            this.açToolStripMenuItem1.Name = "açToolStripMenuItem1";
            this.açToolStripMenuItem1.Size = new System.Drawing.Size(171, 26);
            this.açToolStripMenuItem1.Text = "Aç";
            this.açToolStripMenuItem1.Click += new System.EventHandler(this.açToolStripMenuItem1_Click);
            // 
            // sağaHizalaToolStripMenuItem
            // 
            this.sağaHizalaToolStripMenuItem.Name = "sağaHizalaToolStripMenuItem";
            this.sağaHizalaToolStripMenuItem.Size = new System.Drawing.Size(171, 26);
            this.sağaHizalaToolStripMenuItem.Text = "Sağa Hizala";
            this.sağaHizalaToolStripMenuItem.Click += new System.EventHandler(this.sağaHizalaToolStripMenuItem_Click);
            // 
            // solaHizalaToolStripMenuItem
            // 
            this.solaHizalaToolStripMenuItem.Name = "solaHizalaToolStripMenuItem";
            this.solaHizalaToolStripMenuItem.Size = new System.Drawing.Size(171, 26);
            this.solaHizalaToolStripMenuItem.Text = "Sola Hizala";
            this.solaHizalaToolStripMenuItem.Click += new System.EventHandler(this.solaHizalaToolStripMenuItem_Click);
            // 
            // ortalaToolStripMenuItem
            // 
            this.ortalaToolStripMenuItem.Name = "ortalaToolStripMenuItem";
            this.ortalaToolStripMenuItem.Size = new System.Drawing.Size(171, 26);
            this.ortalaToolStripMenuItem.Text = "Ortala";
            this.ortalaToolStripMenuItem.Click += new System.EventHandler(this.ortalaToolStripMenuItem_Click);
            // 
            // açToolStripMenuItem
            // 
            this.açToolStripMenuItem.Name = "açToolStripMenuItem";
            this.açToolStripMenuItem.Size = new System.Drawing.Size(40, 24);
            this.açToolStripMenuItem.Text = "Aç";
            this.açToolStripMenuItem.Click += new System.EventHandler(this.açToolStripMenuItem_Click);
            // 
            // kaydetToolStripMenuItem
            // 
            this.kaydetToolStripMenuItem.Name = "kaydetToolStripMenuItem";
            this.kaydetToolStripMenuItem.Size = new System.Drawing.Size(69, 24);
            this.kaydetToolStripMenuItem.Text = "Kaydet";
            this.kaydetToolStripMenuItem.Click += new System.EventHandler(this.kaydetToolStripMenuItem_Click);
            // 
            // renkToolStripMenuItem
            // 
            this.renkToolStripMenuItem.Name = "renkToolStripMenuItem";
            this.renkToolStripMenuItem.Size = new System.Drawing.Size(55, 24);
            this.renkToolStripMenuItem.Text = "Renk";
            this.renkToolStripMenuItem.Click += new System.EventHandler(this.renkToolStripMenuItem_Click);
            // 
            // yazıTipiToolStripMenuItem
            // 
            this.yazıTipiToolStripMenuItem.Name = "yazıTipiToolStripMenuItem";
            this.yazıTipiToolStripMenuItem.Size = new System.Drawing.Size(78, 24);
            this.yazıTipiToolStripMenuItem.Text = "Yazı Tipi";
            this.yazıTipiToolStripMenuItem.Click += new System.EventHandler(this.yazıTipiToolStripMenuItem_Click);
            // 
            // ekleToolStripMenuItem
            // 
            this.ekleToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fotoğrafEkleToolStripMenuItem,
            this.yeniToolStripMenuItem1,
            this.tabloEkleToolStripMenuItem});
            this.ekleToolStripMenuItem.Name = "ekleToolStripMenuItem";
            this.ekleToolStripMenuItem.Size = new System.Drawing.Size(50, 24);
            this.ekleToolStripMenuItem.Text = "Ekle";
            // 
            // fotoğrafEkleToolStripMenuItem
            // 
            this.fotoğrafEkleToolStripMenuItem.Name = "fotoğrafEkleToolStripMenuItem";
            this.fotoğrafEkleToolStripMenuItem.Size = new System.Drawing.Size(180, 26);
            this.fotoğrafEkleToolStripMenuItem.Text = "Fotoğraf Ekle";
            this.fotoğrafEkleToolStripMenuItem.Click += new System.EventHandler(this.fotoğrafEkleToolStripMenuItem_Click);
            // 
            // yeniToolStripMenuItem1
            // 
            this.yeniToolStripMenuItem1.Name = "yeniToolStripMenuItem1";
            this.yeniToolStripMenuItem1.Size = new System.Drawing.Size(180, 26);
            this.yeniToolStripMenuItem1.Text = "Yeni";
            this.yeniToolStripMenuItem1.Click += new System.EventHandler(this.yeniToolStripMenuItem1_Click);
            // 
            // tabloEkleToolStripMenuItem
            // 
            this.tabloEkleToolStripMenuItem.Name = "tabloEkleToolStripMenuItem";
            this.tabloEkleToolStripMenuItem.Size = new System.Drawing.Size(180, 26);
            this.tabloEkleToolStripMenuItem.Text = "Tablo Ekle";
            this.tabloEkleToolStripMenuItem.Click += new System.EventHandler(this.tabloEkleToolStripMenuItem_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.Color.DimGray;
            this.richTextBox1.Location = new System.Drawing.Point(5, 75);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(797, 370);
            this.richTextBox1.TabIndex = 1;
            this.richTextBox1.Text = "";
            this.toolTip1.SetToolTip(this.richTextBox1, "Yazma Alanı");
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(76, 5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 32);
            this.label2.TabIndex = 5;
            this.label2.Text = " ✂";
            this.toolTip1.SetToolTip(this.label2, "Kes");
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(133, 5);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 32);
            this.label3.TabIndex = 5;
            this.label3.Text = " 📑";
            this.toolTip1.SetToolTip(this.label3, "Yeni");
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(250, 5);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 32);
            this.label4.TabIndex = 5;
            this.label4.Text = "  💾";
            this.toolTip1.SetToolTip(this.label4, "Kaydet");
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(201, 5);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 32);
            this.label5.TabIndex = 5;
            this.label5.Text = "📄";
            this.toolTip1.SetToolTip(this.label5, "Kopyala");
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Menu;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(11, 80);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(766, 359);
            this.dataGridView1.TabIndex = 6;
            this.dataGridView1.Visible = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(528, 5);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 32);
            this.label7.TabIndex = 5;
            this.label7.Text = "🖼️";
            this.toolTip1.SetToolTip(this.label7, "Resim Ekle");
            this.label7.Click += new System.EventHandler(this.label6_Click);
            // 
            // lblItelik
            // 
            this.lblItelik.AutoSize = true;
            this.lblItelik.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblItelik.Location = new System.Drawing.Point(489, 3);
            this.lblItelik.Name = "lblItelik";
            this.lblItelik.Size = new System.Drawing.Size(23, 36);
            this.lblItelik.TabIndex = 11;
            this.lblItelik.Text = "I";
            this.toolTip1.SetToolTip(this.lblItelik, "İtalik");
            this.lblItelik.Click += new System.EventHandler(this.lblItelik_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.Location = new System.Drawing.Point(437, 3);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(37, 36);
            this.label10.TabIndex = 10;
            this.label10.Text = "A";
            this.toolTip1.SetToolTip(this.label10, "Altı Çizili");
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(382, 3);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(36, 36);
            this.label9.TabIndex = 9;
            this.label9.Text = "K";
            this.toolTip1.SetToolTip(this.label9, "Kalın");
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(7, -6);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(36, 46);
            this.label8.TabIndex = 8;
            this.label8.Text = "⤸";
            this.toolTip1.SetToolTip(this.label8, "Geri");
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(569, 5);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 32);
            this.label6.TabIndex = 12;
            this.toolTip1.SetToolTip(this.label6, "İleri");
            this.label6.Click += new System.EventHandler(this.label6_Click_1);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label11.Location = new System.Drawing.Point(42, -6);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(36, 46);
            this.label11.TabIndex = 13;
            this.label11.Text = "⤹";
            this.toolTip1.SetToolTip(this.label11, "İleri");
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label15.Image = global::_2.Properties.Resources.capture_20240522000642773;
            this.label15.Location = new System.Drawing.Point(591, 9);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(27, 25);
            this.label15.TabIndex = 13;
            this.label15.Text = "ㅤ";
            this.toolTip1.SetToolTip(this.label15, "Sola Hizala");
            this.label15.Click += new System.EventHandler(this.label15_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label14.Image = global::_2.Properties.Resources.capture_20240522001647915;
            this.label14.Location = new System.Drawing.Point(683, 9);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(27, 25);
            this.label14.TabIndex = 12;
            this.label14.Text = "ㅤ";
            this.toolTip1.SetToolTip(this.label14, "Sağa Hizala");
            this.label14.Click += new System.EventHandler(this.label14_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label13.Image = global::_2.Properties.Resources.capture_20240522000226172;
            this.label13.Location = new System.Drawing.Point(636, 9);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(27, 25);
            this.label13.TabIndex = 11;
            this.label13.Text = "‎‎‎‎‎‎‎‎‏‎‏‎‏‎ㅤ";
            this.toolTip1.SetToolTip(this.label13, "Ortala");
            this.label13.Click += new System.EventHandler(this.label13_Click);
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Image = global::_2.Properties.Resources.images_removebg_preview;
            this.button1.Location = new System.Drawing.Point(731, 8);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(40, 28);
            this.button1.TabIndex = 7;
            this.toolTip1.SetToolTip(this.button1, "Renk");
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(314, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 32);
            this.label1.TabIndex = 4;
            this.label1.Text = " 🖨️";
            this.toolTip1.SetToolTip(this.label1, "Yazdır");
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.Teal;
            this.panel1.Controls.Add(this.label14);
            this.panel1.Controls.Add(this.label15);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.lblItelik);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(5, 31);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(777, 47);
            this.panel1.TabIndex = 8;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // comboBoxFont
            // 
            this.comboBoxFont.FormattingEnabled = true;
            this.comboBoxFont.Location = new System.Drawing.Point(375, 1);
            this.comboBoxFont.Name = "comboBoxFont";
            this.comboBoxFont.Size = new System.Drawing.Size(227, 24);
            this.comboBoxFont.TabIndex = 9;
            this.comboBoxFont.SelectedIndexChanged += new System.EventHandler(this.comboBoxFont_SelectedIndexChanged);
            // 
            // comboBoxFontSize
            // 
            this.comboBoxFontSize.FormattingEnabled = true;
            this.comboBoxFontSize.Location = new System.Drawing.Point(608, 2);
            this.comboBoxFontSize.Name = "comboBoxFontSize";
            this.comboBoxFontSize.Size = new System.Drawing.Size(162, 24);
            this.comboBoxFontSize.TabIndex = 10;
            this.comboBoxFontSize.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // printDialog1
            // 
            this.printDialog1.UseEXDialog = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(789, 435);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(10, 10);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(782, 455);
            this.Controls.Add(this.comboBoxFontSize);
            this.Controls.Add(this.comboBoxFont);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.richTextBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Word Uygulama";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem yeniToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kaydetToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem renkToolStripMenuItem;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.ToolStripMenuItem açToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yazıTipiToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStripMenuItem kesToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem kopyalaToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem yapışturToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ekleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fotoğrafEkleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem açToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem yeniToolStripMenuItem1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ToolStripMenuItem tabloEkleToolStripMenuItem;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox comboBoxFont;
        private System.Windows.Forms.ComboBox comboBoxFontSize;
        private System.Windows.Forms.Label lblItelik;
        private System.Windows.Forms.PrintDialog printDialog1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ToolStripMenuItem sağaHizalaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem solaHizalaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ortalaToolStripMenuItem;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label1;
    }
}

