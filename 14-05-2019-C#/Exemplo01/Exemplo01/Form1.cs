using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exemplo01
{
    public partial class Exemplo01 : Form
    {
        public Exemplo01()
        {
            InitializeComponent();
        }

        private void txtEvento_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((Keys)e.KeyChar == Keys.Enter && txtEvento.Text != "")
            {
                mskData.Focus();
            }
        }

        private void mskData_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((Keys)e.KeyChar == Keys.Enter && txtEvento.Text != "")
            {
                try
                {
                    DateTime date = Convert.ToDateTime(mskData.Text);
                    lstEvento.Items.Add(txtEvento.Text);
                    lstData.Items.Add(mskData.Text);
                    txtEvento.Text = "";
                    mskData.Text = "";
                    txtEvento.Focus();
                }
                catch (Exception error)
                {
                    MessageBox.Show("Data Invalidada");
                }
                
            }
        }

        private void btnVotar_Click(object sender, EventArgs e)
        {
            if (lstCandidatos.SelectedIndex == 0)
                lblQtdCandidato01.Text = (int.Parse(lblQtdCandidato01.Text) + 1).ToString();
            else if (lstCandidatos.SelectedIndex == 1)
                lblQtdCandidato02.Text = (int.Parse(lblQtdCandidato02.Text) + 1).ToString();
            else if (lstCandidatos.SelectedIndex == 2)
                lblQtdCandidato03.Text = (int.Parse(lblQtdCandidato03.Text) + 1).ToString();
            else
                MessageBox.Show("Selecione um candidato");
        }

        private void Exemplo01_Load(object sender, EventArgs e)
        {
            txtEvento.Focus();
        }

        private void lstEvento_Click(object sender, EventArgs e)
        {
            lstData.Items.RemoveAt(lstEvento.SelectedIndex);
            lstEvento.Items.RemoveAt(lstEvento.SelectedIndex);
        }

        private void lstData_MouseClick(object sender, MouseEventArgs e)
        {
            lstEvento.Items.RemoveAt(lstData.SelectedIndex);
            lstData.Items.RemoveAt(lstData.SelectedIndex);
            
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            lblQtdCandidato01.Text = lblQtdCandidato02.Text = lblQtdCandidato03.Text = 0.ToString();
        }
    }
}
