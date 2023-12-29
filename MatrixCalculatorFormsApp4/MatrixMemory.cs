using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatrixCalculatorFormsApp4
{
    public static class MatrixMemory
    {
        private static List<Matrix> matrixList = new List<Matrix>();

        // Event to notify subscribers (e.g., forms) when a matrix is saved
        public static event Action<Matrix> MatrixSaved;

        // Method to save a matrix
        public static void SaveMatrix(Matrix matrix)
        {
            matrixList.Add(matrix);

            // Notify subscribers that a matrix has been saved
            MatrixSaved?.Invoke(matrix);
        }

        public static List<Matrix> GetMatrices()
        {
            return matrixList;
        }
    }
}
