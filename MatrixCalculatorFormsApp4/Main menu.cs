using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using TextBox = System.Windows.Forms.TextBox;

namespace MatrixCalculatorFormsApp4
{
    public partial class MatrixCalculatorForm : Form
    {
        public List<Matrix> memory = new List<Matrix>();
        bool runProgram = true;
        Matrix txtMatrix;
        //private MsgBox1 buttonForm1;
        private MsgBox2 buttonForm2;
        bool selected = false;
        


        public MatrixCalculatorForm()
        {
            InitializeComponent();

            MatrixMemory.MatrixSaved += AddMatrixToList;

            // Load existing matrices into the ListBox
            UpdateMemoryListBox();
            //buttonForm1 = new MsgBox1();
            buttonForm2 = new MsgBox2();

        }
        

 
        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }
        private void radioButton1_CheckedChanged_1(object sender, EventArgs e)
        {

        }
        private void radioButton1_CheckedChanged_2(object sender, EventArgs e)
        {

        }
        private void radioButton1_CheckedChanged_3(object sender, EventArgs e)
        {

        }
        private void label4_Click(object sender, EventArgs e)
        {

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
                    runProgram = false;
                }
            }

            return matrix; // Return the parsed matrix.
        }

        string PrintMatrix(double[,] matrix)
        {
            // Initialize an empty string to hold the resulting matrix representation.
            string result = "";

            // Get the number of rows and columns in the matrix.
            int rowCount = matrix.GetLength(0);
            int colCount = matrix.GetLength(1);

            // Loop through each row of the matrix.
            for (int i = 0; i < rowCount; i++)
            {
                // Loop through each column in the current row.
                for (int j = 0; j < colCount; j++)
                {
                    // Convert the matrix element to a string and append it to the result string.
                    result += matrix[i, j].ToString() + "  ";
                }

                // Add a new line character to separate rows in the result string.
                result += Environment.NewLine;
            }

            // Return the resulting string representing the matrix.
            return result;
        }

        private string MatrixToString(Matrix matrix)
        {
            int rowCount = matrix.rows;
            int colCount = matrix.cols;
            string result = "";

            // Loop through rows and elements to construct the string representation
            for (int i = 0; i < rowCount; i++)
            {
                for (int j = 0; j < colCount; j++)
                {
                    // Append each element to the result string
                    result += matrix.GetValue(i, j).ToString();

                    // Add a comma if it's not the last element in the row
                    if (j < colCount - 1)
                    {
                        result += " ";
                    }
                }

                // Add a semicolon if it's not the last row
                if (i < rowCount - 1)
                {
                    result += "; ";
                }
            }

            // Return the constructed string
            return result;
        }

        // Method to update the memory listbox with stored matrices
        private void UpdateMemoryListBox()
        {
            
            // Clear the items in the memory listbox
            lstMemory2.Items.Clear();

            // Loop through stored matrices and add them to the listbox
            foreach (var item in MatrixMemory.GetMatrices())
            {
                lstMemory2.Items.Add(MatrixToString(item));
            }

           
        }

        public void AddMatrixToList(Matrix matrix)
        {
            memory.Add(matrix);
            UpdateMemoryListBox();
        }


       


        // Recursive function to calculate the determinant of a matrix


        private void TransposeButton_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void CalculateButton_Click(object sender, EventArgs e)
        {
            
            // Parse the input matrices from the textboxes
            double[,] matrixA = ReadMatrix(InputMatrixAtextBox.Text);
            double[,] matrixB = ReadMatrix(InputMatrixBtextBox.Text);
            double[,] result = new double[0, 0];
            MsgBox1 m1 = new MsgBox1();
            MsgBox2 m2 = new MsgBox2();
            MsgBox3 m3 = new MsgBox3();
            int rowsA = matrixA.GetLength(0);
            int colsA = matrixA.GetLength(1);

            int rowsB = matrixB.GetLength(0);
            int colsB = matrixB.GetLength(1);

            Matrix InputMatrixA = new Matrix(rowsA, colsA);
            Matrix InputMatrixB = new Matrix(rowsB, colsB);
            for (int i = 0; i < rowsA; i++)
            {
                for (int j = 0; j < colsA; j++)
                {
                    InputMatrixA.SetValue(i, j, matrixA[i, j]);
                }

            }

            for (int i = 0; i < rowsB; i++)
            {
                for (int j = 0; j < colsB; j++)
                {
                    InputMatrixB.SetValue(i, j, matrixB[i, j]);
                } 
                
            }


            if (DetButton.Checked == true)

            {
                if (runProgram == true)
                {
                    try
                    {
                        double[,] matrix = ReadMatrix(InputMatrixAtextBox.Text);                     
                        
                        int n = matrix.GetLength(0);
                        double resultDet = Matrix.CalculateDeterminant(InputMatrixA);
                        m1.MatrixATxtBox1.Text = InputMatrixA.PrintMatrix();
                        
                        m1.ResultTxtBox1.Text = resultDet.ToString();
                        // Display the result.
                        m1.MsgLabel1.Text = "Calculate Determinant";
                        //m1.MatrixATxtBox1.Text = PrintMatrix(matrixA);
                        //m1.ResultTxtBox1.Text = determinant.ToString();
                        if (n == 2)
                        {
                            m1.MsgTextBox1.Text = "The input MatrixA is 2x2 square matrix, use the determinant formula. \n";
                            string imagePath = "C:/Users/Nick/source/repos/MatrixCalculatorForms2/Matrix_Fomulas_png/Determinant_of_2x2_Matrix.png";
                            m1.MsgPictureBox1.Image = System.Drawing.Image.FromFile(imagePath);
                            m1.Show();
                        }
                        else
                        {
                            m1.MsgTextBox1.Text = "The input MatrixA is 3x3 square matrix, hence use the expand formula " +
                                "to calculate the Determinanta. The picture below show the expand formula.\n";
                            string imagePath = "C:/Users/Nick/source/repos/MatrixCalculatorForms2/Matrix_Fomulas_png/3x3_Determint_Expand_Formula.png";
                            m1.MsgPictureBox1.Image = System.Drawing.Image.FromFile(imagePath);
                            m1.Show();
                        }
                    }
                    catch (Exception ex)
                    {
                        System.Windows.Forms.MessageBox.Show("An error occurred: " + ex.Message);
                    }
                }
            }
            if (TransposeButton.Checked == true)
            {
                if (runProgram == true)
                {
                    // Display the result.
                    m1.MsgLabel1.Text = "Calculate Transpose";
                   
                    m1.MsgTextBox1.Text = "To calculate the Transpose of a Matrix, just swap rows with columns of the matrix or reflect in the leading diagonal. See the example below\n";
                    string imagePath = "C:/Users/Nick/source/repos/MatrixCalculatorForms2/Matrix_Fomulas_png/Transpose.png";
                    m1.MsgPictureBox1.Image = System.Drawing.Image.FromFile(imagePath);
;
                    Matrix resultTranspose = Matrix.CalculateTranspose(InputMatrixA);
                    m1.MatrixATxtBox1.Text = InputMatrixA.PrintMatrix();                   
                    m1.ResultTxtBox1.Text = resultTranspose.PrintMatrix();
                    m1.Show();

                    //Update memory list box


                    //lstMemory1.Items.Add("Transpose");



                }
            }

            if (CofactorButton.Checked == true)
            {
                if (runProgram == true)
                {
                    try
                    {
                        // Display the result.
                        m2.MsgLabel2.Text = "Calculate Cofactor";                                           
                        m2.MsgTextBox2.Text = "The picture below show the steps to calculate the first cofactor C11 of a square matrix A. " +
                            "You need to repeat all the steps for C12, C13, ..., C33, to calculate the cofactor of matrix A.  \n";
                        string imagePath = "C:/Users/Nick/source/repos/MatrixCalculatorForms2/Matrix_Fomulas_png/3x3_Cofactor_formula.png";
                        m2.MsgPictureBox2.Image = System.Drawing.Image.FromFile(imagePath);
                        
                        Matrix resultCofactor = Matrix.CalculateCofactor(InputMatrixA);
                        m2.MatrixATxtBox2.Text = InputMatrixA.PrintMatrix();
                        m2.ResultTxtBox2.Text = resultCofactor.PrintMatrix();
                        m2.Show();
                      //memory.Add(resultCofactor); // Saves the result to the memory
                      //UpdateMemoryListBox(); //Update memory list box
                      //lstMemory1.Items.Add("Cofactor");
                    }
                    catch (Exception ex)
                    {
                        System.Windows.Forms.MessageBox.Show("An error occurred: " + ex.Message);
                    }

                }
            }

            if (AdjButton.Checked == true)
            {
                if (runProgram == true)
                {
                    try
                    {
                        
                        // Display the result.
                        m2.MsgLabel2.Text = "Calculate Adjugate";                     
                        m2.MsgTextBox2.Text = "The Adjugate of a square matrix A is the Transpose of Cofactor(A). Picture below show The steps to calculate the Cofactor(A): \n";
                        string imagePath = "C:/Users/Nick/source/repos/MatrixCalculatorForms2/Matrix_Fomulas_png/3x3_Cofactor_formula.png";
                        m2.MsgPictureBox2.Image = System.Drawing.Image.FromFile(imagePath);
                        Matrix resultAdjugate = Matrix.CalculateAdjugate(InputMatrixA);
                        m2.MatrixATxtBox2.Text = InputMatrixA.PrintMatrix();
                        m2.ResultTxtBox2.Text = resultAdjugate.PrintMatrix();
                        m2.Show();

                        //memory.Add(resultAdjugate); // Saves the result to the memory
                        //UpdateMemoryListBox(); //Update memory list box
                        //lstMemory1.Items.Add("Adjugate");
                    }
                    catch (Exception ex)
                    {
                        System.Windows.Forms.MessageBox.Show("An error occurred: " + ex.Message);
                    }
                }
            }

            if (InverseButton.Checked == true)
            {
                if (runProgram == true)
                {
                    try
                    {
                        // Display the result.
                        m1.MsgLabel1.Text = "Calculate Inverse";                       
                        
                        m1.MsgTextBox1.Text = "The formula to calculate the inverse of square matrix A is show in the picture below.\n";
                        string imagePath = "C:/Users/Nick/source/repos/MatrixCalculatorForms2/Matrix_Fomulas_png/Inverse-of-Matrix-Formula.png";
                        m1.MsgPictureBox1.Image = System.Drawing.Image.FromFile(imagePath);
                        
                        Matrix resultInverse = Matrix.CalculateInverse(InputMatrixA);
                        m1.MatrixATxtBox1.Text = InputMatrixA.PrintMatrix();
                        m1.ResultTxtBox1.Text = resultInverse.PrintMatrix();
                        m1.Show();
                     // memory.Add(resultInverse); // Saves the result to the memory
                      //UpdateMemoryListBox(); //Update memory list box
                        lstMemory1.Items.Add("Inverse");
                    }
                    catch (Exception ex)
                    {
                        System.Windows.Forms.MessageBox.Show("An error occurred: " + ex.Message);
                    }
                }
            }

            if (AddButton.Checked == true)
            {
                if (runProgram == true)
                {
                    try
                    {
                        // Display the result.
                        Matrix resultAdd = Matrix.AddMatrices(InputMatrixA, InputMatrixB);
                        m3.MsgLabel3.Text = "Matrices Addition";
                                              
                        m3.MsgTextBox3.Text = "Steps to do Matrices Addition are:\r\n\r\n" +
                        "1. Check Matrix dimensions must be the same for Addition.\r\n" +
                        "2. Simply add the correcsponding elements of each matrix. The picture below show an example of 3x3 matirces addition";
                        string imagePath = "C:/Users/Nick/source/repos/MatrixCalculatorForms2/Matrix_Fomulas_png/3x3_Addition.png";
                        m3.MsgPictureBox3.Image = System.Drawing.Image.FromFile(imagePath);                                            
                        m3.MatrixATxtBox3.Text = InputMatrixA.PrintMatrix();
                        m3.MatrixBTxtBox3.Text = InputMatrixB.PrintMatrix();
                        m3.ResultTxtBox3.Text = resultAdd.PrintMatrix();
                        m3.MatrixAStepsTxtBox.Visible = false;
                        m3.OperationTxtBox.Visible = false;
                        m3.EqualsTxtBox.Visible = false;
                        m3.MatrixBStepsTxtBox.Visible = false;
                        m3.Show();
                        //memory.Add(resultAdd); // Saves the result to the memory
                        //UpdateMemoryListBox(); //Update memory list box
                        //lstMemory1.Items.Add("Addition");
                    }
                    catch (Exception ex)
                    {
                        System.Windows.Forms.MessageBox.Show("An error occurred: " + ex.Message);
                    }
                }
            }

            if (SubtractButton.Checked == true)
            {
                if (runProgram == true)
                {
                    try
                    {
                        m3.MatrixAStepsTxtBox.Text = PrintMatrix(matrixA);
                        m3.OperationTxtBox.Text = "-";
                        m3.MatrixBStepsTxtBox.Text = PrintMatrix(matrixB);
                        m3.MsgPictureBox3.Visible = false;
                        // Display the result.
                        m3.MsgLabel3.Text = "Matrices Subtraction";                      
                        m3.MsgTextBox3.Text = "Steps to do Matrices Subtraction are:\r\n\r\n" +
                        "1. Check Matrix dimensions must be the same for Subtraction.\r\n" +
                        "2. Simply Subtract the correcsponding elements of each matrix. The picture below show an example of 3x3 matirces Subtraction";
                        string imagePath = "C:/Users/Nick/source/repos/MatrixCalculatorForms2/Matrix_Fomulas_png/3x3_Subtraction.png";
                        m3.MsgPictureBox3.Image = System.Drawing.Image.FromFile(imagePath);
                        

                        

                        Matrix resultSubtract = Matrix.Subtract(InputMatrixA, InputMatrixB);
                        m3.MatrixATxtBox3.Text = InputMatrixA.PrintMatrix();
                        m3.MatrixBTxtBox3.Text = InputMatrixB.PrintMatrix();
                        m3.ResultTxtBox3.Text = resultSubtract.PrintMatrix();
                        result = ReadMatrix(m3.ResultTxtBox3.Text);


                        if (rowsA < 4 && colsA < 4 && rowsB < 4 && colsB < 4)
                        {
                            m3.MsgPictureBox3.Visible = false;
                            if (result.GetLength(0) == 1)
                            {
                                for (int i = 0; i < result.GetLength(1); i++)
                                {
                                    TextBox element = new TextBox();
                                    // Set properties for the TextBox
                                    element.Name = "dynamicTextBox" + i; // Set a unique name
                                    element.Location = new System.Drawing.Point(470 + 40 * i, 263); // Set the location
                                    element.Size = new System.Drawing.Size(30, 30);
                                    element.Font = new Font("Arial", 11);
                                    int n = i + 1;
                                    element.Text = "E" + n;

                                    // Add the TextBox to the form's controls collection
                                    m3.Controls.Add(element);
                                }

                                for (int i = 0; i < result.GetLength(1); i++)
                                {
                                    int n = i + 1;
                                    for (int j = 0; j < 3; j++)
                                    {
                                        TextBox element = new TextBox();
                                        element.Name = "dynamicTextBox" + i + j; // Set a unique name
                                        element.Font = new Font("Arial", 11);
                                        switch (j)
                                        {
                                            case 0:
                                                element.Location = new System.Drawing.Point(197, 327 + 40 * i); // Set the location
                                                element.Size = new System.Drawing.Size(30, 30);


                                                element.Text = "E" + n;
                                                // Add the TextBox to the form's controls collection
                                                m3.Controls.Add(element);
                                                break;
                                            case 1:
                                                element.Location = new System.Drawing.Point(237, 327 + 40 * i); // Set the location
                                                element.Size = new System.Drawing.Size(30, 30);


                                                element.Text = "=";

                                                m3.Controls.Add(element);
                                                break;
                                            case 2:
                                                element.Location = new System.Drawing.Point(277, 327 + 40 * i); // Set the location
                                                element.Size = new System.Drawing.Size(80, 30);
                                                element.Text = InputMatrixA.GetValue(0, i).ToString() + "-" + InputMatrixB.GetValue(0, i).ToString();

                                                m3.Controls.Add(element);
                                                break;

                                        }
                                    }
                                }

                            }
                            if (result.GetLength(0) > 1 && result.GetLength(0) < 4)
                            {
                                int index1 = 0;
                                int index2 = 0;
                                for (int i = 0; i < result.GetLength(1); i++)
                                {
                                    for (int j = 0; j < result.GetLength(0); j++)
                                    {
                                        TextBox element = new TextBox();
                                        // Set properties for the TextBox
                                        element.Name = "dynamicTextBox" + i; // Set a unique name
                                        element.Location = new System.Drawing.Point(470 + 40 * i, 241 + 40 * j); // Set the location
                                        element.Size = new System.Drawing.Size(30, 30);
                                        element.Font = new Font("Arial", 11);
                                        index1 += 1;
                                        element.Text = "E" + index1;

                                        // Add the TextBox to the form's controls collection
                                        m3.Controls.Add(element);


                                    }
                                }

                                for (int i = 0; i < result.GetLength(1); i++)
                                {

                                    for (int j = 0; j < result.GetLength(0); j++)
                                    {
                                        TextBox element = new TextBox();
                                        // Set properties for the TextBox
                                        element.Name = "dynamicTextBox" + i; // Set a unique name
                                        element.Location = new System.Drawing.Point(197 + 200 * i, 357 + 40 * j); // Set the location
                                        element.Size = new System.Drawing.Size(30, 30);
                                        element.Font = new Font("Arial", 11);

                                        index2 += 1;
                                        element.Text = "E" + index2;


                                        // Add the TextBox to the form's controls collection
                                        m3.Controls.Add(element);

                                        TextBox element2 = new TextBox();

                                        element2.Name = "dynamicTextBox" + i; // Set a unique name
                                        element2.Location = new System.Drawing.Point(237 + 200 * i, 357 + 40 * j); // Set the location
                                        element2.Size = new System.Drawing.Size(30, 30);
                                        element2.Font = new Font("Arial", 11);

                                        element2.Text = "=";
                                        m3.Controls.Add(element2);

                                    }

                                }

                                for (int i = 0; i < result.GetLength(1); i++)
                                {
                                    for (int j = 0; j < result.GetLength(0); j++)
                                    {
                                        TextBox element3 = new TextBox();

                                        element3.Name = "dynamicTextBox" + i; // Set a unique name
                                        element3.Location = new System.Drawing.Point(277 + 200 * i, 357 + 40 * j); // Set the location
                                        element3.Size = new System.Drawing.Size(80, 30);
                                        element3.Font = new Font("Arial", 11);
                                        m3.Controls.Add(element3);

                                        element3.Text = matrixA[i, j].ToString();
                                        element3.Text += "-";
                                        element3.Text += matrixB[i, j].ToString();
                                    }

                                }



                            }
                        }

                        else
                        {
                            m3.MsgPictureBox3.Image = System.Drawing.Image.FromFile(imagePath);
                            m3.MatrixAStepsTxtBox.Visible = false;
                            m3.OperationTxtBox.Visible = false;
                            m3.EqualsTxtBox.Visible = false;
                            m3.MatrixBStepsTxtBox.Visible = false;
                            m3.MsgPictureBox3.Visible = true;
                        }   
                        

                        
                        
                        
                        
                        
                        
                        
                        m3.Show();
                         
                        
                       
                        
                    }
                    catch (Exception ex)
                    {
                        System.Windows.Forms.MessageBox.Show("An error occurred: " + ex.Message);
                    }
                }
            }

            if (MultiplyButton.Checked == true)
            {
                if (runProgram == true)
                {
                    try
                    {
                       
                        // Display the result.
                        Matrix resultMultiply = Matrix.MultiplyMatrices(InputMatrixA, InputMatrixB);
                        m3.MsgLabel3.Text = "Matrices Multiplication";
                                               
                        m3.MatrixATxtBox3.Text = InputMatrixA.PrintMatrix();
                        m3.MatrixBTxtBox3.Text = InputMatrixB.PrintMatrix();
                        m3.ResultTxtBox3.Text = resultMultiply.PrintMatrix();
                        result = ReadMatrix(m3.ResultTxtBox3.Text);

                        m3.MsgTextBox3.Text = "For (m x n) MatrixA mupliply (n x k) MatrixB. Steps to do are:\r\n" +
                        "step 1. Check The number of columns in MatrixA = to the number of rows in MatrixB.\r\n" +
                        "step 2. Multiply the correcsponding elements of first row (i) of MatrixA to first column (j) of MatrixB.\r\n" +
                        "step 3. Add together the products from step 2.\r\n" +
                        "step 4. Repeat step2 to step3 with j=j+1 until j=k \r\n" +
                        "step 5. Repeat step2 to step4 with i=i+1 until i=m \r\n" +
                        "The picture below show an example of 3x3 matirces multiplication";
                        string imagePath = "C:/Users/Nick/source/repos/MatrixCalculatorForms2/Matrix_Fomulas_png/3x3_Multiplication.png";
                        


                        if (rowsA < 4 && colsA < 4 && rowsB < 4 && colsB < 4)
                        {
                            m3.MatrixAStepsTxtBox.Text = PrintMatrix(matrixA);
                            m3.OperationTxtBox.Text = "X";
                            m3.MatrixBStepsTxtBox.Text = PrintMatrix(matrixB);
                            m3.MsgPictureBox3.Visible = false;
                            //if ((colsA == 1 && rowsA ==1)|| (colsB == 1 && rowsB == 1))
                            if(result.GetLength(0) == 1)
                            {
                                for (int i = 0; i < result.GetLength(1); i++)
                                {
                                    TextBox element = new TextBox();
                                    // Set properties for the TextBox
                                    element.Name = "dynamicTextBox" + i; // Set a unique name
                                    element.Location = new System.Drawing.Point(470 + 40 * i, 263); // Set the location
                                    element.Size = new System.Drawing.Size(30, 30);
                                    element.Font = new Font("Arial", 11);
                                    int n = i + 1;
                                    element.Text = "E" + n;

                                    // Add the TextBox to the form's controls collection
                                    m3.Controls.Add(element);
                                }

                                for (int i = 0; i < result.GetLength(1); i++)
                                {
                                    int n = i + 1;
                                    for (int j = 0; j < 3; j++)
                                    {
                                        TextBox element = new TextBox();
                                        element.Name = "dynamicTextBox" + i + j; // Set a unique name
                                        element.Font = new Font("Arial", 11);
                                        switch (j)
                                        {
                                            case 0:
                                                element.Location = new System.Drawing.Point(197, 327 + 40 * i); // Set the location
                                                element.Size = new System.Drawing.Size(30, 30);


                                                element.Text = "E" + n;
                                                // Add the TextBox to the form's controls collection
                                                m3.Controls.Add(element);
                                                break;
                                            case 1:
                                                element.Location = new System.Drawing.Point(237, 327 + 40 * i); // Set the location
                                                element.Size = new System.Drawing.Size(30, 30);


                                                element.Text = "=";

                                                m3.Controls.Add(element);
                                                break;
                                            case 2:
                                                element.Location = new System.Drawing.Point(277, 327 + 40 * i); // Set the location
                                                element.Size = new System.Drawing.Size(80, 30);
                                                if (colsA == 1)
                                                {
                                                    
                                                    element.Text = matrixA[0, 0] + "x" + matrixB[0, i];
                                                }

                                                if (colsB == 1)
                                                {
                                                    element.Text = matrixA[0, i] + "x" + matrixB[0, 0];

                                                }

                                                m3.Controls.Add(element);
                                                break;

                                        }

                                    }
                                }

                            }

                            if (result.GetLength(0) > 1 && result.GetLength(0) < 4)
                            {
                                int index1 = 0;
                                int index2 = 0;
                                for (int i = 0; i < result.GetLength(1); i++)
                                {
                                    for (int j = 0; j < result.GetLength(0); j++)
                                    {
                                        TextBox element = new TextBox();
                                        // Set properties for the TextBox
                                        element.Name = "dynamicTextBox" + i; // Set a unique name
                                        element.Location = new System.Drawing.Point(470 + 40 * i, 241 + 40 * j); // Set the location
                                        element.Size = new System.Drawing.Size(30, 30);
                                        element.Font = new Font("Arial", 11);
                                        index1 += 1;
                                        element.Text = "E" + index1;

                                        // Add the TextBox to the form's controls collection
                                        m3.Controls.Add(element);


                                    }
                                }

                                for (int i = 0; i < result.GetLength(1); i++)
                                {
                                    
                                    for (int j = 0; j < result.GetLength(0); j++)
                                    {
                                        TextBox element = new TextBox();
                                        // Set properties for the TextBox
                                        element.Name = "dynamicTextBox" + i; // Set a unique name
                                        element.Location = new System.Drawing.Point(197 + 200 * i, 357 + 40 * j); // Set the location
                                        element.Size = new System.Drawing.Size(30, 30);
                                        element.Font = new Font("Arial", 11);

                                        index2 += 1;
                                        element.Text = "E" + index2;
                                        

                                        // Add the TextBox to the form's controls collection
                                        m3.Controls.Add(element);

                                        TextBox element2 = new TextBox();

                                        element2.Name = "dynamicTextBox" + i; // Set a unique name
                                        element2.Location = new System.Drawing.Point(237 + 200 * i, 357 + 40 * j); // Set the location
                                        element2.Size = new System.Drawing.Size(30, 30);
                                        element2.Font = new Font("Arial", 11);

                                        element2.Text = "=";
                                        m3.Controls.Add(element2);
                                                                                                       
                                    }

                                }

                                for (int i = 0; i < result.GetLength(1); i++)
                                {
                                    for (int j = 0; j < result.GetLength(0); j++)
                                    {
                                        TextBox element3 = new TextBox();

                                        element3.Name = "dynamicTextBox" + i; // Set a unique name
                                        element3.Location = new System.Drawing.Point(277 + 200 * i, 357 + 40 * j); // Set the location
                                        element3.Size = new System.Drawing.Size(120, 30);
                                        element3.Font = new Font("Arial", 11);
                                        m3.Controls.Add(element3);
                                        
                                        for (int k = 0; k < colsA; k++)
                                        {
                                            
                                            if(k < (colsA - 1))
                                            {
                                                element3.Text += InputMatrixA.GetValue(j, k).ToString();
                                                element3.Text += "*";
                                                element3.Text += InputMatrixB.GetValue(k, i).ToString();
                                                element3.Text += "+";
                                            }
                                            else
                                            {
                                                element3.Text += InputMatrixA.GetValue(j, k).ToString();
                                                element3.Text += "*";
                                                element3.Text += InputMatrixB.GetValue(k, i).ToString();
                                            }
                                        }
                                    }

                                }



                            }

                        }

                        else
                        {
                            m3.MsgPictureBox3.Image = System.Drawing.Image.FromFile(imagePath);
                            m3.MatrixAStepsTxtBox.Visible = false;
                            m3.OperationTxtBox.Visible = false;
                            m3.EqualsTxtBox.Visible = false;
                            m3.MatrixBStepsTxtBox.Visible = false;
                            m3.MsgPictureBox3.Visible = true;
                        }
                       
                        m3.Show();                     

                    }
                    catch (Exception ex)
                    {
                        System.Windows.Forms.MessageBox.Show("An error occurred: " + ex.Message);
                    }
                }
            }
            runProgram = true;
        }

        private void Exitbutton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void PasteMemoryA_Click(object sender, EventArgs e)
        {
            
            if(selected == true)
            {
                InputMatrixAtextBox.Text = txtMatrix.PrintMatrix();
            }
            
        
        }


        
        // Event handler for the memory listbox selection change
        private void lstMemory2_SelectedIndexChanged(object sender, EventArgs e) 
        {
            if (lstMemory2.SelectedIndex >= 0 && lstMemory2.SelectedIndex < memory.Count)
            {
                Matrix selectedMatrix = memory[lstMemory2.SelectedIndex];

                txtMatrix = selectedMatrix;
                selected = true;
                
            }
        }

        private void PasteMemoryB_Click(object sender, EventArgs e)
        {
            
            if (selected == true)
            {
                InputMatrixBtextBox.Text = txtMatrix.PrintMatrix();
            }
        }
    }
}
