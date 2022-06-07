
namespace OnlineTicaretUygulamasi.Satis
{
    partial class SatisSiparis
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SatisSiparis));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.backToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.PNLSiparis = new System.Windows.Forms.Panel();
            this.PnlDetay = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.DtGDetay = new System.Windows.Forms.DataGridView();
            this.DtGSiparisler = new System.Windows.Forms.DataGridView();
            this.Detay = new System.Windows.Forms.DataGridViewButtonColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.LblID = new System.Windows.Forms.Label();
            this.button6 = new System.Windows.Forms.Button();
            this.BtnListe = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.CmbOdeme = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.RbtBanka = new System.Windows.Forms.RadioButton();
            this.RbtNakit = new System.Windows.Forms.RadioButton();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.TxtMustAdi = new System.Windows.Forms.TextBox();
            this.CmbMusteri = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnsil = new System.Windows.Forms.Button();
            this.btnguncelle = new System.Windows.Forms.Button();
            this.btnkaydet = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtfiyat = new System.Windows.Forms.TextBox();
            this.txtmiktar = new System.Windows.Forms.TextBox();
            this.cmburunsec = new System.Windows.Forms.ComboBox();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.PNLSiparis.SuspendLayout();
            this.PnlDetay.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DtGDetay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DtGSiparisler)).BeginInit();
            this.panel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(12, 3, 0, 3);
            this.menuStrip1.Size = new System.Drawing.Size(1892, 42);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.backToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(72, 36);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // backToolStripMenuItem
            // 
            this.backToolStripMenuItem.Name = "backToolStripMenuItem";
            this.backToolStripMenuItem.Size = new System.Drawing.Size(198, 44);
            this.backToolStripMenuItem.Text = "Back";
            this.backToolStripMenuItem.Click += new System.EventHandler(this.backToolStripMenuItem_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.PNLSiparis);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.CmbOdeme);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.dateTimePicker1);
            this.panel1.Controls.Add(this.TxtMustAdi);
            this.panel1.Controls.Add(this.CmbMusteri);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 42);
            this.panel1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1892, 452);
            this.panel1.TabIndex = 1;
            // 
            // PNLSiparis
            // 
            this.PNLSiparis.Controls.Add(this.PnlDetay);
            this.PNLSiparis.Controls.Add(this.DtGSiparisler);
            this.PNLSiparis.Location = new System.Drawing.Point(280, 139);
            this.PNLSiparis.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.PNLSiparis.Name = "PNLSiparis";
            this.PNLSiparis.Size = new System.Drawing.Size(968, 302);
            this.PNLSiparis.TabIndex = 12;
            this.PNLSiparis.Visible = false;
            // 
            // PnlDetay
            // 
            this.PnlDetay.Controls.Add(this.button1);
            this.PnlDetay.Controls.Add(this.DtGDetay);
            this.PnlDetay.Location = new System.Drawing.Point(0, 6);
            this.PnlDetay.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.PnlDetay.Name = "PnlDetay";
            this.PnlDetay.Size = new System.Drawing.Size(968, 291);
            this.PnlDetay.TabIndex = 1;
            this.PnlDetay.Visible = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(846, 22);
            this.button1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(116, 78);
            this.button1.TabIndex = 1;
            this.button1.Text = "Geri Dön";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // DtGDetay
            // 
            this.DtGDetay.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DtGDetay.Location = new System.Drawing.Point(8, 8);
            this.DtGDetay.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.DtGDetay.Name = "DtGDetay";
            this.DtGDetay.RowHeadersWidth = 82;
            this.DtGDetay.Size = new System.Drawing.Size(824, 289);
            this.DtGDetay.TabIndex = 0;
            // 
            // DtGSiparisler
            // 
            this.DtGSiparisler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DtGSiparisler.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Detay});
            this.DtGSiparisler.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DtGSiparisler.Location = new System.Drawing.Point(0, 0);
            this.DtGSiparisler.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.DtGSiparisler.Name = "DtGSiparisler";
            this.DtGSiparisler.RowHeadersWidth = 82;
            this.DtGSiparisler.Size = new System.Drawing.Size(968, 302);
            this.DtGSiparisler.TabIndex = 0;
            this.DtGSiparisler.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DtGSiparisler_CellContentClick);
            // 
            // Detay
            // 
            this.Detay.HeaderText = "Sipariş Detayları";
            this.Detay.MinimumWidth = 10;
            this.Detay.Name = "Detay";
            this.Detay.Text = "Detay";
            this.Detay.ToolTipText = "Seçilen siparişin Satırlarını Gösterir";
            this.Detay.Width = 200;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.LblID);
            this.panel2.Controls.Add(this.button6);
            this.panel2.Controls.Add(this.BtnListe);
            this.panel2.Controls.Add(this.button4);
            this.panel2.Controls.Add(this.button5);
            this.panel2.Controls.Add(this.button3);
            this.panel2.Controls.Add(this.button2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(1264, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(628, 452);
            this.panel2.TabIndex = 11;
            // 
            // LblID
            // 
            this.LblID.AutoSize = true;
            this.LblID.Location = new System.Drawing.Point(228, 23);
            this.LblID.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.LblID.Name = "LblID";
            this.LblID.Size = new System.Drawing.Size(70, 25);
            this.LblID.TabIndex = 12;
            this.LblID.Text = "label2";
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(6, 277);
            this.button6.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(182, 44);
            this.button6.TabIndex = 11;
            this.button6.Text = "Bekleyen Siparişler";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // BtnListe
            // 
            this.BtnListe.Location = new System.Drawing.Point(6, 6);
            this.BtnListe.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.BtnListe.Name = "BtnListe";
            this.BtnListe.Size = new System.Drawing.Size(182, 44);
            this.BtnListe.TabIndex = 6;
            this.BtnListe.Text = "Listele";
            this.BtnListe.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(6, 333);
            this.button4.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(182, 44);
            this.button4.TabIndex = 9;
            this.button4.Text = "Ödeme Bilgileri";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(6, 61);
            this.button5.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(182, 44);
            this.button5.TabIndex = 10;
            this.button5.Text = "Yeni Sipariş";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(6, 173);
            this.button3.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(182, 92);
            this.button3.TabIndex = 8;
            this.button3.Text = "Taamamlanmış Teslimatlar";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(6, 117);
            this.button2.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(182, 44);
            this.button2.TabIndex = 7;
            this.button2.Text = "Yeni Ürün";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // CmbOdeme
            // 
            this.CmbOdeme.FormattingEnabled = true;
            this.CmbOdeme.Location = new System.Drawing.Point(32, 294);
            this.CmbOdeme.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.CmbOdeme.Name = "CmbOdeme";
            this.CmbOdeme.Size = new System.Drawing.Size(206, 33);
            this.CmbOdeme.TabIndex = 5;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.RbtBanka);
            this.groupBox1.Controls.Add(this.RbtNakit);
            this.groupBox1.Location = new System.Drawing.Point(32, 127);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.groupBox1.Size = new System.Drawing.Size(210, 156);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ödeme Şekli";
            // 
            // RbtBanka
            // 
            this.RbtBanka.AutoSize = true;
            this.RbtBanka.Location = new System.Drawing.Point(14, 84);
            this.RbtBanka.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.RbtBanka.Name = "RbtBanka";
            this.RbtBanka.Size = new System.Drawing.Size(104, 29);
            this.RbtBanka.TabIndex = 1;
            this.RbtBanka.TabStop = true;
            this.RbtBanka.Text = "Banka";
            this.RbtBanka.UseVisualStyleBackColor = true;
            // 
            // RbtNakit
            // 
            this.RbtNakit.AutoSize = true;
            this.RbtNakit.Location = new System.Drawing.Point(14, 39);
            this.RbtNakit.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.RbtNakit.Name = "RbtNakit";
            this.RbtNakit.Size = new System.Drawing.Size(92, 29);
            this.RbtNakit.TabIndex = 0;
            this.RbtNakit.TabStop = true;
            this.RbtNakit.Text = "Nakit";
            this.RbtNakit.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(848, 27);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(396, 31);
            this.dateTimePicker1.TabIndex = 3;
            // 
            // TxtMustAdi
            // 
            this.TxtMustAdi.Enabled = false;
            this.TxtMustAdi.Location = new System.Drawing.Point(126, 27);
            this.TxtMustAdi.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.TxtMustAdi.Name = "TxtMustAdi";
            this.TxtMustAdi.Size = new System.Drawing.Size(452, 31);
            this.TxtMustAdi.TabIndex = 2;
            // 
            // CmbMusteri
            // 
            this.CmbMusteri.FormattingEnabled = true;
            this.CmbMusteri.Location = new System.Drawing.Point(126, 77);
            this.CmbMusteri.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.CmbMusteri.Name = "CmbMusteri";
            this.CmbMusteri.Size = new System.Drawing.Size(452, 33);
            this.CmbMusteri.TabIndex = 1;
            this.CmbMusteri.SelectedIndexChanged += new System.EventHandler(this.CmbMusteri_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 33);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Müşteri ";
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 494);
            this.panel3.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1892, 731);
            this.panel3.TabIndex = 2;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.btnsil);
            this.panel4.Controls.Add(this.btnguncelle);
            this.panel4.Controls.Add(this.btnkaydet);
            this.panel4.Controls.Add(this.panel5);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Controls.Add(this.txtfiyat);
            this.panel4.Controls.Add(this.txtmiktar);
            this.panel4.Controls.Add(this.cmburunsec);
            this.panel4.Location = new System.Drawing.Point(6, 8);
            this.panel4.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(982, 716);
            this.panel4.TabIndex = 0;
            this.panel4.Visible = false;
            // 
            // btnsil
            // 
            this.btnsil.Location = new System.Drawing.Point(514, 322);
            this.btnsil.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnsil.Name = "btnsil";
            this.btnsil.Size = new System.Drawing.Size(150, 44);
            this.btnsil.TabIndex = 9;
            this.btnsil.Text = "sil";
            this.btnsil.UseVisualStyleBackColor = true;
            this.btnsil.Click += new System.EventHandler(this.btnsil_Click);
            // 
            // btnguncelle
            // 
            this.btnguncelle.Location = new System.Drawing.Point(270, 322);
            this.btnguncelle.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnguncelle.Name = "btnguncelle";
            this.btnguncelle.Size = new System.Drawing.Size(150, 44);
            this.btnguncelle.TabIndex = 8;
            this.btnguncelle.Text = "güncelle";
            this.btnguncelle.UseVisualStyleBackColor = true;
            this.btnguncelle.Click += new System.EventHandler(this.btnguncelle_Click);
            // 
            // btnkaydet
            // 
            this.btnkaydet.Location = new System.Drawing.Point(42, 322);
            this.btnkaydet.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnkaydet.Name = "btnkaydet";
            this.btnkaydet.Size = new System.Drawing.Size(150, 44);
            this.btnkaydet.TabIndex = 7;
            this.btnkaydet.Text = "kaydet";
            this.btnkaydet.UseVisualStyleBackColor = true;
            this.btnkaydet.Click += new System.EventHandler(this.btnkaydet_Click);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.dataGridView1);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel5.Location = new System.Drawing.Point(0, 397);
            this.panel5.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(982, 319);
            this.panel5.TabIndex = 6;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 82;
            this.dataGridView1.Size = new System.Drawing.Size(982, 319);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(122, 186);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 25);
            this.label4.TabIndex = 5;
            this.label4.Text = "Fiyatı";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(116, 98);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "Miktarı";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(98, 16);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Ürün Seçiniz";
            // 
            // txtfiyat
            // 
            this.txtfiyat.Location = new System.Drawing.Point(36, 231);
            this.txtfiyat.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtfiyat.Name = "txtfiyat";
            this.txtfiyat.Size = new System.Drawing.Size(238, 31);
            this.txtfiyat.TabIndex = 2;
            // 
            // txtmiktar
            // 
            this.txtmiktar.Location = new System.Drawing.Point(36, 134);
            this.txtmiktar.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtmiktar.Name = "txtmiktar";
            this.txtmiktar.Size = new System.Drawing.Size(238, 31);
            this.txtmiktar.TabIndex = 1;
            // 
            // cmburunsec
            // 
            this.cmburunsec.FormattingEnabled = true;
            this.cmburunsec.Location = new System.Drawing.Point(36, 47);
            this.cmburunsec.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.cmburunsec.Name = "cmburunsec";
            this.cmburunsec.Size = new System.Drawing.Size(238, 33);
            this.cmburunsec.TabIndex = 0;
            // 
            // SatisSiparis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1892, 1225);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "SatisSiparis";
            this.Text = "SatisSiparis";
            this.Load += new System.EventHandler(this.SatisSiparis_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.PNLSiparis.ResumeLayout(false);
            this.PnlDetay.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DtGDetay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DtGSiparisler)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem backToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox TxtMustAdi;
        private System.Windows.Forms.ComboBox CmbMusteri;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton RbtBanka;
        private System.Windows.Forms.RadioButton RbtNakit;
        private System.Windows.Forms.ComboBox CmbOdeme;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button BtnListe;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Label LblID;
        private System.Windows.Forms.Panel PNLSiparis;
        private System.Windows.Forms.DataGridView DtGSiparisler;
        private System.Windows.Forms.DataGridViewButtonColumn Detay;
        private System.Windows.Forms.Panel PnlDetay;
        private System.Windows.Forms.DataGridView DtGDetay;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnsil;
        private System.Windows.Forms.Button btnguncelle;
        private System.Windows.Forms.Button btnkaydet;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtfiyat;
        private System.Windows.Forms.TextBox txtmiktar;
        private System.Windows.Forms.ComboBox cmburunsec;
    }
}