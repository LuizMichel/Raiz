using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Modelos;
using BLL;

namespace Cadastro
{
    public partial class Cadastro : MetroFramework.Forms.MetroForm
    {
        public Cadastro()
        {
            InitializeComponent();
        }

        private void Cadastro_Load(object sender, EventArgs e)
        {
            bloquear();

        }

        public char verifica = 'N';

        public void limpar()
        {
            txtCodigo.Clear();
            txtEndereco.Clear();
            txtRazaoSocial.Clear();

            txtCodigo.Focus();
        }

        private void bntCadastrar_Click(object sender, EventArgs e)
        {
            try
            {
                CheckModelo check = new CheckModelo();

                check.IdCodigo = Convert.ToInt32(txtCodigo.Text);
                if(check.IdCodigo <= 0)
                {
                    MessageBox.Show("Numeros negativos sao invalidos", "Aviso");
                    return;
                }

                check.RazaoSocial = txtRazaoSocial.Text;
                check.Endereco = txtEndereco.Text;

                CheckBLL obj = new CheckBLL();
                obj.incluir(check, verifica);
                if(verifica == 'S')
                {
                    MessageBox.Show("Cliente Alterado com Sucesso");
                }
                else
                {
                    MessageBox.Show("Cliente Efetuado com Sucesso");
                }
                
            }
            catch(Exception ex)
            {
                MessageBox.Show("Erro", ex.Message);
            }

            limpar();
            txtCodigo.Focus();
            txtRazaoSocial.Enabled = false;
            txtEndereco.Enabled = false;

            
        }

        public void bloquear()
        {
            txtRazaoSocial.Enabled = false;
            txtEndereco.Enabled = false;
            bntCadastrar.Enabled = false;
            bntExcluir.Enabled = false;
            bntLimpar.Enabled = false;           
        }

        private void bntLimpar_Click(object sender, EventArgs e)
        {
            limpar();
            bloquear();
        }

        private void txtCodigo_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyData == Keys.Enter)
            {
                bntCadastrar.Enabled = true;               
                try
                {
                    if ((txtCodigo.Text.Equals("0") && (txtCodigo.Text.Trim().Length == 0)))
                    {
                        MessageBox.Show("Favor Informar o Codigo do Cliente");
                    }
                    else
                    {
                        CheckModelo cli = new CheckModelo();
                        cli.IdCodigo = Convert.ToInt32(txtCodigo.Text);
                        CheckBLL obj = new CheckBLL();
                        obj.listar3(cli);

                        txtRazaoSocial.Enabled = true;
                        txtEndereco.Enabled = true;

                        if (!(ReferenceEquals(cli.RazaoSocial, null)))
                        {
                            txtRazaoSocial.Text = cli.RazaoSocial;
                            txtEndereco.Text = cli.Endereco;
                            verifica = 'S';
                            bntExcluir.Enabled = true;
                        }
                        txtRazaoSocial.Focus();
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Informe o código corretamente!\n" + ex.Message);
                }


            }
        }

        private void bntExcluir_Click(object sender, EventArgs e)
        {
            CheckModelo cli = new CheckModelo();
            cli.IdCodigo = Convert.ToInt32(txtCodigo.Text);
            cli.RazaoSocial = txtRazaoSocial.Text;
            cli.Endereco = txtEndereco.Text;

            if (MessageBox.Show("Deseja realmente excluir esse cadastro?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                CheckBLL obj = new CheckBLL();
            obj.excluir(cli);
                MessageBox.Show("As observações do fornecedor excluída com sucesso!");
            }

            txtCodigo.Focus();
            bloquear();

        }

        private void txtCodigo_Enter(object sender, EventArgs e)
        {
            limpar();
            bloquear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            string strDadosCliente;

            Graphics ObjImpressao = e.Graphics;

            ObjImpressao.DrawString("Dados do Cliente", new Font("Times New Roman", 14, FontStyle.Bold), Brushes.Black, 50, 50);
            strDadosCliente = "\n\n\nCodigo do Cliente...." + txtCodigo.ToString() +
                              "\nRazao Social............." + txtRazaoSocial.ToString() +
                              "\nEndereço..................." + txtEndereco.ToString();


            ObjImpressao.DrawString(strDadosCliente, new Font("Arial", 12, FontStyle.Bold), Brushes.Black, 50, 50);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (printDialog1.ShowDialog() == DialogResult.OK)
            {
                printDocument1.DocumentName = "Cadastro do Cliente";
                printPreviewDialog1.ShowDialog();
            }
        }

        private void Cadastro_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.SelectNextControl(this.ActiveControl, !e.Shift, true, true, true);
            }
        }
    }
}
