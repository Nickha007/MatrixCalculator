using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MatrixCalculatorFormsApp4
{
    public partial class MsgBox2 : Form
    {
        public MsgBox2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double[,] answer = ReadMatrix(ResultTxtBox2.Text);
            int answerRows = answer.GetLength(0);
            int answerCols = answer.GetLength(1);
            Matrix result = new Matrix(answerRows, answerCols);

            for (int i = 0; i < answerRows; i++)
            {
                for (int j = 0; j < answerCols; j++)
                {
                    result.SetValue(i, j, answer[i, j]);
                }
            }


            MatrixMemory.SaveMatrix(result);
        }

        double[,] ReadMatrix(string matrixName)
        {
            double[,] matrix = null; // Initialize a matrix variable to hold the parsed data.
            bool invalidInput = true; // A flag to control the input loop.

            while (invalidInput) // Start a loop for input validation.
            {

                try
                {
                    string[] rows = matrixName.Split(new char[] { ';', '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries); // Split the input into rows using semicolon as the delimiter.
                    if (rows.Length == 0 || string.IsNullOrWhiteSpace(rows[0])) // Check if there are no rows or the first row is empty.
                    {
                        throw new FormatException($"Invalid input for \"  \" {matrixName}. There are no rows or the first row is empty.");
                    }

                    int colCount = rows[0].Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Length; // Determine the number of columns based on the first row.
                    matrix = new double[rows.Length, colCount]; // Initialize the matrix with the determined dimensions.

                    for (int i = 0; i < rows.Length; i++) // Loop through each row.
                    {
                        string[] elements = rows[i].Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries); // Split the row into elements.

                        if (elements.Length != colCount) // Check if the number of elements in the current row matches the expected colCount.
                        {
                            throw new FormatException($"Invalid input for {matrixName}. Row lengths are inconsistent.");
                        }

                        for (int j = 0; j < colCount; j++) // Loop through each element in the row.
                        {
                            if (!double.TryParse(elements[j], out matrix[i, j])) // Try to parse the element as a double.
                            {
                                throw new FormatException($"Invalid input for {matrixName}. Please enter valid numeric values in the matrix.");
                            }
                        }
                    }

                    invalidInput = false; // Input is valid, exit the loop.
                }
                catch (Exception ex)
                {
                    System.Windows.Forms.MessageBox.Show($"Error: {ex.Message}" + "Please enter the matrix again.");
                    invalidInput = false;

                }
            }

            return matrix; // Return the parsed matrix.
        }
    }
}
