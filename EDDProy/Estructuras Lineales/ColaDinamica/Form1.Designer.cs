namespace ColaDinamica
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
            this.btnEnqueue = new System.Windows.Forms.Button();
            this.btnDequeue = new System.Windows.Forms.Button();
            this.btnPeek = new System.Windows.Forms.Button();
            this.listBoxCola = new System.Windows.Forms.ListBox();
            this.txtInput = new System.Windows.Forms.TextBox();
            this.lblPeek = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnGraficar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnEnqueue
            // 
            this.btnEnqueue.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnEnqueue.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnqueue.Location = new System.Drawing.Point(225, 235);
            this.btnEnqueue.Name = "btnEnqueue";
            this.btnEnqueue.Size = new System.Drawing.Size(88, 31);
            this.btnEnqueue.TabIndex = 0;
            this.btnEnqueue.Text = "Enqueue";
            this.btnEnqueue.UseVisualStyleBackColor = false;
            this.btnEnqueue.Click += new System.EventHandler(this.btnEnqueue_Click);
            // 
            // btnDequeue
            // 
            this.btnDequeue.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnDequeue.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDequeue.Location = new System.Drawing.Point(225, 286);
            this.btnDequeue.Name = "btnDequeue";
            this.btnDequeue.Size = new System.Drawing.Size(88, 29);
            this.btnDequeue.TabIndex = 1;
            this.btnDequeue.Text = "Dequeue";
            this.btnDequeue.UseVisualStyleBackColor = false;
            this.btnDequeue.Click += new System.EventHandler(this.btnDequeue_Click);
            // 
            // btnPeek
            // 
            this.btnPeek.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnPeek.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPeek.Location = new System.Drawing.Point(225, 334);
            this.btnPeek.Name = "btnPeek";
            this.btnPeek.Size = new System.Drawing.Size(88, 28);
            this.btnPeek.TabIndex = 2;
            this.btnPeek.Text = "Peek";
            this.btnPeek.UseVisualStyleBackColor = false;
            this.btnPeek.Click += new System.EventHandler(this.btnPeek_Click);
            // 
            // listBoxCola
            // 
            this.listBoxCola.FormattingEnabled = true;
            this.listBoxCola.ItemHeight = 16;
            this.listBoxCola.Location = new System.Drawing.Point(336, 235);
            this.listBoxCola.Name = "listBoxCola";
            this.listBoxCola.Size = new System.Drawing.Size(120, 180);
            this.listBoxCola.TabIndex = 3;
            // 
            // txtInput
            // 
            this.txtInput.Location = new System.Drawing.Point(336, 189);
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(120, 22);
            this.txtInput.TabIndex = 4;
            // 
            // lblPeek
            // 
            this.lblPeek.AutoSize = true;
            this.lblPeek.Location = new System.Drawing.Point(525, 346);
            this.lblPeek.Name = "lblPeek";
            this.lblPeek.Size = new System.Drawing.Size(44, 16);
            this.lblPeek.TabIndex = 5;
            this.lblPeek.Text = "label1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(197, 190);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 19);
            this.label1.TabIndex = 6;
            this.label1.Text = "Ingresa un valor";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(276, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 25);
            this.label2.TabIndex = 7;
            this.label2.Text = "Cola(FIFO)";
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnClear.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(489, 235);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(96, 32);
            this.btnClear.TabIndex = 8;
            this.btnClear.Text = "Vaciar";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnGraficar
            // 
            this.btnGraficar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnGraficar.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGraficar.Location = new System.Drawing.Point(489, 273);
            this.btnGraficar.Name = "btnGraficar";
            this.btnGraficar.Size = new System.Drawing.Size(96, 35);
            this.btnGraficar.TabIndex = 9;
            this.btnGraficar.Text = "Graficar";
            this.btnGraficar.UseVisualStyleBackColor = false;
            this.btnGraficar.Click += new System.EventHandler(this.btnGraficar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnGraficar);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblPeek);
            this.Controls.Add(this.txtInput);
            this.Controls.Add(this.listBoxCola);
            this.Controls.Add(this.btnPeek);
            this.Controls.Add(this.btnDequeue);
            this.Controls.Add(this.btnEnqueue);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEnqueue;
        private System.Windows.Forms.Button btnDequeue;
        private System.Windows.Forms.Button btnPeek;
        private System.Windows.Forms.ListBox listBoxCola;
        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.Label lblPeek;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnGraficar;
    }
}

