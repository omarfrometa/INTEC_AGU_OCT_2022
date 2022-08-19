namespace WindowsFormsApp1
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblTime = new System.Windows.Forms.Label();
            this.txtTimeLeft = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblAddend1 = new System.Windows.Forms.Label();
            this.lblAddend2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtAddenResult = new System.Windows.Forms.TextBox();
            this.txtMinuendResult = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lblMinuend2 = new System.Windows.Forms.Label();
            this.lblMinuend1 = new System.Windows.Forms.Label();
            this.txtMultiplicandResult = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.lblMultiplicand2 = new System.Windows.Forms.Label();
            this.lblMultiplicand1 = new System.Windows.Forms.Label();
            this.txtDividendResult = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.lblDividend2 = new System.Windows.Forms.Label();
            this.lblDividend1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lblDividendResult = new System.Windows.Forms.Label();
            this.lblMultiplicandResult = new System.Windows.Forms.Label();
            this.lblMinuendResult = new System.Windows.Forms.Label();
            this.lblAddResult = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(175, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(476, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "EXAMEN DE MATEMATICAS";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WindowsFormsApp1.Properties.Resources.intec_logo;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(157, 163);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.Location = new System.Drawing.Point(179, 51);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(66, 25);
            this.lblTime.TabIndex = 2;
            this.lblTime.Text = "label2";
            // 
            // txtTimeLeft
            // 
            this.txtTimeLeft.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTimeLeft.HideSelection = false;
            this.txtTimeLeft.Location = new System.Drawing.Point(343, 103);
            this.txtTimeLeft.Name = "txtTimeLeft";
            this.txtTimeLeft.ReadOnly = true;
            this.txtTimeLeft.Size = new System.Drawing.Size(299, 30);
            this.txtTimeLeft.TabIndex = 3;
            this.txtTimeLeft.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(340, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Tiempo Restante:";
            // 
            // btnStart
            // 
            this.btnStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.ForeColor = System.Drawing.Color.Green;
            this.btnStart.Location = new System.Drawing.Point(343, 147);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(101, 28);
            this.btnStart.TabIndex = 5;
            this.btnStart.Text = "Iniciar";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnStop
            // 
            this.btnStop.Enabled = false;
            this.btnStop.ForeColor = System.Drawing.Color.Red;
            this.btnStop.Location = new System.Drawing.Point(535, 147);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(107, 28);
            this.btnStop.TabIndex = 6;
            this.btnStop.Text = "Detener";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblDividendResult);
            this.groupBox1.Controls.Add(this.lblMultiplicandResult);
            this.groupBox1.Controls.Add(this.lblMinuendResult);
            this.groupBox1.Controls.Add(this.lblAddResult);
            this.groupBox1.Controls.Add(this.txtDividendResult);
            this.groupBox1.Controls.Add(this.label16);
            this.groupBox1.Controls.Add(this.label17);
            this.groupBox1.Controls.Add(this.lblDividend2);
            this.groupBox1.Controls.Add(this.lblDividend1);
            this.groupBox1.Controls.Add(this.txtMultiplicandResult);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.lblMultiplicand2);
            this.groupBox1.Controls.Add(this.lblMultiplicand1);
            this.groupBox1.Controls.Add(this.txtMinuendResult);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.lblMinuend2);
            this.groupBox1.Controls.Add(this.lblMinuend1);
            this.groupBox1.Controls.Add(this.txtAddenResult);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.lblAddend2);
            this.groupBox1.Controls.Add(this.lblAddend1);
            this.groupBox1.Location = new System.Drawing.Point(12, 215);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(630, 343);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "EXAMEN";
            // 
            // lblAddend1
            // 
            this.lblAddend1.AutoSize = true;
            this.lblAddend1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddend1.Location = new System.Drawing.Point(18, 57);
            this.lblAddend1.Name = "lblAddend1";
            this.lblAddend1.Size = new System.Drawing.Size(29, 31);
            this.lblAddend1.TabIndex = 0;
            this.lblAddend1.Text = "?";
            this.lblAddend1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblAddend2
            // 
            this.lblAddend2.AutoSize = true;
            this.lblAddend2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddend2.Location = new System.Drawing.Point(250, 61);
            this.lblAddend2.Name = "lblAddend2";
            this.lblAddend2.Size = new System.Drawing.Size(29, 31);
            this.lblAddend2.TabIndex = 1;
            this.lblAddend2.Text = "?";
            this.lblAddend2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(128, 61);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(30, 31);
            this.label6.TabIndex = 2;
            this.label6.Text = "+";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(353, 61);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(30, 31);
            this.label7.TabIndex = 3;
            this.label7.Text = "=";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtAddenResult
            // 
            this.txtAddenResult.Enabled = false;
            this.txtAddenResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddenResult.Location = new System.Drawing.Point(452, 54);
            this.txtAddenResult.Name = "txtAddenResult";
            this.txtAddenResult.Size = new System.Drawing.Size(116, 38);
            this.txtAddenResult.TabIndex = 8;
            this.txtAddenResult.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtMinuendResult
            // 
            this.txtMinuendResult.Enabled = false;
            this.txtMinuendResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMinuendResult.Location = new System.Drawing.Point(452, 118);
            this.txtMinuendResult.Name = "txtMinuendResult";
            this.txtMinuendResult.Size = new System.Drawing.Size(116, 38);
            this.txtMinuendResult.TabIndex = 13;
            this.txtMinuendResult.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(353, 125);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(30, 31);
            this.label8.TabIndex = 12;
            this.label8.Text = "=";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(128, 125);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(23, 31);
            this.label9.TabIndex = 11;
            this.label9.Text = "-";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblMinuend2
            // 
            this.lblMinuend2.AutoSize = true;
            this.lblMinuend2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMinuend2.Location = new System.Drawing.Point(250, 125);
            this.lblMinuend2.Name = "lblMinuend2";
            this.lblMinuend2.Size = new System.Drawing.Size(29, 31);
            this.lblMinuend2.TabIndex = 10;
            this.lblMinuend2.Text = "?";
            this.lblMinuend2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblMinuend1
            // 
            this.lblMinuend1.AutoSize = true;
            this.lblMinuend1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMinuend1.Location = new System.Drawing.Point(18, 121);
            this.lblMinuend1.Name = "lblMinuend1";
            this.lblMinuend1.Size = new System.Drawing.Size(29, 31);
            this.lblMinuend1.TabIndex = 9;
            this.lblMinuend1.Text = "?";
            this.lblMinuend1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtMultiplicandResult
            // 
            this.txtMultiplicandResult.Enabled = false;
            this.txtMultiplicandResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMultiplicandResult.Location = new System.Drawing.Point(452, 187);
            this.txtMultiplicandResult.Name = "txtMultiplicandResult";
            this.txtMultiplicandResult.Size = new System.Drawing.Size(116, 38);
            this.txtMultiplicandResult.TabIndex = 18;
            this.txtMultiplicandResult.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(353, 194);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(30, 31);
            this.label12.TabIndex = 17;
            this.label12.Text = "=";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(128, 194);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(27, 31);
            this.label13.TabIndex = 16;
            this.label13.Text = "x";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblMultiplicand2
            // 
            this.lblMultiplicand2.AutoSize = true;
            this.lblMultiplicand2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMultiplicand2.Location = new System.Drawing.Point(250, 194);
            this.lblMultiplicand2.Name = "lblMultiplicand2";
            this.lblMultiplicand2.Size = new System.Drawing.Size(29, 31);
            this.lblMultiplicand2.TabIndex = 15;
            this.lblMultiplicand2.Text = "?";
            this.lblMultiplicand2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblMultiplicand1
            // 
            this.lblMultiplicand1.AutoSize = true;
            this.lblMultiplicand1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMultiplicand1.Location = new System.Drawing.Point(18, 190);
            this.lblMultiplicand1.Name = "lblMultiplicand1";
            this.lblMultiplicand1.Size = new System.Drawing.Size(29, 31);
            this.lblMultiplicand1.TabIndex = 14;
            this.lblMultiplicand1.Text = "?";
            this.lblMultiplicand1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtDividendResult
            // 
            this.txtDividendResult.Enabled = false;
            this.txtDividendResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDividendResult.Location = new System.Drawing.Point(452, 261);
            this.txtDividendResult.Name = "txtDividendResult";
            this.txtDividendResult.Size = new System.Drawing.Size(116, 38);
            this.txtDividendResult.TabIndex = 23;
            this.txtDividendResult.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(353, 268);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(30, 31);
            this.label16.TabIndex = 22;
            this.label16.Text = "=";
            this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(128, 264);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(22, 31);
            this.label17.TabIndex = 21;
            this.label17.Text = "/";
            this.label17.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDividend2
            // 
            this.lblDividend2.AutoSize = true;
            this.lblDividend2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDividend2.Location = new System.Drawing.Point(250, 268);
            this.lblDividend2.Name = "lblDividend2";
            this.lblDividend2.Size = new System.Drawing.Size(29, 31);
            this.lblDividend2.TabIndex = 20;
            this.lblDividend2.Text = "?";
            this.lblDividend2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDividend1
            // 
            this.lblDividend1.AutoSize = true;
            this.lblDividend1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDividend1.Location = new System.Drawing.Point(18, 264);
            this.lblDividend1.Name = "lblDividend1";
            this.lblDividend1.Size = new System.Drawing.Size(29, 31);
            this.lblDividend1.TabIndex = 19;
            this.lblDividend1.Text = "?";
            this.lblDividend1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lblDividendResult
            // 
            this.lblDividendResult.AutoSize = true;
            this.lblDividendResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDividendResult.Location = new System.Drawing.Point(583, 265);
            this.lblDividendResult.Name = "lblDividendResult";
            this.lblDividendResult.Size = new System.Drawing.Size(29, 31);
            this.lblDividendResult.TabIndex = 27;
            this.lblDividendResult.Text = "?";
            this.lblDividendResult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblDividendResult.Visible = false;
            // 
            // lblMultiplicandResult
            // 
            this.lblMultiplicandResult.AutoSize = true;
            this.lblMultiplicandResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMultiplicandResult.Location = new System.Drawing.Point(583, 191);
            this.lblMultiplicandResult.Name = "lblMultiplicandResult";
            this.lblMultiplicandResult.Size = new System.Drawing.Size(29, 31);
            this.lblMultiplicandResult.TabIndex = 26;
            this.lblMultiplicandResult.Text = "?";
            this.lblMultiplicandResult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblMultiplicandResult.Visible = false;
            // 
            // lblMinuendResult
            // 
            this.lblMinuendResult.AutoSize = true;
            this.lblMinuendResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMinuendResult.Location = new System.Drawing.Point(583, 125);
            this.lblMinuendResult.Name = "lblMinuendResult";
            this.lblMinuendResult.Size = new System.Drawing.Size(29, 31);
            this.lblMinuendResult.TabIndex = 25;
            this.lblMinuendResult.Text = "?";
            this.lblMinuendResult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblMinuendResult.Visible = false;
            // 
            // lblAddResult
            // 
            this.lblAddResult.AutoSize = true;
            this.lblAddResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddResult.Location = new System.Drawing.Point(583, 61);
            this.lblAddResult.Name = "lblAddResult";
            this.lblAddResult.Size = new System.Drawing.Size(29, 31);
            this.lblAddResult.TabIndex = 24;
            this.lblAddResult.Text = "?";
            this.lblAddResult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblAddResult.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(673, 568);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtTimeLeft);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.TextBox txtTimeLeft;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtAddenResult;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblAddend2;
        private System.Windows.Forms.Label lblAddend1;
        private System.Windows.Forms.TextBox txtDividendResult;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label lblDividend2;
        private System.Windows.Forms.Label lblDividend1;
        private System.Windows.Forms.TextBox txtMultiplicandResult;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label lblMultiplicand2;
        private System.Windows.Forms.Label lblMultiplicand1;
        private System.Windows.Forms.TextBox txtMinuendResult;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblMinuend2;
        private System.Windows.Forms.Label lblMinuend1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblDividendResult;
        private System.Windows.Forms.Label lblMultiplicandResult;
        private System.Windows.Forms.Label lblMinuendResult;
        private System.Windows.Forms.Label lblAddResult;
    }
}

