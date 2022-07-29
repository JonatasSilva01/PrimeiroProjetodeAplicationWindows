using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsAplication
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void NameLabel(object sender, EventArgs e)
        {

        }

        private void labelPergunta(object sender, EventArgs e)
        {

        }

        private void txtNome_TextChanged(object sender, EventArgs e)
        {

        }

        private void botaoEnviar_Click(object sender, EventArgs e)
        {
            var nome = "Jonatas";
            txtNome.Text = "Meu nome é " + nome + "\nBem vindo ao meu programa!";
        }
    }
}
