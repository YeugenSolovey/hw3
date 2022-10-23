//task 1.2
namespace hw3_2
{
    public partial class Form1 : Form
    {
        private string _tbVal; 
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(_tbVal);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            try 
            { 
                int a = Convert.ToInt32(textBox1.Text); 
                _tbVal = a.ToString();
            }
            catch 
            {
                _tbVal = "Error";
            }
        }
    }
}