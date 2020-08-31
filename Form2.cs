using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kiseleva
{
    public partial class Form2 : Form
    {
        public string TEKST1;
        public Form2(String TEKST)
        {
            TEKST1 = TEKST;
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            label1.Text = TEKST1;
        }

        private void Ok_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
