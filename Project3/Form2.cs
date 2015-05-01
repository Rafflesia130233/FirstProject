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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        

        private void Form2_Load(object sender, EventArgs e)
        {
            StreamReader readFile = new StreamReader("F:\\TextFile.txt");
           
            
            labelN.Text = readFile.ReadLine();
            labelR.Text = readFile.ReadLine();
            labelB.Text = readFile.ReadLine();
            labelY.Text = readFile.ReadLine();
            labelT.Text = readFile.ReadLine();
            labelA.Text = readFile.ReadLine();
            labelC.Text = readFile.ReadLine();
           
            readFile.Close();
        }

        private void labelR_Click(object sender, EventArgs e)
        {

        }

        private void labelB_Click(object sender, EventArgs e)
        {

        }

        private void labelA_Click(object sender, EventArgs e)
        {

        }

        private void labelC_Click(object sender, EventArgs e)
        {

        }

        private void listView_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

    }
}
