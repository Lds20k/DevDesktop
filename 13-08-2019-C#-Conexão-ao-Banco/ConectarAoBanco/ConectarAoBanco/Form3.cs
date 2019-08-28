using MySql.Data.MySqlClient;
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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                MySqlConnection con = new MySqlConnection("server=143.106.241.1;port=3306;UserID=cl18475;database=cl18475;password=cl*19022003");
                con.Open();
                MySqlCommand insere = new MySqlCommand("insert into PalestraC (data, hora, titulo, palestrante) values ('" + textBox1.Text + "','" + hora.SelectedItem.ToString() + "','" + textBox3.Text + "','" + textBox4.Text + "')", con);
                insere.ExecuteNonQuery();
                MessageBox.Show("Gravacao realizada com sucesso");
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Falha na gravacao");
            }
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            textBox1.Text = monthCalendar1.SelectionRange.Start.Date.ToString("MM/dd/yyyy");
        }
    }
}
