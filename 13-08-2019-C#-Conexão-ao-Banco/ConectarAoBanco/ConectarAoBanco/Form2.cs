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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            try
            {
                MySqlConnection con = new MySqlConnection("server=143.106.241.1;port=3306;UserID=cl18474;database=cl18474;password=lu159357");
                con.Open();
                MessageBox.Show("Conectado");
                con.Close();
            }
            catch
            {
                MessageBox.Show("Falha na conexão");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                MySqlConnection con = new MySqlConnection("server=143.106.241.1;port=3306;UserID=cl18474;database=cl18474;password=lu159357");
                con.Open();
                String id    = textBox1.Text;
                String nome  = textBox2.Text;
                String turma = comboBox1.SelectedItem.ToString(); 

                MySqlCommand insere = new MySqlCommand("INSERT INTO Alunos_C(idAlunos, nomeAlunos, turmaAlunos) VALUES "+ id + ",'" + nome + "','" + turma + "')", con);
                insere.ExecuteNonQuery();
                MessageBox.Show("Inserido!");
                con.Close();
            }
            catch
            {
                MessageBox.Show("Falha na gravação!" +
                    "");
            }
        }
    }
}
