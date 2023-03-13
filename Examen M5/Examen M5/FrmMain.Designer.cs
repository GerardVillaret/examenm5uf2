namespace Examen_M5
{
    partial class FrmMain
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
            this.btAnimal = new System.Windows.Forms.Button();
            this.btVintage = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btAnimal
            // 
            this.btAnimal.BackColor = System.Drawing.Color.Lime;
            this.btAnimal.Location = new System.Drawing.Point(256, 133);
            this.btAnimal.Name = "btAnimal";
            this.btAnimal.Size = new System.Drawing.Size(75, 23);
            this.btAnimal.TabIndex = 0;
            this.btAnimal.Text = "Animal";
            this.btAnimal.UseVisualStyleBackColor = false;
            this.btAnimal.Click += new System.EventHandler(this.btAnimal_Click);
            // 
            // btVintage
            // 
            this.btVintage.BackColor = System.Drawing.Color.IndianRed;
            this.btVintage.Location = new System.Drawing.Point(423, 133);
            this.btVintage.Name = "btVintage";
            this.btVintage.Size = new System.Drawing.Size(75, 23);
            this.btVintage.TabIndex = 1;
            this.btVintage.Text = "Vintage";
            this.btVintage.UseVisualStyleBackColor = false;
            this.btVintage.Click += new System.EventHandler(this.btVintage_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btVintage);
            this.Controls.Add(this.btAnimal);
            this.Name = "FrmMain";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btAnimal;
        private System.Windows.Forms.Button btVintage;
    }
}

