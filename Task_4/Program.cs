static class Program
    {
        public static void FindMax(int[,] array,int m, int n, ref int max,ref int intLine, ref int intColumn)
        {
            int tempMax = 0;
            int tempLine = 0, tempColumn = 0;
            for (int i = 0; i < m; i++)
                for (int j = 0; j < n; j ++)
                {
                    if (array[i, j] > tempMax)
                    {
                        tempMax = array[i, j];
                        tempLine = i;
                        tempColumn = j;
                    }
                }
            max = tempMax; intLine = tempLine; intColumn = tempColumn;
        }
        static void Main(string[] args)
        {
            int m = 2, n = 3;
            int[,] intArray = new int[3, 2] { {6,3},{9,8},{5,10}};
            int max = 0; int Line = 0; int Column = 0;
            FindMax(intArray,3,2,ref max,ref Line,ref Column);
 
            while (Line != 0)
            {
                int[] tempInt = new int[2];
                for (int i = 0; i < 2; i++)
                    tempInt[i] = intArray[Line - 1, i];
                for (int i = 0; i < 2; i++)
                    intArray[Line - 1, i] = intArray[Line,i];
                for (int i = 0; i < 2; i++)
                    intArray[Line, i] = tempInt[i];
                Line--;
            }
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 2; j++)
                    Console.Write(intArray[i, j].ToString() + " ");
                Console.WriteLine();
            }
            if (intArray[0, 0] != max)
            {
                int temp = intArray[0, 0];
                intArray[0, 0] = intArray[0, Column];
                intArray[0, Column] = temp;
            }
            Console.WriteLine();
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 2; j++)
                    Console.Write(intArray[i, j].ToString() + " ");
                Console.WriteLine();
            }
                //Console.WriteLine(max.ToString() + " " + Line.ToString() + " " + Column.ToString() + " ");
                Console.ReadKey();
        }
    }
