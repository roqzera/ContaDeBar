using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ContaDeBar
{
    public partial class ContaDeBar : Form
    {

        Conta conta;


        public ContaDeBar()
        {
            InitializeComponent();
            conta = new Conta();
        }

        private void Atualizar()
        {

            //Printando no Forms
            double sValorPorPessoa = conta.ValorPorPessoa();
            double sTotal = conta.CalcTotal();

            LblTotalPessoas.Text = Convert.ToString(sValorPorPessoa.ToString("F2"));
            LblResultTotal.Text = Convert.ToString(sTotal.ToString("F2"));

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Verificação de preenchimento
            if (TxbQtdPessoas.Text == string.Empty | TxtbQtd.Text == string.Empty | TxtbValorUn.Text == string.Empty)
            {
                MessageBox.Show("Preencha todos os campos antes de adicionar!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                conta.AdicionarItem(Convert.ToInt32(TxtbQtd.Text), Convert.ToDouble(TxtbValorUn.Text));
                Atualizar();
            }

        }

        private void TxbQtdPessoas_TextChanged(object sender, EventArgs e)
        {
            if (Convert.ToInt32(TxbQtdPessoas.Text) == 0)
            {
                MessageBox.Show("Alguém tem que pagar a conta!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if (TxbQtdPessoas.Text != "")
            {
                conta.SetQtdPessoa(Convert.ToInt32(TxbQtdPessoas.Text));
                Atualizar();
            }

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            conta.Taxa(Chkbox10.Checked);
            Atualizar();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void LblResultTotal_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
