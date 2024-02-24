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

            try
            {

                cadastro c = new cadastro();
                string regime;
                string tipo;
                string porte;

                c.Cnpj = tx_cnpj.Text;
                c.RazaoSocial = tx_razao.Text;
                c.NomeFantasia = tx_nomeFantasia.Text;
                c.SituacaoCadastral = cmb_situacaoCadastral.Text;
                c.DataInicioAtividade = msk_data.Text;
                c.Telefone = msk_telefone.Text;
                c.Estado = cmb_estado.Text;
                c.Cidade = tx_cidade.Text;
                c.Bairro = tx_bairro.Text;
                c.Rua = tx_rua.Text;
                c.NaturezaJuridica = tx_naturezaJuridica.Text;
                c.Nome = tx_nomeProprietario.Text;
                c.Cpf = msk_cpfProprietario.Text;

                if (radioButton1.Checked == true)
                {
                    regime = radioButton1.Text;
                }
                else if (radioButton2.Checked == true)
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
                if (rd_Pequena.Checked == true)
                {
                    porte = rd_Pequena.Text;
                }
                else if(rd_Medio.Checked == true)
                {
                    porte = rd_Medio.Text;
                }
                else
                {
                    porte = rd_Grande.Text;
                }

                if (Validar())
                {
                    MessageBox.Show("Cadastro realizado com sucesso");
                    MessageBox.Show($" Cnpj: {c.Cnpj} \n Razão: {c.RazaoSocial} \n NomeFantasia: {c.NomeFantasia} \n SituaçãoCadastral: {c.SituacaoCadastral} \n Regime: {regime} \n dataAtividade: {c.DataInicioAtividade} " +
                    $"Telefone: {c.Telefone} \n Estado: {c.Estado} \n Cidade: {c.Cidade} \n Bairro: {c.Bairro} \n Rua: {c.Rua} \n Tipo {tipo} \n Porte: {porte} \n Ntureza: {c.NaturezaJuridica} \n NomeProprietario: {c.Nome}" +
                    $"Cpf: {c.Cpf}");
                }
                else
                {
                    MessageBox.Show("Erro, prencha todos campos");
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro tente novamente");
            }

        }
              public bool Validar()
            {
                bool validacao;

                if (tx_cnpj.Text == "")
                {
                    validacao = false;
                }
                else if (tx_razao.Text == "")
                {
                    validacao = false;
                }
                else if (tx_nomeFantasia.Text == "")
                {
                    validacao = false;
                }
                else if (cmb_situacaoCadastral.Text == "")
                {
                    validacao = false;
                }
                else if (msk_telefone.Text == "")
                {
                    validacao = false;
                }
                else if (msk_data.Text == "")
                {
                    validacao = false;
                }
                else if (tx_capitalSocial.Text == "")
                {
                    validacao = false;
                }
                else if (cmb_estado.Text == "")
                {
                    validacao = false;
                }
                else if (tx_naturezaJuridica.Text == "")
                {
                    validacao = false;
                }
                else if (tx_cidade.Text == "")
                {
                    validacao = false;
                }
                else if (tx_bairro.Text == "")
                {
                    validacao = false;
                }
                else if (tx_rua.Text == "")
                {
                    validacao = false;
                }
                else if (tx_nomeProprietario.Text == "")
                {
                    validacao = false;
                }
                else if (msk_cpfProprietario.Text == "")
                {
                    validacao = false;
                }
                else
                {
                    validacao = true;
                }
                return validacao;
            }

        

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
