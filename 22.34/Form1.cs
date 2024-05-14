using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _22._34
{
    public partial class Form1 : Form
    {
        private List<double> resistenze = new List<double>();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (double.TryParse(textBoxSomma.Text, out double resistenza)) 
            { 
                resistenze.Add(resistenza);
                listBox.Items.Add(resistenza.ToString()); 
                CalcolaResistenzaTotale();
                textBoxSomma.Clear();
            }
            else
            {
                textBoxSomma.Clear();
            }
                
        }
        private void CalcolaResistenzaTotale()
        {
            if (resistenze.Count == 0)
            {
                Console.WriteLine("Inserire valori validi");
                Console.ReadLine();
                return;
            }
            else
            {
                double totaleDenominatore = resistenze.Sum(r => 1 / r);
                double Totale = 1 / totaleDenominatore;
                textBoxrisultato.Text= Totale.ToString();

            }
        }
    }
}
