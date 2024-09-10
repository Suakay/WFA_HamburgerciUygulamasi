namespace WFA_HamburgerciUygulamasi
{
	public partial class Form1 : Form
	{
		string menuAd = "";
		decimal toplamFiyat = 0;
		decimal menuFiyat = 0;

		string tumMenuAdlari = string.Empty;
		decimal toplamMenuFiyatlari;
		decimal toplamMenuAdedi = 0;
		public Form1()
		{
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			cmbMenuler.Items.Add("Menü Seçiniz...");
			cmbMenuler.Items.Add("Özel Big King® Menü");
			cmbMenuler.Items.Add("Whopper® Menü");
			cmbMenuler.Items.Add("3'lü Whopper® Fırsatı");
			cmbMenuler.Items.Add("Kral İkili");
			cmbMenuler.SelectedIndex = 0;//ilk eleman seçili gelir
		}

		private void btnHesapla_Click(object sender, EventArgs e)
		{
			int seciliIndex = cmbMenuler.SelectedIndex;
			if (seciliIndex <= 0)
			{
				MessageBox.Show("Önce bir adet menü seçimi yapınız!!!");
				return;//kendinden sonraki satırları çalıştırmadan ilgili eventı(metot) bitirir.
			}
			//menü adını bulma
			menuAd = cmbMenuler.SelectedItem.ToString();

			menuFiyat = FiyataBul(menuAd);
			toplamFiyat = menuFiyat * nudAdet.Value;
			toplamMenuAdedi += nudAdet.Value;
			lblTutar.Text = $"Tutar: {toplamFiyat}₺";
		}
		decimal FiyataBul(string menuAdi)
		{
			decimal fiyat = 0;
			switch (menuAdi)
			{
				case "Özel Big King® Menü":
					fiyat = 220;
					break;
				case "Whopper® Menü":
					fiyat = 235;
					break;
				case "3'lü Whopper® Fırsatı":
					fiyat = 345;
					break;
				case "Kral İkili":
					fiyat = 310;
					break;
				default:
					fiyat = 0;
					break;
			}

			return fiyat;
		}

		private void btnSepeteAt_Click(object sender, EventArgs e)
		{
			if (string.IsNullOrWhiteSpace(menuAd) || toplamFiyat == 0)
			{
				MessageBox.Show("Önce Menü Seçimini Yapınız Sonra Sepete At Butonuna Basınız");
				return;
			}
			tumMenuAdlari += $"{menuAd} -> {nudAdet.Value} x {menuFiyat}={toplamFiyat}₺\n";
			toplamMenuFiyatlari += toplamFiyat;
			lstSiparisler.Items.Add($"{menuAd} -> {nudAdet.Value} x {menuFiyat}={toplamFiyat}₺");
			FormTemizle();
		}

		void FormTemizle()
		{
			menuAd = string.Empty;
			toplamFiyat = 0;
			cmbMenuler.SelectedIndex = 0;
		}

		private void btnSiparisiTamamla_Click(object sender, EventArgs e)
		{
			MessageBox.Show($"{tumMenuAdlari}\nToplam Menu Adedi={toplamMenuAdedi}\nFiyat = {toplamMenuFiyatlari}₺");
			toplamMenuFiyatlari = 0;
			tumMenuAdlari = string.Empty;
			lstSiparisler.Items.Clear();
		}
	}
}
