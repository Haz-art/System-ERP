namespace System_ERP
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var myForm = new Form2();
            myForm.Show();
        }
    }
}