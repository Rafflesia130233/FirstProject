using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace Project3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void butSave_Click(object sender, EventArgs e)
        {

            StreamWriter writeFile = new StreamWriter("F:\\TextFile.txt",true);

            
            writeFile.WriteLine(textname.Text);

            writeFile.WriteLine(textroll.Text);

            writeFile.WriteLine(textbatch.Text);

            writeFile.WriteLine(comboYear.Text);

            writeFile.WriteLine(comboTerm.Text);

            writeFile.WriteLine(textadd.Text);

            writeFile.WriteLine(textcont.Text);

            writeFile.Close();

            MessageBox.Show("Saved Successfully !");
        }

        private void butShow_Click(object sender, EventArgs e)
        {
            //StreamReader readFile = new StreamReader("F:\\TextFile.txt",true);
            Form2 a = new Form2();
            a.Show();



            //readFile.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button_Click(object sender, EventArgs e)
        {
            Form3 b = new Form3();
            b.Show();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            /*comboYear.Items.Add("1st");
            comboYear.Items.Add("2nd");
            comboYear.Items.Add("3rd");
            comboYear.Items.Add("4th");*/
        }

        private void comboTerm_SelectedIndexChanged(object sender, EventArgs e)
        {
           /* comboTerm.Items.Add("1st");
            comboTerm.Items.Add("2nd");*/
        }
    }
}
