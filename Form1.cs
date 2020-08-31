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
    public partial class Glavnaya : Form
    {
        public Glavnaya()
        {
            InitializeComponent();
        }

        private void Glavnaya_Load(object sender, EventArgs e)
        {
            DateBirthd.Mask = "00.00.0000";
            INN.Mask = "000000000000";
            OGRN.Mask = "0000000000000";
            SizePay.Mask = "0000000000000000000";
        }

        private void YRIK_Click(object sender, EventArgs e)
        {
            UrLico Proverka = new UrLico(Family.Text, NameKlient.Text, Otchestvo.Text, DateBirthd.Text, SizePay.Text, Valuta.Text, 
                                        CountryPay.Text, CountryBank.Text, INN.Text, OGRN.Text, NameUL.Text, checkBox1.Checked);
            Proverka.ShowDialog();
        }

        private void FIZIK_Click(object sender, EventArgs e)
        {
            FizLico Proverka = new FizLico(Family.Text, NameKlient.Text, Otchestvo.Text, DateBirthd.Text ,  SizePay.Text,
                                            Valuta.Text, CountryPay.Text, CountryBank.Text);
            Proverka.ShowDialog();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            APIKey p = new APIKey();
            p.ShowDialog();
        }
    }
}
