namespace TimedMathQuiz
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
            this.btnStart = new System.Windows.Forms.Button();
            this.lblTimeRemaining = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblMinusRight = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblMinusLeft = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblTimesRight = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lblTimesLeft = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.lblDivideRight = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.lblDivideLeft = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.lblDate = new System.Windows.Forms.Label();
            this.pnl1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.lblPlusRight = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblPlusLeft = new System.Windows.Forms.Label();
            this.pnl2 = new System.Windows.Forms.Panel();
            this.pnl3 = new System.Windows.Forms.Panel();
            this.pnl4 = new System.Windows.Forms.Panel();
            this.tbSum = new System.Windows.Forms.TextBox();
            this.tbDifference = new System.Windows.Forms.TextBox();
            this.tbProduct = new System.Windows.Forms.TextBox();
            this.tbQuotient = new System.Windows.Forms.TextBox();
            this.btnCheckAnswer = new System.Windows.Forms.Button();
            this.pnl1.SuspendLayout();
            this.pnl2.SuspendLayout();
            this.pnl3.SuspendLayout();
            this.pnl4.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnStart
            // 
            this.btnStart.AutoSize = true;
            this.btnStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.Location = new System.Drawing.Point(366, 404);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(100, 34);
            this.btnStart.TabIndex = 1;
            this.btnStart.Text = "Start Quiz";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // lblTimeRemaining
            // 
            this.lblTimeRemaining.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTimeRemaining.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimeRemaining.Location = new System.Drawing.Point(588, 9);
            this.lblTimeRemaining.Name = "lblTimeRemaining";
            this.lblTimeRemaining.Size = new System.Drawing.Size(200, 30);
            this.lblTimeRemaining.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(382, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(200, 30);
            this.label1.TabIndex = 2;
            this.label1.Text = "Time Remaining";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(209, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 50);
            this.label3.TabIndex = 11;
            this.label3.Text = "=";
            // 
            // lblMinusRight
            // 
            this.lblMinusRight.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMinusRight.Location = new System.Drawing.Point(143, 13);
            this.lblMinusRight.Name = "lblMinusRight";
            this.lblMinusRight.Size = new System.Drawing.Size(60, 50);
            this.lblMinusRight.TabIndex = 10;
            this.lblMinusRight.Text = "?";
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(77, 13);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 50);
            this.label6.TabIndex = 9;
            this.label6.Text = "-";
            // 
            // lblMinusLeft
            // 
            this.lblMinusLeft.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMinusLeft.Location = new System.Drawing.Point(11, 13);
            this.lblMinusLeft.Name = "lblMinusLeft";
            this.lblMinusLeft.Size = new System.Drawing.Size(60, 50);
            this.lblMinusLeft.TabIndex = 8;
            this.lblMinusLeft.Text = "?";
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(210, 15);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(60, 50);
            this.label8.TabIndex = 16;
            this.label8.Text = "=";
            // 
            // lblTimesRight
            // 
            this.lblTimesRight.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimesRight.Location = new System.Drawing.Point(144, 15);
            this.lblTimesRight.Name = "lblTimesRight";
            this.lblTimesRight.Size = new System.Drawing.Size(60, 50);
            this.lblTimesRight.TabIndex = 15;
            this.lblTimesRight.Text = "?";
            // 
            // label10
            // 
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(78, 15);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(60, 50);
            this.label10.TabIndex = 14;
            this.label10.Text = "*";
            // 
            // lblTimesLeft
            // 
            this.lblTimesLeft.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimesLeft.Location = new System.Drawing.Point(12, 15);
            this.lblTimesLeft.Name = "lblTimesLeft";
            this.lblTimesLeft.Size = new System.Drawing.Size(60, 50);
            this.lblTimesLeft.TabIndex = 13;
            this.lblTimesLeft.Text = "?";
            // 
            // label12
            // 
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(209, 15);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(60, 50);
            this.label12.TabIndex = 21;
            this.label12.Text = "=";
            // 
            // lblDivideRight
            // 
            this.lblDivideRight.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDivideRight.Location = new System.Drawing.Point(143, 15);
            this.lblDivideRight.Name = "lblDivideRight";
            this.lblDivideRight.Size = new System.Drawing.Size(60, 50);
            this.lblDivideRight.TabIndex = 20;
            this.lblDivideRight.Text = "?";
            // 
            // label14
            // 
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(77, 15);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(60, 50);
            this.label14.TabIndex = 19;
            this.label14.Text = "/";
            // 
            // lblDivideLeft
            // 
            this.lblDivideLeft.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDivideLeft.Location = new System.Drawing.Point(11, 15);
            this.lblDivideLeft.Name = "lblDivideLeft";
            this.lblDivideLeft.Size = new System.Drawing.Size(60, 50);
            this.lblDivideLeft.TabIndex = 18;
            this.lblDivideLeft.Text = "?";
            // 
            // timer
            // 
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.Location = new System.Drawing.Point(12, 9);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(79, 29);
            this.lblDate.TabIndex = 22;
            this.lblDate.Text = "label5";
            // 
            // pnl1
            // 
            this.pnl1.Controls.Add(this.label4);
            this.pnl1.Controls.Add(this.lblPlusRight);
            this.pnl1.Controls.Add(this.label2);
            this.pnl1.Controls.Add(this.lblPlusLeft);
            this.pnl1.Controls.Add(this.tbSum);
            this.pnl1.Location = new System.Drawing.Point(52, 59);
            this.pnl1.Name = "pnl1";
            this.pnl1.Size = new System.Drawing.Size(471, 80);
            this.pnl1.TabIndex = 23;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(209, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 50);
            this.label4.TabIndex = 11;
            this.label4.Text = "=";
            // 
            // lblPlusRight
            // 
            this.lblPlusRight.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlusRight.Location = new System.Drawing.Point(143, 15);
            this.lblPlusRight.Name = "lblPlusRight";
            this.lblPlusRight.Size = new System.Drawing.Size(60, 50);
            this.lblPlusRight.TabIndex = 10;
            this.lblPlusRight.Text = "?";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(77, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 50);
            this.label2.TabIndex = 9;
            this.label2.Text = "+";
            // 
            // lblPlusLeft
            // 
            this.lblPlusLeft.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlusLeft.Location = new System.Drawing.Point(11, 15);
            this.lblPlusLeft.Name = "lblPlusLeft";
            this.lblPlusLeft.Size = new System.Drawing.Size(60, 50);
            this.lblPlusLeft.TabIndex = 8;
            this.lblPlusLeft.Text = "?";
            // 
            // pnl2
            // 
            this.pnl2.Controls.Add(this.lblMinusLeft);
            this.pnl2.Controls.Add(this.label6);
            this.pnl2.Controls.Add(this.lblMinusRight);
            this.pnl2.Controls.Add(this.tbDifference);
            this.pnl2.Controls.Add(this.label3);
            this.pnl2.Location = new System.Drawing.Point(52, 145);
            this.pnl2.Name = "pnl2";
            this.pnl2.Size = new System.Drawing.Size(471, 80);
            this.pnl2.TabIndex = 24;
            // 
            // pnl3
            // 
            this.pnl3.Controls.Add(this.lblTimesLeft);
            this.pnl3.Controls.Add(this.label10);
            this.pnl3.Controls.Add(this.tbProduct);
            this.pnl3.Controls.Add(this.lblTimesRight);
            this.pnl3.Controls.Add(this.label8);
            this.pnl3.Location = new System.Drawing.Point(52, 231);
            this.pnl3.Name = "pnl3";
            this.pnl3.Size = new System.Drawing.Size(471, 80);
            this.pnl3.TabIndex = 25;
            // 
            // pnl4
            // 
            this.pnl4.Controls.Add(this.lblDivideLeft);
            this.pnl4.Controls.Add(this.tbQuotient);
            this.pnl4.Controls.Add(this.label14);
            this.pnl4.Controls.Add(this.lblDivideRight);
            this.pnl4.Controls.Add(this.label12);
            this.pnl4.Location = new System.Drawing.Point(52, 317);
            this.pnl4.Name = "pnl4";
            this.pnl4.Size = new System.Drawing.Size(471, 80);
            this.pnl4.TabIndex = 25;
            // 
            // tbSum
            // 
            this.tbSum.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSum.Location = new System.Drawing.Point(275, 12);
            this.tbSum.Name = "tbSum";
            this.tbSum.Size = new System.Drawing.Size(150, 35);
            this.tbSum.TabIndex = 3;
            this.tbSum.Text = "0";
            // 
            // tbDifference
            // 
            this.tbDifference.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbDifference.Location = new System.Drawing.Point(275, 14);
            this.tbDifference.Name = "tbDifference";
            this.tbDifference.Size = new System.Drawing.Size(150, 35);
            this.tbDifference.TabIndex = 4;
            this.tbDifference.Text = "0";
            // 
            // tbProduct
            // 
            this.tbProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbProduct.Location = new System.Drawing.Point(275, 15);
            this.tbProduct.Name = "tbProduct";
            this.tbProduct.Size = new System.Drawing.Size(150, 35);
            this.tbProduct.TabIndex = 5;
            this.tbProduct.Text = "0";
            // 
            // tbQuotient
            // 
            this.tbQuotient.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbQuotient.Location = new System.Drawing.Point(275, 12);
            this.tbQuotient.Name = "tbQuotient";
            this.tbQuotient.Size = new System.Drawing.Size(150, 35);
            this.tbQuotient.TabIndex = 6;
            this.tbQuotient.Text = "0";
            // 
            // btnCheckAnswer
            // 
            this.btnCheckAnswer.Location = new System.Drawing.Point(529, 217);
            this.btnCheckAnswer.Name = "btnCheckAnswer";
            this.btnCheckAnswer.Size = new System.Drawing.Size(94, 23);
            this.btnCheckAnswer.TabIndex = 2;
            this.btnCheckAnswer.Text = "Check Answer";
            this.btnCheckAnswer.UseVisualStyleBackColor = true;
            this.btnCheckAnswer.Click += new System.EventHandler(this.enterNext);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCheckAnswer);
            this.Controls.Add(this.pnl4);
            this.Controls.Add(this.pnl3);
            this.Controls.Add(this.pnl2);
            this.Controls.Add(this.pnl1);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblTimeRemaining);
            this.Controls.Add(this.btnStart);
            this.Name = "Form1";
            this.Text = "Alex Nielson Math Quiz";
            this.pnl1.ResumeLayout(false);
            this.pnl1.PerformLayout();
            this.pnl2.ResumeLayout(false);
            this.pnl2.PerformLayout();
            this.pnl3.ResumeLayout(false);
            this.pnl3.PerformLayout();
            this.pnl4.ResumeLayout(false);
            this.pnl4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Label lblTimeRemaining;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblMinusRight;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblMinusLeft;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblTimesRight;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lblTimesLeft;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lblDivideRight;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label lblDivideLeft;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Panel pnl1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblPlusRight;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblPlusLeft;
        private System.Windows.Forms.Panel pnl2;
        private System.Windows.Forms.Panel pnl3;
        private System.Windows.Forms.Panel pnl4;
        private System.Windows.Forms.TextBox tbSum;
        private System.Windows.Forms.TextBox tbDifference;
        private System.Windows.Forms.TextBox tbProduct;
        private System.Windows.Forms.TextBox tbQuotient;
        private System.Windows.Forms.Button btnCheckAnswer;
    }
}

