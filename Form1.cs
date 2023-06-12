using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace apresentacao
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (ValidaCampus())
            {
                string nome = tx_nome.Text;
                double peso = Convert.ToDouble(tx_peso.Text);
                double altura = Convert.ToDouble(tx_altura.Text);
                Pessoa p = new Pessoa(nome, peso, altura);
                (double a, string b, string c) = p.ImcCal();
                MessageBox.Show($"O IMC é {a.ToString("00.00")} \n A classificação é {b}\n O grau é {c}");

            }


        }
        
        



        
        private bool estado;
        private bool ValidaCampus()
        {
            bool estado = true;
            if (tx_nome.Text == "") //ou String.Empty = string vazia
            {
                estado = false;
                errorProvider1.SetError(tx_nome, "Campo obrigatório!");
            }
            if (tx_peso.Text == "")
            {
                estado = false;
                errorProvider1.SetError(tx_peso, "Campo obrigatório!");
            }
            if (tx_altura.Text == "")
            {
                estado = false;
                errorProvider1.SetError(tx_altura, "Campo obrigatório!");
            }
            return estado;

        }
       
    }
}
