namespace LernmaschieneV2
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
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.dateiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.neuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.lernmaschieneToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.speichernToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.öffnenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.lernenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.statistikToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
			this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
			this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
			this.comboBoxFach = new System.Windows.Forms.ComboBox();
			this.comboBoxKasten = new System.Windows.Forms.ComboBox();
			this.labelListVorderseite = new System.Windows.Forms.Label();
			this.labelListRueckseite = new System.Windows.Forms.Label();
			this.labelAuswahlFach = new System.Windows.Forms.Label();
			this.labelAuswahlKasten = new System.Windows.Forms.Label();
			this.buttonZurueck = new System.Windows.Forms.Button();
			this.buttonSpeichern = new System.Windows.Forms.Button();
			this.buttonPruefen = new System.Windows.Forms.Button();
			this.buttonBeenden = new System.Windows.Forms.Button();
			this.buttonWeiter = new System.Windows.Forms.Button();
			this.buttonLoeschen = new System.Windows.Forms.Button();
			this.textBoxVorderseite = new System.Windows.Forms.TextBox();
			this.textBoxRueckseite = new System.Windows.Forms.TextBox();
			this.labelVorderseite = new System.Windows.Forms.Label();
			this.labelRueckseite = new System.Windows.Forms.Label();
			this.labelMessage = new System.Windows.Forms.Label();
			this.listBoxVorderseite = new System.Windows.Forms.ListBox();
			this.listBoxRueckseite = new System.Windows.Forms.ListBox();
			this.menuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dateiToolStripMenuItem,
            this.editToolStripMenuItem,
            this.lernenToolStripMenuItem,
            this.statistikToolStripMenuItem,
            this.toolStripMenuItem1});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(507, 24);
			this.menuStrip1.TabIndex = 0;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// dateiToolStripMenuItem
			// 
			this.dateiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.neuToolStripMenuItem,
            this.speichernToolStripMenuItem,
            this.öffnenToolStripMenuItem});
			this.dateiToolStripMenuItem.Name = "dateiToolStripMenuItem";
			this.dateiToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
			this.dateiToolStripMenuItem.Text = "Datei";
			// 
			// neuToolStripMenuItem
			// 
			this.neuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lernmaschieneToolStripMenuItem});
			this.neuToolStripMenuItem.Name = "neuToolStripMenuItem";
			this.neuToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
			this.neuToolStripMenuItem.Text = "Neu";
			// 
			// lernmaschieneToolStripMenuItem
			// 
			this.lernmaschieneToolStripMenuItem.Name = "lernmaschieneToolStripMenuItem";
			this.lernmaschieneToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
			this.lernmaschieneToolStripMenuItem.Text = "Lernmaschiene";
			this.lernmaschieneToolStripMenuItem.Click += new System.EventHandler(this.lernmaschieneToolStripMenuItem_Click);
			// 
			// speichernToolStripMenuItem
			// 
			this.speichernToolStripMenuItem.Name = "speichernToolStripMenuItem";
			this.speichernToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
			this.speichernToolStripMenuItem.Text = "Speichern";
			this.speichernToolStripMenuItem.Click += new System.EventHandler(this.speichernToolStripMenuItem_Click);
			// 
			// öffnenToolStripMenuItem
			// 
			this.öffnenToolStripMenuItem.Name = "öffnenToolStripMenuItem";
			this.öffnenToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
			this.öffnenToolStripMenuItem.Text = "Öffnen";
			this.öffnenToolStripMenuItem.Click += new System.EventHandler(this.öffnenToolStripMenuItem_Click);
			// 
			// editToolStripMenuItem
			// 
			this.editToolStripMenuItem.Name = "editToolStripMenuItem";
			this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
			this.editToolStripMenuItem.Text = "Edit";
			this.editToolStripMenuItem.Click += new System.EventHandler(this.editToolStripMenuItem_Click);
			// 
			// lernenToolStripMenuItem
			// 
			this.lernenToolStripMenuItem.Name = "lernenToolStripMenuItem";
			this.lernenToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
			this.lernenToolStripMenuItem.Text = "Lernen";
			this.lernenToolStripMenuItem.Click += new System.EventHandler(this.lernenToolStripMenuItem_Click);
			// 
			// statistikToolStripMenuItem
			// 
			this.statistikToolStripMenuItem.Name = "statistikToolStripMenuItem";
			this.statistikToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
			this.statistikToolStripMenuItem.Text = "Statistik";
			// 
			// toolStripMenuItem1
			// 
			this.toolStripMenuItem1.Name = "toolStripMenuItem1";
			this.toolStripMenuItem1.Size = new System.Drawing.Size(24, 20);
			this.toolStripMenuItem1.Text = "?";
			// 
			// openFileDialog1
			// 
			this.openFileDialog1.FileName = "openFileDialog1";
			// 
			// comboBoxFach
			// 
			this.comboBoxFach.FormattingEnabled = true;
			this.comboBoxFach.Location = new System.Drawing.Point(12, 56);
			this.comboBoxFach.Name = "comboBoxFach";
			this.comboBoxFach.Size = new System.Drawing.Size(121, 21);
			this.comboBoxFach.TabIndex = 1;
			this.comboBoxFach.SelectedIndexChanged += new System.EventHandler(this.comboBoxFach_SelectedIndexChanged);
			// 
			// comboBoxKasten
			// 
			this.comboBoxKasten.FormattingEnabled = true;
			this.comboBoxKasten.Location = new System.Drawing.Point(12, 112);
			this.comboBoxKasten.Name = "comboBoxKasten";
			this.comboBoxKasten.Size = new System.Drawing.Size(121, 21);
			this.comboBoxKasten.TabIndex = 2;
			this.comboBoxKasten.SelectedIndexChanged += new System.EventHandler(this.comboBoxKasten_SelectedIndexChanged);
			// 
			// labelListVorderseite
			// 
			this.labelListVorderseite.AutoSize = true;
			this.labelListVorderseite.Location = new System.Drawing.Point(177, 37);
			this.labelListVorderseite.Name = "labelListVorderseite";
			this.labelListVorderseite.Size = new System.Drawing.Size(117, 13);
			this.labelListVorderseite.TabIndex = 5;
			this.labelListVorderseite.Text = "Karteikarte Vorderseite:";
			// 
			// labelListRueckseite
			// 
			this.labelListRueckseite.AutoSize = true;
			this.labelListRueckseite.Location = new System.Drawing.Point(336, 36);
			this.labelListRueckseite.Name = "labelListRueckseite";
			this.labelListRueckseite.Size = new System.Drawing.Size(112, 13);
			this.labelListRueckseite.TabIndex = 6;
			this.labelListRueckseite.Text = "Karteikarte Rückseite:";
			// 
			// labelAuswahlFach
			// 
			this.labelAuswahlFach.AutoSize = true;
			this.labelAuswahlFach.Location = new System.Drawing.Point(9, 36);
			this.labelAuswahlFach.Name = "labelAuswahlFach";
			this.labelAuswahlFach.Size = new System.Drawing.Size(77, 13);
			this.labelAuswahlFach.TabIndex = 7;
			this.labelAuswahlFach.Text = "Auswahl Fach:";
			// 
			// labelAuswahlKasten
			// 
			this.labelAuswahlKasten.AutoSize = true;
			this.labelAuswahlKasten.Location = new System.Drawing.Point(12, 96);
			this.labelAuswahlKasten.Name = "labelAuswahlKasten";
			this.labelAuswahlKasten.Size = new System.Drawing.Size(86, 13);
			this.labelAuswahlKasten.TabIndex = 8;
			this.labelAuswahlKasten.Text = "Auswahl Kasten:";
			// 
			// buttonZurueck
			// 
			this.buttonZurueck.Location = new System.Drawing.Point(16, 255);
			this.buttonZurueck.Name = "buttonZurueck";
			this.buttonZurueck.Size = new System.Drawing.Size(75, 23);
			this.buttonZurueck.TabIndex = 9;
			this.buttonZurueck.Text = "Zurück";
			this.buttonZurueck.UseVisualStyleBackColor = true;
			// 
			// buttonSpeichern
			// 
			this.buttonSpeichern.Location = new System.Drawing.Point(97, 255);
			this.buttonSpeichern.Name = "buttonSpeichern";
			this.buttonSpeichern.Size = new System.Drawing.Size(75, 23);
			this.buttonSpeichern.TabIndex = 10;
			this.buttonSpeichern.Text = "Speichern";
			this.buttonSpeichern.UseVisualStyleBackColor = true;
			this.buttonSpeichern.Click += new System.EventHandler(this.buttonSpeichern_Click);
			// 
			// buttonPruefen
			// 
			this.buttonPruefen.Location = new System.Drawing.Point(259, 255);
			this.buttonPruefen.Name = "buttonPruefen";
			this.buttonPruefen.Size = new System.Drawing.Size(75, 23);
			this.buttonPruefen.TabIndex = 11;
			this.buttonPruefen.Text = "Prüfen";
			this.buttonPruefen.UseVisualStyleBackColor = true;
			this.buttonPruefen.Click += new System.EventHandler(this.buttonPruefen_Click);
			// 
			// buttonBeenden
			// 
			this.buttonBeenden.Location = new System.Drawing.Point(340, 255);
			this.buttonBeenden.Name = "buttonBeenden";
			this.buttonBeenden.Size = new System.Drawing.Size(75, 23);
			this.buttonBeenden.TabIndex = 12;
			this.buttonBeenden.Text = "Beenden";
			this.buttonBeenden.UseVisualStyleBackColor = true;
			this.buttonBeenden.Click += new System.EventHandler(this.buttonBeenden_Click);
			// 
			// buttonWeiter
			// 
			this.buttonWeiter.Location = new System.Drawing.Point(421, 255);
			this.buttonWeiter.Name = "buttonWeiter";
			this.buttonWeiter.Size = new System.Drawing.Size(75, 23);
			this.buttonWeiter.TabIndex = 13;
			this.buttonWeiter.Text = "Weiter";
			this.buttonWeiter.UseVisualStyleBackColor = true;
			// 
			// buttonLoeschen
			// 
			this.buttonLoeschen.Location = new System.Drawing.Point(178, 255);
			this.buttonLoeschen.Name = "buttonLoeschen";
			this.buttonLoeschen.Size = new System.Drawing.Size(75, 23);
			this.buttonLoeschen.TabIndex = 14;
			this.buttonLoeschen.Text = "Löschen";
			this.buttonLoeschen.UseVisualStyleBackColor = true;
			this.buttonLoeschen.Click += new System.EventHandler(this.buttonLoeschen_Click);
			// 
			// textBoxVorderseite
			// 
			this.textBoxVorderseite.Location = new System.Drawing.Point(34, 185);
			this.textBoxVorderseite.Multiline = true;
			this.textBoxVorderseite.Name = "textBoxVorderseite";
			this.textBoxVorderseite.Size = new System.Drawing.Size(174, 54);
			this.textBoxVorderseite.TabIndex = 15;
			// 
			// textBoxRueckseite
			// 
			this.textBoxRueckseite.Location = new System.Drawing.Point(275, 185);
			this.textBoxRueckseite.Multiline = true;
			this.textBoxRueckseite.Name = "textBoxRueckseite";
			this.textBoxRueckseite.Size = new System.Drawing.Size(174, 54);
			this.textBoxRueckseite.TabIndex = 16;
			// 
			// labelVorderseite
			// 
			this.labelVorderseite.AutoSize = true;
			this.labelVorderseite.Location = new System.Drawing.Point(34, 166);
			this.labelVorderseite.Name = "labelVorderseite";
			this.labelVorderseite.Size = new System.Drawing.Size(63, 13);
			this.labelVorderseite.TabIndex = 17;
			this.labelVorderseite.Text = "Vorderseite:";
			// 
			// labelRueckseite
			// 
			this.labelRueckseite.AutoSize = true;
			this.labelRueckseite.Location = new System.Drawing.Point(272, 166);
			this.labelRueckseite.Name = "labelRueckseite";
			this.labelRueckseite.Size = new System.Drawing.Size(58, 13);
			this.labelRueckseite.TabIndex = 18;
			this.labelRueckseite.Text = "Rückseite:";
			// 
			// labelMessage
			// 
			this.labelMessage.AutoSize = true;
			this.labelMessage.Location = new System.Drawing.Point(12, 139);
			this.labelMessage.Name = "labelMessage";
			this.labelMessage.Size = new System.Drawing.Size(0, 13);
			this.labelMessage.TabIndex = 19;
			// 
			// listBoxVorderseite
			// 
			this.listBoxVorderseite.FormattingEnabled = true;
			this.listBoxVorderseite.Location = new System.Drawing.Point(180, 56);
			this.listBoxVorderseite.Name = "listBoxVorderseite";
			this.listBoxVorderseite.Size = new System.Drawing.Size(120, 95);
			this.listBoxVorderseite.TabIndex = 20;
			this.listBoxVorderseite.SelectedIndexChanged += new System.EventHandler(this.listBoxVorderseite_SelectedIndexChanged);
			// 
			// listBoxRueckseite
			// 
			this.listBoxRueckseite.FormattingEnabled = true;
			this.listBoxRueckseite.Location = new System.Drawing.Point(339, 57);
			this.listBoxRueckseite.Name = "listBoxRueckseite";
			this.listBoxRueckseite.Size = new System.Drawing.Size(120, 95);
			this.listBoxRueckseite.TabIndex = 21;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(507, 291);
			this.Controls.Add(this.listBoxRueckseite);
			this.Controls.Add(this.listBoxVorderseite);
			this.Controls.Add(this.labelMessage);
			this.Controls.Add(this.labelRueckseite);
			this.Controls.Add(this.labelVorderseite);
			this.Controls.Add(this.textBoxRueckseite);
			this.Controls.Add(this.textBoxVorderseite);
			this.Controls.Add(this.buttonLoeschen);
			this.Controls.Add(this.buttonWeiter);
			this.Controls.Add(this.buttonBeenden);
			this.Controls.Add(this.buttonPruefen);
			this.Controls.Add(this.buttonSpeichern);
			this.Controls.Add(this.buttonZurueck);
			this.Controls.Add(this.labelAuswahlKasten);
			this.Controls.Add(this.labelAuswahlFach);
			this.Controls.Add(this.labelListRueckseite);
			this.Controls.Add(this.labelListVorderseite);
			this.Controls.Add(this.comboBoxKasten);
			this.Controls.Add(this.comboBoxFach);
			this.Controls.Add(this.menuStrip1);
			this.MainMenuStrip = this.menuStrip1;
			this.Name = "Form1";
			this.Text = "Lernmaschine V2";
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem dateiToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem neuToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem speichernToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem öffnenToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem lernenToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem statistikToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
		private System.Windows.Forms.OpenFileDialog openFileDialog1;
		private System.Windows.Forms.SaveFileDialog saveFileDialog1;
		private System.Windows.Forms.ToolStripMenuItem lernmaschieneToolStripMenuItem;
		private System.Windows.Forms.ComboBox comboBoxFach;
		private System.Windows.Forms.ComboBox comboBoxKasten;
        private System.Windows.Forms.Label labelListVorderseite;
        private System.Windows.Forms.Label labelListRueckseite;
        private System.Windows.Forms.Label labelAuswahlFach;
        private System.Windows.Forms.Label labelAuswahlKasten;
        private System.Windows.Forms.Button buttonZurueck;
        private System.Windows.Forms.Button buttonSpeichern;
        private System.Windows.Forms.Button buttonPruefen;
        private System.Windows.Forms.Button buttonBeenden;
        private System.Windows.Forms.Button buttonWeiter;
        private System.Windows.Forms.Button buttonLoeschen;
        private System.Windows.Forms.TextBox textBoxVorderseite;
        private System.Windows.Forms.TextBox textBoxRueckseite;
        private System.Windows.Forms.Label labelVorderseite;
        private System.Windows.Forms.Label labelRueckseite;
		private System.Windows.Forms.Label labelMessage;
		private System.Windows.Forms.ListBox listBoxVorderseite;
		private System.Windows.Forms.ListBox listBoxRueckseite;
	}
}

