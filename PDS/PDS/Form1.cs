using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PDS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string Cnpj = tx_cnpj.Text;
            string razao = tx_razao.Text;
            string nomeFantasia = tx_nomeFantasia.Text;
            string situacao = cmb_situacaoCadastral.Text;
            string regime = gp_regimeTributario.Text;
            string dataAtividade = msk_data.Text;
            string telefone = msk_telefone.Text;
            string estado = cmb_estado.Text;
            string cidade = tx_cidade.Text;
            string bairro = tx_bairro.Text;
            string rua = tx_rua.Text;  
            string tipo = gp_tipo.Text;
            string porte = cmb_porteEmpresa.Text;
            string natureza = tx_naturezaJuridica.Text;
            string nomeProprietario = tx_nomeProprietario.Text;
            string cpf = msk_cpfProprietario.Text;

            if(radioButton1.Checked == true)
            {
                regime = radioButton1.Text;
            }
            else if(radioButton2.Checked == true)
            {
                regime = radioButton2.Text;
            }
            else
            {
                regime = radioButton3.Text;

            }
            if (radio_matriz.Checked == true)
            {
                tipo = radio_filial.Text;

            }
            else
            {
                tipo = radio_filial.Text;
            }
            MessageBox.Show($"cnpj: {Cnpj} \n razao: {razao} \n nomeFantasia: {nomeFantasia} \n situação: {situacao} \n regime: {regime} \n dataAtividade: {dataAtividade} " +
                $"telefone: {telefone} \n estado: {estado} \n cidade: {cidade} \n bairro {bairro} \n rua {rua} \n  tipo {tipo} \n  porte {porte} \n natureza {natureza} \n nomeProprietario {nomeProprietario}" +
                $"cpf {cpf}");
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
