using System;
using System.Windows.Forms;
using MarkEmbling.PostcodesIO;

namespace Postcode_Checker
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            textBox2.Clear();
            var data = textBox1.Text;
            string myData = data.ToString();

            var client = new PostcodesIOClient();
            var result = client.Lookup(myData);

            try
            {
                string myResult = result.AdminDistrict + "\r\n" + result.Region + "\r\n" + result.Country + "\r\n" + result.Postcode.ToString();
                textBox2.AppendText(myResult);
            }
            catch (Exception)
            {
                MessageBox.Show("That's Not A Valid Postcode!");
            }
        }

        private void TextBox2_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void AboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Created by Glynn Bower" + "\r\n\n" + "A simple UK Postcode Checker created using" + "\r\n" + "postcodes.io and the MarkEmbling library" + "\r\n\n" + "Application Version" + " " + Application.ProductVersion);
        }
    }
}