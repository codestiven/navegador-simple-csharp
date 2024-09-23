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
    public partial class pestaña : Form
    {
        public pestaña()
        {
            InitializeComponent();
        }



        private void alante_Click(object sender, EventArgs e)
        {
            web.GoForward();
        }

        private void actualizar_Click(object sender, EventArgs e)
        {
            web.Refresh();
        }

        private void toolStripButton1_Click_1(object sender, EventArgs e)
        {

            if(buscador.Text == "")
            {
                buscador.Text = "introdusca una pagina web porfabor";
                buscador.BorderStyle= BorderStyle.FixedSingle;
            }
            else
            {
                web.Navigate(buscador.Text);
            }

        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void pictureBox1_MouseEnter(object sender, EventArgs e)
        {
            PictureBox p = (PictureBox)sender;

            p.BackColor = ColorTranslator.FromHtml("#Ff0000");
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            web.GoBack();
        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            PictureBox p = (PictureBox)sender;

            p.BackColor = arriba.BackColor;
        }

        private void pestaña_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            web.Navigate("www.bing.com");
        }

        private void buscador_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {


                web.Navigate(buscador.Text);
            }
            else
            {
            
            }
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            web.Navigate("www.bing.com");
        }
    }
    }

