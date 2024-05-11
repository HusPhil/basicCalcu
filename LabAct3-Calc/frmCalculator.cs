using System;
using System.Windows.Forms;

namespace LabAct3_Calc
{
    public partial class frmCalculator : Form
    {
        private Entry entryHolder;

        public frmCalculator()
        {
            InitializeComponent();
            entryHolder = new Entry();
        }

        private void btnNum_Click(object sender, EventArgs e)
        {
            var btn = (Button)sender;

            if (txtInput.Text.Equals("0") || entryHolder.operation_Supplied || entryHolder.calculated)
            {
                txtInput.Clear();
                entryHolder.operation_Supplied = false;
                entryHolder.calculated = false;
            }

            if (btn.Text.Equals("."))
            {
                if (!txtInput.Text.Contains("."))
                {
                    txtInput.AppendText(string.IsNullOrWhiteSpace(txtInput.Text) ? "0" + btn.Text : btn.Text);
                }
            }
            else
            {
                txtInput.AppendText(btn.Text);
            }

            if (!entryHolder.operandA_Supplied)
            {
                entryHolder.operandA = double.Parse(txtInput.Text);
            }
            else
            {
                entryHolder.operandB = double.Parse(txtInput.Text);
            }
        }

        private void btnOperator_Click(object sender, EventArgs e)
        {
            var btn = (Button)sender;

            if (entryHolder.operandA_Supplied)
            {
                btnEqual.PerformClick();
            }

            entryHolder.operation = char.Parse(btn.Text);
            entryHolder.operandA_Supplied = true;
            lblEntry.Text = $"{entryHolder.operandA} {entryHolder.operation}";
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            entryHolder = new Entry();
            lblEntry.Text = "";
            txtInput.Text = "0";
            entryHolder.operandA_Supplied = false;
        }

        private void btnCE_Click(object sender, EventArgs e)
        {
            if (entryHolder.calculated)
            {
                lblEntry.Text = "";
                entryHolder.operandA = 0.0;
            }
            txtInput.Text = "0";
        }

        private void btnEqual_Click(object sender, EventArgs e)
        {
            Console.WriteLine(entryHolder.EntryToString());
            lblEntry.Text = $"{entryHolder.operandA} {entryHolder.operation} {entryHolder.operandB} = ";
            entryHolder.operandA_Supplied = false;
            entryHolder.calculated = true;

            try
            {
                txtInput.Text = calculateEntry(entryHolder).ToString();
                entryHolder.operandA = double.Parse(txtInput.Text.Contains(".") ? txtInput.Text : txtInput.Text + ".0");
            }
            catch (DivideByZeroException)
            {
                txtInput.Text = "Cannot divide by 0";
                lblEntry.Text = "";
            }
        }

        private double calculateEntry(Entry entry)
        {
            double result = 0;
            switch (entry.operation)
            {
                case '+':
                    result = entry.operandA + entry.operandB;
                    break;
                case '-':
                    result = entry.operandA - entry.operandB;
                    break;
                case '*':
                    result = entry.operandA * entry.operandB;
                    break;
                case '/':
                    if (entry.operandB == 0) throw new DivideByZeroException();
                    result = entry.operandA / entry.operandB;
                    break;
            }
            return result;
        }

        private void btnSquare_Click(object sender, EventArgs e)
        {
            double squaredValue = double.Parse(txtInput.Text) * double.Parse(txtInput.Text);
            txtInput.Text = squaredValue.ToString();

            if (!entryHolder.operandA_Supplied)
            {
                entryHolder.operandA = squaredValue;
            }
            else
            {
                entryHolder.operandB = squaredValue;
            }
        }

        private void fpnl_buttonsCont_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
