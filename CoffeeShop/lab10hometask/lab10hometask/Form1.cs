using System;
using System.Windows.Forms;
using CoffeeShop;

namespace lab10hometask
{
    public partial class Form1 : Form
    {
        public static string text = "";
        private string p_name;
        private double m_balance;
        private string PriceExceedsTheAmount = "Price Exceeds Balance";
        private string DebitAmountLessThaneroMEssage = "Price less than zero";
        private string pName { get { return p_name; } set { p_name = value; } }
        private double MBalance { get { return m_balance; } set { m_balance = value; } }
        private string PriceExceeds { get { return PriceExceedsTheAmount; } }
        private string DebitLess { get { return DebitAmountLessThaneroMEssage; } }

        public Form1()
        {
            InitializeComponent();
            pName = "Muneeb";
            MBalance = 5000;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            DLL coffee = new DLL();
            String input = textBox1.Text;
            double n=0;
            MessageBox.Show("Confirm Order?", "Are you sure?", MessageBoxButtons.OK);
            switch (input)
            {
                case "1":
                    text = coffee.Amountavailable(250,MBalance);
                    n = MBalance;
                    MBalance = MBalance - 250;
                    break;
                case "2":
                    text = coffee.Amountavailable(280,MBalance);
                    n = MBalance;
                    MBalance = MBalance - 280;
                    break;
                case "3":
                    text = coffee.Amountavailable(300,MBalance);
                    n = MBalance;
                    MBalance = MBalance - 300;
                    break;
                default:
                    break;
            }
            MessageBox.Show(text+"\nYour Previous Balance: "+n+"\nYour Current Balance: "+MBalance+"", "Alert!", MessageBoxButtons.OK);
           
        }
        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
