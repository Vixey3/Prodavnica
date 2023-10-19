using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tvpprojekat2
{
    public partial class DodavanjeProizvoda : Form
    {
        tvpbazaDataSet ds = new tvpbazaDataSet();
        tvpbazaDataSetTableAdapters.ProizvodTableAdapter proizvodi = new tvpbazaDataSetTableAdapters.ProizvodTableAdapter();
        tvpbazaDataSetTableAdapters.RacunTableAdapter racuni = new tvpbazaDataSetTableAdapters.RacunTableAdapter();
        tvpbazaDataSetTableAdapters.StatistikaTableAdapter statistika = new tvpbazaDataSetTableAdapters.StatistikaTableAdapter();
        tvpbazaDataSet.StatistikaDataTable tabela = new tvpbazaDataSet.StatistikaDataTable();

        private Brush vratiCetkicu()
        {
            PropertyInfo[] nizCetkicaInfo = typeof(Brushes).GetProperties();
            Brush[] nizCetkica = new Brush[nizCetkicaInfo.Length];
            for (int i = 0; i < nizCetkicaInfo.Length; i++)
            {
                nizCetkica[i] = (Brush)nizCetkicaInfo[i].GetValue(null, null);
            }
            Random rnd = new Random(Guid.NewGuid().GetHashCode());
            return nizCetkica[rnd.Next(1, nizCetkica.Length)];
        }

        public DodavanjeProizvoda()
        {
            InitializeComponent();
            
        }
        public DodavanjeProizvoda(tvpbazaDataSet ds):this()
        {
            proizvodi.Fill(ds.Proizvod);
            racuni.Fill(ds.Racun);
            statistika.Fill(ds.Statistika);
            this.ds = ds;
        }

        private void proizvodBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
        }

        private void DodavanjeProizvoda_Load(object sender, EventArgs e)
        {
            cmbKategorija.DisplayMember = "naziv";
            cmbKategorija.DataSource = ds.Kategorija;

            //dtpPocetni.MaxDate = DateTime.Now;
            //dtpKrajnji.MaxDate = DateTime.Now;
        }

        private void btnDodajProizvod_Click(object sender, EventArgs e)
        {
            int p;
            if(nazivTextBox.Text.Trim().Length==0 || cenaTextBox.Text.Trim().Length == 0)
            {
                
                MessageBox.Show("Niste uneli podatke za cenu ili naziv proizvoda");
                return;
            }
            else if(!int.TryParse(cenaTextBox.Text,out p))
            {
                MessageBox.Show("Niste uneli broj za cenu!");
                return;
            }
            else if(nazivTextBox.Text.Trim().Length != 0)
            {
                char[] tekst = nazivTextBox.Text.ToCharArray();
                foreach (char c in tekst)
                {
                    if (char.IsDigit(c))
                    {
                        MessageBox.Show("Naziv mora sadrzati samo slova!");
                        return;
                    }
                        
                }
            }
            tvpbazaDataSet.ProizvodRow red = ds.Proizvod.NewProizvodRow();
            red.IDK = cmbKategorija.SelectedIndex + 1;
            red.naziv = nazivTextBox.Text;
            red.cena = int.Parse(cenaTextBox.Text);
            ds.Proizvod.AddProizvodRow(red);
            nazivTextBox.Clear();
            cenaTextBox.Clear();
            MessageBox.Show("Uspesno ste dodali proizvod u bazu");
        }

        private void DodavanjeProizvoda_FormClosing(object sender, FormClosingEventArgs e)
        {
            proizvodi.Update(ds.Proizvod);
        }

        private void btnPrikaziRacune_Click(object sender, EventArgs e)
        {
            if(dtpKrajnji.Value<dtpPocetni.Value)
            {
                MessageBox.Show("Opseg nema smisla");
                return;
            }

            var linq = from p in ds.Racun
                        where p.datum >= dtpPocetni.Value && p.datum <= dtpKrajnji.Value
                        select p;
            if (linq.Any())
                dtgRacuni.DataSource = linq.CopyToDataTable();
            else
                MessageBox.Show("Ne postoje racuni za izabrani ospeg");
        }

        private void DodavanjeProizvoda_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawEllipse(Pens.Black, new Rectangle(30, 375, 225, 225));
        }

        List<Stavka> stavke = new List<Stavka>();
        int ukupno = 0;

        private void btnStatistika_Click(object sender, EventArgs e)
        {
            ukupno = 0; // PRICAM NA TELEFON
            DateTime datum = dtpMesec.Value;
            stavke = new List<Stavka>();
            //List<Stavka> stavke = new List<Stavka>();
            //lbStatistika.Items.Clear();

            var linq = from s in ds.Statistika
                       where s.datum.Month == datum.Month
                       select s;
            

            if (linq.Count() == 0)
            {
                lbStatistika.DataSource = null;
                this.Refresh();
                MessageBox.Show("Ne postoje proizvodi za taj mesec");
                return;
            }

            foreach (var row in linq)
            {
                int kolicina = 0;
                ukupno += row.kolicina;
                var naziv = from p in ds.Proizvod
                            where p.IDP == row.IDP
                            select p.naziv;
                foreach (var red in ds.Statistika)
                {
                    if (red.IDP == row.IDP && red.datum.Month==datum.Month)
                        kolicina += red.kolicina;
                }
                bool postoji = false;

                var id = from s in ds.Statistika
                         where s.IDP == row.IDP
                         select s.IDP;

                foreach (Stavka stavka in stavke)
                {
                    if (stavka.Id == id.First())
                    {
                        postoji = true;
                    }
                }
                if (postoji == false)
                    stavke.Add(new Stavka(naziv.First(),id.First(), kolicina, 0));
            }

            foreach (Stavka s in stavke)
            {
                s.Procenat = (double)s.Kolicina / ukupno*100;
            }

            lbStatistika.DataSource = stavke;
            
            this.Paint += crtaj;
            this.Refresh();
        }

        private void crtaj(object sender, PaintEventArgs e)
        {
            float p = 0;
            for (int i = 0; i < stavke.Count; i++)
            {
                e.Graphics.FillPie(vratiCetkicu(), new Rectangle(30, 375, 225, 225), p, (float)(stavke[i].Kolicina * 360) / ukupno);
                p += (float)(stavke[i].Kolicina * 360) / ukupno;
            }
            
        }

        private void lbStatistika_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}