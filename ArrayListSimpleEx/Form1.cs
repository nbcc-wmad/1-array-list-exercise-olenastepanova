using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace ArrayListSimpleEx
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private ArrayList message = new ArrayList();
        bool isReversed = false;
        
        private void Form1_Load(object sender, EventArgs e)
        {
            message.Add("I");
            message.Add("Love");
            message.Add("Programming");
            message.Add("So");
            message.Add("Much");
        
        }

        private void btnShowMsg_Click(object sender, EventArgs e)
        {
            
            if (isReversed)
            {
                message.Reverse();
            }
            lblMessage.Text = ComposeMessage(message);
            isReversed = false;
        }


        private void btnReverse_Click(object sender, EventArgs e)
        {
            message.Reverse();
            lblMessage.Text = ComposeMessage(message);
            isReversed = true;

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (isReversed)
            {
                MessageBox.Show("You cannot add word in reverse order. Click Display button.");
            }
            else
            {
                string userWord = txtSecondPos.Text;
                message.Insert(1, userWord);
                
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            message.RemoveAt(1);
        }

        private string ComposeMessage(ArrayList list)
        {
            string messageDisplay = "";
            foreach (string word in list)
            {
                messageDisplay += $"{word.ToString()} ";
            }

            return messageDisplay;
        }
    }
}
