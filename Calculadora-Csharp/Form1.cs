using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora_Csharp
{
    public partial class Background : Form
    {
        StringBuilder sb = new StringBuilder();
        public Background()
        {
            InitializeComponent();
        }

        private void bttnN0_Click(object sender, EventArgs e)
        {
            sb.Append("0");
            result.Text = sb.ToString();
        }

        private void bttnN1_Click(object sender, EventArgs e)
        {
            sb.Append("1");
            result.Text = sb.ToString();
        }

        private void bttnN2_Click(object sender, EventArgs e)
        {
            sb.Append("2");
            result.Text = sb.ToString();
        }

        private void bttnN3_Click(object sender, EventArgs e)
        {
            sb.Append("3");
            result.Text = sb.ToString();
        }

        private void bttnN4_Click(object sender, EventArgs e)
        {
            sb.Append("4");
            result.Text = sb.ToString();
        }

        private void bttnN5_Click(object sender, EventArgs e)
        {
            sb.Append("5");
            result.Text = sb.ToString();
        }

        private void bttnN6_Click(object sender, EventArgs e)
        {
            sb.Append("6");
            result.Text = sb.ToString();
        }

        private void bttnN7_Click(object sender, EventArgs e)
        {
            sb.Append("7");
            result.Text = sb.ToString();
        }

        private void bttnN8_Click(object sender, EventArgs e)
        {
            sb.Append("8");
            result.Text = sb.ToString();
        }

        private void bttnN9_Click(object sender, EventArgs e)
        {
            sb.Append("9");
            result.Text = sb.ToString();
        }

        private void bttnIgual_Click(object sender, EventArgs e)
        {

        }

        private void bttnMais_Click(object sender, EventArgs e)
        {

        }

        private void bttnMenos_Click(object sender, EventArgs e)
        {

        }

        private void bttnMultiplicacao_Click(object sender, EventArgs e)
        {

        }

        private void bttnDivisao_Click(object sender, EventArgs e)
        {

        }

        private void bttnBack_Click(object sender, EventArgs e)
        {

        }

        private void bttnClear_Click(object sender, EventArgs e)
        {

        }
    }
}
