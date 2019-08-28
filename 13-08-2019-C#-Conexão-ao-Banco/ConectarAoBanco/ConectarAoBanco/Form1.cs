using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConectarAoBanco
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void cadastrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<Form2>().Count() == 0)
            {
                Form2 form2 = new Form2();
                form2.MdiParent = this;
                form2.Show();
            }
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<Form3>().Count() == 0)
            {
                Form3 form3 = new Form3();
                form3.MdiParent = this;
                form3.Show();
            }
        }

        private void presençaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form4 form4 = new Form4();
            form4.MdiParent = this;
            form4.Show();
        }
    }
}
