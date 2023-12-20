
namespace PrimerEjemplo
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
            this.btTocar = new System.Windows.Forms.Button();
            this.textNombre = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btTocar
            // 
            this.btTocar.Location = new System.Drawing.Point(302, 115);
            this.btTocar.Name = "btTocar";
            this.btTocar.Size = new System.Drawing.Size(164, 74);
            this.btTocar.TabIndex = 0;
            this.btTocar.Text = "apretar";
            this.btTocar.UseVisualStyleBackColor = true;
            this.btTocar.Click += new System.EventHandler(this.button1_Click);
            // 
            // textNombre
            // 
            this.textNombre.Location = new System.Drawing.Point(337, 54);
            this.textNombre.Name = "textNombre";
            this.textNombre.Size = new System.Drawing.Size(100, 20);
            this.textNombre.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(793, 344);
            this.Controls.Add(this.textNombre);
            this.Controls.Add(this.btTocar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btTocar;
        private System.Windows.Forms.TextBox textNombre;
    }
}

