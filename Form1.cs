using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Yazılım_yarisma
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        SqlConnection baglan = new SqlConnection("Data Source=.;Initial Catalog=yarisma;Integrated Security=True");

        int sayac = 0 , sayi;
        int syc = 0;
        int Dogrusayisi = 0;
        int[] sayilar = new int[10];
        string s1;
        Random rnd = new Random();
        private void buttonbasla_Click(object sender, EventArgs e)
        {
            buttonA.BackColor = Color.LightCyan;
            buttonB.BackColor = Color.LightCyan;
            buttonC.BackColor = Color.LightCyan;
            buttonD.BackColor = Color.LightCyan;
            buttonbasla.Enabled = false;
            buttonA.Enabled = true;
            buttonB.Enabled = true;
            buttonC.Enabled = true;
            buttonD.Enabled = true;
            buttonbasla.Text = "Sonraki";
            sayac++;
            while (syc < 10)
            {
                sayi = rnd.Next(1, 40);
                if (Array.IndexOf(sayilar, sayi) == -1)
                {
                    sayilar[syc] = sayi;
                    syc++;
                }
            }

            if (sayac == 1)
            {
                baglan.Open();
                SqlCommand komut = new SqlCommand("Select * from Sorular where SoruID=" + sayilar[0], baglan);
                SqlDataReader oku = komut.ExecuteReader();
                while (oku.Read())
                    {
                    buttonA.Text = (oku["A"].ToString());
                    buttonB.Text = (oku["B"].ToString());
                    buttonC.Text = (oku["C"].ToString());
                    buttonD.Text = (oku["D"].ToString());
                    textBoxSoru.Text = sayac.ToString() + "." + (oku["Soru"].ToString());
                    lbldogru.Text = (oku["DogruCevap"].ToString());
                }
                baglan.Close();
            }
            if (sayac == 2)
            {
                baglan.Open();
                SqlCommand komut = new SqlCommand("Select * from Sorular where SoruID=" + sayilar[1], baglan);
                SqlDataReader oku = komut.ExecuteReader();
                while (oku.Read())
                {
                    buttonA.Text = (oku["A"].ToString());
                    buttonB.Text = (oku["B"].ToString());
                    buttonC.Text = (oku["C"].ToString());
                    buttonD.Text = (oku["D"].ToString());
                    textBoxSoru.Text = sayac.ToString() + "." + (oku["Soru"].ToString());
                    lbldogru.Text = (oku["DogruCevap"].ToString());
                }
                baglan.Close();
            }
            if (sayac == 3)
            {
                baglan.Open();
                SqlCommand komut = new SqlCommand("Select * from Sorular where SoruID=" + sayilar[2], baglan);
                SqlDataReader oku = komut.ExecuteReader();
                while (oku.Read())
                {
                    buttonA.Text = (oku["A"].ToString());
                    buttonB.Text = (oku["B"].ToString());
                    buttonC.Text = (oku["C"].ToString());
                    buttonD.Text = (oku["D"].ToString());
                    textBoxSoru.Text = sayac.ToString() + "." + (oku["Soru"].ToString());
                    lbldogru.Text = (oku["DogruCevap"].ToString());
                }
                baglan.Close();
            }
            if (sayac == 4)
            {
                baglan.Open();
                SqlCommand komut = new SqlCommand("Select * from Sorular where SoruID=" + sayilar[3], baglan);
                SqlDataReader oku = komut.ExecuteReader();
                while (oku.Read())
                {
                    buttonA.Text = (oku["A"].ToString());
                    buttonB.Text = (oku["B"].ToString());
                    buttonC.Text = (oku["C"].ToString());
                    buttonD.Text = (oku["D"].ToString());
                    textBoxSoru.Text = sayac.ToString() + "." + (oku["Soru"].ToString());
                    lbldogru.Text = (oku["DogruCevap"].ToString());
                }
                baglan.Close();
            }
            if (sayac == 5)
            {
                baglan.Open();
                SqlCommand komut = new SqlCommand("Select * from Sorular where SoruID=" + sayilar[4], baglan);
                SqlDataReader oku = komut.ExecuteReader();
                while (oku.Read())
                {
                    buttonA.Text = (oku["A"].ToString());
                    buttonB.Text = (oku["B"].ToString());
                    buttonC.Text = (oku["C"].ToString());
                    buttonD.Text = (oku["D"].ToString());
                    textBoxSoru.Text = sayac.ToString() + "." + (oku["Soru"].ToString());
                    lbldogru.Text = (oku["DogruCevap"].ToString());
                }
                baglan.Close();
            }
            if (sayac == 6)
            {
                baglan.Open();
                SqlCommand komut = new SqlCommand("Select * from Sorular where SoruID=" + sayilar[5], baglan);
                SqlDataReader oku = komut.ExecuteReader();
                while (oku.Read())
                {
                    buttonA.Text = (oku["A"].ToString());
                    buttonB.Text = (oku["B"].ToString());
                    buttonC.Text = (oku["C"].ToString());
                    buttonD.Text = (oku["D"].ToString());
                    textBoxSoru.Text = sayac.ToString() + "." + (oku["Soru"].ToString());
                    lbldogru.Text = (oku["DogruCevap"].ToString());
                }
                baglan.Close();
            }
            if (sayac == 7)
            {
                baglan.Open();
                SqlCommand komut = new SqlCommand("Select * from Sorular where SoruID=" + sayilar[6], baglan);
                SqlDataReader oku = komut.ExecuteReader();
                while (oku.Read())
                {
                    buttonA.Text = (oku["A"].ToString());
                    buttonB.Text = (oku["B"].ToString());
                    buttonC.Text = (oku["C"].ToString());
                    buttonD.Text = (oku["D"].ToString());
                    textBoxSoru.Text = sayac.ToString() + "." + (oku["Soru"].ToString());
                    lbldogru.Text = (oku["DogruCevap"].ToString());
                }
                baglan.Close();
            }
            if (sayac == 8)
            {
                baglan.Open();
                SqlCommand komut = new SqlCommand("Select * from Sorular where SoruID=" + sayilar[7], baglan);
                SqlDataReader oku = komut.ExecuteReader();
                while (oku.Read())
                {
                    buttonA.Text = (oku["A"].ToString());
                    buttonB.Text = (oku["B"].ToString());
                    buttonC.Text = (oku["C"].ToString());
                    buttonD.Text = (oku["D"].ToString());
                    textBoxSoru.Text = sayac.ToString() + "." + (oku["Soru"].ToString());
                    lbldogru.Text = (oku["DogruCevap"].ToString());
                }
                baglan.Close();
            }
            if (sayac == 9)
            {
                baglan.Open();
                SqlCommand komut = new SqlCommand("Select * from Sorular where SoruID=" + sayilar[8], baglan);
                SqlDataReader oku = komut.ExecuteReader();
                while (oku.Read())
                {
                    buttonA.Text = (oku["A"].ToString());
                    buttonB.Text = (oku["B"].ToString());
                    buttonC.Text = (oku["C"].ToString());
                    buttonD.Text = (oku["D"].ToString());
                    textBoxSoru.Text = sayac.ToString() + "." + (oku["Soru"].ToString());
                    lbldogru.Text = (oku["DogruCevap"].ToString());
                }
                baglan.Close();
            }
            if (sayac == 10)
            {
                buttonbasla.Text = "Oyunu Bitir";
                buttonbasla.Enabled = false;
                
                baglan.Open();
                SqlCommand komut = new SqlCommand("Select * from Sorular where SoruID=" + sayilar[9], baglan);
                SqlDataReader oku = komut.ExecuteReader();
                while (oku.Read())
                {
                    buttonA.Text = (oku["A"].ToString());
                    buttonB.Text = (oku["B"].ToString());
                    buttonC.Text = (oku["C"].ToString());
                    buttonD.Text = (oku["D"].ToString());
                    textBoxSoru.Text = sayac.ToString() + "." + (oku["Soru"].ToString());
                    lbldogru.Text = (oku["DogruCevap"].ToString());
                }
                baglan.Close();
            }
            if (sayac == 11)
            {
                textBoxSoru.Text = Environment.NewLine + "UMUT YILMAZ" + Environment.NewLine + "170106206018" + Environment.NewLine + "Oyunu Oynadığınız İçin Teşekkürler:)";
                buttonA.Enabled = false;
                buttonB.Enabled = false;
                buttonC.Enabled = false;
                buttonD.Enabled = false;
                buttonA.Text = "DOĞRU:";
                buttonA.BackColor = Color.ForestGreen;
                buttonB.Text = Dogrusayisi.ToString();
                buttonB.BackColor = Color.ForestGreen;
                buttonC.Text = "YANLIŞ";
                buttonC.BackColor = Color.Red;
                buttonD.Text = (10-Dogrusayisi).ToString();
                buttonD.BackColor = Color.Red;
                buttonbasla.Enabled = false;
                buttonbasla.Text = "YİNE BEKLERİZ";
                if (Dogrusayisi >= 6)
                {
                    MessageBox.Show("TEBRİKLER GÜZEL SONUÇ:)"); 
                }
                if (Dogrusayisi < 6) 
                {
                    MessageBox.Show("BİR DAHAKİNE DAHA İYİSİNİ YAP;)"); 
                }
            }
        }


        private void buttonA_Click(object sender, EventArgs e)
        {
            if (buttonA.Text== lbldogru.Text)
            {
                Dogrusayisi += 1;
                buttonA.BackColor = Color.Green;
            }
            else
            {
                buttonA.BackColor = Color.Red;
                if (buttonD.Text == lbldogru.Text)
                {
                    buttonD.BackColor = Color.Green;
                }
                if (buttonB.Text == lbldogru.Text)
                {
                    buttonB.BackColor = Color.Green;
                }
                if (buttonC.Text == lbldogru.Text)
                {
                    buttonC.BackColor = Color.Green;
                }
            }
            buttonbasla.Enabled = true;
            buttonA.Enabled = false;
            buttonB.Enabled = false;
            buttonC.Enabled = false;
            buttonD.Enabled = false;
        }
        private void buttonB_Click(object sender, EventArgs e)
        {
            if (buttonB.Text == lbldogru.Text)
            {
                Dogrusayisi += 1;
                buttonB.BackColor = Color.Green;
            }
            else
            {
                buttonB.BackColor = Color.Red;
                if (buttonA.Text == lbldogru.Text)
                {
                    buttonA.BackColor = Color.Green;
                }
                if (buttonD.Text == lbldogru.Text)
                {
                    buttonD.BackColor = Color.Green;
                }
                if (buttonC.Text == lbldogru.Text)
                {
                    buttonC.BackColor = Color.Green;
                }
            }
            buttonbasla.Enabled = true;
            buttonA.Enabled = false;
            buttonB.Enabled = false;
            buttonC.Enabled = false;
            buttonD.Enabled = false;
        }

        private void buttonC_Click(object sender, EventArgs e)
        {
            if (buttonC.Text == lbldogru.Text)
            {
                Dogrusayisi += 1;
                buttonC.BackColor = Color.Green;
            }
            else
            {
                buttonC.BackColor = Color.Red;
                if (buttonA.Text == lbldogru.Text)
                {
                    buttonA.BackColor = Color.Green;
                }
                if (buttonB.Text == lbldogru.Text)
                {
                    buttonB.BackColor = Color.Green;
                }
                if (buttonD.Text == lbldogru.Text)
                {
                    buttonD.BackColor = Color.Green;
                }
            }
            buttonbasla.Enabled = true;
            buttonA.Enabled = false;
            buttonB.Enabled = false;
            buttonC.Enabled = false;
            buttonD.Enabled = false;
        }

        
        private void buttonD_Click(object sender, EventArgs e)
        {
            if (buttonD.Text == lbldogru.Text)
            {
                Dogrusayisi += 1;
                buttonD.BackColor = Color.Green;
            }
            else
            {
                buttonD.BackColor = Color.Red;
                if (buttonA.Text == lbldogru.Text)
                { 
                    buttonA.BackColor = Color.Green;
                }
                if (buttonB.Text == lbldogru.Text)
                {
                    buttonB.BackColor = Color.Green;
                }
                if (buttonC.Text == lbldogru.Text)
                {
                    buttonC.BackColor = Color.Green;
                }
            }
            buttonbasla.Enabled = true;
            buttonA.Enabled = false;
            buttonB.Enabled = false;
            buttonC.Enabled = false;
            buttonD.Enabled = false;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            lbldogru.Visible = false;
            buttonA.Enabled = false;
            buttonB.Enabled = false;
            buttonC.Enabled = false;
            buttonD.Enabled = false;
        }

    }
}
