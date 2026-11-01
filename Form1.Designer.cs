namespace StudentMarksCalculator
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
            this.lblName = new System.Windows.Forms.Label();
            this.lblSubject1 = new System.Windows.Forms.Label();
            this.lblSubject2 = new System.Windows.Forms.Label();
            this.lblSuject3 = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblAverage = new System.Windows.Forms.Label();
            this.lblResult = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtSubject1 = new System.Windows.Forms.TextBox();
            this.txtSubject2 = new System.Windows.Forms.TextBox();
            this.txtSubject3 = new System.Windows.Forms.TextBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(27, 25);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(112, 20);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Student Name";
            // 
            // lblSubject1
            // 
            this.lblSubject1.AutoSize = true;
            this.lblSubject1.Location = new System.Drawing.Point(27, 72);
            this.lblSubject1.Name = "lblSubject1";
            this.lblSubject1.Size = new System.Drawing.Size(123, 20);
            this.lblSubject1.TabIndex = 1;
            this.lblSubject1.Text = "Subject 1 marks";
            // 
            // lblSubject2
            // 
            this.lblSubject2.AutoSize = true;
            this.lblSubject2.Location = new System.Drawing.Point(27, 117);
            this.lblSubject2.Name = "lblSubject2";
            this.lblSubject2.Size = new System.Drawing.Size(123, 20);
            this.lblSubject2.TabIndex = 2;
            this.lblSubject2.Text = "Subject 2 marks";
            // 
            // lblSuject3
            // 
            this.lblSuject3.AutoSize = true;
            this.lblSuject3.Location = new System.Drawing.Point(27, 157);
            this.lblSuject3.Name = "lblSuject3";
            this.lblSuject3.Size = new System.Drawing.Size(123, 20);
            this.lblSuject3.TabIndex = 3;
            this.lblSuject3.Text = "Subject 3 marks";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(27, 288);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(48, 20);
            this.lblTotal.TabIndex = 4;
            this.lblTotal.Text = "Total:";
            // 
            // lblAverage
            // 
            this.lblAverage.AutoSize = true;
            this.lblAverage.Location = new System.Drawing.Point(27, 327);
            this.lblAverage.Name = "lblAverage";
            this.lblAverage.Size = new System.Drawing.Size(72, 20);
            this.lblAverage.TabIndex = 5;
            this.lblAverage.Text = "Average:";
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Location = new System.Drawing.Point(27, 367);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(59, 20);
            this.lblResult.TabIndex = 6;
            this.lblResult.Text = "Result:";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(203, 25);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(327, 26);
            this.txtName.TabIndex = 7;
            // 
            // txtSubject1
            // 
            this.txtSubject1.Location = new System.Drawing.Point(203, 72);
            this.txtSubject1.Name = "txtSubject1";
            this.txtSubject1.Size = new System.Drawing.Size(100, 26);
            this.txtSubject1.TabIndex = 8;
            // 
            // txtSubject2
            // 
            this.txtSubject2.Location = new System.Drawing.Point(203, 111);
            this.txtSubject2.Name = "txtSubject2";
            this.txtSubject2.Size = new System.Drawing.Size(100, 26);
            this.txtSubject2.TabIndex = 9;
            // 
            // txtSubject3
            // 
            this.txtSubject3.Location = new System.Drawing.Point(203, 154);
            this.txtSubject3.Name = "txtSubject3";
            this.txtSubject3.Size = new System.Drawing.Size(100, 26);
            this.txtSubject3.TabIndex = 10;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(114, 225);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(100, 41);
            this.btnCalculate.TabIndex = 11;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(291, 225);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(100, 41);
            this.btnClear.TabIndex = 12;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.txtSubject3);
            this.Controls.Add(this.txtSubject2);
            this.Controls.Add(this.txtSubject1);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.lblAverage);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.lblSuject3);
            this.Controls.Add(this.lblSubject2);
            this.Controls.Add(this.lblSubject1);
            this.Controls.Add(this.lblName);
            this.Name = "Form1";
            this.Text = "Student Marks Calculator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblSubject1;
        private System.Windows.Forms.Label lblSubject2;
        private System.Windows.Forms.Label lblSuject3;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblAverage;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtSubject1;
        private System.Windows.Forms.TextBox txtSubject2;
        private System.Windows.Forms.TextBox txtSubject3;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Button btnClear;
    }
}

