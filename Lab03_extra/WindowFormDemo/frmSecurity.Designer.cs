namespace WindowFormDemo
{
    partial class frmSecurity
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
            this.txtCode = new System.Windows.Forms.TextBox();
            this.btn1 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btnC = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btnEnter = new System.Windows.Forms.Button();
            this.btn7 = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.btn0 = new System.Windows.Forms.Button();
            this.btn9 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtLog = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Security code:";
            // 
            // txtCode
            // 
            this.txtCode.Enabled = false;
            this.txtCode.Location = new System.Drawing.Point(93, 16);
            this.txtCode.Name = "txtCode";
            this.txtCode.PasswordChar = '*';
            this.txtCode.ReadOnly = true;
            this.txtCode.Size = new System.Drawing.Size(169, 20);
            this.txtCode.TabIndex = 1;
            // 
            // btn1
            // 
            this.btn1.BackColor = System.Drawing.Color.Transparent;
            this.btn1.Location = new System.Drawing.Point(63, 56);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(37, 34);
            this.btn1.TabIndex = 2;
            this.btn1.Text = "1";
            this.btn1.UseVisualStyleBackColor = false;
            this.btn1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btn_MouseClick);
            // 
            // btn2
            // 
            this.btn2.BackColor = System.Drawing.Color.Transparent;
            this.btn2.Location = new System.Drawing.Point(106, 56);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(37, 34);
            this.btn2.TabIndex = 3;
            this.btn2.Text = "2";
            this.btn2.UseVisualStyleBackColor = false;
            this.btn2.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btn_MouseClick);
            // 
            // btn3
            // 
            this.btn3.BackColor = System.Drawing.Color.Transparent;
            this.btn3.Location = new System.Drawing.Point(151, 56);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(37, 34);
            this.btn3.TabIndex = 4;
            this.btn3.Text = "3";
            this.btn3.UseVisualStyleBackColor = false;
            this.btn3.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btn_MouseClick);
            // 
            // btnC
            // 
            this.btnC.BackColor = System.Drawing.Color.Yellow;
            this.btnC.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnC.ForeColor = System.Drawing.Color.Lime;
            this.btnC.Location = new System.Drawing.Point(194, 56);
            this.btnC.Name = "btnC";
            this.btnC.Size = new System.Drawing.Size(37, 34);
            this.btnC.TabIndex = 5;
            this.btnC.Text = "C";
            this.btnC.UseVisualStyleBackColor = false;
            this.btnC.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnC_MouseClick);
            // 
            // btn4
            // 
            this.btn4.BackColor = System.Drawing.Color.Transparent;
            this.btn4.Location = new System.Drawing.Point(63, 96);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(37, 34);
            this.btn4.TabIndex = 6;
            this.btn4.Text = "4";
            this.btn4.UseVisualStyleBackColor = false;
            this.btn4.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btn_MouseClick);
            // 
            // btn5
            // 
            this.btn5.BackColor = System.Drawing.Color.Transparent;
            this.btn5.Location = new System.Drawing.Point(106, 96);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(37, 34);
            this.btn5.TabIndex = 7;
            this.btn5.Text = "5";
            this.btn5.UseVisualStyleBackColor = false;
            this.btn5.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btn_MouseClick);
            // 
            // btn6
            // 
            this.btn6.BackColor = System.Drawing.Color.Transparent;
            this.btn6.Location = new System.Drawing.Point(151, 96);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(37, 34);
            this.btn6.TabIndex = 8;
            this.btn6.Text = "6";
            this.btn6.UseVisualStyleBackColor = false;
            this.btn6.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btn_MouseClick);
            // 
            // btnEnter
            // 
            this.btnEnter.BackColor = System.Drawing.Color.DarkGray;
            this.btnEnter.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnter.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnEnter.Location = new System.Drawing.Point(194, 96);
            this.btnEnter.Name = "btnEnter";
            this.btnEnter.Size = new System.Drawing.Size(37, 34);
            this.btnEnter.TabIndex = 9;
            this.btnEnter.Text = "#";
            this.btnEnter.UseVisualStyleBackColor = false;
            this.btnEnter.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnEnter_MouseClick);
            // 
            // btn7
            // 
            this.btn7.BackColor = System.Drawing.Color.Transparent;
            this.btn7.Location = new System.Drawing.Point(63, 136);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(37, 34);
            this.btn7.TabIndex = 10;
            this.btn7.Text = "7";
            this.btn7.UseVisualStyleBackColor = false;
            this.btn7.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btn_MouseClick);
            // 
            // btn8
            // 
            this.btn8.BackColor = System.Drawing.Color.Transparent;
            this.btn8.Location = new System.Drawing.Point(106, 136);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(37, 34);
            this.btn8.TabIndex = 11;
            this.btn8.Text = "8";
            this.btn8.UseVisualStyleBackColor = false;
            this.btn8.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btn_MouseClick);
            // 
            // btn0
            // 
            this.btn0.BackColor = System.Drawing.Color.Transparent;
            this.btn0.Location = new System.Drawing.Point(194, 136);
            this.btn0.Name = "btn0";
            this.btn0.Size = new System.Drawing.Size(37, 34);
            this.btn0.TabIndex = 13;
            this.btn0.Text = "0";
            this.btn0.UseVisualStyleBackColor = false;
            this.btn0.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btn_MouseClick);
            // 
            // btn9
            // 
            this.btn9.BackColor = System.Drawing.Color.Transparent;
            this.btn9.Location = new System.Drawing.Point(151, 136);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(37, 34);
            this.btn9.TabIndex = 14;
            this.btn9.Text = "9";
            this.btn9.UseVisualStyleBackColor = false;
            this.btn9.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btn_MouseClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 184);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Access log:";
            // 
            // txtLog
            // 
            this.txtLog.FormattingEnabled = true;
            this.txtLog.Location = new System.Drawing.Point(18, 201);
            this.txtLog.Name = "txtLog";
            this.txtLog.Size = new System.Drawing.Size(244, 134);
            this.txtLog.TabIndex = 16;
            // 
            // frmSecurity
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(291, 347);
            this.Controls.Add(this.txtLog);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn9);
            this.Controls.Add(this.btn0);
            this.Controls.Add(this.btn8);
            this.Controls.Add(this.btn7);
            this.Controls.Add(this.btnEnter);
            this.Controls.Add(this.btn6);
            this.Controls.Add(this.btn5);
            this.Controls.Add(this.btn4);
            this.Controls.Add(this.btnC);
            this.Controls.Add(this.btn3);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.txtCode);
            this.Controls.Add(this.label1);
            this.KeyPreview = true;
            this.Name = "frmSecurity";
            this.Text = "Security Panel";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmSecurity_Down);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCode;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btnC;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Button btn6;
        private System.Windows.Forms.Button btnEnter;
        private System.Windows.Forms.Button btn7;
        private System.Windows.Forms.Button btn8;
        private System.Windows.Forms.Button btn0;
        private System.Windows.Forms.Button btn9;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox txtLog;
    }
}