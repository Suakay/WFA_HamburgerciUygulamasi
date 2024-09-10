namespace WFA_HamburgerciUygulamasi
{
	partial class Form1
	{
		/// <summary>
		///  Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///  Clean up any resources being used.
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
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			lstSiparisler = new ListBox();
			pictureBox1 = new PictureBox();
			groupBox1 = new GroupBox();
			groupBox2 = new GroupBox();
			cmbMenuler = new ComboBox();
			btnSepeteAt = new Button();
			label1 = new Label();
			nudAdet = new NumericUpDown();
			lblTutar = new Label();
			btnHesapla = new Button();
			btnSiparisiTamamla = new Button();
			radioButton1 = new RadioButton();
			checkBox1 = new CheckBox();
			label2 = new Label();
			((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
			groupBox1.SuspendLayout();
			groupBox2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)nudAdet).BeginInit();
			SuspendLayout();
			// 
			// lstSiparisler
			// 
			lstSiparisler.FormattingEnabled = true;
			lstSiparisler.Location = new Point(541, 12);
			lstSiparisler.Name = "lstSiparisler";
			lstSiparisler.Size = new Size(904, 644);
			lstSiparisler.TabIndex = 0;
			// 
			// pictureBox1
			// 
			pictureBox1.Image = Properties.Resources.Screenshot_1;
			pictureBox1.Location = new Point(38, 13);
			pictureBox1.Name = "pictureBox1";
			pictureBox1.Size = new Size(463, 289);
			pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
			pictureBox1.TabIndex = 1;
			pictureBox1.TabStop = false;
			// 
			// groupBox1
			// 
			groupBox1.Controls.Add(radioButton1);
			groupBox1.Font = new Font("Segoe UI", 11F);
			groupBox1.Location = new Point(38, 376);
			groupBox1.Name = "groupBox1";
			groupBox1.Size = new Size(463, 72);
			groupBox1.TabIndex = 2;
			groupBox1.TabStop = false;
			groupBox1.Text = "Boy";
			// 
			// groupBox2
			// 
			groupBox2.Controls.Add(checkBox1);
			groupBox2.Font = new Font("Segoe UI", 11F);
			groupBox2.Location = new Point(38, 450);
			groupBox2.Name = "groupBox2";
			groupBox2.Size = new Size(463, 214);
			groupBox2.TabIndex = 3;
			groupBox2.TabStop = false;
			groupBox2.Text = "Ekstra Malzeme";
			// 
			// cmbMenuler
			// 
			cmbMenuler.DropDownStyle = ComboBoxStyle.DropDownList;
			cmbMenuler.Font = new Font("Segoe UI", 15F);
			cmbMenuler.FormattingEnabled = true;
			cmbMenuler.Location = new Point(38, 321);
			cmbMenuler.Name = "cmbMenuler";
			cmbMenuler.Size = new Size(463, 43);
			cmbMenuler.TabIndex = 4;
			// 
			// btnSepeteAt
			// 
			btnSepeteAt.Font = new Font("Segoe UI", 11F);
			btnSepeteAt.Location = new Point(552, 666);
			btnSepeteAt.Name = "btnSepeteAt";
			btnSepeteAt.Size = new Size(192, 51);
			btnSepeteAt.TabIndex = 5;
			btnSepeteAt.Text = "Sepete At";
			btnSepeteAt.UseVisualStyleBackColor = true;
			btnSepeteAt.Click += btnSepeteAt_Click;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Font = new Font("Segoe UI", 12F);
			label1.Location = new Point(48, 678);
			label1.Name = "label1";
			label1.Size = new Size(63, 28);
			label1.TabIndex = 6;
			label1.Text = "Adet :";
			// 
			// nudAdet
			// 
			nudAdet.Font = new Font("Segoe UI", 15F);
			nudAdet.Location = new Point(126, 671);
			nudAdet.Name = "nudAdet";
			nudAdet.Size = new Size(85, 41);
			nudAdet.TabIndex = 7;
			// 
			// lblTutar
			// 
			lblTutar.AutoSize = true;
			lblTutar.Font = new Font("Segoe UI", 12F);
			lblTutar.Location = new Point(48, 745);
			lblTutar.Name = "lblTutar";
			lblTutar.Size = new Size(130, 28);
			lblTutar.TabIndex = 8;
			lblTutar.Text = "Tutar : ______₺";
			// 
			// btnHesapla
			// 
			btnHesapla.Font = new Font("Segoe UI", 12F);
			btnHesapla.Location = new Point(335, 666);
			btnHesapla.Name = "btnHesapla";
			btnHesapla.Size = new Size(166, 51);
			btnHesapla.TabIndex = 9;
			btnHesapla.Text = "Hesapla";
			btnHesapla.UseVisualStyleBackColor = true;
			btnHesapla.Click += btnHesapla_Click;
			// 
			// btnSiparisiTamamla
			// 
			btnSiparisiTamamla.Font = new Font("Segoe UI", 12F);
			btnSiparisiTamamla.Location = new Point(1068, 662);
			btnSiparisiTamamla.Name = "btnSiparisiTamamla";
			btnSiparisiTamamla.Size = new Size(377, 55);
			btnSiparisiTamamla.TabIndex = 10;
			btnSiparisiTamamla.Text = "Siparişi Tamamla";
			btnSiparisiTamamla.UseVisualStyleBackColor = true;
			btnSiparisiTamamla.Click += btnSiparisiTamamla_Click;
			// 
			// radioButton1
			// 
			radioButton1.AutoSize = true;
			radioButton1.Location = new Point(30, 31);
			radioButton1.Name = "radioButton1";
			radioButton1.Size = new Size(70, 29);
			radioButton1.TabIndex = 0;
			radioButton1.TabStop = true;
			radioButton1.Text = "Orta";
			radioButton1.UseVisualStyleBackColor = true;
			// 
			// checkBox1
			// 
			checkBox1.AutoSize = true;
			checkBox1.Location = new Point(30, 49);
			checkBox1.Name = "checkBox1";
			checkBox1.Size = new Size(81, 29);
			checkBox1.TabIndex = 0;
			checkBox1.Text = "Turşu";
			checkBox1.UseVisualStyleBackColor = true;
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Font = new Font("Segoe UI", 11F);
			label2.Location = new Point(1073, 754);
			label2.Name = "label2";
			label2.Size = new Size(344, 25);
			label2.TabIndex = 11;
			label2.Text = "Orta : ücrete dahil, Büyük: +5, King: +15";
			// 
			// Form1
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(1481, 810);
			Controls.Add(label2);
			Controls.Add(btnSiparisiTamamla);
			Controls.Add(btnHesapla);
			Controls.Add(lblTutar);
			Controls.Add(nudAdet);
			Controls.Add(label1);
			Controls.Add(btnSepeteAt);
			Controls.Add(cmbMenuler);
			Controls.Add(groupBox2);
			Controls.Add(groupBox1);
			Controls.Add(pictureBox1);
			Controls.Add(lstSiparisler);
			Name = "Form1";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "Form1";
			Load += Form1_Load;
			((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
			groupBox1.ResumeLayout(false);
			groupBox1.PerformLayout();
			groupBox2.ResumeLayout(false);
			groupBox2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)nudAdet).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private ListBox lstSiparisler;
		private PictureBox pictureBox1;
		private GroupBox groupBox1;
		private GroupBox groupBox2;
		private ComboBox cmbMenuler;
		private Button btnSepeteAt;
		private Label label1;
		private NumericUpDown nudAdet;
		private Label lblTutar;
		private Button btnHesapla;
		private Button btnSiparisiTamamla;
		private RadioButton radioButton1;
		private CheckBox checkBox1;
		private Label label2;
	}
}
