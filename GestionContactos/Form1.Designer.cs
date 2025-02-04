namespace GestionContactos
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
            this.btnAddContac = new System.Windows.Forms.Button();
            this.btnDeleteCon = new System.Windows.Forms.Button();
            this.btnEditContac = new System.Windows.Forms.Button();
            this.btnShowContac = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAddContac
            // 
            this.btnAddContac.Location = new System.Drawing.Point(85, 48);
            this.btnAddContac.Name = "btnAddContac";
            this.btnAddContac.Size = new System.Drawing.Size(144, 59);
            this.btnAddContac.TabIndex = 0;
            this.btnAddContac.Text = "Añadir contacto";
            this.btnAddContac.UseVisualStyleBackColor = true;
            this.btnAddContac.Click += new System.EventHandler(this.btnAddContac_Click);
            // 
            // btnDeleteCon
            // 
            this.btnDeleteCon.Location = new System.Drawing.Point(345, 48);
            this.btnDeleteCon.Name = "btnDeleteCon";
            this.btnDeleteCon.Size = new System.Drawing.Size(144, 59);
            this.btnDeleteCon.TabIndex = 1;
            this.btnDeleteCon.Text = "Eliminar contacto";
            this.btnDeleteCon.UseVisualStyleBackColor = true;
            this.btnDeleteCon.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnEditContac
            // 
            this.btnEditContac.Location = new System.Drawing.Point(85, 148);
            this.btnEditContac.Name = "btnEditContac";
            this.btnEditContac.Size = new System.Drawing.Size(144, 59);
            this.btnEditContac.TabIndex = 2;
            this.btnEditContac.Text = "Modificar telefono";
            this.btnEditContac.UseVisualStyleBackColor = true;
            // 
            // btnShowContac
            // 
            this.btnShowContac.Location = new System.Drawing.Point(345, 148);
            this.btnShowContac.Name = "btnShowContac";
            this.btnShowContac.Size = new System.Drawing.Size(144, 59);
            this.btnShowContac.TabIndex = 3;
            this.btnShowContac.Text = "Mostrar contacto";
            this.btnShowContac.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnShowContac);
            this.Controls.Add(this.btnEditContac);
            this.Controls.Add(this.btnDeleteCon);
            this.Controls.Add(this.btnAddContac);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAddContac;
        private System.Windows.Forms.Button btnDeleteCon;
        private System.Windows.Forms.Button btnEditContac;
        private System.Windows.Forms.Button btnShowContac;
    }
}

