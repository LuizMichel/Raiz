namespace Cadastro
{
    partial class Listagem
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Listagem));
            this.dvgClientes = new System.Windows.Forms.DataGridView();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.txtConsulRazao = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lsvClientes = new System.Windows.Forms.ListView();
            this.ColCodigo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColRazaoSocial = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColEndereco = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.bntSair = new System.Windows.Forms.Button();
            this.bntConsulta = new System.Windows.Forms.Button();
            this.bntImprimir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dvgClientes)).BeginInit();
            this.SuspendLayout();
            // 
            // dvgClientes
            // 
            this.dvgClientes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dvgClientes.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dvgClientes.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dvgClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgClientes.GridColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dvgClientes.Location = new System.Drawing.Point(14, 267);
            this.dvgClientes.Name = "dvgClientes";
            this.dvgClientes.Size = new System.Drawing.Size(633, 150);
            this.dvgClientes.TabIndex = 0;
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // printDialog1
            // 
            this.printDialog1.Document = this.printDocument1;
            this.printDialog1.UseEXDialog = true;
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Document = this.printDocument1;
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // txtConsulRazao
            // 
            this.txtConsulRazao.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtConsulRazao.Location = new System.Drawing.Point(162, 94);
            this.txtConsulRazao.Name = "txtConsulRazao";
            this.txtConsulRazao.Size = new System.Drawing.Size(116, 21);
            this.txtConsulRazao.TabIndex = 20;
            this.txtConsulRazao.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtConsulRazao_KeyDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(4, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(152, 15);
            this.label2.TabIndex = 21;
            this.label2.Text = "Consulta por Razao Social";
            // 
            // lsvClientes
            // 
            this.lsvClientes.BackColor = System.Drawing.SystemColors.Window;
            this.lsvClientes.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ColCodigo,
            this.ColRazaoSocial,
            this.ColEndereco});
            this.lsvClientes.Cursor = System.Windows.Forms.Cursors.Default;
            this.lsvClientes.FullRowSelect = true;
            this.lsvClientes.GridLines = true;
            this.lsvClientes.Location = new System.Drawing.Point(7, 128);
            this.lsvClientes.Name = "lsvClientes";
            this.lsvClientes.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lsvClientes.Size = new System.Drawing.Size(633, 133);
            this.lsvClientes.TabIndex = 24;
            this.lsvClientes.UseCompatibleStateImageBehavior = false;
            this.lsvClientes.View = System.Windows.Forms.View.Details;
            // 
            // ColCodigo
            // 
            this.ColCodigo.Text = "Codigo";
            this.ColCodigo.Width = 80;
            // 
            // ColRazaoSocial
            // 
            this.ColRazaoSocial.Text = "Razão Social";
            this.ColRazaoSocial.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // ColEndereco
            // 
            this.ColEndereco.Text = "Endereço";
            this.ColEndereco.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // bntSair
            // 
            this.bntSair.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bntSair.BackgroundImage")));
            this.bntSair.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.bntSair.Location = new System.Drawing.Point(377, 88);
            this.bntSair.Name = "bntSair";
            this.bntSair.Size = new System.Drawing.Size(87, 27);
            this.bntSair.TabIndex = 22;
            this.bntSair.Text = "Sair";
            this.bntSair.UseVisualStyleBackColor = true;
            this.bntSair.Click += new System.EventHandler(this.bntSair_Click);
            // 
            // bntConsulta
            // 
            this.bntConsulta.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bntConsulta.BackgroundImage")));
            this.bntConsulta.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.bntConsulta.Location = new System.Drawing.Point(284, 88);
            this.bntConsulta.Name = "bntConsulta";
            this.bntConsulta.Size = new System.Drawing.Size(87, 27);
            this.bntConsulta.TabIndex = 19;
            this.bntConsulta.Text = "    Consultar";
            this.bntConsulta.UseVisualStyleBackColor = true;
            this.bntConsulta.Click += new System.EventHandler(this.button1_Click);
            // 
            // bntImprimir
            // 
            this.bntImprimir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.bntImprimir.Image = global::Cadastro.Properties.Resources.if_BT_printer_905556__1_;
            this.bntImprimir.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bntImprimir.Location = new System.Drawing.Point(520, 82);
            this.bntImprimir.Name = "bntImprimir";
            this.bntImprimir.Size = new System.Drawing.Size(120, 39);
            this.bntImprimir.TabIndex = 1;
            this.bntImprimir.Text = "Imprimir           ";
            this.bntImprimir.UseVisualStyleBackColor = true;
            this.bntImprimir.Click += new System.EventHandler(this.bntImprimir_Click);
            // 
            // Listagem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(666, 428);
            this.Controls.Add(this.lsvClientes);
            this.Controls.Add(this.bntSair);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtConsulRazao);
            this.Controls.Add(this.bntConsulta);
            this.Controls.Add(this.bntImprimir);
            this.Controls.Add(this.dvgClientes);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Listagem";
            this.Padding = new System.Windows.Forms.Padding(23, 69, 23, 23);
            this.Text = "Listagem de Clientes";
            this.Load += new System.EventHandler(this.Listagem_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dvgClientes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dvgClientes;
        private System.Windows.Forms.Button bntImprimir;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintDialog printDialog1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Windows.Forms.Button bntConsulta;
        private System.Windows.Forms.TextBox txtConsulRazao;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button bntSair;
        private System.Windows.Forms.ListView lsvClientes;
        private System.Windows.Forms.ColumnHeader ColCodigo;
        private System.Windows.Forms.ColumnHeader ColRazaoSocial;
        private System.Windows.Forms.ColumnHeader ColEndereco;
    }
}