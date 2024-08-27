using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EstadosWindowsForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void lblNorte_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void lblEstados_Click(object sender, EventArgs e)
        {
            lblEstados.Text = cboEstados.Items.Count.ToString();
        }

        private void cboEstados_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnEstados_Click(object sender, EventArgs e)
        {
            if (cboEstados.Text == "SP" || cboEstados.Text == "RJ" || cboEstados.Text == "MG" || cboEstados.Text == "ES") ;
            {
                cboSudeste.Items.Add(cboEstados.Text);
                cboEstados.Items.RemoveAt(cboEstados.SelectedIndex);
                lblEstados.Text = cboEstados.Items.Count.ToString();
                lblSudeste.Text = cboSudeste.Items.Count.ToString();
                cboSudeste.Sorted = true;
            }

            if (cboEstados.Text == "RS" || cboEstados.Text == "PR" || cboEstados.Text == "SC") ;
            {
                cboSul.Items.Add(cboEstados.Text);
                cboEstados.Items.RemoveAt(cboEstados.SelectedIndex);
                lblEstados.Text = cboEstados.Items.Count.ToString();
                lblSul.Text = cboSul.Items.Count.ToString();
                cboSul.Sorted = true;
            }

            if (cboEstados.Text == "MT" || cboEstados.Text == "MS" || cboEstados.Text == "GO") ;
            {
                cboCentro.Items.Add(cboEstados.Text);
                cboEstados.Items.RemoveAt(cboEstados.SelectedIndex);
                lblEstados.Text = cboEstados.Items.Count.ToString();
                lblCentro.Text = cboCentro.Items.Count.ToString();
                cboCentro.Sorted = true;
            }

            if (cboEstados.Text == "PE" || cboEstados.Text == "PB" || cboEstados.Text == "PI" || cboEstados.Text == "BA" || cboEstados.Text == "CE" || cboEstados.Text == "RN" || cboEstados.Text == "SE" || cboEstados.Text == "MA" || cboEstados.Text == "AL") ;
            {
                cboNordeste.Items.Add(cboEstados.Text);
                cboEstados.Items.RemoveAt(cboEstados.SelectedIndex);
                lblEstados.Text = cboEstados.Items.Count.ToString();
                lblNordeste.Text = cboNordeste.Items.Count.ToString();
                cboNordeste.Sorted = true;
            }

            if (cboEstados.Text == "AC" || cboEstados.Text == "AM" || cboEstados.Text == "RO" || cboEstados.Text == "RR" || cboEstados.Text == "PA" || cboEstados.Text == "AP" || cboEstados.Text == "TO") ;
            {
                cboNorte.Items.Add(cboEstados.Text);
                cboEstados.Items.RemoveAt(cboEstados.SelectedIndex);
                lblEstados.Text = cboEstados.Items.Count.ToString();
                lblNorte.Text = cboNorte.Items.Count.ToString();
                cboNorte.Sorted = true;
            }
        }
    }
}
