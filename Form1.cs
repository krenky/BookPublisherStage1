using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookPublisherStage1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormAuthor FormA = new FormAuthor();
            FormA.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FormBook FormB = new FormBook();
            FormB.Show();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
        }

        protected void listUpdate(Author author)
        { }

        //protected void listUpdate2(Boolean bool)
        //{ }

        private void button1_Click(object sender, EventArgs e)
        {
            string firstname = null;
            Queue queue = new Queue();
            LinkedList linkedlist = new LinkedList();
            if (radioButton1.Checked) listUpdate(queue.FindAuthor(firstname));
            //if (radioButton2.Checked) listUpdate2(linkedlist.Contains(firstname));
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listView2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
