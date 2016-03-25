using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace cryptography.View
{
    public partial class EnterKeyForm : Form
    {
        private string key;
        public string getKey() { return rich_txtbox_key.Text; }
        public void setKey(string s) { key = s; }
        public EnterKeyForm()
        {   
            InitializeComponent();
            string key="";
        }
       
    }
}
