using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class frmUsuario : Form

    {
        private void HabilitaEdicao()
        {
            nm_usuarioTextBox.Enabled = true;
            sg_nivelTextBox.Enabled = true;
            nm_loginTextBox.Enabled = true;
            cd_senhaTextBox.Enabled = true;
            btnAnterior.Enabled = false;
            btnProximo.Enabled = false;
            btnNovo.Enabled = false;
            btnAlterar.Enabled = false;
            btnExcluir.Enabled = false;
            btnSalvar.Enabled = true;
            btnCancelar.Enabled = true;
            btnPesquisar.Enabled = false;
            btnImprimir.Enabled = false;
            btnSair.Enabled = false;   
        }

        private void DesabilitaEdicao()
        {
            nm_usuarioTextBox.Enabled = false;
            sg_nivelTextBox.Enabled = false;
            nm_loginTextBox.Enabled = false;
            cd_senhaTextBox.Enabled = false;
            btnAnterior.Enabled = true;
            btnProximo.Enabled = true;
            btnNovo.Enabled = true;
            btnAlterar.Enabled = true;
            btnExcluir.Enabled = true;
            btnSalvar.Enabled = false;
            btnCancelar.Enabled = false;
            btnPesquisar.Enabled = true;
            btnImprimir.Enabled = true;
            btnSair.Enabled = true;
        }

        public frmUsuario()
        {
            InitializeComponent();
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void FrmUsuario_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'cadastroDataSet.Tbusuario'. Você pode movê-la ou removê-la conforme necessário.
            this.tbusuarioTableAdapter.Fill(this.cadastroDataSet.Tbusuario);
            DesabilitaEdicao();

        }

        private void Cd_senhaLabel_Click(object sender, EventArgs e)
        {

        }

        private void BtnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnAnterior_Click(object sender, EventArgs e)
        {
            tbusuarioBindingSource.MovePrevious();
        }

        private void BtnProximo_Click(object sender, EventArgs e)
        {
            tbusuarioBindingSource.MoveNext();
        }

        private void BtnNovo_Click(object sender, EventArgs e)
        {
            tbusuarioBindingSource.AddNew();
            HabilitaEdicao();
        }

        private void BtnAlterar_Click(object sender, EventArgs e)
        {
            HabilitaEdicao();
        }

        private void BtnExcluir_Click(object sender, EventArgs e)
        {
            tbusuarioBindingSource.RemoveCurrent();
            tbusuarioTableAdapter.Update(cadastroDataSet.Tbusuario);
        }

        private void BtnSalvar_Click(object sender, EventArgs e)
        {
            Validate();
            tbusuarioBindingSource.EndEdit();
            tbusuarioTableAdapter.Update(cadastroDataSet.Tbusuario);
            DesabilitaEdicao();
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            tbusuarioBindingSource.CancelEdit();
            DesabilitaEdicao();
        }
    }
}
