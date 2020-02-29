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
      // Data validation. 
      /*      try {
              try
              {
                try
                {*/
      if (validateData())
      {
        double monthlyInvest = Double.Parse(txtMonthlyInvest.Text);
        double yearlyInterest = Double.Parse(txtYearlyInterst.Text);
        int numYears = int.Parse(txtNumYears.Text);

        // Convert to months
        int months = numYears * 12;
        double monthlyInterest = yearlyInterest / 12 / 100;

        double futureValue = calcFutureValue(months, monthlyInvest, monthlyInterest);

        // Share the data with the user
        txtFutureValue.Text = futureValue.ToString("c");
        txtMonthlyInvest.Focus();
      }
            /*throw new Exception("Unknown Error That We Definately Didn't Code In Here Intentionally");
          }
          catch (OverflowException) {
            MessageBox.Show("Enter a smaller number", "Error");
          }
        }
        catch (FormatException) {
          MessageBox.Show("Please enter only numbers", "Error");
        }
      }
      catch (Exception ex)
      {
        MessageBox.Show(ex.Message + "\n" + ex.GetType() + "\n" + ex.StackTrace, "Error");
      } */
    }

    private bool validateData()
    {
      // checking the monthly invest field
      if(!IsPresent(txtMonthlyInvest.Text, "Monthly Investment") || !IsDecimal(txtMonthlyInvest.Text, "Monthly Investment") || !IsWithinRange(txtMonthlyInvest.Text, "Monthly Investment", 1, 1000))
      {
        return false;
      }
      // checking the yearly intrest field
      else if (!IsPresent(txtYearlyInterst.Text, "Yearly Invest Rate") || !IsDecimal(txtYearlyInterst.Text, "Yearly Invest Rate") || !IsWithinRange(txtYearlyInterst.Text, "Yearly Invest Rate", 1, 20))
      {
        return false;
      }
      // Checking the number of years field
      else if (!IsPresent(txtNumYears.Text, "Number of Years") || !IsDecimal(txtNumYears.Text, "Number of Years") || !IsWithinRange(txtNumYears.Text, "Number of Years", 0, 100))
      {
        return false;
      }
      else { return true; }
    }

    private bool IsPresent(string value, string field)
    {
      // Makes sure something is actually there.
      if (!String.IsNullOrWhiteSpace(value))
      {
        return true;
      }
      MessageBox.Show(field + " field is empty. Rectify this.");
      return false;
    }

    private bool IsDecimal(string value, string field)
    {
      // These all do exactally what they say on the tin and I ain't commenting them all.
      double Imnotusingthis;
      if (Double.TryParse(value, out Imnotusingthis))
      {
        return true;
      }
      MessageBox.Show(field + " field is not a number. Rectify this.");
      return false;
    }

    private bool IsInt32(string value, string field)
    {
      Int32 Imnotusingthis;
      if (Int32.TryParse(value, out Imnotusingthis))
      {
        return true;
      }
      MessageBox.Show(field + " field is not a whole number. Rectify this.");
      return false;
    }

    private bool IsWithinRange(string value, string field, decimal minValue, decimal maxValue)
    {
      decimal valueNum = Decimal.Parse(value);
      if (valueNum < minValue || valueNum > maxValue)
      {
        MessageBox.Show(field + " field is outside of range " + minValue.ToString()+ " - " + maxValue.ToString() + ". Rectify this.");
        return false;
      }
      return true;
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

  }
}
