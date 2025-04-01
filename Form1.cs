using System;
using System.Windows.Forms;

namespace Pocitani
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            // Select the first operation by default
            if (cmbOperation.Items.Count > 0)
            {
                cmbOperation.SelectedIndex = 0;
            }
        }

        private void cmbOperation_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Disable second input for operations that only need one number
            string selectedOperation = cmbOperation.SelectedItem.ToString();
            bool requiresTwoNumbers = !(selectedOperation.Contains("Odmocnění") || selectedOperation.Contains("Faktoriál"));
            
            txtNum2.Enabled = requiresTwoNumbers;
            lblNum2.Enabled = requiresTwoNumbers;
            if (!requiresTwoNumbers)
            {
                txtNum2.Clear(); // Clear if disabled
            }
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            lblResult.Text = "-"; // Reset result label

            if (cmbOperation.SelectedItem == null)
            {
                MessageBox.Show("Prosím, vyberte operaci.", "Chyba", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string operation = cmbOperation.SelectedItem.ToString();
            bool requiresTwoNumbers = txtNum2.Enabled; // Check if second input is enabled

            // --- Input Validation ---
            if (!double.TryParse(txtNum1.Text, out double num1))
            {
                MessageBox.Show("Neplatný vstup pro první číslo.", "Chyba", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            double num2 = 0; // Default value
            if (requiresTwoNumbers)
            {
                if (!double.TryParse(txtNum2.Text, out num2))
                {
                    MessageBox.Show("Neplatný vstup pro druhé číslo.", "Chyba", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }

            // --- Calculation ---
            try
            {
                double result = 0;
                long factorialResult = 0; // For factorial
                bool isFactorial = false;

                switch (operation)
                {
                    case "Sčítání (+)":
                        result = num1 + num2;
                        break;
                    case "Odčítání (-)":
                        result = num1 - num2;
                        break;
                    case "Násobení (*)":
                        result = num1 * num2;
                        break;
                    case "Dělení (/)":
                        if (num2 == 0)
                        {
                            MessageBox.Show("Dělení nulou není povoleno.", "Chyba", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                        result = num1 / num2;
                        break;
                    case "Mocnění (^)":
                        result = Math.Pow(num1, num2);
                        break;
                    case "Odmocnění (√)":
                        if (num1 < 0)
                        {
                            MessageBox.Show("Odmocnina je definována pouze pro nezáporná čísla.", "Chyba", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                        result = Math.Sqrt(num1);
                        break;
                    case "Faktoriál (!)":
                        if (num1 < 0 || num1 != Math.Floor(num1)) // Check for non-negative integer
                        {
                             MessageBox.Show("Faktoriál je definován pouze pro nezáporná celá čísla.", "Chyba", MessageBoxButtons.OK, MessageBoxIcon.Error);
                             return;
                        }
                        int intNum1 = (int)num1;
                        factorialResult = 1;
                        if (intNum1 > 0)
                        {
                             for (int i = 1; i <= intNum1; i++)
                             {
                                 try { factorialResult = checked(factorialResult * i); } // Check for overflow
                                 catch (OverflowException) 
                                 { 
                                     MessageBox.Show($"Výsledek faktoriálu pro {intNum1} je příliš velký.", "Chyba", MessageBoxButtons.OK, MessageBoxIcon.Error); 
                                     return; 
                                 }
                             }
                        }
                        isFactorial = true;
                        break;
                    case "Modulo (%)":
                         if (num2 == 0)
                        {
                            MessageBox.Show("Dělení nulou (pro modulo) není povoleno.", "Chyba", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                        result = num1 % num2;
                        break;
                    default:
                        MessageBox.Show("Neznámá operace.", "Chyba", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                }

                // --- Display Result ---
                if (isFactorial)
                {
                    lblResult.Text = factorialResult.ToString();
                }
                else
                {
                    // Format nicely, avoid unnecessary decimals for whole numbers
                    if (result == Math.Floor(result)) 
                    {
                         lblResult.Text = result.ToString("N0"); // No decimal places if whole number
                    }
                    else
                    {
                         lblResult.Text = result.ToString("N2"); // Two decimal places otherwise
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Došlo k chybě při výpočtu: {ex.Message}", "Chyba", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
