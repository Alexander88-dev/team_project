using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TeamProject
{
    public partial class Form1 : Form
    {
        private List<string> _state;
        

        public Form1()
        {
            InitializeComponent();
            _state = new List<string>();
        }

        private void Form1_Load(object sender, EventArgs e)
        {}

        private void btnSend_Click(object sender, EventArgs e)
        {
            if (txtBox.Text.Replace(" ", "") != "") 
            {
         
                listBox.Items.Add(txtBox.Text);
                _state.Add(txtBox.Text);        
                txtBox.Text = "";
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (listBox.Text != "") 
                listBox.Items.RemoveAt(listBox.SelectedIndex);
        }
    }
}