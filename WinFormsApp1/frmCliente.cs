using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class frmCliente : Form
    {
        public frmCliente()
        {
            InitializeComponent();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            if (txbTelefone.Text == "" || !txbTelefone.MaskCompleted || !txbCPF.MaskCompleted)
                return;
            Cliente cliente = new();
            cliente.Nome = txbNome.Text;
            cliente.CPF = txbCPF.Text;
            cliente.Telefone = txbTelefone.Text;
            cliente.DataNascimento = dtpNasicmento.Value;
            BD.AddPessoa(cliente);
            MessageBox.Show(" -> Cliente Cadastrado! <-");
            this.Close();
        }
    }
}
