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
    
    public partial class Form4 : Form
    {
        public MySqlConnection con;
        public int idPalestra, ra;

        private void Form4_Load(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                MySqlCommand busca_palestra = new MySqlCommand("Select titulo from PalestraC", con);
                MySqlDataReader resultado = busca_palestra.ExecuteReader();
                while (resultado.Read())
                {
                    comboBox1.Items.Add(resultado["titulo"].ToString());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                con.Close();
            }
        }

        private void comboBox1_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                MySqlCommand busca_palestra = new MySqlCommand("Select titulo from PalestraC", con);
                MySqlDataReader resultado = busca_palestra.ExecuteReader();
                if (resultado.Read())
                {
                    idPalestra = Convert.ToInt32(resultado["idPalestraC"].ToString());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                con.Close();
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if((Keys)e.KeyChar == Keys.Enter)
            {
                con.Open();
                MySqlCommand busca_ra = new MySqlCommand("Select nomeAlunos, idAlunos from AlunoC where idAlunos="+ textBox1.Text, con);
                MySqlDataReader resultado = busca_ra.ExecuteReader();
                if (resultado.Read())
                {
                    label3.Text = resultado["nomeAlunos"].ToString();
                    ra = Convert.ToInt32(resultado["idAlunos"].ToString());
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                con.Close();
            }
        }

        public Form4()
        {
            InitializeComponent();
            try
            {
                con = new MySqlConnection("server=143.106.241.1;port=3306;UserID=cl18475;database=cl18475;password=cl*19022003");
            }
            catch
            {
                MessageBox.Show("Falha na conexão");
            }
            this.WindowState = FormWindowState.Maximized;

        }

        
            
        
    }

}
