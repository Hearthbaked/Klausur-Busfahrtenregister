namespace Klausur
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBoxFahrtnummer = new System.Windows.Forms.TextBox();
            this.textBoxStadt = new System.Windows.Forms.TextBox();
            this.textBoxBundesland = new System.Windows.Forms.TextBox();
            this.labelFahrtNr = new System.Windows.Forms.Label();
            this.labelStadt = new System.Windows.Forms.Label();
            this.labelBundesland = new System.Windows.Forms.Label();
            this.buttonHinzufügen = new System.Windows.Forms.Button();
            this.textBoxEntfernung = new System.Windows.Forms.TextBox();
            this.labelEntfernung = new System.Windows.Forms.Label();
            this.listBoxFahrten = new System.Windows.Forms.ListBox();
            this.labelStrecken = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.listBoxGesamteStrecke = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxAnzahl = new System.Windows.Forms.TextBox();
            this.buttonErrechne = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.labelGesamtStrecke = new System.Windows.Forms.Label();
            this.buttonNeu = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxFahrtnummer
            // 
            this.textBoxFahrtnummer.Location = new System.Drawing.Point(64, 65);
            this.textBoxFahrtnummer.Name = "textBoxFahrtnummer";
            this.textBoxFahrtnummer.Size = new System.Drawing.Size(151, 20);
            this.textBoxFahrtnummer.TabIndex = 0;
            // 
            // textBoxStadt
            // 
            this.textBoxStadt.Location = new System.Drawing.Point(64, 139);
            this.textBoxStadt.Name = "textBoxStadt";
            this.textBoxStadt.Size = new System.Drawing.Size(151, 20);
            this.textBoxStadt.TabIndex = 1;
            // 
            // textBoxBundesland
            // 
            this.textBoxBundesland.Location = new System.Drawing.Point(64, 196);
            this.textBoxBundesland.Name = "textBoxBundesland";
            this.textBoxBundesland.Size = new System.Drawing.Size(151, 20);
            this.textBoxBundesland.TabIndex = 2;
            // 
            // labelFahrtNr
            // 
            this.labelFahrtNr.AutoSize = true;
            this.labelFahrtNr.Location = new System.Drawing.Point(61, 33);
            this.labelFahrtNr.Name = "labelFahrtNr";
            this.labelFahrtNr.Size = new System.Drawing.Size(154, 13);
            this.labelFahrtNr.TabIndex = 3;
            this.labelFahrtNr.Text = "Einzugebende Fahrtennummer:";
            // 
            // labelStadt
            // 
            this.labelStadt.AutoSize = true;
            this.labelStadt.Location = new System.Drawing.Point(64, 106);
            this.labelStadt.Name = "labelStadt";
            this.labelStadt.Size = new System.Drawing.Size(106, 13);
            this.labelStadt.TabIndex = 4;
            this.labelStadt.Text = "Einzugebende Stadt:";
            // 
            // labelBundesland
            // 
            this.labelBundesland.AutoSize = true;
            this.labelBundesland.Location = new System.Drawing.Point(64, 171);
            this.labelBundesland.Name = "labelBundesland";
            this.labelBundesland.Size = new System.Drawing.Size(142, 13);
            this.labelBundesland.TabIndex = 5;
            this.labelBundesland.Text = "Einzugebendes Bundesland:";
            // 
            // buttonHinzufügen
            // 
            this.buttonHinzufügen.Location = new System.Drawing.Point(64, 291);
            this.buttonHinzufügen.Name = "buttonHinzufügen";
            this.buttonHinzufügen.Size = new System.Drawing.Size(118, 30);
            this.buttonHinzufügen.TabIndex = 6;
            this.buttonHinzufügen.Text = "Hinzufügen";
            this.buttonHinzufügen.UseVisualStyleBackColor = true;
            this.buttonHinzufügen.Click += new System.EventHandler(this.buttonHinzufügen_Click);
            // 
            // textBoxEntfernung
            // 
            this.textBoxEntfernung.Location = new System.Drawing.Point(64, 257);
            this.textBoxEntfernung.Name = "textBoxEntfernung";
            this.textBoxEntfernung.Size = new System.Drawing.Size(151, 20);
            this.textBoxEntfernung.TabIndex = 7;
            // 
            // labelEntfernung
            // 
            this.labelEntfernung.AutoSize = true;
            this.labelEntfernung.Location = new System.Drawing.Point(64, 231);
            this.labelEntfernung.Name = "labelEntfernung";
            this.labelEntfernung.Size = new System.Drawing.Size(133, 13);
            this.labelEntfernung.TabIndex = 8;
            this.labelEntfernung.Text = "Einzugebende Entfernung:";
            // 
            // listBoxFahrten
            // 
            this.listBoxFahrten.FormattingEnabled = true;
            this.listBoxFahrten.Location = new System.Drawing.Point(280, 65);
            this.listBoxFahrten.Name = "listBoxFahrten";
            this.listBoxFahrten.Size = new System.Drawing.Size(178, 212);
            this.listBoxFahrten.TabIndex = 9;
            // 
            // labelStrecken
            // 
            this.labelStrecken.AutoSize = true;
            this.labelStrecken.Location = new System.Drawing.Point(280, 33);
            this.labelStrecken.Name = "labelStrecken";
            this.labelStrecken.Size = new System.Drawing.Size(50, 13);
            this.labelStrecken.TabIndex = 10;
            this.labelStrecken.Text = "Strecken";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(221, 260);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(22, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Km";
            // 
            // listBoxGesamteStrecke
            // 
            this.listBoxGesamteStrecke.FormattingEnabled = true;
            this.listBoxGesamteStrecke.Location = new System.Drawing.Point(664, 66);
            this.listBoxGesamteStrecke.Name = "listBoxGesamteStrecke";
            this.listBoxGesamteStrecke.Size = new System.Drawing.Size(120, 212);
            this.listBoxGesamteStrecke.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(664, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Gesamtstrecke";
            // 
            // textBoxAnzahl
            // 
            this.textBoxAnzahl.Location = new System.Drawing.Point(507, 66);
            this.textBoxAnzahl.Name = "textBoxAnzahl";
            this.textBoxAnzahl.Size = new System.Drawing.Size(124, 20);
            this.textBoxAnzahl.TabIndex = 14;
            // 
            // buttonErrechne
            // 
            this.buttonErrechne.Location = new System.Drawing.Point(507, 140);
            this.buttonErrechne.Name = "buttonErrechne";
            this.buttonErrechne.Size = new System.Drawing.Size(124, 45);
            this.buttonErrechne.TabIndex = 15;
            this.buttonErrechne.Text = "Errechne Gesamstrecke";
            this.buttonErrechne.UseVisualStyleBackColor = true;
            this.buttonErrechne.Click += new System.EventHandler(this.buttonErrechne_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(507, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "Anzahl:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(664, 314);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "Gesamte Strecke:";
            // 
            // labelGesamtStrecke
            // 
            this.labelGesamtStrecke.AutoSize = true;
            this.labelGesamtStrecke.Location = new System.Drawing.Point(762, 314);
            this.labelGesamtStrecke.Name = "labelGesamtStrecke";
            this.labelGesamtStrecke.Size = new System.Drawing.Size(42, 13);
            this.labelGesamtStrecke.TabIndex = 18;
            this.labelGesamtStrecke.Text = "0,00km";
            // 
            // buttonNeu
            // 
            this.buttonNeu.Location = new System.Drawing.Point(279, 297);
            this.buttonNeu.Name = "buttonNeu";
            this.buttonNeu.Size = new System.Drawing.Size(121, 53);
            this.buttonNeu.TabIndex = 19;
            this.buttonNeu.Text = "Neu";
            this.buttonNeu.UseVisualStyleBackColor = true;
            this.buttonNeu.Click += new System.EventHandler(this.buttonNeu_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(848, 450);
            this.Controls.Add(this.buttonNeu);
            this.Controls.Add(this.labelGesamtStrecke);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.buttonErrechne);
            this.Controls.Add(this.textBoxAnzahl);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.listBoxGesamteStrecke);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelStrecken);
            this.Controls.Add(this.listBoxFahrten);
            this.Controls.Add(this.labelEntfernung);
            this.Controls.Add(this.textBoxEntfernung);
            this.Controls.Add(this.buttonHinzufügen);
            this.Controls.Add(this.labelBundesland);
            this.Controls.Add(this.labelStadt);
            this.Controls.Add(this.labelFahrtNr);
            this.Controls.Add(this.textBoxBundesland);
            this.Controls.Add(this.textBoxStadt);
            this.Controls.Add(this.textBoxFahrtnummer);
            this.Name = "Form1";
            this.Text = "Fahrtenregister";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxFahrtnummer;
        private System.Windows.Forms.TextBox textBoxStadt;
        private System.Windows.Forms.TextBox textBoxBundesland;
        private System.Windows.Forms.Label labelFahrtNr;
        private System.Windows.Forms.Label labelStadt;
        private System.Windows.Forms.Label labelBundesland;
        private System.Windows.Forms.Button buttonHinzufügen;
        private System.Windows.Forms.TextBox textBoxEntfernung;
        private System.Windows.Forms.Label labelEntfernung;
        private System.Windows.Forms.ListBox listBoxFahrten;
        private System.Windows.Forms.Label labelStrecken;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listBoxGesamteStrecke;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxAnzahl;
        private System.Windows.Forms.Button buttonErrechne;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labelGesamtStrecke;
        private System.Windows.Forms.Button buttonNeu;
    }
}

