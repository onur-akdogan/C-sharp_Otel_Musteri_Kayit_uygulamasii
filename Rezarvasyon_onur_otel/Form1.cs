using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rezarvasyon_onur_otel
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            listView1.Columns.Add("TC NO", 160);
            listView1.Columns.Add("Adı Soyadı", 160);
            listView1.Columns.Add("Medeni Hali", 160);
            listView1.Columns.Add("Uyruk", 160);
            string[] strListUyruk = { "Türkiye", "Fransa", "Almanya", "İtalya", "Arabistan", "italya", "İngiltere", "ABD" };
            Uyruk_ComboBox.Items.AddRange(strListUyruk);
        }
        string strTc, strad, struyruk, strmedeni;
        private void Kaydet_Click(object sender, EventArgs e)
        {
            strTc = TC_No_TextBox.Text;
            strad = Ad_Soyad_TextBox.Text;
            struyruk = Uyruk_ComboBox.Text;
            strmedeni = "";
            if (evli.Checked == true) {
                strmedeni = evli.Text;
            }
            if (Bekar.Checked == true)
            {
                strmedeni =strmedeni+", " +Bekar.Text;
            }
            string[] strEntry = { strTc, strad, struyruk, strmedeni };
            ListViewItem ListEntry = new ListViewItem(strEntry);
            
            bool kayitVar = false;
            for(int i=0;i<listView1.Items.Count;i++){
                if (listView1.Items[i].SubItems[0].Text == strTc)
                {
                    kayitVar = true;
                }

            }
            bool bosKayıt=false;
            if (strTc == "" || strad == "") bosKayıt = true; 

            if (kayitVar == false && bosKayıt == false)
            {
                listView1.Items.Add(ListEntry);
            };

            if (kayitVar == true) MessageBox.Show("Müşteri Kaydı Mevcut ");
            if (bosKayıt == true) MessageBox.Show("TC ve Ad Soyad bilgisi boş bırakılamaz ");


         
        }

        private void Secileni_Sil_Click(object sender, EventArgs e)
        {
            int secilenKayıtadeti = listView1.CheckedItems.Count;
            foreach (ListViewItem i in listView1.CheckedItems)
            {
                i.Remove();
            }
            MessageBox.Show("Silinen müşteri sayısı " + secilenKayıtadeti);
        }

        private void Musteri_Sil_Click(object sender, EventArgs e)
        {
            int secilenKayıtadeti = listView1.SelectedItems.Count;
            foreach (ListViewItem i in listView1.SelectedItems)
            {
                i.Remove();
            }
            
            MessageBox.Show(secilenKayıtadeti + " Müşteri Başarıyla Silindi ");
        }

        private void Tum_Musteri_Sil_Click(object sender, EventArgs e)
        {
            int silinenKayitAdedi = listView1.Items.Count;
            listView1.Items.Clear();
            MessageBox.Show("Başarı ile silinen müşteri Sayısı: "+silinenKayitAdedi.ToString());
        }

        private void Yeni_musteri_Click(object sender, EventArgs e)
        {
            TC_No_TextBox.Clear();
            Ad_Soyad_TextBox.Clear();
            evli.Checked = false;
            Bekar.Checked = false;
        }

        private void Ara_Click(object sender, EventArgs e)
        {
            strTc = TC_No_TextBox.Text;
            bool kayitVar = false;
            for (int i = 0; i < listView1.Items.Count; i++)
            {
                if (listView1.Items[i].SubItems[0].Text == strTc)
                {
                    kayitVar = true;
                }

            } 
            if (kayitVar == true)
            { MessageBox.Show(strTc + " Müşteri Kaydı Mevcut "); }
            else { MessageBox.Show(strTc + " T.C nolu müşteri kayıtlı değil"); }
        }
    }
}
