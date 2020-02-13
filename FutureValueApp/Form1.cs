using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FutureValueApp
{
  public partial class Form1 : Form
  {
    public Form1()
    {
      InitializeComponent();
    }

    private void btnCalc_Click(object sender, EventArgs e)
    {
      // Data validation
      bool validMonthly = Double.TryParse(txtMonthlyInvest.Text, out double monthlyInvest);
      bool validYearly = Double.TryParse(txtYearlyInterst.Text, out double yearlyInterest);
      bool validNumYears = int.TryParse(txtNumYears.Text, out int numYears);

      if (validMonthly && validYearly && validNumYears)
      {
        // Convert to months
        int months = numYears * 12;
        double monthlyInterest = yearlyInterest / 12 / 100;

        double futureValue = calcFutureValue(months, monthlyInvest, monthlyInterest);

        // Share the data with the user
        txtFutureValue.Text = futureValue.ToString("c");
        txtMonthlyInvest.Focus();
      }
      else
      {
        MessageBox.Show("Please put in numbers for all the boxes.");
      }
    }

    private double calcFutureValue(int months, double monthlyInvest, double monthlyInterest)
    {
      // preform the caculation one time for every month
      double futureValue = 0;
      for (int i = 0; i < months; i++)
      {
        futureValue = (futureValue + monthlyInvest) * (1 + monthlyInterest);
      }
      return futureValue;
    }

    private void btnExit_Click(object sender, EventArgs e)
    {
      this.Close();
    }

    private void ClearFutureValue(object sender, EventArgs e)
    {
      // It clear the value
      txtFutureValue.Text = "";
    }

    private void ClearAllText(object sender, EventArgs e)
    {
      ClearAll();
    }

    private void ClearAll()
    {
      // It clear ALL the value
      txtFutureValue.Text = "";
      txtMonthlyInvest.Text = "";
      txtNumYears.Text = "";
      txtYearlyInterst.Text = "";
    }

    private void SetToTwelve(object sender, MouseEventArgs e)
    {
      // Make it 12. Why? Why not?
      txtYearlyInterst.Text = 12.ToString();
    }

    private void YouShouldntHaveDoneThat(object sender, EventArgs e)
    {
      // You Shouldn't Have Done That.
      while (true){
      }
    }
  }
}
