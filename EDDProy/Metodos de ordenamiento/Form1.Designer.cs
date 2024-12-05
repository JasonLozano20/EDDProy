namespace EDDemo.Metodos_de_ordenamiento
{
    partial class FormMetodo
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
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.btnCrearList = new System.Windows.Forms.Button();
            this.txtLista = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblQuickSort = new System.Windows.Forms.Label();
            this.btnOrdenar = new System.Windows.Forms.Button();
            this.ShellSort = new System.Windows.Forms.Label();
            this.lblShellSort = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblRadix = new System.Windows.Forms.Label();
            this.lblBurbuja = new System.Windows.Forms.Label();
            this.txtBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.lblResultado = new System.Windows.Forms.Label();
            this.time = new System.Windows.Forms.Label();
            this.time1 = new System.Windows.Forms.Label();
            this.time2 = new System.Windows.Forms.Label();
            this.time3 = new System.Windows.Forms.Label();
            this.TimeBusqueda = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(26, 132);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 22);
            this.numericUpDown1.TabIndex = 0;
            this.numericUpDown1.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // btnCrearList
            // 
            this.btnCrearList.BackColor = System.Drawing.Color.RosyBrown;
            this.btnCrearList.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCrearList.Location = new System.Drawing.Point(174, 118);
            this.btnCrearList.Name = "btnCrearList";
            this.btnCrearList.Size = new System.Drawing.Size(120, 49);
            this.btnCrearList.TabIndex = 1;
            this.btnCrearList.Text = "Crear Lista";
            this.btnCrearList.UseVisualStyleBackColor = false;
            this.btnCrearList.Click += new System.EventHandler(this.btnCrearList_Click);
            // 
            // txtLista
            // 
            this.txtLista.Location = new System.Drawing.Point(26, 196);
            this.txtLista.Name = "txtLista";
            this.txtLista.Size = new System.Drawing.Size(707, 22);
            this.txtLista.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(33, 266);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 19);
            this.label2.TabIndex = 4;
            this.label2.Text = "QuickSort:";
            // 
            // lblQuickSort
            // 
            this.lblQuickSort.AutoSize = true;
            this.lblQuickSort.Location = new System.Drawing.Point(148, 268);
            this.lblQuickSort.Name = "lblQuickSort";
            this.lblQuickSort.Size = new System.Drawing.Size(0, 16);
            this.lblQuickSort.TabIndex = 5;
            // 
            // btnOrdenar
            // 
            this.btnOrdenar.BackColor = System.Drawing.Color.RosyBrown;
            this.btnOrdenar.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOrdenar.Location = new System.Drawing.Point(310, 117);
            this.btnOrdenar.Name = "btnOrdenar";
            this.btnOrdenar.Size = new System.Drawing.Size(125, 49);
            this.btnOrdenar.TabIndex = 6;
            this.btnOrdenar.Text = "Ordenar";
            this.btnOrdenar.UseVisualStyleBackColor = false;
            this.btnOrdenar.Click += new System.EventHandler(this.btnOrdenar_Click);
            // 
            // ShellSort
            // 
            this.ShellSort.AutoSize = true;
            this.ShellSort.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShellSort.Location = new System.Drawing.Point(34, 296);
            this.ShellSort.Name = "ShellSort";
            this.ShellSort.Size = new System.Drawing.Size(85, 19);
            this.ShellSort.TabIndex = 7;
            this.ShellSort.Text = "ShellSort:";
            // 
            // lblShellSort
            // 
            this.lblShellSort.AutoSize = true;
            this.lblShellSort.Location = new System.Drawing.Point(148, 296);
            this.lblShellSort.Name = "lblShellSort";
            this.lblShellSort.Size = new System.Drawing.Size(0, 16);
            this.lblShellSort.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(34, 327);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 19);
            this.label1.TabIndex = 9;
            this.label1.Text = "Radix:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(34, 358);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 19);
            this.label3.TabIndex = 10;
            this.label3.Text = "Burbuja:";
            // 
            // lblRadix
            // 
            this.lblRadix.AutoSize = true;
            this.lblRadix.Location = new System.Drawing.Point(148, 327);
            this.lblRadix.Name = "lblRadix";
            this.lblRadix.Size = new System.Drawing.Size(0, 16);
            this.lblRadix.TabIndex = 11;
            // 
            // lblBurbuja
            // 
            this.lblBurbuja.AutoSize = true;
            this.lblBurbuja.Location = new System.Drawing.Point(148, 361);
            this.lblBurbuja.Name = "lblBurbuja";
            this.lblBurbuja.Size = new System.Drawing.Size(0, 16);
            this.lblBurbuja.TabIndex = 12;
            // 
            // txtBox
            // 
            this.txtBox.Location = new System.Drawing.Point(25, 56);
            this.txtBox.Name = "txtBox";
            this.txtBox.Size = new System.Drawing.Size(100, 22);
            this.txtBox.TabIndex = 13;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button1.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(174, 52);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(120, 33);
            this.button1.TabIndex = 14;
            this.button1.Text = "Buscar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Location = new System.Drawing.Point(336, 59);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(0, 16);
            this.lblResultado.TabIndex = 15;
            // 
            // time
            // 
            this.time.AutoSize = true;
            this.time.Location = new System.Drawing.Point(605, 266);
            this.time.Name = "time";
            this.time.Size = new System.Drawing.Size(0, 16);
            this.time.TabIndex = 16;
            // 
            // time1
            // 
            this.time1.AutoSize = true;
            this.time1.Location = new System.Drawing.Point(605, 296);
            this.time1.Name = "time1";
            this.time1.Size = new System.Drawing.Size(0, 16);
            this.time1.TabIndex = 17;
            // 
            // time2
            // 
            this.time2.AutoSize = true;
            this.time2.Location = new System.Drawing.Point(605, 327);
            this.time2.Name = "time2";
            this.time2.Size = new System.Drawing.Size(0, 16);
            this.time2.TabIndex = 18;
            // 
            // time3
            // 
            this.time3.AutoSize = true;
            this.time3.Location = new System.Drawing.Point(605, 358);
            this.time3.Name = "time3";
            this.time3.Size = new System.Drawing.Size(0, 16);
            this.time3.TabIndex = 19;
            // 
            // TimeBusqueda
            // 
            this.TimeBusqueda.AutoSize = true;
            this.TimeBusqueda.Location = new System.Drawing.Point(582, 59);
            this.TimeBusqueda.Name = "TimeBusqueda";
            this.TimeBusqueda.Size = new System.Drawing.Size(0, 16);
            this.TimeBusqueda.TabIndex = 20;
            // 
            // FormMetodo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.TimeBusqueda);
            this.Controls.Add(this.time3);
            this.Controls.Add(this.time2);
            this.Controls.Add(this.time1);
            this.Controls.Add(this.time);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtBox);
            this.Controls.Add(this.lblBurbuja);
            this.Controls.Add(this.lblRadix);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblShellSort);
            this.Controls.Add(this.ShellSort);
            this.Controls.Add(this.btnOrdenar);
            this.Controls.Add(this.lblQuickSort);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtLista);
            this.Controls.Add(this.btnCrearList);
            this.Controls.Add(this.numericUpDown1);
            this.Name = "FormMetodo";
            this.Text = "MetodoOrdenamiento";
            this.Load += new System.EventHandler(this.FormMetodo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Button btnCrearList;
        private System.Windows.Forms.TextBox txtLista;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblQuickSort;
        private System.Windows.Forms.Button btnOrdenar;
        private System.Windows.Forms.Label ShellSort;
        private System.Windows.Forms.Label lblShellSort;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblRadix;
        private System.Windows.Forms.Label lblBurbuja;
        private System.Windows.Forms.TextBox txtBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.Label time;
        private System.Windows.Forms.Label time1;
        private System.Windows.Forms.Label time2;
        private System.Windows.Forms.Label time3;
        private System.Windows.Forms.Label TimeBusqueda;
    }
}