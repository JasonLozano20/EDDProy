namespace Algoritmos_recursividad
{
    partial class ExponentForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.number = new System.Windows.Forms.TextBox();
            this.back = new System.Windows.Forms.Button();
            this.start = new System.Windows.Forms.Button();
            this.labelResult = new System.Windows.Forms.Label();
            this.time = new System.Windows.Forms.Label();
            this.complex = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.number2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(427, 67);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(186, 42);
            this.label1.TabIndex = 6;
            this.label1.Text = "Exponente";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(287, 175);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(147, 19);
            this.label2.TabIndex = 7;
            this.label2.Text = "Ingrese el número ";
            // 
            // number
            // 
            this.number.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.number.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.number.Location = new System.Drawing.Point(445, 172);
            this.number.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.number.Name = "number";
            this.number.Size = new System.Drawing.Size(127, 22);
            this.number.TabIndex = 8;
            // 
            // back
            // 
            this.back.BackColor = System.Drawing.Color.Gray;
            this.back.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.back.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.back.Font = new System.Drawing.Font("MS UI Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.back.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.back.Location = new System.Drawing.Point(924, 495);
            this.back.Margin = new System.Windows.Forms.Padding(0);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(100, 28);
            this.back.TabIndex = 10;
            this.back.Text = "Regresar";
            this.back.UseVisualStyleBackColor = false;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // start
            // 
            this.start.BackColor = System.Drawing.Color.LightGray;
            this.start.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.start.Location = new System.Drawing.Point(445, 268);
            this.start.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.start.Name = "start";
            this.start.Size = new System.Drawing.Size(136, 37);
            this.start.TabIndex = 11;
            this.start.Text = "Calcular";
            this.start.UseVisualStyleBackColor = false;
            this.start.Click += new System.EventHandler(this.Start_Click);
            // 
            // labelResult
            // 
            this.labelResult.AutoSize = true;
            this.labelResult.BackColor = System.Drawing.Color.Transparent;
            this.labelResult.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelResult.Location = new System.Drawing.Point(360, 377);
            this.labelResult.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelResult.Name = "labelResult";
            this.labelResult.Size = new System.Drawing.Size(0, 16);
            this.labelResult.TabIndex = 12;
            // 
            // time
            // 
            this.time.AutoSize = true;
            this.time.BackColor = System.Drawing.Color.Transparent;
            this.time.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.time.Location = new System.Drawing.Point(360, 416);
            this.time.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.time.Name = "time";
            this.time.Size = new System.Drawing.Size(0, 16);
            this.time.TabIndex = 13;
            // 
            // complex
            // 
            this.complex.AutoSize = true;
            this.complex.BackColor = System.Drawing.Color.Transparent;
            this.complex.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.complex.Location = new System.Drawing.Point(360, 457);
            this.complex.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.complex.Name = "complex";
            this.complex.Size = new System.Drawing.Size(0, 16);
            this.complex.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(274, 212);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(160, 19);
            this.label3.TabIndex = 15;
            this.label3.Text = "Ingrese el exponente";
            // 
            // number2
            // 
            this.number2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.number2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.number2.Location = new System.Drawing.Point(445, 209);
            this.number2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.number2.Name = "number2";
            this.number2.Size = new System.Drawing.Size(127, 22);
            this.number2.TabIndex = 16;
            // 
            // ExponentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.number2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.complex);
            this.Controls.Add(this.time);
            this.Controls.Add(this.labelResult);
            this.Controls.Add(this.start);
            this.Controls.Add(this.back);
            this.Controls.Add(this.number);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "ExponentForm";
            this.Text = "ExponentForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox number;
        private System.Windows.Forms.Button back;
        private System.Windows.Forms.Button start;
        private System.Windows.Forms.Label labelResult;
        private System.Windows.Forms.Label time;
        private System.Windows.Forms.Label complex;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox number2;
    }
}