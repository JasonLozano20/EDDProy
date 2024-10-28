namespace Algoritmos_recursividad
{
    partial class HanoiForm
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
            this.back = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.start = new System.Windows.Forms.Button();
            this.diskNumeric = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.Movimientos = new System.Windows.Forms.ListBox();
            this.time = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.diskNumeric)).BeginInit();
            this.SuspendLayout();
            // 
            // back
            // 
            this.back.BackColor = System.Drawing.Color.Gray;
            this.back.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.back.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.back.Font = new System.Drawing.Font("Times New Roman", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.back.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.back.Location = new System.Drawing.Point(915, 481);
            this.back.Margin = new System.Windows.Forms.Padding(0);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(100, 28);
            this.back.TabIndex = 10;
            this.back.Text = "Regresar";
            this.back.UseVisualStyleBackColor = false;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(387, 62);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(257, 42);
            this.label1.TabIndex = 11;
            this.label1.Text = "Torre de Hanoi";
            // 
            // start
            // 
            this.start.BackColor = System.Drawing.Color.LightGray;
            this.start.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.start.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.start.Location = new System.Drawing.Point(433, 439);
            this.start.Margin = new System.Windows.Forms.Padding(4);
            this.start.Name = "start";
            this.start.Size = new System.Drawing.Size(185, 52);
            this.start.TabIndex = 16;
            this.start.Text = "Iniciar";
            this.start.UseVisualStyleBackColor = false;
            this.start.Click += new System.EventHandler(this.start_Click);
            // 
            // diskNumeric
            // 
            this.diskNumeric.Location = new System.Drawing.Point(431, 215);
            this.diskNumeric.Margin = new System.Windows.Forms.Padding(4);
            this.diskNumeric.Name = "diskNumeric";
            this.diskNumeric.Size = new System.Drawing.Size(160, 22);
            this.diskNumeric.TabIndex = 17;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(404, 147);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(214, 19);
            this.label3.TabIndex = 18;
            this.label3.Text = "Ingrese el número de discos";
            // 
            // Movimientos
            // 
            this.Movimientos.FormattingEnabled = true;
            this.Movimientos.ItemHeight = 16;
            this.Movimientos.Location = new System.Drawing.Point(321, 276);
            this.Movimientos.Margin = new System.Windows.Forms.Padding(4);
            this.Movimientos.Name = "Movimientos";
            this.Movimientos.Size = new System.Drawing.Size(425, 132);
            this.Movimientos.TabIndex = 19;
            // 
            // time
            // 
            this.time.AutoSize = true;
            this.time.BackColor = System.Drawing.Color.Transparent;
            this.time.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.time.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.time.Location = new System.Drawing.Point(36, 224);
            this.time.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.time.Name = "time";
            this.time.Size = new System.Drawing.Size(0, 15);
            this.time.TabIndex = 21;
            // 
            // HanoiForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.time);
            this.Controls.Add(this.Movimientos);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.diskNumeric);
            this.Controls.Add(this.start);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.back);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "HanoiForm";
            this.Text = "HanoiForm";
            this.Load += new System.EventHandler(this.HanoiForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.diskNumeric)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button back;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button start;
        private System.Windows.Forms.NumericUpDown diskNumeric;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox Movimientos;
        private System.Windows.Forms.Label time;
    }
}