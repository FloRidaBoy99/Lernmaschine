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

		private XDocument xdoc;
		private string filename = "";

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
				this.xdoc = XDocument.Load(this.openFileDialog1.FileName);
				this.filename = this.openFileDialog1.FileName;
			}

			this.setMenuStrip(true);
			this.fillComboboxFach();
		}

		private void speichernToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if (this.saveFileDialog1.ShowDialog() == DialogResult.OK && this.saveFileDialog1.FileName != "")
			{
				this.xdoc.Save(this.saveFileDialog1.FileName);
				this.filename = this.saveFileDialog1.FileName;
			}

		}

		private void lernmaschieneToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.xdoc = new XDocument(
				new XElement("Lernmaschiene",
					new XElement("Fach",
						new XAttribute("Bezeichnung", "Englisch"),
						new XElement("Kasten",
							new XAttribute("Nr", "1"),
							new XElement("Karte",
								new XElement("Vorderseite", "Haus"),
								new XElement("Rueckseite", "House")
							)
						),
						new XElement("Kasten",
							new XAttribute("Nr", "2"),
							new XElement("Karte",
								new XElement("Vorderseite", "Kacken"),
								new XElement("Rueckseite", "Shit")
							)
						)
					),
					new XElement("Fach",
						new XAttribute("Bezeichnung", "Deutsch"),
						new XElement("Kasten",
							new XAttribute("Nr", "3"),
							new XElement("Karte",
								new XElement("Vorderseite", "Emilia Galotti"),
								new XElement("Rueckseite", "Tolles Buch")
							)
						),
						new XElement("Kasten",
							new XAttribute("Nr", "6"),
							new XElement("Karte",
								new XElement("Vorderseite", "Haus"),
								new XElement("Rueckseite", "House")
							)
						)
					)
				)
			);
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

		private void clearLayout()
		{
			this.labelAuswahlFach.Visible = false;
			this.labelAuswahlKasten.Visible = false;
			this.labelListRueckseite.Visible = false;
			this.labelListVorderseite.Visible = false;
			this.labelMessage.Visible = false;
			this.labelRueckseite.Visible = false;
			this.labelVorderseite.Visible = false;

			this.comboBoxFach.Visible = false;
			this.comboBoxKasten.Visible = false;

			this.listBoxRueckseite.Visible = false;
			this.listBoxVorderseite.Visible = false;

			this.textBoxRueckseite.Visible = false;
			this.textBoxVorderseite.Visible = false;

			this.buttonZurueck.Visible = false;
			this.buttonSpeichern.Visible = false;
			this.buttonLoeschen.Visible = false;
			this.buttonPruefen.Visible = false;
			this.buttonBeenden.Visible = true;
			this.buttonWeiter.Visible = false;
		}

		private void editLayout()
		{
			this.labelAuswahlFach.Visible = true;
			this.labelAuswahlKasten.Visible = true;
			this.labelListRueckseite.Visible = true;
			this.labelListVorderseite.Visible = true;
			this.labelMessage.Visible = false;
			this.labelRueckseite.Visible = true;
			this.labelVorderseite.Visible = true;

			this.comboBoxFach.Visible = true;
			this.comboBoxKasten.Visible = true;

			this.listBoxRueckseite.Visible = true;
			this.listBoxVorderseite.Visible = true;

			this.textBoxRueckseite.Visible = true;
			this.textBoxVorderseite.Visible = true;

			this.buttonZurueck.Visible = false;
			this.buttonSpeichern.Visible = true;
			this.buttonLoeschen.Visible = true;
			this.buttonPruefen.Visible = false;
			this.buttonBeenden.Visible = true;
			this.buttonWeiter.Visible = false;
		}

		private void lernenLayout()
		{
			this.labelAuswahlFach.Visible = true;
			this.labelAuswahlKasten.Visible = true;
			this.labelListRueckseite.Visible = false;
			this.labelListVorderseite.Visible = false;
			this.labelMessage.Visible = false;
			this.labelRueckseite.Visible = true;
			this.labelVorderseite.Visible = true;

			this.comboBoxFach.Visible = true;
			this.comboBoxKasten.Visible = true;

			this.listBoxRueckseite.Visible = false;
			this.listBoxVorderseite.Visible = false;

			this.textBoxRueckseite.Visible = true;
			this.textBoxVorderseite.Visible = true;

			this.buttonZurueck.Visible = true;
			this.buttonSpeichern.Visible = false;
			this.buttonLoeschen.Visible = false;
			this.buttonPruefen.Visible = true;
			this.buttonBeenden.Visible = true;
			this.buttonWeiter.Visible = true;
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
			IEnumerable<XElement> faecher = this.xdoc.Element("Lernmaschiene").Elements();
			List<string> faecherlist = new List<string>();

			foreach (XElement fach in faecher)
			{
				faecherlist.Add(fach.Attribute("Bezeichnung").Value); 
			}
			this.comboBoxFach.DataSource = faecherlist;
		}

		private void fillComboboxKasten()
		{
			List<string> kastenlist = new List<string>();

			IEnumerable<XElement> alleKaesten = xdoc
				.Descendants("Fach")
				.Where(o => o.Attribute("Bezeichnung").Value == this.comboBoxFach.SelectedValue.ToString())
				.Descendants("Kasten");

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

			IEnumerable<XElement> karten = this.xdoc
				.Descendants("Fach")
				.Where(o => o.Attribute("Bezeichnung").Value == this.comboBoxFach.SelectedValue.ToString())
				.Descendants("Kasten")
				.Where(o => o.Attribute("Nr").Value == this.comboBoxKasten.SelectedValue.ToString())
				.Elements();

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
			this.fillComboboxKasten();
		}

		private void comboBoxKasten_SelectedIndexChanged(object sender, EventArgs e)
		{
			this.fillListBoxes();
		}

		private void buttonSpeichern_Click(object sender, EventArgs e)
		{
			if (this.textBoxRueckseite.Text == "" || this.textBoxVorderseite.Text == "")
			{
				return;
			}

			this.xdoc.Descendants("Fach")
				.Where(
					o => o.Attribute("Bezeichnung").Value.ToString() == this.comboBoxFach.SelectedValue.ToString()
				)
				.Descendants("Kasten")
				.Where(a => a.Attribute("Nr").Value.ToString() == "1")
				.First()
				.Add(
					new XElement("Karteikarte",
						new XElement("Vorderseite", this.textBoxVorderseite.Text),
						new XElement("Rueckseite", this.textBoxRueckseite.Text)
					)
				);
			this.fillListBoxes();
			this.saveXML();
		}

		private void saveXML()
		{
			if (this.filename != "")
			{
				this.xdoc.Save(this.filename);
			}
		}

	}
}
