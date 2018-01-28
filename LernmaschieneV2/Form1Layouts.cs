using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LernmaschieneV2
{
	partial class Form1
	{

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

			this.layout = "clear";
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

			this.buttonZurueck.Visible = true;
			this.buttonSpeichern.Visible = true;
			this.buttonLoeschen.Visible = true;
			this.buttonPruefen.Visible = false;
			this.buttonBeenden.Visible = true;
			this.buttonWeiter.Visible = true;

			this.layout = "edit";
		}

		private void lernenLayout()
		{
			this.labelAuswahlFach.Visible = true;
			this.labelAuswahlKasten.Visible = false;
			this.labelListRueckseite.Visible = false;
			this.labelListVorderseite.Visible = false;
			this.labelMessage.Visible = true;
			this.labelRueckseite.Visible = true;
			this.labelVorderseite.Visible = true;

			this.comboBoxFach.Visible = true;
			this.comboBoxKasten.Visible = false;

			this.listBoxRueckseite.Visible = false;
			this.listBoxVorderseite.Visible = false;

			this.textBoxRueckseite.Visible = true;
			this.textBoxVorderseite.Visible = true;

			this.buttonZurueck.Visible = false;
			this.buttonSpeichern.Visible = false;
			this.buttonLoeschen.Visible = false;
			this.buttonPruefen.Visible = true;
			this.buttonBeenden.Visible = true;
			this.buttonWeiter.Visible = false;

			this.layout = "lernen";
			this.lernen();
		}

	}
}
