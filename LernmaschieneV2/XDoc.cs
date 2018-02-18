using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;

namespace LernmaschieneV2
{
	class XDoc
	{
		private string filename = "";
		public string Filename
		{
			get { return filename; }
			set { filename = value; }
		}

		private string fach;
		public string Fach
		{
			get { return fach; }
			set { fach = value; }
		}

		private string kasten;

		public string Kasten
		{
			get { return kasten; }
			set { kasten = value; }
		}
		
		

		private XDocument doc;

		public XDoc()
		{
			this.doc = new XDocument(
				new XElement("Lernmaschiene",
					new XElement("Fach",
						new XAttribute("Bezeichnung", "Englisch"),
						new XElement("Kasten",
							new XAttribute("Nr", "1"),
							new XElement("Karte",
								new XElement("Vorderseite", "Klasse"),
								new XElement("Rueckseite", "Class")
							),
							new XElement("Karte",
								new XElement("Vorderseite", "Hund"),
								new XElement("Rueckseite", "Dog")
							)
						),
						new XElement("Kasten",
							new XAttribute("Nr", "2"),
							new XElement("Karte",
								new XElement("Vorderseite", "Fisch"),
								new XElement("Rueckseite", "Fish")
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
		}

		public XDoc(string path)
		{
			this.doc = XDocument.Load(path);
			this.Filename = path;
		}

		public void Save()
		{
			if (this.Filename != "")
			{
				this.doc.Save(this.Filename);
			}
		}
		public void Save(string newFilename)
		{
			if (newFilename != "")
			{
				this.Filename = newFilename;
				this.doc.Save(newFilename);
			}
		}

		public IEnumerable<XElement> getFaecher()
		{
			return this.doc.Descendants("Fach");
		}

		public IEnumerable<XElement> getFach()
		{
			return this.getFach(this.Fach);
		}

		public IEnumerable<XElement> getFach(string fach)
		{
			return this.getFaecher().Where(
				o => o.Attribute("Bezeichnung").Value == fach
			);
		}
		public IEnumerable<XElement> getKaestenInFach()
		{
			return this.getKaestenInFach(this.Fach);
		}
		

		public IEnumerable<XElement> getKaestenInFach(string fach)
		{
			return this.getFach(fach).Descendants("Kasten").OrderBy(o => (int)o.Attribute("Nr"));
		}

		public IEnumerable<XElement> getKastenInFach(string fach, string kasten)
		{
			return this.getKaestenInFach(fach).Where(
				o => o.Attribute("Nr").Value == kasten
			);
		}

		public IEnumerable<XElement> getKarten()
		{
			return this.getKarten(this.Fach, this.Kasten);
		}
		public IEnumerable<XElement> getKarten(string fach, string kasten)
		{
			return this.getKastenInFach(fach, kasten).Descendants("Karte");
		}


		public void addKasten(string fach, int Nr)
		{
			this.getFach(fach)
				.First()
				.Add(
					new XElement("Kasten",
						new XAttribute("Nr", Nr)
					)
				);
		}

		public void addKarte(string fach, string kasten, XElement karte)
		{
			this.getKastenInFach(fach, kasten).First().Add(karte);
		}
		public void addKarte(string kasten, XElement karte)
		{
			this.addKarte(this.Fach, kasten, karte);
		}

		public void removeKarte(string fach, string vs, string rs)
		{
			this.getFach(fach)
				.Descendants("Karte")
				.Where(o => o.Element("Vorderseite").Value == vs && o.Element("Rueckseite").Value == rs)
				.Remove();
		}
		public void removeKarte(string vs, string rs)
		{
			this.removeKarte(this.Fach, vs, rs);
		}
	}
}
