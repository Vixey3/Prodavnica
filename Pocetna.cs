using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tvpprojekat2
{
    public partial class Pocetna : Form
    {
        tvpbazaDataSet ds = new tvpbazaDataSet();
        tvpbazaDataSetTableAdapters.KategorijaTableAdapter kategorija = new tvpbazaDataSetTableAdapters.KategorijaTableAdapter();
        tvpbazaDataSetTableAdapters.ProizvodTableAdapter proizvodi = new tvpbazaDataSetTableAdapters.ProizvodTableAdapter();
        tvpbazaDataSetTableAdapters.RacunTableAdapter racuni = new tvpbazaDataSetTableAdapters.RacunTableAdapter();
        tvpbazaDataSetTableAdapters.StatistikaTableAdapter statistika = new tvpbazaDataSetTableAdapters.StatistikaTableAdapter();
        tvpbazaDataSet.ProizvodDataTable tabela = new tvpbazaDataSet.ProizvodDataTable();
        int idk;
        double racun = 0;

        //List<StatProizvoda> statistika;
        //string putanja = "dat.bin";
        public Pocetna()
        {
            InitializeComponent();
           /* if (File.Exists(putanja))
            {
                FileStream fs = File.OpenRead(putanja);
                BinaryFormatter bf = new BinaryFormatter();
                statistika = bf.Deserialize(fs) as List<StatProizvoda>;

                fs.Close();
            }
            else
                statistika = new List<StatProizvoda>();*/
        }


        private void Pocetna_Load(object sender, EventArgs e)
        {
            proizvodi.Fill(ds.Proizvod);
            racuni.Fill(ds.Racun);
            kategorija.Fill(ds.Kategorija);
            statistika.Fill(ds.Statistika);
            dtgKategorija.DataSource = ds.Kategorija;
            label2.Text = $"Ukupna cena racuna: {racun}"; 
        }

        private void dtgKategorija_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void dtgKategorija_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            idk = dtgKategorija.CurrentCell.RowIndex + 1;

            //var linq = from p in ds.Proizvod
            //           orderby p.naziv
            //           where p.IDK == idk
            //           select p;
            //if (linq.Any())
            //    dtgProizvodi.DataSource = linq.CopyToDataTable();
            //else
            //    dtgProizvodi.DataSource = null;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (idk > 0)
            {
                var linq = from p in ds.Proizvod
                           orderby p.naziv
                           where p.IDK == idk
                           select p;
                if (linq.Any())
                    dtgProizvodi.DataSource = linq.CopyToDataTable();
                else
                {
                    dtgProizvodi.DataSource = null;
                    MessageBox.Show("Nepostoji proizvod za trazenu kategoriju");
                }    
            }
            else
                MessageBox.Show("Niste odabrali kategoriju");
                  
        }

        private void btnPronadji_Click(object sender, EventArgs e)
        {
            if(txtTrazeni.Text.Trim().Length==0)
            {
                MessageBox.Show("Niste uneli nista u polje za pretragu");
                return;
            }
            else if(txtTrazeni.Text.Trim().Length != 0)
            {
                char[] tekst = txtTrazeni.Text.ToCharArray();
                foreach (char c in tekst)
                {
                    if (char.IsDigit(c))
                    {
                        MessageBox.Show("Pretraga mora sadrzati samo slova!");
                        return;
                    }

                }
            }
            int pom = 0;
            if (rbNazivProizovda.Checked)
            {
                string tekst = txtTrazeni.Text;
                var linq = from x in ds.Proizvod
                           where x.naziv.StartsWith(tekst)
                           select x;
                if (linq.Any())
                    dtgProizvodi.DataSource = linq.CopyToDataTable();
                else
                    MessageBox.Show("Nepostoji proizvod za trazeni naziv");

            }
            else if(rbKategorija.Checked)
            {

                string tekst = txtTrazeni.Text;
                var linq = from x in ds.Kategorija
                           where x.naziv.StartsWith(tekst)
                           select x;
                if (linq.Any())
                {
                   
                    dtgProizvodi.DataSource = linq.CopyToDataTable();
                    pom = Convert.ToInt32(linq.FirstOrDefault().IDK);
                    var linq2 = from p in ds.Proizvod
                                orderby p.naziv
                                where p.IDK == pom
                                select p;
                    if (linq2.Any())
                        dtgProizvodi.DataSource = linq2.CopyToDataTable();
                    else
                    {
                        dtgProizvodi.DataSource = null;
                        MessageBox.Show("Nepostoji prozivod za trazenu kategoriju");
                    }
                }
                else
                {
                    MessageBox.Show("Nepostoji trazena kategorija");
                    dtgProizvodi.DataSource = null;
                }
            }
            else
            {
                MessageBox.Show("Niste odabrali nijedan radio button!");
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnDodajNovProizvod_Click(object sender, EventArgs e)
        {
            statistika.Update(ds.Statistika);
            DodavanjeProizvoda dp = new DodavanjeProizvoda(ds);
            dp.Show();
        }

        private void btnDodajNaRacun_Click(object sender, EventArgs e)
        {
            //dtgRacun.DataSource = tabela;

            if (dtgProizvodi.DataSource == null)
            {
                MessageBox.Show("Niste ucitali proizvode");
                return;
            }

            //if (dtgProizvodi.CurrentRow.Index + 1 == dtgProizvodi.Rows.Count)
            //{
            //    MessageBox.Show("Nije selektovana dobra celija");
            //    return;
            //}

            int id = dtgProizvodi.SelectedCells[0].RowIndex;
            DataGridViewRow row = dtgProizvodi.Rows[id];
            if(row.Cells["cena"].Value==null)
            {
                MessageBox.Show("Nije selektovana dobra celija");
                return;
            }
            string naziv = Convert.ToString(row.Cells["naziv"].Value);
            double cena = Convert.ToDouble(row.Cells["cena"].Value);
            int kolicina = Convert.ToInt32(numericUpDown1.Value);
            double iznos = kolicina * cena;
            int idp = int.Parse(row.Cells["IDP"].Value.ToString());
            dtgRacun.Rows.Add(new object[] { naziv, kolicina, cena, iznos, idp });
            numericUpDown1.Value = 1;
            racun += iznos;
            label2.Text = $"Ukupna cena racuna: {racun}";
        }

        private void btnUkloniSaRacuna_Click(object sender, EventArgs e)
        {
            if (racun == 0)
            {
                MessageBox.Show("Nemate proizvode na racunu");
                return;
            }
            int id = dtgRacun.SelectedCells[0].RowIndex;
            DataGridViewRow row = dtgRacun.Rows[id];
            if (dtgRacun.Rows.Count < 2)
                MessageBox.Show("Nemate proizvode u korpi");
            else if (dtgRacun.CurrentRow.Cells["iznos"].Value != null)
            {
                double iznos = Convert.ToDouble(row.Cells["iznos"].Value);
                racun -= iznos;
                label2.Text = $"Ukupna cena racuna: {racun}";
                dtgRacun.Rows.RemoveAt(id);
            }
            else if (dtgRacun.CurrentRow.Cells["iznos"].Value == null)
                MessageBox.Show("Nemate nijedan proizvod u korpi");
                
        }

        private void btnStornirajCeoRacun_Click(object sender, EventArgs e)
        {
            if (racun == 0)
            {
                MessageBox.Show("Nemate proizvode na racunu");
                return;
            }
            dtgRacun.Rows.Clear();
            racun = 0;
            label2.Text = $"Ukupna cena racuna: {racun}";
            MessageBox.Show("Uspesno ste stornirali racun");
        }

        private void btnKupovina_Click(object sender, EventArgs e)
        {
            if (racun == 0)
            {
                MessageBox.Show("Nemate proizvode na racunu");
                return;
            }
            tvpbazaDataSet.RacunRow row = ds.Racun.NewRacunRow();
            row.ukupna = racun;
            row.datum = DateTime.Now;
            ds.Racun.AddRacunRow(row);
            MessageBox.Show("Uspesno ste dodali racun u bazu");
            racuni.Update(ds.Racun);

            for (int i = 0; i < dtgRacun.Rows.Count - 1; i++)
            {
                tvpbazaDataSet.StatistikaRow statrow = ds.Statistika.NewStatistikaRow();
                statrow.IDP = int.Parse((dtgRacun.Rows[i].Cells["id_pr"].Value).ToString());
                statrow.datum = DateTime.Now;
                statrow.kolicina = int.Parse((dtgRacun.Rows[i].Cells["kolicina"].Value).ToString());

                ds.Statistika.AddStatistikaRow(statrow);
            }

            dtgRacun.Rows.Clear();

            /*List<Proizvod> proizvodi = new List<Proizvod>();
            for (int i=0; i<dtgRacun.Rows.Count-1; i++)
            {
                proizvodi.Add(new Proizvod(int.Parse(dtgRacun.Rows[i].Cells["id"].Value.ToString()), int.Parse(dtgRacun.Rows[i].Cells["kolicina"].Value.ToString())));
            }*/

            /*bool postojiPr = false;
            for (int i=0; i<statistika.Count; i++)
            {
                if (row.datum.Month == statistika[i].Datum.Month)
                {
                    for (int j = 0; j < statistika[i].Proizvodi.Count; j++)
                    {
                        postojiPr=false;
                        for (int k = 0; k < dtgRacun.Rows.Count - 1; k++)
                        {
                            if (statistika[i].Proizvodi[j].Pid == proizvodi[k].Pid)
                            {
                                statistika[i].Proizvodi[j].Kolicina += proizvodi[k].Kolicina;
                                postojiPr = true;
                            }
                        }
                        if (postojiPr == false)
                        {

                        }
                    }
                }
                else
                {
                    statistika.Add(new StatProizvoda());
                    //statistika[statistika.Count-1].Proizvodi
                }
                    
            }*/

            racun = 0;
            label2.Text = $"Ukupna cena racuna: {racun}";
        }

        private void Pocetna_FormClosing(object sender, FormClosingEventArgs e)
        {
            proizvodi.Update(ds.Proizvod);
            racuni.Update(ds.Racun);
            kategorija.Update(ds.Kategorija);
            statistika.Update(ds.Statistika);
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dtgKategorija_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            idk = dtgKategorija.CurrentCell.RowIndex + 1;

            if (idk > 0)
            {
                var linq = from p in ds.Proizvod
                           orderby p.naziv
                           where p.IDK == idk
                           select p;
                if (linq.Any())
                    dtgProizvodi.DataSource = linq.CopyToDataTable();
                else
                {
                    dtgProizvodi.DataSource = null;
                    MessageBox.Show("Ne postoji proizvod za trazenu kategoriju");
                }
            }
            else
                MessageBox.Show("Niste odabrali kategoriju");
        }
    }
}