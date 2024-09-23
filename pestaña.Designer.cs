namespace Navegador
{
    partial class pestaña
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.arriba = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.buscador = new System.Windows.Forms.TextBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.rehacer = new System.Windows.Forms.PictureBox();
            this.atras = new System.Windows.Forms.PictureBox();
            this.web = new System.Windows.Forms.WebBrowser();
            this.arriba.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rehacer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.atras)).BeginInit();
            this.SuspendLayout();
            // 
            // arriba
            // 
            this.arriba.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.arriba.Controls.Add(this.pictureBox1);
            this.arriba.Controls.Add(this.pictureBox4);
            this.arriba.Controls.Add(this.buscador);
            this.arriba.Controls.Add(this.pictureBox3);
            this.arriba.Controls.Add(this.rehacer);
            this.arriba.Controls.Add(this.atras);
            this.arriba.Dock = System.Windows.Forms.DockStyle.Top;
            this.arriba.Location = new System.Drawing.Point(0, 0);
            this.arriba.Name = "arriba";
            this.arriba.Size = new System.Drawing.Size(1001, 38);
            this.arriba.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackgroundImage = global::Navegador.Properties.Resources.casa_silueta_negra_sin_puerta;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Location = new System.Drawing.Point(956, 8);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(20, 20);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click_1);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox4.BackgroundImage = global::Navegador.Properties.Resources.buscar;
            this.pictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox4.Location = new System.Drawing.Point(917, 8);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(20, 20);
            this.pictureBox4.TabIndex = 6;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Click += new System.EventHandler(this.toolStripButton1_Click_1);
            this.pictureBox4.MouseEnter += new System.EventHandler(this.pictureBox1_MouseEnter);
            this.pictureBox4.MouseLeave += new System.EventHandler(this.pictureBox1_MouseLeave);
            // 
            // buscador
            // 
            this.buscador.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.buscador.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.buscador.Location = new System.Drawing.Point(141, 5);
            this.buscador.Multiline = true;
            this.buscador.Name = "buscador";
            this.buscador.Size = new System.Drawing.Size(770, 25);
            this.buscador.TabIndex = 5;
            this.buscador.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.buscador_KeyPress);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackgroundImage = global::Navegador.Properties.Resources.actualizar;
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox3.Location = new System.Drawing.Point(78, 8);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(20, 20);
            this.pictureBox3.TabIndex = 4;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.actualizar_Click);
            this.pictureBox3.MouseEnter += new System.EventHandler(this.pictureBox1_MouseEnter);
            this.pictureBox3.MouseLeave += new System.EventHandler(this.pictureBox1_MouseLeave);
            // 
            // rehacer
            // 
            this.rehacer.BackgroundImage = global::Navegador.Properties.Resources.flecha__1_;
            this.rehacer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.rehacer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rehacer.Location = new System.Drawing.Point(38, 8);
            this.rehacer.Name = "rehacer";
            this.rehacer.Size = new System.Drawing.Size(20, 20);
            this.rehacer.TabIndex = 3;
            this.rehacer.TabStop = false;
            this.rehacer.Click += new System.EventHandler(this.alante_Click);
            this.rehacer.MouseEnter += new System.EventHandler(this.pictureBox1_MouseEnter);
            this.rehacer.MouseLeave += new System.EventHandler(this.pictureBox1_MouseLeave);
            // 
            // atras
            // 
            this.atras.BackgroundImage = global::Navegador.Properties.Resources.flecha__1_1;
            this.atras.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.atras.Cursor = System.Windows.Forms.Cursors.Hand;
            this.atras.Location = new System.Drawing.Point(12, 8);
            this.atras.Name = "atras";
            this.atras.Size = new System.Drawing.Size(20, 20);
            this.atras.TabIndex = 2;
            this.atras.TabStop = false;
            this.atras.Click += new System.EventHandler(this.pictureBox1_Click);
            this.atras.MouseLeave += new System.EventHandler(this.pictureBox1_MouseLeave);
            this.atras.MouseHover += new System.EventHandler(this.pictureBox1_MouseEnter);
            // 
            // web
            // 
            this.web.Dock = System.Windows.Forms.DockStyle.Fill;
            this.web.Location = new System.Drawing.Point(0, 38);
            this.web.MinimumSize = new System.Drawing.Size(20, 20);
            this.web.Name = "web";
            this.web.ScriptErrorsSuppressed = true;
            this.web.Size = new System.Drawing.Size(1001, 412);
            this.web.TabIndex = 1;
            // 
            // pestaña
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1001, 450);
            this.Controls.Add(this.web);
            this.Controls.Add(this.arriba);
            this.Name = "pestaña";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "pestaña";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.pestaña_Load);
            this.arriba.ResumeLayout(false);
            this.arriba.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rehacer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.atras)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel arriba;
        private System.Windows.Forms.WebBrowser web;
        private System.Windows.Forms.PictureBox rehacer;
        private System.Windows.Forms.PictureBox atras;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.TextBox buscador;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}