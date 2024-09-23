namespace Navegador
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.tab2 = new System.Windows.Forms.TabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.caca = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.tab2.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.caca.SuspendLayout();
            this.SuspendLayout();
            // 
            // tab2
            // 
            this.tab2.Controls.Add(this.tabPage2);
            this.tab2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tab2.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tab2.Location = new System.Drawing.Point(0, 0);
            this.tab2.Name = "tab2";
            this.tab2.SelectedIndex = 0;
            this.tab2.Size = new System.Drawing.Size(800, 450);
            this.tab2.TabIndex = 0;
            this.tab2.Click += new System.EventHandler(this.tab2_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.caca);
            this.tabPage2.Location = new System.Drawing.Point(4, 32);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(792, 414);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // caca
            // 
            this.caca.Controls.Add(this.button1);
            this.caca.Dock = System.Windows.Forms.DockStyle.Fill;
            this.caca.Location = new System.Drawing.Point(3, 3);
            this.caca.Name = "caca";
            this.caca.Size = new System.Drawing.Size(786, 408);
            this.caca.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(764, -3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(25, 29);
            this.button1.TabIndex = 1;
            this.button1.Text = "+";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tab2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tab2.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.caca.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tab2;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Panel caca;
        private System.Windows.Forms.Button button1;
    }
}

