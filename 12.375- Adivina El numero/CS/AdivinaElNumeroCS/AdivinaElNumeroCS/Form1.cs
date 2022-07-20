using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdivinaElNumeroCS
{
	public partial class frmAdivinaElNumeroCS : Form
	{
		public frmAdivinaElNumeroCS()
		{
			InitializeComponent();
		}

		private void frmAdivinaElNumeroCS_Load(object sender, EventArgs e)
		{

		}


		private string number;
		private bool proceso = false;

		public void Preguntar()
		{
			proceso = true;
			VBMath.Randomize();
			number = Conversions.ToString(Convert.ToInt32(VBMath.Rnd() * 10));
			while (true)
			{
				if ((Interaction.InputBox("Que numero estoy pensando?") ?? "") == (number ?? ""))
				{
					MessageBox.Show("Correcto, adivina otro numero");
					proceso = false;
					break;
				}
				else
				{
					MessageBox.Show("No, intenta de nuevo");
				}
			}
		}

		private void tmrPrincipal_Tick(object sender, EventArgs e)
		{
			if (proceso == false)
			{
				Preguntar();
			}
		}
	}
}
