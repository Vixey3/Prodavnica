
namespace tvpprojekat2
{
    partial class DodavanjeProizvoda
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
            System.Windows.Forms.Label nazivLabel;
            System.Windows.Forms.Label cenaLabel;
            this.tvpbazaDataSet = new tvpprojekat2.tvpbazaDataSet();
            this.nazivTextBox = new System.Windows.Forms.TextBox();
            this.cenaTextBox = new System.Windows.Forms.TextBox();
            this.cmbKategorija = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnDodajProizvod = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpPocetni = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dtpKrajnji = new System.Windows.Forms.DateTimePicker();
            this.dtgRacuni = new System.Windows.Forms.DataGridView();
            this.btnPrikaziRacune = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.racunTableAdapter1 = new tvpprojekat2.tvpbazaDataSetTableAdapters.RacunTableAdapter();
            this.dtpMesec = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.btnStatistika = new System.Windows.Forms.Button();
            this.lbStatistika = new System.Windows.Forms.ListBox();
            this.label7 = new System.Windows.Forms.Label();
            nazivLabel = new System.Windows.Forms.Label();
            cenaLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.tvpbazaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgRacuni)).BeginInit();
            this.SuspendLayout();
            // 
            // nazivLabel
            // 
            nazivLabel.AutoSize = true;
            nazivLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            nazivLabel.Location = new System.Drawing.Point(12, 105);
            nazivLabel.Name = "nazivLabel";
            nazivLabel.Size = new System.Drawing.Size(99, 20);
            nazivLabel.TabIndex = 5;
            nazivLabel.Text = "Dodaj naziv: ";
            // 
            // cenaLabel
            // 
            cenaLabel.AutoSize = true;
            cenaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            cenaLabel.Location = new System.Drawing.Point(12, 137);
            cenaLabel.Name = "cenaLabel";
            cenaLabel.Size = new System.Drawing.Size(98, 20);
            cenaLabel.TabIndex = 7;
            cenaLabel.Text = "Dodaj cenu: ";
            // 
            // tvpbazaDataSet
            // 
            this.tvpbazaDataSet.DataSetName = "tvpbazaDataSet";
            this.tvpbazaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // nazivTextBox
            // 
            this.nazivTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nazivTextBox.Location = new System.Drawing.Point(119, 102);
            this.nazivTextBox.Name = "nazivTextBox";
            this.nazivTextBox.Size = new System.Drawing.Size(77, 26);
            this.nazivTextBox.TabIndex = 6;
            // 
            // cenaTextBox
            // 
            this.cenaTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cenaTextBox.Location = new System.Drawing.Point(118, 134);
            this.cenaTextBox.Name = "cenaTextBox";
            this.cenaTextBox.Size = new System.Drawing.Size(77, 26);
            this.cenaTextBox.TabIndex = 8;
            // 
            // cmbKategorija
            // 
            this.cmbKategorija.FormattingEnabled = true;
            this.cmbKategorija.Location = new System.Drawing.Point(148, 72);
            this.cmbKategorija.Name = "cmbKategorija";
            this.cmbKategorija.Size = new System.Drawing.Size(98, 21);
            this.cmbKategorija.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 20);
            this.label1.TabIndex = 10;
            this.label1.Text = "Izaberi kategoriju";
            // 
            // btnDodajProizvod
            // 
            this.btnDodajProizvod.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDodajProizvod.Location = new System.Drawing.Point(16, 166);
            this.btnDodajProizvod.Name = "btnDodajProizvod";
            this.btnDodajProizvod.Size = new System.Drawing.Size(242, 51);
            this.btnDodajProizvod.TabIndex = 11;
            this.btnDodajProizvod.Text = "Dodaj proizvod";
            this.btnDodajProizvod.UseVisualStyleBackColor = true;
            this.btnDodajProizvod.Click += new System.EventHandler(this.btnDodajProizvod_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(246, 31);
            this.label2.TabIndex = 12;
            this.label2.Text = "Dodaj nov proizvod";
            // 
            // dtpPocetni
            // 
            this.dtpPocetni.Location = new System.Drawing.Point(679, 88);
            this.dtpPocetni.Name = "dtpPocetni";
            this.dtpPocetni.Size = new System.Drawing.Size(200, 20);
            this.dtpPocetni.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(570, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 18);
            this.label3.TabIndex = 14;
            this.label3.Text = "Pocetni datum";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(580, 114);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 18);
            this.label4.TabIndex = 15;
            this.label4.Text = "Krajnji datum";
            // 
            // dtpKrajnji
            // 
            this.dtpKrajnji.Location = new System.Drawing.Point(679, 114);
            this.dtpKrajnji.Name = "dtpKrajnji";
            this.dtpKrajnji.Size = new System.Drawing.Size(200, 20);
            this.dtpKrajnji.TabIndex = 13;
            // 
            // dtgRacuni
            // 
            this.dtgRacuni.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgRacuni.Location = new System.Drawing.Point(573, 258);
            this.dtgRacuni.Name = "dtgRacuni";
            this.dtgRacuni.Size = new System.Drawing.Size(371, 357);
            this.dtgRacuni.TabIndex = 16;
            // 
            // btnPrikaziRacune
            // 
            this.btnPrikaziRacune.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrikaziRacune.Location = new System.Drawing.Point(573, 162);
            this.btnPrikaziRacune.Name = "btnPrikaziRacune";
            this.btnPrikaziRacune.Size = new System.Drawing.Size(371, 83);
            this.btnPrikaziRacune.TabIndex = 17;
            this.btnPrikaziRacune.Text = "Prikazi racune";
            this.btnPrikaziRacune.UseVisualStyleBackColor = true;
            this.btnPrikaziRacune.Click += new System.EventHandler(this.btnPrikaziRacune_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(587, 15);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(303, 31);
            this.label5.TabIndex = 18;
            this.label5.Text = "Izaberi opseg za racune";
            // 
            // racunTableAdapter1
            // 
            this.racunTableAdapter1.ClearBeforeFill = true;
            // 
            // dtpMesec
            // 
            this.dtpMesec.CustomFormat = "MMMM";
            this.dtpMesec.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpMesec.Location = new System.Drawing.Point(18, 262);
            this.dtpMesec.MinDate = new System.DateTime(2021, 1, 1, 0, 0, 0, 0);
            this.dtpMesec.Name = "dtpMesec";
            this.dtpMesec.ShowUpDown = true;
            this.dtpMesec.Size = new System.Drawing.Size(240, 20);
            this.dtpMesec.TabIndex = 19;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.Location = new System.Drawing.Point(56, 220);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(178, 25);
            this.label6.TabIndex = 20;
            this.label6.Text = "Izaberite mesec";
            // 
            // btnStatistika
            // 
            this.btnStatistika.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStatistika.Location = new System.Drawing.Point(16, 288);
            this.btnStatistika.Name = "btnStatistika";
            this.btnStatistika.Size = new System.Drawing.Size(242, 58);
            this.btnStatistika.TabIndex = 21;
            this.btnStatistika.Text = "Pogledaj statistiku";
            this.btnStatistika.UseVisualStyleBackColor = true;
            this.btnStatistika.Click += new System.EventHandler(this.btnStatistika_Click);
            // 
            // lbStatistika
            // 
            this.lbStatistika.FormattingEnabled = true;
            this.lbStatistika.Location = new System.Drawing.Point(286, 69);
            this.lbStatistika.Name = "lbStatistika";
            this.lbStatistika.Size = new System.Drawing.Size(267, 550);
            this.lbStatistika.TabIndex = 22;
            this.lbStatistika.SelectedIndexChanged += new System.EventHandler(this.lbStatistika_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(293, 15);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(251, 31);
            this.label7.TabIndex = 12;
            this.label7.Text = "Statistika proizvoda";
            // 
            // DodavanjeProizvoda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(957, 631);
            this.Controls.Add(this.lbStatistika);
            this.Controls.Add(this.btnStatistika);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dtpMesec);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnPrikaziRacune);
            this.Controls.Add(this.dtgRacuni);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dtpKrajnji);
            this.Controls.Add(this.dtpPocetni);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnDodajProizvod);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbKategorija);
            this.Controls.Add(nazivLabel);
            this.Controls.Add(this.nazivTextBox);
            this.Controls.Add(cenaLabel);
            this.Controls.Add(this.cenaTextBox);
            this.Name = "DodavanjeProizvoda";
            this.Text = "DodavanjeProizvoda";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.DodavanjeProizvoda_FormClosing);
            this.Load += new System.EventHandler(this.DodavanjeProizvoda_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.DodavanjeProizvoda_Paint);
            ((System.ComponentModel.ISupportInitialize)(this.tvpbazaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgRacuni)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private tvpbazaDataSet tvpbazaDataSet;
        private System.Windows.Forms.TextBox nazivTextBox;
        private System.Windows.Forms.TextBox cenaTextBox;
        private System.Windows.Forms.ComboBox cmbKategorija;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDodajProizvod;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpPocetni;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtpKrajnji;
        private System.Windows.Forms.DataGridView dtgRacuni;
        private System.Windows.Forms.Button btnPrikaziRacune;
        private System.Windows.Forms.Label label5;
        private tvpbazaDataSetTableAdapters.RacunTableAdapter racunTableAdapter1;
        private System.Windows.Forms.DateTimePicker dtpMesec;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnStatistika;
        private System.Windows.Forms.ListBox lbStatistika;
        private System.Windows.Forms.Label label7;
    }
}