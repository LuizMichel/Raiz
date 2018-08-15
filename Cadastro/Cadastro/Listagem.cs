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
using Npgsql;
using DAL;
using System.Collections;

namespace Cadastro
{
    public partial class Listagem : MetroFramework.Forms.MetroForm
    {
        public Listagem()
        {
            InitializeComponent();
        }

        private void Listagem_Load(object sender, EventArgs e)
        {
            CheckBLL check = new CheckBLL();
            dvgClientes.DataSource = check.Listar();

            CheckBLL chec = new CheckBLL();
            List<CheckModelo> lis = new List<CheckModelo>();
            lis = chec.listar4(lis);
            foreach (CheckModelo che in lis)
            {

                ListViewItem item = new ListViewItem();

                item.Text = che.IdCodigo.ToString();
                
                item.SubItems.Add(che.RazaoSocial.ToString());
                item.SubItems.Add(che.Endereco.ToString());
                lsvClientes.Items.Add(item);
            }
            lsvClientes.AutoResizeColumn(0,
            ColumnHeaderAutoResizeStyle.HeaderSize);
            lsvClientes.AutoResizeColumn(1,
            ColumnHeaderAutoResizeStyle.ColumnContent);
            lsvClientes.AutoResizeColumn(2,
            ColumnHeaderAutoResizeStyle.ColumnContent);

            dvgClientes.Columns[0].HeaderText = "Código";
            dvgClientes.Columns[1].HeaderText = "Razão Social";
            dvgClientes.Columns[2].HeaderText = "Endereço";
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            string strDadosCliente;

            Graphics ObjImpressao = e.Graphics;

            ObjImpressao.DrawString("Dados do Cliente", new Font("Times New Roman", 14, FontStyle.Bold), Brushes.Black, 50, 50);
            strDadosCliente = "\n\n\nCodigo do Cliente...." + dvgClientes[0, dvgClientes.CurrentRow.Index].Value.ToString() +
                              "\nRazao Social............." + dvgClientes[1, dvgClientes.CurrentRow.Index].Value.ToString() +
                              "\nEndereço..................." + dvgClientes[2, dvgClientes.CurrentRow.Index].Value.ToString();


            ObjImpressao.DrawString(strDadosCliente, new Font("Arial", 12, FontStyle.Bold), Brushes.Black, 50, 50);
        }

        private void bntImprimir_Click(object sender, EventArgs e)
        {
            if(printDialog1.ShowDialog() == DialogResult.OK)
            {
                printDocument1.DocumentName = "Cadastro do Cliente";
                printPreviewDialog1.ShowDialog();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            CheckBLL check = new CheckBLL();
            dvgClientes.DataSource = check.listar2(txtConsulRazao.Text);
        }

        private void bntSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtConsulRazao_KeyDown(object sender, KeyEventArgs e)
        {

            if(e.KeyData == Keys.Enter)
            {
                CheckBLL check = new CheckBLL();
                dvgClientes.DataSource = check.listar2(txtConsulRazao.Text);
            }
            
        }
    }
}
