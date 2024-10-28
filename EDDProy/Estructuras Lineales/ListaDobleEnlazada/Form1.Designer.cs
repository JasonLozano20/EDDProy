namespace ListaDobleEnlazada
{
    partial class Form4
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
            this.txtInput = new System.Windows.Forms.TextBox();
            this.btnInsertarInicio = new System.Windows.Forms.Button();
            this.btnInsertarFinal = new System.Windows.Forms.Button();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.listBoxElementos = new System.Windows.Forms.ListBox();
            this.lblMensaje = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtInput
            // 
            this.txtInput.Location = new System.Drawing.Point(144, 104);
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(100, 22);
            this.txtInput.TabIndex = 0;
            // 
            // btnInsertarInicio
            // 
            this.btnInsertarInicio.BackColor = System.Drawing.Color.Silver;
            this.btnInsertarInicio.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInsertarInicio.Location = new System.Drawing.Point(150, 166);
            this.btnInsertarInicio.Name = "btnInsertarInicio";
            this.btnInsertarInicio.Size = new System.Drawing.Size(94, 38);
            this.btnInsertarInicio.TabIndex = 1;
            this.btnInsertarInicio.Text = "In Inicio";
            this.btnInsertarInicio.UseVisualStyleBackColor = false;
            this.btnInsertarInicio.Click += new System.EventHandler(this.btnInsertarInicio_Click);
            // 
            // btnInsertarFinal
            // 
            this.btnInsertarFinal.BackColor = System.Drawing.Color.Silver;
            this.btnInsertarFinal.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInsertarFinal.Location = new System.Drawing.Point(150, 210);
            this.btnInsertarFinal.Name = "btnInsertarFinal";
            this.btnInsertarFinal.Size = new System.Drawing.Size(94, 34);
            this.btnInsertarFinal.TabIndex = 2;
            this.btnInsertarFinal.Text = "In Final";
            this.btnInsertarFinal.UseVisualStyleBackColor = false;
            this.btnInsertarFinal.Click += new System.EventHandler(this.btnInsertarFinal_Click);
            // 
            // btnBorrar
            // 
            this.btnBorrar.BackColor = System.Drawing.Color.Silver;
            this.btnBorrar.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBorrar.Location = new System.Drawing.Point(150, 250);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(94, 37);
            this.btnBorrar.TabIndex = 3;
            this.btnBorrar.Text = "Borrar";
            this.btnBorrar.UseVisualStyleBackColor = false;
            this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.Silver;
            this.btnBuscar.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.Location = new System.Drawing.Point(150, 298);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(94, 32);
            this.btnBuscar.TabIndex = 4;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // listBoxElementos
            // 
            this.listBoxElementos.FormattingEnabled = true;
            this.listBoxElementos.ItemHeight = 16;
            this.listBoxElementos.Location = new System.Drawing.Point(285, 166);
            this.listBoxElementos.Name = "listBoxElementos";
            this.listBoxElementos.Size = new System.Drawing.Size(120, 164);
            this.listBoxElementos.TabIndex = 5;
            // 
            // lblMensaje
            // 
            this.lblMensaje.AutoSize = true;
            this.lblMensaje.Location = new System.Drawing.Point(243, 357);
            this.lblMensaje.Name = "lblMensaje";
            this.lblMensaje.Size = new System.Drawing.Size(44, 16);
            this.lblMensaje.TabIndex = 6;
            this.lblMensaje.Text = "label1";
            
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(22, 107);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 19);
            this.label1.TabIndex = 7;
            this.label1.Text = "Ingresar valor";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(120, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(354, 32);
            this.label2.TabIndex = 8;
            this.label2.Text = "Listas doblemente enlazadas";
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(586, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblMensaje);
            this.Controls.Add(this.listBoxElementos);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.btnBorrar);
            this.Controls.Add(this.btnInsertarFinal);
            this.Controls.Add(this.btnInsertarInicio);
            this.Controls.Add(this.txtInput);
            this.Name = "Form4";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.Button btnInsertarInicio;
        private System.Windows.Forms.Button btnInsertarFinal;
        private System.Windows.Forms.Button btnBorrar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.ListBox listBoxElementos;
        private System.Windows.Forms.Label lblMensaje;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

