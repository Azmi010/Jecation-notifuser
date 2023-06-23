namespace notifuser
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            label6 = new Label();
            label15 = new Label();
            label12 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label15);
            panel1.Controls.Add(label12);
            panel1.Location = new Point(576, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(344, 563);
            panel1.TabIndex = 13;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Microsoft Sans Serif", 17.9999981F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(3, 4);
            label6.Name = "label6";
            label6.Size = new Size(122, 29);
            label6.TabIndex = 11;
            label6.Text = "Notifikasi";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label15.Location = new Point(9, 55);
            label15.Name = "label15";
            label15.Size = new Size(148, 20);
            label15.TabIndex = 12;
            label15.Text = "Tidak Ada Notifikasi";
            label15.Click += label15_Click;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label12.Location = new Point(9, 253);
            label12.Name = "label12";
            label12.Size = new Size(205, 20);
            label12.TabIndex = 13;
            label12.Text = "Tidak Ada kode yang dikirim";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1264, 681);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label6;
        private Label label15;
        private Label label12;
    }
}