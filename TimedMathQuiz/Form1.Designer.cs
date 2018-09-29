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
            this.lblPlusLeft = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblPlusRight = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.nudSum = new System.Windows.Forms.NumericUpDown();
            this.nudDifference = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.lblMinusRight = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblMinusLeft = new System.Windows.Forms.Label();
            this.nudProduct = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.lblTimesRight = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lblTimesLeft = new System.Windows.Forms.Label();
            this.nudQuotient = new System.Windows.Forms.NumericUpDown();
            this.label12 = new System.Windows.Forms.Label();
            this.lblDivideRight = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.lblDivideLeft = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.nudSum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDifference)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudProduct)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudQuotient)).BeginInit();
            this.SuspendLayout();
            // 
            // btnStart
            // 
            this.btnStart.AutoSize = true;
            this.btnStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.Location = new System.Drawing.Point(342, 344);
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
            // lblPlusLeft
            // 
            this.lblPlusLeft.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlusLeft.Location = new System.Drawing.Point(63, 103);
            this.lblPlusLeft.Name = "lblPlusLeft";
            this.lblPlusLeft.Size = new System.Drawing.Size(60, 50);
            this.lblPlusLeft.TabIndex = 3;
            this.lblPlusLeft.Text = "?";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(129, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 50);
            this.label2.TabIndex = 4;
            this.label2.Text = "+";
            // 
            // lblPlusRight
            // 
            this.lblPlusRight.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlusRight.Location = new System.Drawing.Point(195, 103);
            this.lblPlusRight.Name = "lblPlusRight";
            this.lblPlusRight.Size = new System.Drawing.Size(60, 50);
            this.lblPlusRight.TabIndex = 5;
            this.lblPlusRight.Text = "?";
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(261, 103);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 50);
            this.label4.TabIndex = 6;
            this.label4.Text = "=";
            // 
            // nudSum
            // 
            this.nudSum.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudSum.Location = new System.Drawing.Point(327, 103);
            this.nudSum.Name = "nudSum";
            this.nudSum.Size = new System.Drawing.Size(100, 35);
            this.nudSum.TabIndex = 2;
            this.nudSum.Enter += new System.EventHandler(this.enterAnswer);
            // 
            // nudDifference
            // 
            this.nudDifference.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudDifference.Location = new System.Drawing.Point(327, 144);
            this.nudDifference.Name = "nudDifference";
            this.nudDifference.Size = new System.Drawing.Size(100, 35);
            this.nudDifference.TabIndex = 3;
            this.nudDifference.Enter += new System.EventHandler(this.enterAnswer);
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(261, 144);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 50);
            this.label3.TabIndex = 11;
            this.label3.Text = "=";
            // 
            // lblMinusRight
            // 
            this.lblMinusRight.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMinusRight.Location = new System.Drawing.Point(195, 144);
            this.lblMinusRight.Name = "lblMinusRight";
            this.lblMinusRight.Size = new System.Drawing.Size(60, 50);
            this.lblMinusRight.TabIndex = 10;
            this.lblMinusRight.Text = "?";
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(129, 144);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 50);
            this.label6.TabIndex = 9;
            this.label6.Text = "-";
            // 
            // lblMinusLeft
            // 
            this.lblMinusLeft.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMinusLeft.Location = new System.Drawing.Point(63, 144);
            this.lblMinusLeft.Name = "lblMinusLeft";
            this.lblMinusLeft.Size = new System.Drawing.Size(60, 50);
            this.lblMinusLeft.TabIndex = 8;
            this.lblMinusLeft.Text = "?";
            // 
            // nudProduct
            // 
            this.nudProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudProduct.Location = new System.Drawing.Point(327, 185);
            this.nudProduct.Name = "nudProduct";
            this.nudProduct.Size = new System.Drawing.Size(100, 35);
            this.nudProduct.TabIndex = 4;
            this.nudProduct.Enter += new System.EventHandler(this.enterAnswer);
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(261, 185);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(60, 50);
            this.label8.TabIndex = 16;
            this.label8.Text = "=";
            // 
            // lblTimesRight
            // 
            this.lblTimesRight.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimesRight.Location = new System.Drawing.Point(195, 185);
            this.lblTimesRight.Name = "lblTimesRight";
            this.lblTimesRight.Size = new System.Drawing.Size(60, 50);
            this.lblTimesRight.TabIndex = 15;
            this.lblTimesRight.Text = "?";
            // 
            // label10
            // 
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(129, 185);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(60, 50);
            this.label10.TabIndex = 14;
            this.label10.Text = "*";
            // 
            // lblTimesLeft
            // 
            this.lblTimesLeft.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimesLeft.Location = new System.Drawing.Point(63, 185);
            this.lblTimesLeft.Name = "lblTimesLeft";
            this.lblTimesLeft.Size = new System.Drawing.Size(60, 50);
            this.lblTimesLeft.TabIndex = 13;
            this.lblTimesLeft.Text = "?";
            // 
            // nudQuotient
            // 
            this.nudQuotient.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudQuotient.Location = new System.Drawing.Point(327, 226);
            this.nudQuotient.Name = "nudQuotient";
            this.nudQuotient.Size = new System.Drawing.Size(100, 35);
            this.nudQuotient.TabIndex = 5;
            this.nudQuotient.Enter += new System.EventHandler(this.enterAnswer);
            // 
            // label12
            // 
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(261, 226);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(60, 50);
            this.label12.TabIndex = 21;
            this.label12.Text = "=";
            // 
            // lblDivideRight
            // 
            this.lblDivideRight.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDivideRight.Location = new System.Drawing.Point(195, 226);
            this.lblDivideRight.Name = "lblDivideRight";
            this.lblDivideRight.Size = new System.Drawing.Size(60, 50);
            this.lblDivideRight.TabIndex = 20;
            this.lblDivideRight.Text = "?";
            // 
            // label14
            // 
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(129, 226);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(60, 50);
            this.label14.TabIndex = 19;
            this.label14.Text = "/";
            // 
            // lblDivideLeft
            // 
            this.lblDivideLeft.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDivideLeft.Location = new System.Drawing.Point(63, 226);
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.nudQuotient);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.lblDivideRight);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.lblDivideLeft);
            this.Controls.Add(this.nudProduct);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lblTimesRight);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.lblTimesLeft);
            this.Controls.Add(this.nudDifference);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblMinusRight);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblMinusLeft);
            this.Controls.Add(this.nudSum);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblPlusRight);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblPlusLeft);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblTimeRemaining);
            this.Controls.Add(this.btnStart);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.nudSum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDifference)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudProduct)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudQuotient)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Label lblTimeRemaining;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblPlusLeft;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblPlusRight;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown nudSum;
        private System.Windows.Forms.NumericUpDown nudDifference;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblMinusRight;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblMinusLeft;
        private System.Windows.Forms.NumericUpDown nudProduct;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblTimesRight;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lblTimesLeft;
        private System.Windows.Forms.NumericUpDown nudQuotient;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lblDivideRight;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label lblDivideLeft;
        private System.Windows.Forms.Timer timer;
    }
}

