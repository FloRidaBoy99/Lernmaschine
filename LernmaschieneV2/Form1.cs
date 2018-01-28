using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Xml.Linq;
using System.Linq;
using System.Diagnostics;

namespace LernmaschieneV2
{
	public partial class Form1 : Form
	{

		private XDoc xdoc;
		private string layout = "";

		public Form1()
		{
			InitializeComponent();
			this.setMenuStrip(false);
			this.clearLayout();
			this.lernenToolStripMenuItem.PerformClick();
		}

		private void öffnenToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if (this.openFileDialog1.ShowDialog() == DialogResult.OK && this.openFileDialog1.FileName != "")
			{
				this.xdoc = new XDoc(this.openFileDialog1.FileName);
			}

			this.setMenuStrip(true);
			this.fillComboboxFach();
		}

		private void speichernToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if (this.saveFileDialog1.ShowDialog() == DialogResult.OK && this.saveFileDialog1.FileName != "")
			{
				this.xdoc.Save(this.saveFileDialog1.FileName);
			}

		}

		private void lernmaschieneToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.xdoc = new XDoc();
			this.setMenuStrip(true);
			this.editLayout();
			this.fillComboboxFach();
		}

		private void buttonBeenden_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void editToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.editLayout();
		}

		private void lernenToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.lernenLayout();
		}

		private void setMenuStrip(bool mode)
		{
			this.speichernToolStripMenuItem.Enabled = mode;
			this.editToolStripMenuItem.Enabled = mode;
			this.lernenToolStripMenuItem.Enabled = mode;
			this.statistikToolStripMenuItem.Enabled = mode;
		}

		private void fillComboboxFach()
		{
			IEnumerable<XElement> faecher = this.xdoc.getFaecher();
			List<string> faecherlist = new List<string>();

			foreach (XElement fach in faecher)
			{
				faecherlist.Add(fach.Attribute("Bezeichnung").Value); 
			}
			this.comboBoxFach.DataSource = faecherlist;
		}

		private void fillComboboxKasten()
		{
			IEnumerable<XElement> alleKaesten = this.xdoc.getKaestenInFach();
			List<string> kastenlist = new List<string>();
			
			foreach (XElement kasten in alleKaesten)
			{
				kastenlist.Add(kasten.Attribute("Nr").Value);
			}

			this.comboBoxKasten.DataSource = kastenlist;
		}

		private void fillListBoxes()
		{
			this.listBoxRueckseite.Items.Clear();
			this.listBoxVorderseite.Items.Clear();

			IEnumerable<XElement> karten = this.xdoc.getKarten();

			foreach (var karte in karten)
			{
				string vs = karte.Element("Vorderseite").Value;
				string rs = karte.Element("Rueckseite").Value;

				this.listBoxVorderseite.Items.Add(vs);
				this.listBoxRueckseite.Items.Add(rs);
			}
		}

		private void comboBoxFach_SelectedIndexChanged(object sender, EventArgs e)
		{
			this.xdoc.Fach = this.comboBoxFach.SelectedValue.ToString();
			this.fillComboboxKasten();
		}

		private void comboBoxKasten_SelectedIndexChanged(object sender, EventArgs e)
		{
			this.xdoc.Kasten = this.comboBoxKasten.SelectedValue.ToString();
			this.fillListBoxes();
		}

		private void buttonSpeichern_Click(object sender, EventArgs e)
		{
			if (this.textBoxRueckseite.Text == "" || this.textBoxVorderseite.Text == "")
			{
				return;
			}

			string fach = this.comboBoxFach.SelectedValue.ToString();

			XElement karte = new XElement("Karte",
				new XElement("Vorderseite", this.textBoxVorderseite.Text),
				new XElement("Rueckseite", this.textBoxRueckseite.Text)
			);

			if (this.xdoc.getKastenInFach(fach, "1").Count() != 1)
			{
				this.xdoc.addKasten(fach, 1);
				this.fillComboboxKasten();
			}

			this.xdoc.addKarte(fach, "1", karte);

			this.fillListBoxes();
			this.xdoc.Save();
		}

		private void buttonLoeschen_Click(object sender, EventArgs e)
		{
			this.removeKarte();
			this.fillListBoxes(); 
		}

		private void removeKarte()
		{
			string vs = this.listBoxVorderseite.Text;
			string rs = this.listBoxRueckseite.Text;
			
			this.xdoc.removeKarte(vs, rs);
		}

		private	void showKarte()
		{
			string vs = this.listBoxVorderseite.Text;
			this.listBoxRueckseite.SelectedIndex = this.listBoxVorderseite.SelectedIndex;
			string rs = this.listBoxRueckseite.Text;

			this.textBoxVorderseite.Text = vs;
			this.textBoxRueckseite.Text = rs;
		}

		private void listBoxVorderseite_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (this.layout == "edit")
			{
				this.showKarte();
			}
		}

		private void lernen()
		{
			this.textBoxVorderseite.Text = "";
			this.textBoxRueckseite.Text = "";
			try
			{
				XElement karte = this.xdoc.getKarten().First();

				this.textBoxVorderseite.Text = karte.Element("Vorderseite").Value;
			}
			catch (InvalidOperationException e)
			{
				Debug.WriteLine(e.Message);
				this.labelMessage.Text = "Es gab einen Fehler. Hast du bereits Karten erstellt?";
			}
		}

		private void pruefen()
		{
			try
			{
				XElement karte = this.xdoc.getKarten().First();

				string vorderseite = karte.Element("Vorderseite").Value;
				string rueckseite = karte.Element("Rueckseite").Value;


				if (vorderseite.ToLower() == this.textBoxVorderseite.Text.ToLower() && rueckseite.ToLower() == this.textBoxRueckseite.Text.ToLower())
				{
					this.labelMessage.Text = "Richtig!";
					this.xdoc.addKarte("2", karte);
					karte.Remove();
					this.xdoc.Save();
					this.lernen();
				}
				else
				{
					this.textBoxRueckseite.Text = "";
					this.labelMessage.Text = "Warum haben Sie das geschrieben? Wie war das motiviert?";
				}
			}
			catch (InvalidOperationException e)
			{
				Debug.WriteLine(e.Message);
				this.labelMessage.Text = "Es gab einen Fehler. Überprüfe ob Karten vorhanden sind.";
			}

		}

		private void buttonPruefen_Click(object sender, EventArgs e)
		{
			this.pruefen();
		}

		private void buttonWeiter_Click(object sender, EventArgs e)
		{
			this.listBoxVorderseite.SelectedIndex++;
		}

		private void buttonZurueck_Click(object sender, EventArgs e)
		{
			this.listBoxVorderseite.SelectedIndex--;
		}
	}
}