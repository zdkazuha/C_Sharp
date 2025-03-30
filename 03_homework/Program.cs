using System;
using System.ComponentModel.Design;
using System.Text;

internal class Program
{
    static void Print(int[] arr)
    {
        foreach (var item in arr)
        {
            Console.Write($"{item,-20}");
        }
        Console.WriteLine();
    }
    static void Print(double[,] arr)
    {
        for (int i = 0; i < arr.GetLength(0); i++)
        {
            for (int j = 0; j < arr.GetLength(1); j++)
            {
                Console.Write($"{arr[i, j],-20:F2}");
            }
            Console.WriteLine();
        }
    }
    static double MaxArrTwo(int[] arr1, double[,] arr2)
    {
        int max1 = arr1[0];
        double max2 = arr2[0, 0];
        for (int i = 0; i < arr1.Length; i++)
        {
            if (max1 < arr1[i])
                max1 = arr1[i];
        }
        for (int i = 0; i < arr2.GetLength(0); i++)
        {
            for (int j = 0; j < arr2.GetLength(1); j++)
            {
                if (max2 < arr2[i, j])
                    max2 = arr2[i, j];
            }
        }
        if (max1 < max2)
            return max2;
        else
            return max1;
    }
    static double MinArrTwo(int[] arr1, double[,] arr2)
    {
        int min1 = arr1[0];
        double min2 = arr2[0, 0];
        for (int i = 0; i < arr1.Length; i++)
        {
            if (min1 > arr1[i])
                min1 = arr1[i];
        }
        for (int i = 0; i < arr2.GetLength(0); i++)
        {
            for (int j = 0; j < arr2.GetLength(1); j++)
            {
                if (min2 > arr2[i, j])
                    min2 = arr2[i, j];
            }
        }
        if (min1 > min2)
            return min2;
        else
            return min1;
    }
    static double SumArrTwo(int[] arr1, double[,] arr2)
    {
        double sum = 0;
        for (int i = 0; i < arr1.Length; i++)
        {
            sum += arr1[i];
        }
        for (int i = 0; i < arr2.GetLength(0); i++)
        {
            for (int j = 0; j < arr2.GetLength(1); j++)
            {
                sum = sum + arr2[i, j];
            }
        }
        return sum;
    }
    static double MultArrTwo(int[] arr1, double[,] arr2)
    {
        int productA = 1;
        foreach (var item in arr1) productA *= item;

        double productB = 1;
        foreach (var item in arr2) productB *= item;

        return (productA * productB);
    }
    static int EvenArr(int[] arr)
    {
        int sum = 0;
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] % 2 == 0)
                sum += arr[i];
        }
        return sum;
    }
    static double OddArr(double[,] arr)

    {
        double sum = 0;
        for (int i = 0; i < arr.GetLength(0); i++)
        {
            for (int j = 0; j < arr.GetLength(1); j++)
            {
                if (j % 2 != 0)
                {
                    sum += arr[i, j];
                }
            }
        }
        return sum;
    }



    static int Max_(int[,] arr)
    {
        int max = arr[0, 0];
        for (int i = 0; i < arr.GetLength(0); i++)
        {
            for (int j = 0; j < arr.GetLength(1); j++)
            {
                if (max < arr[i, j])
                    max = arr[i, j];
            }
        }
        return max;
    }
    static int Min_(int[,] arr)
    {
        ;
        int min = arr[0, 0];
        for (int i = 0; i < arr.GetLength(0); i++)
        {
            for (int j = 0; j < arr.GetLength(1); j++)
            {
                if (min > arr[i, j])
                    min = arr[i, j];
            }
        }
        return min;
    }

    static void Print(int[,] arr)
    {
        for (int i = 0; i < arr.GetLength(0); i++)
        {
            for (int j = 0; j < arr.GetLength(1); j++)
            {
                Console.Write($"{arr[i, j],-10}");
            }
            Console.WriteLine();
        }
    }

    static string CaesarsCipher(string text, int numb = 3)
    {
        char[] charArray = text.ToCharArray();
        for (int i = 0; i < charArray.Length; i++)
        {
            if (char.IsLetter(charArray[i]))
            {
                if (char.IsUpper(charArray[i]))
                {
                    charArray[i] = (char)((charArray[i] - 'A' + numb) + 'A');
                }
                else
                {
                    charArray[i] = (char)((charArray[i] - 'a' + numb) + 'a');
                }
            }
        }
        return new string(charArray);
    }


    static string CaesarsDecipherer(string text, int numb = 3)
    {
        char[] charArray = text.ToCharArray();
        for (int i = 0; i < charArray.Length; i++)
        {
            if (char.IsLetter(charArray[i]))
            {
                if (char.IsUpper(charArray[i]))
                {
                    charArray[i] = (char)((charArray[i] - 'A' - numb) + 'A');
                }
                else
                {
                    charArray[i] = (char)((charArray[i] - 'a' - numb) + 'a');
                }
            }
        }
        return new string(charArray);
    }

    static int[,] MultMatrix(int[,] matrix, int numb)
    {
        int[,] matrix0 = new int[3, 3];
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                matrix0[i, j] = (matrix[i, j] * numb);
            }
        }
        return matrix0;
    }

    static int[,] AddingMatrices(int[,] matrix1, int[,] matrix2)
    {
        if (matrix1.GetLength(0) != matrix2.GetLength(0) || matrix1.GetLength(1) != matrix2.GetLength(1))
        {
            Console.WriteLine("Error!!!");
            return new int[0, 0];
        }
            
        int[,] matrix0 = new int[3, 3];
        {
            for (int i = 0; i < matrix1.GetLength(0); i++)
            {
                for (int j = 0; j < matrix1.GetLength(1); j++)
                {
                    matrix0[i, j] = (matrix1[i, j] + matrix2[i,j]);
                }
            }
            return matrix0;
        }
    }

    static int[,] MatrixDob(int[,] matrix1, int[,] matrix2)
    {
        int rows1 = matrix1.GetLength(0);
        int cols1 = matrix1.GetLength(1);
        int rows2 = matrix2.GetLength(0);
        int cols2 = matrix2.GetLength(1);

        int[,] matrix0 = new int[rows1, cols2];

        for (int i = 0; i < rows1; i++)
        {
            for (int j = 0; j < cols2; j++) 
            {
                matrix0[i, j] = 0;
                for (int k = 0; k < cols1; k++)
                {
                    matrix0[i, j] += matrix1[i, k] * matrix2[k, j];
                }
            }
        }

        return matrix0;
    }
    private static void Main(string[] args)
    {
        // 1

        //int[] A = new int[5];
        //double[,] B = new double[3, 4];
        //Random random = new Random();

        //for (int i = 0; i < A.Length; i++)
        //{
        //    Console.Write($"Enter number {i + 1} :: ");
        //    A[i] = int.Parse(Console.ReadLine());
        //}

        //for (int i = 0; i < B.GetLength(0); i++)
        //{
        //    for (int j = 0; j < B.GetLength(1); j++)
        //    {
        //        B[i, j] = (double)(random.NextDouble() * 10);
        //    }
        //}
        //Print(A);
        //Print(B);

        //Console.WriteLine($"Max element array A and array B  :: {MaxArrTwo(A,B),-20:f2}");
        //Console.WriteLine($"Min element array A and array B  :: {MinArrTwo(A,B),-20:f2}");
        //Console.WriteLine($"Sum elements array A and array B  :: {SumArrTwo(A,B),-20:f2}");
        //Console.WriteLine($"Mult elements array A and array B :: {MultArrTwo(A,B),-20:f2}");
        //Console.WriteLine($"Even elements array A             :: {EvenArr(A)}");
        //Console.WriteLine($"Sum odd elements array B          :: {OddArr(B),-20:f2}");

        // 2

        //int[,] arr = new int[5, 5];
        //Random random = new Random();

        //for(int i = 0; i < arr.GetLength(0); i++)
        //{
        //    for (int j = 0; j < arr.GetLength(1); j++)
        //    {
        //        arr[i, j] = random.Next(-100,101);
        //    }
        //}
        //Print(arr);

        //int sum = 0;
        //for (int i = 0; i < arr.GetLength(0); i++)
        //{
        //    for (int j = 0; j < arr.GetLength(1); j++)
        //    {
        //        if (arr[i, j] > Min_(arr) && arr[i, j] < Max_(arr))
        //            sum += arr[i, j];
        //    }
        //}
        //Console.WriteLine(sum);

        // 3

        //Console.WriteLine("Enter text :: ");
        //string text = Console.ReadLine(); 

        //Console.WriteLine("You entered: " + text);

        //string encryptedText = CaesarsCipher(text);
        //Console.WriteLine("Encrypted text: " + encryptedText);

        //string decryptedText = CaesarsDecipherer(encryptedText);
        //Console.WriteLine("Decrypted text: " + decryptedText);

        // 4

        //int[,] matrix1 = new int[3,3] 
        //    {
        //        {1,2,3 },
        //        {4,5,6 },
        //        {7,8,9 }
        //    };

        //int[,] matrix2 = new int[3,3]
        //    {
        //        {11,22,33 },
        //        {44,55,66 },
        //        {77,88,99 }
        //    };

        //Console.WriteLine("Origin :: ");
        //Print(matrix1);
        //Console.WriteLine();
        //Console.WriteLine("Mult matrix :: ");
        //int[,] matrix0 = MultMatrix(matrix1,3);
        //Print(matrix0);
        //Console.WriteLine();

        //Console.WriteLine("Matrix 1 :: ");
        //Print(matrix1);
        //Console.WriteLine();

        //Console.WriteLine("Matrix 2 :: ");
        //Print(matrix2);
        //Console.WriteLine();

        //matrix0 = AddingMatrices(matrix1, matrix2);
        //Console.WriteLine("Adding Matrices :: ");
        //Print(matrix0);
        //Console.WriteLine();

        //matrix0 = MatrixDob(matrix1, matrix2);
        //Console.WriteLine("Matrix dobutoc :: ");
        //Print(matrix0);
        //Console.WriteLine();
    }
}