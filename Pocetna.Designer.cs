
namespace tvpprojekat2
{
    partial class Pocetna
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
            this.dtgKategorija = new System.Windows.Forms.DataGridView();
            this.dtgProizvodi = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.txtTrazeni = new System.Windows.Forms.TextBox();
            this.btnPronadji = new System.Windows.Forms.Button();
            this.rbKategorija = new System.Windows.Forms.RadioButton();
            this.rbNazivProizovda = new System.Windows.Forms.RadioButton();
            this.btnDodajNaRacun = new System.Windows.Forms.Button();
            this.btnUkloniSaRacuna = new System.Windows.Forms.Button();
            this.btnStornirajCeoRacun = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnDodajNovProizvod = new System.Windows.Forms.Button();
            this.dtgRacun = new System.Windows.Forms.DataGridView();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.btnKupovina = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.naziv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kolicina = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cena = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iznos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_pr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dtgKategorija)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgProizvodi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgRacun)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgKategorija
            // 
            this.dtgKategorija.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgKategorija.Location = new System.Drawing.Point(12, 12);
            this.dtgKategorija.MultiSelect = false;
            this.dtgKategorija.Name = "dtgKategorija";
            this.dtgKategorija.ReadOnly = true;
            this.dtgKategorija.Size = new System.Drawing.Size(343, 220);
            this.dtgKategorija.TabIndex = 0;
            this.dtgKategorija.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgKategorija_CellClick);
            this.dtgKategorija.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgKategorija_CellContentClick);
            this.dtgKategorija.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgKategorija_CellEnter);
            // 
            // dtgProizvodi
            // 
            this.dtgProizvodi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgProizvodi.Location = new System.Drawing.Point(361, 12);
            this.dtgProizvodi.MultiSelect = false;
            this.dtgProizvodi.Name = "dtgProizvodi";
            this.dtgProizvodi.ReadOnly = true;
            this.dtgProizvodi.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgProizvodi.Size = new System.Drawing.Size(450, 220);
            this.dtgProizvodi.TabIndex = 0;
            this.dtgProizvodi.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgKategorija_CellContentClick);
            this.dtgProizvodi.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgKategorija_CellEnter);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(817, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(127, 220);
            this.button1.TabIndex = 1;
            this.button1.Text = "Izlistaj proizvode";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // txtTrazeni
            // 
            this.txtTrazeni.Location = new System.Drawing.Point(12, 238);
            this.txtTrazeni.Name = "txtTrazeni";
            this.txtTrazeni.Size = new System.Drawing.Size(343, 20);
            this.txtTrazeni.TabIndex = 2;
            // 
            // btnPronadji
            // 
            this.btnPronadji.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPronadji.Location = new System.Drawing.Point(13, 287);
            this.btnPronadji.Name = "btnPronadji";
            this.btnPronadji.Size = new System.Drawing.Size(342, 44);
            this.btnPronadji.TabIndex = 3;
            this.btnPronadji.Text = "Pronadji zeljeni proizvod";
            this.btnPronadji.UseVisualStyleBackColor = true;
            this.btnPronadji.Click += new System.EventHandler(this.btnPronadji_Click);
            // 
            // rbKategorija
            // 
            this.rbKategorija.AutoSize = true;
            this.rbKategorija.Location = new System.Drawing.Point(283, 264);
            this.rbKategorija.Name = "rbKategorija";
            this.rbKategorija.Size = new System.Drawing.Size(72, 17);
            this.rbKategorija.TabIndex = 4;
            this.rbKategorija.TabStop = true;
            this.rbKategorija.Text = "Kategorija";
            this.rbKategorija.UseVisualStyleBackColor = true;
            // 
            // rbNazivProizovda
            // 
            this.rbNazivProizovda.AutoSize = true;
            this.rbNazivProizovda.Location = new System.Drawing.Point(13, 264);
            this.rbNazivProizovda.Name = "rbNazivProizovda";
            this.rbNazivProizovda.Size = new System.Drawing.Size(121, 17);
            this.rbNazivProizovda.TabIndex = 5;
            this.rbNazivProizovda.TabStop = true;
            this.rbNazivProizovda.Text = "Po nazivu proizvoda";
            this.rbNazivProizovda.UseVisualStyleBackColor = true;
            this.rbNazivProizovda.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // btnDodajNaRacun
            // 
            this.btnDodajNaRacun.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDodajNaRacun.Location = new System.Drawing.Point(362, 238);
            this.btnDodajNaRacun.Name = "btnDodajNaRacun";
            this.btnDodajNaRacun.Size = new System.Drawing.Size(190, 93);
            this.btnDodajNaRacun.TabIndex = 6;
            this.btnDodajNaRacun.Text = "Dodaj proizvod na racun";
            this.btnDodajNaRacun.UseVisualStyleBackColor = true;
            this.btnDodajNaRacun.Click += new System.EventHandler(this.btnDodajNaRacun_Click);
            // 
            // btnUkloniSaRacuna
            // 
            this.btnUkloniSaRacuna.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUkloniSaRacuna.Location = new System.Drawing.Point(558, 238);
            this.btnUkloniSaRacuna.Name = "btnUkloniSaRacuna";
            this.btnUkloniSaRacuna.Size = new System.Drawing.Size(190, 93);
            this.btnUkloniSaRacuna.TabIndex = 6;
            this.btnUkloniSaRacuna.Text = "Ukloni proizvod sa racuna";
            this.btnUkloniSaRacuna.UseVisualStyleBackColor = true;
            this.btnUkloniSaRacuna.Click += new System.EventHandler(this.btnUkloniSaRacuna_Click);
            // 
            // btnStornirajCeoRacun
            // 
            this.btnStornirajCeoRacun.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStornirajCeoRacun.Location = new System.Drawing.Point(754, 238);
            this.btnStornirajCeoRacun.Name = "btnStornirajCeoRacun";
            this.btnStornirajCeoRacun.Size = new System.Drawing.Size(190, 93);
            this.btnStornirajCeoRacun.TabIndex = 6;
            this.btnStornirajCeoRacun.Text = "Storniraj ceo racun";
            this.btnStornirajCeoRacun.UseVisualStyleBackColor = true;
            this.btnStornirajCeoRacun.Click += new System.EventHandler(this.btnStornirajCeoRacun_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(574, 375);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 33);
            this.label1.TabIndex = 7;
            this.label1.Text = "Vas racun";
            // 
            // btnDodajNovProizvod
            // 
            this.btnDodajNovProizvod.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDodajNovProizvod.Location = new System.Drawing.Point(6, 622);
            this.btnDodajNovProizvod.Name = "btnDodajNovProizvod";
            this.btnDodajNovProizvod.Size = new System.Drawing.Size(344, 57);
            this.btnDodajNovProizvod.TabIndex = 8;
            this.btnDodajNovProizvod.Text = "Dodaj nov proizvod u bazu";
            this.btnDodajNovProizvod.UseVisualStyleBackColor = true;
            this.btnDodajNovProizvod.Click += new System.EventHandler(this.btnDodajNovProizvod_Click);
            // 
            // dtgRacun
            // 
            this.dtgRacun.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgRacun.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.naziv,
            this.kolicina,
            this.cena,
            this.iznos,
            this.id_pr});
            this.dtgRacun.Location = new System.Drawing.Point(362, 415);
            this.dtgRacun.Name = "dtgRacun";
            this.dtgRacun.ReadOnly = true;
            this.dtgRacun.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgRacun.Size = new System.Drawing.Size(580, 201);
            this.dtgRacun.TabIndex = 9;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(362, 338);
            this.numericUpDown1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.ReadOnly = true;
            this.numericUpDown1.Size = new System.Drawing.Size(190, 20);
            this.numericUpDown1.TabIndex = 10;
            this.numericUpDown1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // btnKupovina
            // 
            this.btnKupovina.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKupovina.Location = new System.Drawing.Point(751, 622);
            this.btnKupovina.Name = "btnKupovina";
            this.btnKupovina.Size = new System.Drawing.Size(191, 57);
            this.btnKupovina.TabIndex = 11;
            this.btnKupovina.Text = "Kupi proizvode";
            this.btnKupovina.UseVisualStyleBackColor = true;
            this.btnKupovina.Click += new System.EventHandler(this.btnKupovina_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(356, 631);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(272, 31);
            this.label2.TabIndex = 12;
            this.label2.Text = "Ukupna cena racuna:";
            // 
            // naziv
            // 
            this.naziv.HeaderText = "naziv";
            this.naziv.Name = "naziv";
            this.naziv.ReadOnly = true;
            // 
            // kolicina
            // 
            this.kolicina.HeaderText = "kolicina";
            this.kolicina.Name = "kolicina";
            this.kolicina.ReadOnly = true;
            // 
            // cena
            // 
            this.cena.HeaderText = "cena";
            this.cena.Name = "cena";
            this.cena.ReadOnly = true;
            // 
            // iznos
            // 
            this.iznos.HeaderText = "iznos";
            this.iznos.Name = "iznos";
            this.iznos.ReadOnly = true;
            // 
            // id_pr
            // 
            this.id_pr.HeaderText = "id_pr";
            this.id_pr.Name = "id_pr";
            this.id_pr.ReadOnly = true;
            this.id_pr.Visible = false;
            // 
            // Pocetna
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(954, 691);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnKupovina);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.dtgRacun);
            this.Controls.Add(this.btnDodajNovProizvod);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnStornirajCeoRacun);
            this.Controls.Add(this.btnUkloniSaRacuna);
            this.Controls.Add(this.btnDodajNaRacun);
            this.Controls.Add(this.rbNazivProizovda);
            this.Controls.Add(this.rbKategorija);
            this.Controls.Add(this.btnPronadji);
            this.Controls.Add(this.txtTrazeni);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dtgProizvodi);
            this.Controls.Add(this.dtgKategorija);
            this.Name = "Pocetna";
            this.Text = "Pocetna";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Pocetna_FormClosing);
            this.Load += new System.EventHandler(this.Pocetna_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgKategorija)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgProizvodi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgRacun)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgKategorija;
        private System.Windows.Forms.DataGridView dtgProizvodi;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtTrazeni;
        private System.Windows.Forms.Button btnPronadji;
        private System.Windows.Forms.RadioButton rbKategorija;
        private System.Windows.Forms.RadioButton rbNazivProizovda;
        private System.Windows.Forms.Button btnDodajNaRacun;
        private System.Windows.Forms.Button btnUkloniSaRacuna;
        private System.Windows.Forms.Button btnStornirajCeoRacun;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDodajNovProizvod;
        private System.Windows.Forms.DataGridView dtgRacun;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Button btnKupovina;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn naziv;
        private System.Windows.Forms.DataGridViewTextBoxColumn kolicina;
        private System.Windows.Forms.DataGridViewTextBoxColumn cena;
        private System.Windows.Forms.DataGridViewTextBoxColumn iznos;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_pr;
    }
}

