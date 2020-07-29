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
    public partial class Form2 : Form
    {
        private int X { get; set; }
        private int Y { get; set; }
        public Form2()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.Manual;
        }
        public void SetXY(int x, int y)
        {
            X = x;
            Y = y;
            this.Location = new Point(X, Y);
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
