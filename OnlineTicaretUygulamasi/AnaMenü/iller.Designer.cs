
namespace OnlineTicaretUygulamasi.AnaMenü
{
    partial class iller
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(iller));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.backToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Btn_Sil = new System.Windows.Forms.Button();
            this.Btn_Guncelle = new System.Windows.Forms.Button();
            this.Btn_Kaydet = new System.Windows.Forms.Button();
            this.txtil = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.ıllerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.friendyolDataSet = new OnlineTicaretUygulamasi.FriendyolDataSet();
            this.listView1 = new System.Windows.Forms.ListView();
            this.illerTableAdapter = new OnlineTicaretUygulamasi.FriendyolDataSetTableAdapters.IllerTableAdapter();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ıllerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.friendyolDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(487, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.backToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // backToolStripMenuItem
            // 
            this.backToolStripMenuItem.Name = "backToolStripMenuItem";
            this.backToolStripMenuItem.Size = new System.Drawing.Size(99, 22);
            this.backToolStripMenuItem.Text = "Back";
            this.backToolStripMenuItem.Click += new System.EventHandler(this.backToolStripMenuItem_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.Btn_Sil);
            this.panel1.Controls.Add(this.Btn_Guncelle);
            this.panel1.Controls.Add(this.Btn_Kaydet);
            this.panel1.Controls.Add(this.txtil);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 24);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(169, 492);
            this.panel1.TabIndex = 2;
            // 
            // Btn_Sil
            // 
            this.Btn_Sil.BackgroundImage = global::OnlineTicaretUygulamasi.Properties.Resources.icons8_exit_67;
            this.Btn_Sil.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Btn_Sil.Location = new System.Drawing.Point(114, 118);
            this.Btn_Sil.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Btn_Sil.Name = "Btn_Sil";
            this.Btn_Sil.Size = new System.Drawing.Size(20, 21);
            this.Btn_Sil.TabIndex = 4;
            this.Btn_Sil.UseVisualStyleBackColor = true;
            // 
            // Btn_Guncelle
            // 
            this.Btn_Guncelle.BackgroundImage = global::OnlineTicaretUygulamasi.Properties.Resources.icons8_reset_96;
            this.Btn_Guncelle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Btn_Guncelle.Location = new System.Drawing.Point(66, 118);
            this.Btn_Guncelle.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Btn_Guncelle.Name = "Btn_Guncelle";
            this.Btn_Guncelle.Size = new System.Drawing.Size(20, 21);
            this.Btn_Guncelle.TabIndex = 3;
            this.Btn_Guncelle.UseVisualStyleBackColor = true;
            // 
            // Btn_Kaydet
            // 
            this.Btn_Kaydet.BackgroundImage = global::OnlineTicaretUygulamasi.Properties.Resources.icons8_save_64;
            this.Btn_Kaydet.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Btn_Kaydet.Location = new System.Drawing.Point(14, 118);
            this.Btn_Kaydet.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Btn_Kaydet.Name = "Btn_Kaydet";
            this.Btn_Kaydet.Size = new System.Drawing.Size(20, 21);
            this.Btn_Kaydet.TabIndex = 2;
            this.Btn_Kaydet.UseVisualStyleBackColor = true;
            // 
            // txtil
            // 
            this.txtil.Location = new System.Drawing.Point(14, 70);
            this.txtil.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtil.Name = "txtil";
            this.txtil.Size = new System.Drawing.Size(122, 20);
            this.txtil.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 42);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Il Adi:";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.listBox1);
            this.panel2.Controls.Add(this.listView1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(169, 24);
            this.panel2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(318, 492);
            this.panel2.TabIndex = 3;
            // 
            // listBox1
            // 
            this.listBox1.DataSource = this.ıllerBindingSource;
            this.listBox1.DisplayMember = "ilAdi";
            this.listBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(0, 0);
            this.listBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(314, 488);
            this.listBox1.TabIndex = 1;
            this.listBox1.ValueMember = "ilID";
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // ıllerBindingSource
            // 
            this.ıllerBindingSource.DataMember = "Iller";
            this.ıllerBindingSource.DataSource = this.friendyolDataSet;
            // 
            // friendyolDataSet
            // 
            this.friendyolDataSet.DataSetName = "FriendyolDataSet";
            this.friendyolDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(2, 1);
            this.listView1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(169, 310);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // illerTableAdapter
            // 
            this.illerTableAdapter.ClearBeforeFill = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 255);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "label2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 276);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "label3";
            // 
            // iller
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(487, 516);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "iller";
            this.Text = "iller";
            this.Load += new System.EventHandler(this.iller_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ıllerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.friendyolDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem backToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button Btn_Sil;
        private System.Windows.Forms.Button Btn_Guncelle;
        private System.Windows.Forms.Button Btn_Kaydet;
        private System.Windows.Forms.TextBox txtil;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ListBox listBox1;
        private FriendyolDataSet friendyolDataSet;
        private System.Windows.Forms.BindingSource ıllerBindingSource;
        private FriendyolDataSetTableAdapters.IllerTableAdapter illerTableAdapter;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}