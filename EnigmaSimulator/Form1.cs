using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EnigmaMachine;

namespace EnigmaSimulator.WinForms
{
	public partial class Form1 : Form
	{
        

        private EnigmaEngine MotorEnigma { get; set; }
        private Fachada iFacade = new Fachada();

		public Form1()
		{
			InitializeComponent();
            cboAnillo1.DataSource = iFacade.ListarLetras();
            cboAnillo2.DataSource = iFacade.ListarLetras();
            cboAnillo3.DataSource = iFacade.ListarLetras();
        }

     

		private void label1_Click(object sender, EventArgs e)
		{

		}

		private void Form1_Load(object sender, EventArgs e)
		{

		}

		private void label3_Click(object sender, EventArgs e)
		{

		}

		private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
		{

		}

		private void groupBox4_Enter(object sender, EventArgs e)
		{

		}

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void reiniciarConfiguracionToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
