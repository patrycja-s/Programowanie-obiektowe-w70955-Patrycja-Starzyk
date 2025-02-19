namespace KorepetycjeApp
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        // Kontrolki
        private System.Windows.Forms.ListBox listBoxUczniowie;
        private System.Windows.Forms.TextBox textBoxImieNazwisko;
        private System.Windows.Forms.TextBox textBoxOcena;
        private System.Windows.Forms.TextBox textBoxTemat;
        private System.Windows.Forms.DateTimePicker dateTimePickerTermin;
        private System.Windows.Forms.Button buttonDodajUcznia;
        private System.Windows.Forms.Button buttonDodajOcene;
        private System.Windows.Forms.Button buttonDodajTemat;
        private System.Windows.Forms.Button buttonDodajTermin;
        private System.Windows.Forms.Button buttonGenerujRaport;
        private System.Windows.Forms.Button buttonUsunUcznia;

        // Zwalnianie zasobów
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        // Inicjalizacja komponentów
        private void InitializeComponent()
        {
            this.listBoxUczniowie = new System.Windows.Forms.ListBox();
            this.textBoxImieNazwisko = new System.Windows.Forms.TextBox();
            this.textBoxOcena = new System.Windows.Forms.TextBox();
            this.textBoxTemat = new System.Windows.Forms.TextBox();
            this.dateTimePickerTermin = new System.Windows.Forms.DateTimePicker();
            this.buttonDodajUcznia = new System.Windows.Forms.Button();
            this.buttonDodajOcene = new System.Windows.Forms.Button();
            this.buttonDodajTemat = new System.Windows.Forms.Button();
            this.buttonDodajTermin = new System.Windows.Forms.Button();
            this.buttonGenerujRaport = new System.Windows.Forms.Button();
            this.buttonUsunUcznia = new System.Windows.Forms.Button();

            this.SuspendLayout();

            // 
            // listBoxUczniowie
            // 
            this.listBoxUczniowie.FormattingEnabled = true;
            this.listBoxUczniowie.Location = new System.Drawing.Point(20, 20);
            this.listBoxUczniowie.Name = "listBoxUczniowie";
            this.listBoxUczniowie.Size = new System.Drawing.Size(300, 200);
            this.listBoxUczniowie.TabIndex = 0;

            // 
            // textBoxImieNazwisko
            // 
            this.textBoxImieNazwisko.Location = new System.Drawing.Point(20, 240);
            this.textBoxImieNazwisko.Name = "textBoxImieNazwisko";
            this.textBoxImieNazwisko.Size = new System.Drawing.Size(200, 20);
            this.textBoxImieNazwisko.TabIndex = 1;

            // 
            // textBoxOcena
            // 
            this.textBoxOcena.Location = new System.Drawing.Point(20, 270);
            this.textBoxOcena.Name = "textBoxOcena";
            this.textBoxOcena.Size = new System.Drawing.Size(100, 20);
            this.textBoxOcena.TabIndex = 2;

            // 
            // textBoxTemat
            // 
            this.textBoxTemat.Location = new System.Drawing.Point(20, 300);
            this.textBoxTemat.Name = "textBoxTemat";
            this.textBoxTemat.Size = new System.Drawing.Size(200, 20);
            this.textBoxTemat.TabIndex = 3;

            // 
            // dateTimePickerTermin
            // 
            this.dateTimePickerTermin.Location = new System.Drawing.Point(20, 330);
            this.dateTimePickerTermin.Name = "dateTimePickerTermin";
            this.dateTimePickerTermin.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerTermin.TabIndex = 4;

            // 
            // buttonDodajUcznia
            // 
            this.buttonDodajUcznia.Location = new System.Drawing.Point(230, 240);
            this.buttonDodajUcznia.Name = "buttonDodajUcznia";
            this.buttonDodajUcznia.Size = new System.Drawing.Size(100, 30);
            this.buttonDodajUcznia.TabIndex = 5;
            this.buttonDodajUcznia.Text = "Dodaj Ucznia";
            this.buttonDodajUcznia.UseVisualStyleBackColor = true;
            this.buttonDodajUcznia.Click += new System.EventHandler(this.buttonDodajUcznia_Click);

            // 
            // buttonDodajOcene
            // 
            this.buttonDodajOcene.Location = new System.Drawing.Point(130, 270);
            this.buttonDodajOcene.Name = "buttonDodajOcene";
            this.buttonDodajOcene.Size = new System.Drawing.Size(100, 30);
            this.buttonDodajOcene.TabIndex = 6;
            this.buttonDodajOcene.Text = "Dodaj Ocenę";
            this.buttonDodajOcene.UseVisualStyleBackColor = true;
            this.buttonDodajOcene.Click += new System.EventHandler(this.buttonDodajOcene_Click);

            // 
            // buttonDodajTemat
            // 
            this.buttonDodajTemat.Location = new System.Drawing.Point(230, 300);
            this.buttonDodajTemat.Name = "buttonDodajTemat";
            this.buttonDodajTemat.Size = new System.Drawing.Size(100, 30);
            this.buttonDodajTemat.TabIndex = 7;
            this.buttonDodajTemat.Text = "Dodaj Temat";
            this.buttonDodajTemat.UseVisualStyleBackColor = true;
            this.buttonDodajTemat.Click += new System.EventHandler(this.buttonDodajTemat_Click);

            // 
            // buttonDodajTermin
            // 
            this.buttonDodajTermin.Location = new System.Drawing.Point(230, 330);
            this.buttonDodajTermin.Name = "buttonDodajTermin";
            this.buttonDodajTermin.Size = new System.Drawing.Size(100, 30);
            this.buttonDodajTermin.TabIndex = 8;
            this.buttonDodajTermin.Text = "Dodaj Termin";
            this.buttonDodajTermin.UseVisualStyleBackColor = true;
            this.buttonDodajTermin.Click += new System.EventHandler(this.buttonDodajTermin_Click);

            // 
            // buttonGenerujRaport
            // 
            this.buttonGenerujRaport.Location = new System.Drawing.Point(130, 360);
            this.buttonGenerujRaport.Name = "buttonGenerujRaport";
            this.buttonGenerujRaport.Size = new System.Drawing.Size(100, 30);
            this.buttonGenerujRaport.TabIndex = 9;
            this.buttonGenerujRaport.Text = "Generuj Raport";
            this.buttonGenerujRaport.UseVisualStyleBackColor = true;
            this.buttonGenerujRaport.Click += new System.EventHandler(this.buttonGenerujRaport_Click);

            // 
            // buttonUsunUcznia
            // 
            this.buttonUsunUcznia.Location = new System.Drawing.Point(230, 360);
            this.buttonUsunUcznia.Name = "buttonUsunUcznia";
            this.buttonUsunUcznia.Size = new System.Drawing.Size(100, 30);
            this.buttonUsunUcznia.TabIndex = 10;
            this.buttonUsunUcznia.Text = "Usuń Ucznia";
            this.buttonUsunUcznia.UseVisualStyleBackColor = true;
            this.buttonUsunUcznia.Click += new System.EventHandler(this.buttonUsunUcznia_Click);

            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(350, 420);
            this.Controls.Add(this.buttonUsunUcznia);
            this.Controls.Add(this.buttonGenerujRaport);
            this.Controls.Add(this.buttonDodajTermin);
            this.Controls.Add(this.buttonDodajTemat);
            this.Controls.Add(this.buttonDodajOcene);
            this.Controls.Add(this.buttonDodajUcznia);
            this.Controls.Add(this.dateTimePickerTermin);
            this.Controls.Add(this.textBoxTemat);
            this.Controls.Add(this.textBoxOcena);
            this.Controls.Add(this.textBoxImieNazwisko);
            this.Controls.Add(this.listBoxUczniowie);
            this.Name = "Form1";
            this.Text = "System Zarządzania Korepetycjami";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
