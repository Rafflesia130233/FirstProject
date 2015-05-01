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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        

        private void Form3_Load(object sender, EventArgs e)
        {
            StreamReader readFile = new StreamReader("F:\\TextFile.txt",true);

            while (readFile.ReadLine() != null)
            {
                ListViewItem list = new ListViewItem(readFile.ReadLine());
                list.SubItems.Add(readFile.ReadLine());
                list.SubItems.Add(readFile.ReadLine());
                list.SubItems.Add(readFile.ReadLine());
                list.SubItems.Add(readFile.ReadLine());
                list.SubItems.Add(readFile.ReadLine());
                list.SubItems.Add(readFile.ReadLine());
                listView1.Items.Add(list);
            }
            readFile.Close();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
