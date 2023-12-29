using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MatrixCalculatorFormsApp4
{
    public class Matrix
    {
        public int rows;
        public int cols;
        private double[,] data;

        public Matrix(int rows, int cols)
        {
            this.rows = rows;
            this.cols = cols;
            this.data = new double[rows, cols];
        }

        public void SetValue(int row, int col, double value)
        {
            data[row, col] = value;
        }

        public double GetValue (int row, int col)
        {
            return data[row, col];
        }

        public static Matrix Subtract(Matrix InputA, Matrix InputB)
        {

            if (InputA.rows != InputB.rows || InputA.cols != InputB.cols)
            {
                throw new ArgumentException("Matrices must have the same dimensions for subtraction.");
            }

            Matrix result = new Matrix(InputA.rows, InputA.cols);

            for (int i = 0; i < InputA.rows; i++)
            {
                for (int j = 0; j < InputA.cols; j++)
                {
                    result.SetValue(i, j, InputA.data[i, j] - InputB.data[i, j]);
                }
            }

            return result;
        }

        public string PrintMatrix()
        {
            string result = "";

          
            for (int i = 0; i < rows; i++)
            {
                // Loop through each column in the current row.
                for (int j = 0; j < cols; j++)
                {
                    // Convert the matrix element to a string and append it to the result string.
                    result += data[i, j].ToString() + " ";
                }

                // Add a new line character to separate rows in the result string.
                result += Environment.NewLine;
            }

            // Return the resulting string representing the matrix.
            return result;
        }

       

        public static double CalculateDeterminant(Matrix matrix)
        {
            // Get the number of rows/columns of the matrix
            int n = matrix.rows;
            int numCols = matrix.cols;

            // Check the matrix is square
            if (n != numCols)
            {
                throw new ArgumentException("Must be a square Matrix to find the determinant.");
            }

            // If the matrix is 1x1, return the single element as the determinant
            if (n == 1)
            {
                return matrix.GetValue(0,0);
            }

            // If the matrix is 2x2, use the determinant formula for 2x2 matrices
            if (n == 2)
            {
                return (matrix.GetValue(0, 0) * matrix.GetValue(1, 1) - matrix.GetValue(0, 1) * matrix.GetValue(1, 0));
            }

            // Initialize the determinant to 0
            double det = 0;

            // Loop through the first row of the matrix to expand along the first row
            for (int j = 0; j < n; j++)
            {
                // Create a submatrix by excluding the first row and the current column
                Matrix subMatrix = new Matrix(n-1, n-1);
                for (int k = 1; k < n; k++)
                {
                    for (int l = 0; l < n; l++)
                    {
                        if (l < j)

                            subMatrix.SetValue(k - 1, l, matrix.GetValue(k, l));
                        else if (l > j)
                            
                            subMatrix.SetValue(k - 1, l - 1, matrix.GetValue(k, l));
                    }
                }

                // Determine the sign of the current term based on its position
                double sign = (j % 2 == 0) ? 1.0 : -1.0;

                // Recursively calculate the determinant of the submatrix and accumulate
                // it with the appropriate sign to the total determinant
                det += sign * matrix.GetValue(0, j) * CalculateDeterminant(subMatrix);
            }

            // Return the final determinant of the original matrix
            return det;
        }

        public static Matrix CalculateTranspose(Matrix matrix)
        {
            // Get the number of rows and columns in the original matrix
            int rows = matrix.rows;
            int cols = matrix.cols;

            // Create a new matrix with swapped dimensions for the transpose
            Matrix result = new Matrix(rows, cols);

            // Iterate through each element of the original matrix
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    // Swap the positions of elements to perform the transpose
                    result.SetValue(i, j, matrix.GetValue(j,i) );
                }
            }

            // Return the transposed matrix
            return result;
        }

        public static Matrix CalculateCofactor(Matrix matrix)
        {
            // Get the number of rows/columns of the matrix
            int rows = matrix.rows;
            int cols = matrix.cols;

            // Check the matrix is square
            if (rows != cols)
            {
                throw new ArgumentException("Must be a square Matrix to calculate the cofactor.");
            }

            // Create a matrix to store the cofactor values
            Matrix cofactorMatrix = new Matrix(rows, cols);

            // Loop through each element of the matrix
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    // Create a submatrix by excluding the current row and column
                    
                    Matrix subMatrix = new Matrix(rows - 1, cols - 1);
                    for (int k = 0; k < rows; k++)
                    {
                        if (k == i)
                            continue; // Skip the current row

                        for (int l = 0; l < rows; l++)
                        {
                            if (l == j)
                                continue; // Skip the current column

                            // Determine the new indices for the submatrix
                            int newRow = (k < i) ? k : k - 1;
                            int newCol = (l < j) ? l : l - 1;

                            // Fill the submatrix with the corresponding values from the original matrix                            
                            subMatrix.SetValue(newRow, newCol, matrix.GetValue(k, l));
                        }
                    }

                    // Determine the sign of the cofactor based on its position
                    double sign = ((i + j) % 2 == 0) ? 1.0 : -1.0;

                    // Calculate the determinant of the submatrix and multiply by the sign to get the cofactor
                   
                    cofactorMatrix.SetValue(i, j, sign * CalculateDeterminant(subMatrix));

                }
            }

            // Return the cofactor matrix
            return cofactorMatrix;
        }

        public static Matrix GetCofactor(Matrix matrix, int row, int col)
        {
            // Get the number of rows in the original matrix
            int rows = matrix.rows;
            int cols = matrix.cols;

            // Check the matrix is square
            if (rows != cols)
            {
                throw new ArgumentException("Must be a square Matrix to calculate the cofactor.");
            }

            // Create a matrix to store the cofactor, which is one dimension smaller than the original
            Matrix cofactor = new Matrix(rows - 1, cols - 1);

            // Initialize the row index for the cofactor matrix
            int rowIndex = 0;

            // Iterate through each row of the original matrix
            for (int i = 0; i < rows; i++)
            {
                if (i == row)
                {
                    continue; // Skip the current row to exclude it from the cofactor
                }
                int colIndex = 0; // Initialize the column index for the cofactor matrix

                // Iterate through each column of the original matrix
                for (int j = 0; j < rows; j++)
                {
                    if (j == col)
                    {
                        continue; // Skip the current column to exclude it from the cofactor
                    }
                    // Copy the element from the original matrix to the cofactor matrix
                    
                    cofactor.SetValue(rowIndex, colIndex, matrix.GetValue(i, j));
                    colIndex++;
                }
                rowIndex++;
            }

            // Return the cofactor matrix with the specified row and column excluded
            return cofactor;
        }

        public static Matrix CalculateAdjugate(Matrix matrix)
        {
            // Get the number of rows/columns in the original matrix
            int rows = matrix.rows;
            int cols = matrix.cols;

            if (rows != cols)
            {
                throw new ArgumentException("Must be a square Matrix to calculate the Adjugate.");
            }

            // Create a matrix to store the adjugate, which has the same dimensions as the original matrix
            
           

            Matrix adjugate = new Matrix(rows, cols);

          
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < rows; j++)
                {
                    //Get the cofactor matrix by excluding the current row and column
                    Matrix cofactor = GetCofactor(matrix, i, j);

                    // Calculate the determinant of the cofactor matrix
                    double subDeterminant = CalculateDeterminant(cofactor);

                    // Calculate the value for the adjugate matrix element
                    
                    adjugate.SetValue(j, i, ((i + j) % 2 == 0 ? 1 : -1) * subDeterminant);
                }
            }

            // Return the adjugate matrix
            return adjugate;
        }

        public static Matrix CalculateInverse(Matrix matrix)
        {
            // Get the number of rows/columns in the original matrix
            int rows = matrix.rows;
            int cols = matrix.cols;

            // Check the matrix is square
            if (rows != cols)
            {
                throw new ArgumentException("Must be a square Matrix to calculate the Inverse.");
            }

            // Create a matrix to store the inverse with the same dimensions as the original matrix
            Matrix inverse = new Matrix(rows, cols);

            // Calculate the determinant of the input matrix
            double determinant = CalculateDeterminant(matrix);

            // Check if the determinant is close to zero (not invertible)
            if (Math.Abs(determinant) < double.Epsilon)
            {
                throw new InvalidOperationException("The matrix is singular (determinant is zero).");
            }

            // Calculate the adjugate matrix
            Matrix adjugate = new Matrix(rows, cols);
            adjugate = CalculateAdjugate(matrix);
            

            // Calculate the inverse matrix by dividing each element of the adjugate by the determinant
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                   
                    inverse.SetValue(i, j, adjugate.GetValue(i, j) / determinant);
                }
            }

            return inverse;
        }

        public static Matrix AddMatrices(Matrix A, Matrix B)
        {
            int rowsA = A.rows;
            int colsA = A.cols;

            int rowsB = B.rows;
            int colsB = B.cols;

            if (rowsA != rowsB || colsA != colsB)
            {
                throw new ArgumentException("Matrix dimensions must be the same for addition.");
            }

            // Initialize the result matrix
            Matrix result = new Matrix(rowsA, colsA);

            for (int i = 0; i < rowsA; i++)
            {
                for (int j = 0; j < colsA; j++)
                {
                    // Add corresponding elements
                    result.SetValue(i, j, A.GetValue(i, j) + B.GetValue(i, j));
                }
            }

            return result;
        }

        public static Matrix MultiplyMatrices(Matrix A, Matrix B)
        {
            // Get the number of rows and columns for both input matrices
            int rowsA = A.rows;
            int colsA = A.cols;

            int rowsB = B.rows;
            int colsB = B.cols;

            //Check if the matrices can be multiplied (number of columns in A equals number of rows in B)
            if (colsA != rowsB)
            {
                if (rowsA == 1 && colsA == 1)
                {
                    Matrix result = new Matrix(rowsB, colsB);
                    for (int i = 0; i < rowsB; i++)
                    {
                        for (int j = 0; j < colsB; j++)
                        {                            
                            result.SetValue(i, j, A.GetValue(0, 0) * B.GetValue(i, j));

                        }

                    }
                    return result;

                }
                if (rowsB == 1 && colsB == 1)
                {
                    Matrix result = new Matrix(rowsB, colsB);
                    for (int i = 0; i < rowsA; i++)
                    {
                        for (int j = 0; j < colsA; j++)
                        {                           
                            result.SetValue(i, j, B.GetValue(0, 0) * A.GetValue(i, j));

                        }

                    }
                    return result;

                }

                else
                {
                    throw new ArgumentException("Matrix dimensions are not compatible for multiplication.");
                }

            }

            else
            {
                Matrix result = new Matrix(rowsB, colsB);

                // Perform matrix multiplication by iterating through rows and columns
                for (int i = 0; i < rowsA; i++)
                {
                    for (int j = 0; j < colsB; j++)
                    {
                        double sum = 0.0;

                        // Iterate through columns of A or rows of B to compute the dot product
                        for (int k = 0; k < colsA; k++)
                        {                            
                            sum += A.GetValue(i, k) * B.GetValue(k, j);

                        }

                        // Store the sum as the corresponding element in the result matrix
                        
                        result.SetValue(i, j, sum);
                    }


                }
                return result;
            }


            // Return the resulting matrix after multiplication

        }


    }
}
