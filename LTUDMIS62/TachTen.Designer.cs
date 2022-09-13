
namespace LTUDMIS62
{
    partial class TachTen
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
            this.txtHT = new System.Windows.Forms.TextBox();
            this.btnhodem = new System.Windows.Forms.Button();
            this.btndem = new System.Windows.Forms.Button();
            this.btndemvaten = new System.Windows.Forms.Button();
            this.btnexit = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lblKQ = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Maroon;
            this.label1.Location = new System.Drawing.Point(14, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Họ và tên";
            // 
            // txtHT
            // 
            this.txtHT.Location = new System.Drawing.Point(145, 61);
            this.txtHT.Name = "txtHT";
            this.txtHT.Size = new System.Drawing.Size(145, 22);
            this.txtHT.TabIndex = 1;
            this.txtHT.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // btnhodem
            // 
            this.btnhodem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnhodem.ForeColor = System.Drawing.Color.Maroon;
            this.btnhodem.Location = new System.Drawing.Point(79, 169);
            this.btnhodem.Name = "btnhodem";
            this.btnhodem.Size = new System.Drawing.Size(180, 32);
            this.btnhodem.TabIndex = 2;
            this.btnhodem.Text = "Tách họ đệm";
            this.btnhodem.UseVisualStyleBackColor = true;
            this.btnhodem.Click += new System.EventHandler(this.btnhodem_Click);
            // 
            // btndem
            // 
            this.btndem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndem.ForeColor = System.Drawing.Color.Maroon;
            this.btndem.Location = new System.Drawing.Point(305, 149);
            this.btndem.Name = "btndem";
            this.btndem.Size = new System.Drawing.Size(180, 32);
            this.btndem.TabIndex = 3;
            this.btndem.Text = "Tách đệm";
            this.btndem.UseVisualStyleBackColor = true;
            this.btndem.Click += new System.EventHandler(this.btndem_Click);
            // 
            // btndemvaten
            // 
            this.btndemvaten.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndemvaten.ForeColor = System.Drawing.Color.Maroon;
            this.btndemvaten.Location = new System.Drawing.Point(539, 149);
            this.btndemvaten.Name = "btndemvaten";
            this.btndemvaten.Size = new System.Drawing.Size(180, 32);
            this.btndemvaten.TabIndex = 5;
            this.btndemvaten.Text = "Tách đệm và tên";
            this.btndemvaten.UseVisualStyleBackColor = true;
            this.btndemvaten.Click += new System.EventHandler(this.btndemvaten_Click);
            // 
            // btnexit
            // 
            this.btnexit.Location = new System.Drawing.Point(708, 390);
            this.btnexit.Name = "btnexit";
            this.btnexit.Size = new System.Drawing.Size(75, 27);
            this.btnexit.TabIndex = 6;
            this.btnexit.Text = "Đóng";
            this.btnexit.UseVisualStyleBackColor = true;
            this.btnexit.Click += new System.EventHandler(this.btnexit_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(79, 264);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 29);
            this.label2.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Maroon;
            this.label3.Location = new System.Drawing.Point(298, 264);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 29);
            this.label3.TabIndex = 8;
            this.label3.Text = "Kết quả";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtHT);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btndem);
            this.groupBox1.Controls.Add(this.btndemvaten);
            this.groupBox1.Location = new System.Drawing.Point(12, 20);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(735, 228);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Nhập họ và tên";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label4.Location = new System.Drawing.Point(74, 295);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 25);
            this.label4.TabIndex = 10;
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // lblKQ
            // 
            this.lblKQ.AutoSize = true;
            this.lblKQ.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKQ.ForeColor = System.Drawing.Color.Maroon;
            this.lblKQ.Location = new System.Drawing.Point(312, 331);
            this.lblKQ.Name = "lblKQ";
            this.lblKQ.Size = new System.Drawing.Size(48, 29);
            this.lblKQ.TabIndex = 11;
            this.lblKQ.Text = "KQ";
            // 
            // TachTen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblKQ);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnhodem);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnexit);
            this.Name = "TachTen";
            this.Text = "TachTen";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtHT;
        private System.Windows.Forms.Button btnhodem;
        private System.Windows.Forms.Button btndem;
        private System.Windows.Forms.Button btndemvaten;
        private System.Windows.Forms.Button btnexit;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblKQ;
    }
}