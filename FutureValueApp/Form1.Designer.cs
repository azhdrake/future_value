namespace FutureValueApp
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
      this.txtMonthlyInvest = new System.Windows.Forms.TextBox();
      this.txtYearlyInterst = new System.Windows.Forms.TextBox();
      this.txtNumYears = new System.Windows.Forms.TextBox();
      this.txtFutureValue = new System.Windows.Forms.TextBox();
      this.btnCalc = new System.Windows.Forms.Button();
      this.btnExit = new System.Windows.Forms.Button();
      this.label1 = new System.Windows.Forms.Label();
      this.label2 = new System.Windows.Forms.Label();
      this.label3 = new System.Windows.Forms.Label();
      this.label4 = new System.Windows.Forms.Label();
      this.SuspendLayout();
      // 
      // txtMonthlyInvest
      // 
      this.txtMonthlyInvest.Location = new System.Drawing.Point(239, 32);
      this.txtMonthlyInvest.Name = "txtMonthlyInvest";
      this.txtMonthlyInvest.Size = new System.Drawing.Size(111, 31);
      this.txtMonthlyInvest.TabIndex = 0;
      this.txtMonthlyInvest.TextChanged += new System.EventHandler(this.ClearFutureValue);
      // 
      // txtYearlyInterst
      // 
      this.txtYearlyInterst.Location = new System.Drawing.Point(239, 100);
      this.txtYearlyInterst.Name = "txtYearlyInterst";
      this.txtYearlyInterst.Size = new System.Drawing.Size(111, 31);
      this.txtYearlyInterst.TabIndex = 1;
      this.txtYearlyInterst.TextChanged += new System.EventHandler(this.ClearFutureValue);
      // 
      // txtNumYears
      // 
      this.txtNumYears.Location = new System.Drawing.Point(239, 175);
      this.txtNumYears.Name = "txtNumYears";
      this.txtNumYears.Size = new System.Drawing.Size(111, 31);
      this.txtNumYears.TabIndex = 2;
      this.txtNumYears.TextChanged += new System.EventHandler(this.ClearFutureValue);
      // 
      // txtFutureValue
      // 
      this.txtFutureValue.Location = new System.Drawing.Point(239, 249);
      this.txtFutureValue.Name = "txtFutureValue";
      this.txtFutureValue.ReadOnly = true;
      this.txtFutureValue.Size = new System.Drawing.Size(111, 31);
      this.txtFutureValue.TabIndex = 3;
      this.txtFutureValue.TabStop = false;
      // 
      // btnCalc
      // 
      this.btnCalc.Location = new System.Drawing.Point(39, 323);
      this.btnCalc.Name = "btnCalc";
      this.btnCalc.Size = new System.Drawing.Size(111, 41);
      this.btnCalc.TabIndex = 4;
      this.btnCalc.Text = "&Calculate";
      this.btnCalc.UseVisualStyleBackColor = true;
      this.btnCalc.Click += new System.EventHandler(this.btnCalc_Click);
      // 
      // btnExit
      // 
      this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
      this.btnExit.Location = new System.Drawing.Point(239, 323);
      this.btnExit.Name = "btnExit";
      this.btnExit.Size = new System.Drawing.Size(111, 41);
      this.btnExit.TabIndex = 5;
      this.btnExit.Text = "E&xit";
      this.btnExit.UseVisualStyleBackColor = true;
      this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(34, 32);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(193, 25);
      this.label1.TabIndex = 6;
      this.label1.Text = "Monthy Investment";
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(34, 103);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(188, 25);
      this.label2.TabIndex = 7;
      this.label2.Text = "Yearly Invest Rate";
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Location = new System.Drawing.Point(34, 175);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(174, 25);
      this.label3.TabIndex = 8;
      this.label3.Text = "Number of Years";
      // 
      // label4
      // 
      this.label4.AutoSize = true;
      this.label4.Location = new System.Drawing.Point(34, 249);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(143, 25);
      this.label4.TabIndex = 9;
      this.label4.Text = "FutureValue™";
      // 
      // Form1
      // 
      this.AcceptButton = this.btnCalc;
      this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.CancelButton = this.btnExit;
      this.ClientSize = new System.Drawing.Size(387, 407);
      this.Controls.Add(this.label4);
      this.Controls.Add(this.label3);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.btnExit);
      this.Controls.Add(this.btnCalc);
      this.Controls.Add(this.txtFutureValue);
      this.Controls.Add(this.txtNumYears);
      this.Controls.Add(this.txtYearlyInterst);
      this.Controls.Add(this.txtMonthlyInvest);
      this.Name = "Form1";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "FutureValue™";
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.TextBox txtMonthlyInvest;
    private System.Windows.Forms.TextBox txtYearlyInterst;
    private System.Windows.Forms.TextBox txtNumYears;
    private System.Windows.Forms.TextBox txtFutureValue;
    private System.Windows.Forms.Button btnCalc;
    private System.Windows.Forms.Button btnExit;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.Label label4;
  }
}

