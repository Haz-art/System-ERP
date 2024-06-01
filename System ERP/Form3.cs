using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace System_ERP
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string text1 = textBox1.Text;
            string text2 = textBox2.Text;

            MessageBox.Show(text1[0] + " . " + text2[0] + " Witaj w systemie jako " + text1 + "  " + text2);


            string createText = text1 +", "+text2 +  DateTime.Now + Environment.NewLine;
            try{
                File.WriteAllText("./", createText);
            }
            catch
            {
                MessageBox.Show("Nie znaleziono pliku,nie zapisano zmian");

            }
        }
    }
}
