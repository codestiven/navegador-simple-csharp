using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Navegador
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
  

        }



        private void tab2_Click(object sender, EventArgs e)
        {
            pestaña cc = new pestaña();
            cc.TopLevel = false;
            cc.FormBorderStyle = FormBorderStyle.None;  

            caca.Controls.Add(cc);
            cc.Show();

        }

        private void tab7_Click(object sender, EventArgs e)
        {
            pestaña cc = new pestaña();
            cc.TopLevel = false;
            cc.FormBorderStyle = FormBorderStyle.None;

            caca.Controls.Add(cc);
            cc.Show();

        }



        private void button1_Click(object sender, EventArgs e)
        {
            string title = "TabPage " + (tab2.TabCount + 1).ToString();
            TabPage myTabPage = new TabPage(title);
            tab2.TabPages.Add(myTabPage);
        }
    }
}
