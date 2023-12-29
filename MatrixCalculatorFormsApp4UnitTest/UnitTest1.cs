using MatrixCalculatorFormsApp4;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Security.Cryptography;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolTip;


namespace MatrixCalculatorFormsApp4UnitTest
{
    [TestClass]
    public class UnitTest1
    {
        

        [TestMethod]

        public void TestMatrixDeterminant2x2()
        {
            // Arrange
            double[,] matrix = {
            { 2, 3 },
            { 1, 4 }
            };

            Matrix matrixtest = new Matrix(2, 2);
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    matrixtest.SetValue(i, j, matrix[i, j]);
                }

            }


            double expectedDeterminant = 5; // Expected determinant of the 2x2 matrix
            // Act
            double actualDeterminant = Matrix.CalculateDeterminant(matrixtest);

            // Assert
            Assert.AreEqual(expectedDeterminant, actualDeterminant, 0.0001); // Use a delta for floating-point comparison
        }

        [TestMethod]
        public void TestMatrixDeterminant3x3()
        {
            // Arrange
            double[,] matrix = {
            { 2, 0, 2 },
            { 0, 1, 0 },
            { 1, 0, 3 }
            };

            Matrix matrixtest = new Matrix(2, 2);
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    matrixtest.SetValue(i, j, matrix[i, j]);
                }

            }

            double expectedDeterminant = 4; // Expected determinant of the 3x3 matrix
            // Act
            double actualDeterminant = Matrix.CalculateDeterminant(matrixtest);

            // Assert
            Assert.AreEqual(expectedDeterminant, actualDeterminant, 0.0001); // Use a delta for floating-point comparison
        }
        [TestMethod]
        public void TestMatrixDeterminant3x3_2()
        {
            // Arrange
            double[,] matrix = {
            { 1, 2, -1 },
            { 2, 1, 2 },
            { -1, 2, 1 }
            };

            double expectedDeterminant = -16; // Expected determinant of the 3x3 matrix
                                              // Act
            double actualDeterminant = Calculator.CalculateDeterminant(matrix);

            // Assert
            Assert.AreEqual(expectedDeterminant, actualDeterminant, 0.0001); // Use a delta for floating-point comparison
        }
        [TestMethod]
        public void TestMatrixDeterminant_InvalidMatrix_ThrowsException()
        {
            // Arrange
            double[,] invalidMatrix = {
            { 2, 3 },
            { 1, 4 },
            { 5, 6 } // This is an invalid 3x2 matrix
            };

            // Create an instance of the matrix calculator

            // Act and Assert
            // Ensure that calculating the determinant of an invalid matrix throws an exception.
            Assert.ThrowsException<InvalidOperationException>(() =>
            {
                Calculator.CalculateDeterminant(invalidMatrix);
            });
        }
        [TestMethod]
        public void TestMatrixAdjugate2x2()
        {
            // Arrange
            double[,] matrix = {
            { 2, 3 },
            { 1, 4 }
            };

            double[,] expectedAdjugate = {
            { 4, -3 },
            { -1, 2 }
            };

            // Act
            double[,] actualAdjugate = Calculator.CalculateAdjugate(matrix);

            // Assert
            Assert.AreEqual(expectedAdjugate.GetLength(0), actualAdjugate.GetLength(0));
            Assert.AreEqual(expectedAdjugate.GetLength(1), actualAdjugate.GetLength(1));

            for (int i = 0; i < expectedAdjugate.GetLength(0); i++)
            {
                for (int j = 0; j < expectedAdjugate.GetLength(1); j++)
                {
                    Assert.AreEqual(expectedAdjugate[i, j], actualAdjugate[i, j], 0.0001); // Use a delta for floating-point comparison
                }
            }
        }

        [TestMethod]
        public void TestMatrixAdjugate3x3()
        {
            // Arrange
            double[,] matrix = {
            { 2, 0, 2 },
            { 0, 1, 0 },
            { 1, 0, 3 }
            };

            double[,] expectedAdjugate = {
            { 3, 0, -2 },
            { 0, 4, 0 },
            { -1, 0, 2 }
            };
            // Act
            double[,] actualAdjugate = Calculator.CalculateAdjugate(matrix);

            // Assert
            Assert.AreEqual(expectedAdjugate.GetLength(0), actualAdjugate.GetLength(0));
            Assert.AreEqual(expectedAdjugate.GetLength(1), actualAdjugate.GetLength(1));

            for (int i = 0; i < expectedAdjugate.GetLength(0); i++)
            {
                for (int j = 0; j < expectedAdjugate.GetLength(1); j++)
                {
                    Assert.AreEqual(expectedAdjugate[i, j], actualAdjugate[i, j], 0.0001); // Use a delta for floating-point comparison
                }
            }
        }
        public void TestMatrixAdjugate3x3_2()
        {
            // Arrange
            double[,] matrix = {
            { 1, 2, -1 },
            { 2, 1, 2 },
            { -1, 2, 1 }
            };

            double[,] expectedAdjugate = {
            { -3, -4, 5 },
            { -4, 0, -4 },
            { 5, -4, -3 }
            };
            // Act
            double[,] actualAdjugate = Calculator.CalculateAdjugate(matrix);

            // Assert
            Assert.AreEqual(expectedAdjugate.GetLength(0), actualAdjugate.GetLength(0));
            Assert.AreEqual(expectedAdjugate.GetLength(1), actualAdjugate.GetLength(1));

            for (int i = 0; i < expectedAdjugate.GetLength(0); i++)
            {
                for (int j = 0; j < expectedAdjugate.GetLength(1); j++)
                {
                    Assert.AreEqual(expectedAdjugate[i, j], actualAdjugate[i, j], 0.0001); // Use a delta for floating-point comparison
                }
            }
        }

        [TestMethod]
        public void TestMatrixInverse2x2()
        {
            // Arrange
            double[,] matrix = {
            { 2, 3 },
            { 1, 4 }
            };

            double[,] expectedInverse = {
            { 0.8, -0.6 },
            { -0.2, 0.4 }
            };
            // Act
            double[,] actualInverse = Calculator.CalculateInverse(matrix);

            // Assert
            Assert.AreEqual(expectedInverse.GetLength(0), actualInverse.GetLength(0));
            Assert.AreEqual(expectedInverse.GetLength(1), actualInverse.GetLength(1));

            for (int i = 0; i < expectedInverse.GetLength(0); i++)
            {
                for (int j = 0; j < expectedInverse.GetLength(1); j++)
                {
                    Assert.AreEqual(expectedInverse[i, j], actualInverse[i, j], 0.0001); // Use a delta for floating-point comparison
                }
            }
        }

        [TestMethod]
        public void TestMatrixInverse3x3()
        {
            // Arrange
            double[,] matrix = {
            { 2, 0, 2 },
            { 0, 1, 0 },
            { 1, 0, 3 }
            };

            double[,] expectedInverse = {
            { 0.75, 0, -0.5 },
            { 0, 1, 0 },
            { -0.25, 0, 0.5 }
            };

            // Act
            double[,] actualInverse = Calculator.CalculateInverse(matrix);

            // Assert
            Assert.AreEqual(expectedInverse.GetLength(0), actualInverse.GetLength(0));
            Assert.AreEqual(expectedInverse.GetLength(1), actualInverse.GetLength(1));

            for (int i = 0; i < expectedInverse.GetLength(0); i++)
            {
                for (int j = 0; j < expectedInverse.GetLength(1); j++)
                {
                    Assert.AreEqual(expectedInverse[i, j], actualInverse[i, j], 0.0001); // Use a delta for floating-point comparison
                }
            }
        }

        public void TestMatrixInverse3x3_2()
        {
            // Arrange
            double[,] matrix = {
            { 1, 2, -1 },
            { 2, 1, 2 },
            { -1, 2, 1 }
            };

            double[,] expectedInverse = {
            { 0.5, 0.125, -0.3125 },
            { 0.25, 0, 0.25 },
            { -0.3125, 0.125, 0.5 }
            };

            // Act
            double[,] actualInverse = Calculator.CalculateInverse(matrix);

            // Assert
            Assert.AreEqual(expectedInverse.GetLength(0), actualInverse.GetLength(0));
            Assert.AreEqual(expectedInverse.GetLength(1), actualInverse.GetLength(1));

            for (int i = 0; i < expectedInverse.GetLength(0); i++)
            {
                for (int j = 0; j < expectedInverse.GetLength(1); j++)
                {
                    Assert.AreEqual(expectedInverse[i, j], actualInverse[i, j], 0.0001); // Use a delta for floating-point comparison
                }
            }
        }

        [TestMethod]
        public void TestMatrixTranspose2x2()
        {
            // Arrange
            double[,] matrix = {
            { 1, 2 },
            { 3, 4 }
            };

            double[,] expectedTranspose = {
            { 1, 3 },
            { 2, 4 }
            };

            // Act
            double[,] actualTranspose = Calculator.CalculateTranspose(matrix);

            // Assert
            Assert.AreEqual(expectedTranspose.GetLength(0), actualTranspose.GetLength(0));
            Assert.AreEqual(expectedTranspose.GetLength(1), actualTranspose.GetLength(1));

            for (int i = 0; i < expectedTranspose.GetLength(0); i++)
            {
                for (int j = 0; j < expectedTranspose.GetLength(1); j++)
                {
                    Assert.AreEqual(expectedTranspose[i, j], actualTranspose[i, j], 0.0001); // Use a delta for floating-point comparison
                }
            }
        }

        [TestMethod]
        public void TestMatrixTranspose3x3()
        {
            // Arrange
            double[,] matrix = {
            { 1, 2, 3 },
            { 4, 5, 6 },
            { 7, 8, 9 }
            };

            double[,] expectedTranspose = {
            { 1, 4, 7 },
            { 2, 5, 8 },
            { 3, 6, 9 }
            };

            // Act
            double[,] actualTranspose = Calculator.CalculateTranspose(matrix);

            // Assert
            Assert.AreEqual(expectedTranspose.GetLength(0), actualTranspose.GetLength(0));
            Assert.AreEqual(expectedTranspose.GetLength(1), actualTranspose.GetLength(1));

            for (int i = 0; i < expectedTranspose.GetLength(0); i++)
            {
                for (int j = 0; j < expectedTranspose.GetLength(1); j++)
                {
                    Assert.AreEqual(expectedTranspose[i, j], actualTranspose[i, j], 0.0001); // Use a delta for floating-point comparison
                }
            }
        }

        public void TestMatrixTranspose3x3_2()
        {
            // Arrange
            double[,] matrix = {
            { 1, 2, -1 },
            { 2, 1, 2 },
            { -2, 2, 1 }
            };

            double[,] expectedTranspose = {
            { 1, 2, -2 },
            { 2, 1, 2 },
            { -1, 2, 1 }
            };

            // Act
            double[,] actualTranspose = Calculator.CalculateTranspose(matrix);

            // Assert
            Assert.AreEqual(expectedTranspose.GetLength(0), actualTranspose.GetLength(0));
            Assert.AreEqual(expectedTranspose.GetLength(1), actualTranspose.GetLength(1));

            for (int i = 0; i < expectedTranspose.GetLength(0); i++)
            {
                for (int j = 0; j < expectedTranspose.GetLength(1); j++)
                {
                    Assert.AreEqual(expectedTranspose[i, j], actualTranspose[i, j], 0.0001); // Use a delta for floating-point comparison
                }
            }
        }

        [TestMethod]
        public void TestMatrixCofactor2x2()
        {
            // Arrange
            double[,] matrix = {
            { 2, 3 },
            { 1, 4 }
            };

            double[,] expectedCofactor = {
            { 4, -1 },
            { -3, 2 }
            };
            // Act
            double[,] actualCofactor = Calculator.CalculateCofactor(matrix);

            // Assert
            Assert.AreEqual(expectedCofactor.GetLength(0), actualCofactor.GetLength(0));
            Assert.AreEqual(expectedCofactor.GetLength(1), actualCofactor.GetLength(1));

            for (int i = 0; i < expectedCofactor.GetLength(0); i++)
            {
                for (int j = 0; j < expectedCofactor.GetLength(1); j++)
                {
                    Assert.AreEqual(expectedCofactor[i, j], actualCofactor[i, j], 0.0001); // Use a delta for floating-point comparison
                }
            }
        }

        [TestMethod]
        public void TestMatrixCofactor3x3()
        {
            // Arrange
            double[,] matrix = {
            { 2, 0, 2 },
            { 0, 1, 0 },
            { 1, 0, 3 }
            };

            double[,] expectedCofactor = {
            { 3, 0, -1 },
            { 0, 4, 0 },
            { -2, 0, 2 }
            };

            // Act
            double[,] actualCofactor = Calculator.CalculateCofactor(matrix);

            // Assert
            Assert.AreEqual(expectedCofactor.GetLength(0), actualCofactor.GetLength(0));
            Assert.AreEqual(expectedCofactor.GetLength(1), actualCofactor.GetLength(1));

            for (int i = 0; i < expectedCofactor.GetLength(0); i++)
            {
                for (int j = 0; j < expectedCofactor.GetLength(1); j++)
                {
                    Assert.AreEqual(expectedCofactor[i, j], actualCofactor[i, j], 0.0001); // Use a delta for floating-point comparison
                }
            }
        }

        [TestMethod]
        public void TestMatrixCofactor3x3_2()
        {
            // Arrange
            double[,] matrix = {
            { 1, 2, -1 },
            { 2, 1, 2 },
            { -1, 2, 1 }
            };

            double[,] expectedCofactor = {
            { -3, -4, 5 },
            { -4, 0, -4 },
            { 5, -4, -3 }
            };

            // Act
            double[,] actualCofactor = Calculator.CalculateCofactor(matrix);

            // Assert
            Assert.AreEqual(expectedCofactor.GetLength(0), actualCofactor.GetLength(0));
            Assert.AreEqual(expectedCofactor.GetLength(1), actualCofactor.GetLength(1));

            for (int i = 0; i < expectedCofactor.GetLength(0); i++)
            {
                for (int j = 0; j < expectedCofactor.GetLength(1); j++)
                {
                    Assert.AreEqual(expectedCofactor[i, j], actualCofactor[i, j], 0.0001); // Use a delta for floating-point comparison
                }
            }
        }

        [TestMethod]
        public void TestMatrixAddition2x2()
        {
            // Arrange
            double[,] matrixA = {
            { 1, 2 },
            { 3, 4 }
            };

            double[,] matrixB = {
            { 5, 6 },
            { 7, 8 }
            };

            double[,] expectedSum = {
            { 6, 8 },
            { 10, 12 }
            };
            // Act
            double[,] actualSum = Calculator.AddMatrices(matrixA, matrixB);

            // Assert
            CollectionAssert.AreEqual(expectedSum, actualSum);
        }

        [TestMethod]
        public void TestMatrixAddition3x3()
        {
            // Arrange
            double[,] matrixA = {
            { 1, 2, 3 },
            { 4, 5, 6 },
            { 7, 8, 9 }
            };

            double[,] matrixB = {
            { 9, 8, 7 },
            { 6, 5, 4 },
            { 3, 2, 1 }
            };

            double[,] expectedSum = {
            { 10, 10, 10 },
            { 10, 10, 10 },
            { 10, 10, 10 }
            };

            // Act
            double[,] actualSum = Calculator.AddMatrices(matrixA, matrixB);

            // Assert
            CollectionAssert.AreEqual(expectedSum, actualSum);
        }

        [TestMethod]
        public void TestMatrixAdditionInvalid()
        {
            // Arrange
            double[,] matrixA = {
            { 1, 2 },
            { 3, 4 }
            };

            double[,] matrixB = {
            { 5, 6, 7 }, // Invalid 2x3 matrix
            { 8, 9, 10 }
            };

            // Act and Assert
            double[,] actualSum = Calculator.AddMatrices(matrixA, matrixB);
            Assert.ThrowsException<System.ArgumentException>(() => Calculator.AddMatrices(matrixA, matrixB));
        }

        [TestMethod]
        public void TestMatrixMultiplication()
        {
            // Define input matrices
            double[,] matrixA = {
                { 1, 2, 3 },
                { 4, 5, 6 }
            };

            double[,] matrixB = {
                { 7, 8 },
                { 9, 10 },
                { 11, 12 }
            };

            // Define the expected result
            double[,] expected = {
                { 58, 64 },
                { 139, 154 }
            };

            // Call the parallel matrix multiplication method
            double[,] result = Calculator.MultiplyMatrices(matrixA, matrixB);

            // Compare the result with the expected matrix
            Assert.AreEqual(expected.GetLength(0), result.GetLength(0));
            Assert.AreEqual(expected.GetLength(1), result.GetLength(1));

            for (int i = 0; i < expected.GetLength(0); i++)
            {
                for (int j = 0; j < expected.GetLength(1); j++)
                {
                    Assert.AreEqual(expected[i, j], result[i, j]);
                }
            }
        }

        [TestMethod]
        public void TestMatrixSubtraction2x2()
        {
            // Arrange
            double[,] matrixA = {
            { 5, 3 },
            { 2, 7 }
            };

            double[,] matrixB = {
            { 1, 2 },
            { 3, 4 }
            };

            double[,] expectedDifference = {
            { 4, 1 },
            { -1, 3 }
        };

            // Act
            double[,] actualDifference = Calculator.SubtractMatrices(matrixA, matrixB);

            // Assert
            CollectionAssert.AreEqual(expectedDifference, actualDifference);
        }

        [TestMethod]
        public void TestMatrixSubtraction3x3()
        {
            // Arrange
            double[,] matrixA = {
            { 5, 3, 1 },
            { 2, 7, 0 },
            { 2, 2, 2 }
            };

            double[,] matrixB = {
            { 1, 2, 3 },
            { 4, 5, 6 },
            { 7, 8, 9 }
            };

            double[,] expectedDifference = {
            { 4, 1, -2 },
            { -2, 2, -6 },
            { -5, -6, -7 }
        };

            // Act
            double[,] actualDifference = Calculator.SubtractMatrices(matrixA, matrixB);

            // Assert
            CollectionAssert.AreEqual(expectedDifference, actualDifference);
        }

        [TestMethod]
        public void TestMatrixSubtractionInvalid()
        {
            // Arrange
            double[,] matrixA = {
            { 5, 3, 2 },
            { 2, 7, 1 }
            };

            double[,] matrixB = {
            { 1, 2 }, // Invalid 2x3 matrix
            { 4, 5 },
            { 2, 1 }
            };

            // Act and Assert
            Assert.ThrowsException<System.ArgumentException>(() => Calculator.SubtractMatrices(matrixA, matrixB));
        }
    }
}

