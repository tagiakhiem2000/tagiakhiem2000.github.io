using System;

namespace test
{
    class Program
    {
        static void Main(string[] args)
        {
            //test1.Back();

            int[,] board ={ { 0, 1, 0 },{ 0, 0, 1 },{ 1, 1, 1 },{0, 0, 0} };
            int[,] output = Convert(board);
            Print(output);

        }

        static void Print(int[,] matrix)
        {
            int rows = matrix.GetLength(0);
            int cols = matrix.GetLength(1);
            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < cols; col++)
                {
                    Console.Write($"{matrix[row, col]},");
                }
                Console.WriteLine();
            }
        }

        static int[,] Convert(int[,] board)
        {
            int[,] output = board.Clone() as int[,];
            test2.goc1(board, output);
            test2.goc2(board, output);
            test2.goc3(board, output);
            test2.goc4(board, output);
            test2.hangdau(board, output);
            test2.hangcuoi(board, output);
            test2.cotdau(board, output);
            test2.cotcuoi(board, output);
            test2.ogiua(board, output);
            return output;
        }
    }
    class test1
    {
        public static void Back()
        {
            string before, after = "";
            Console.Write("Nhap chuoi: s =");
            before = Console.ReadLine();
            while (before.IndexOf(" ") != -1)
            {
                for (int i = before.IndexOf(" ") - 1; i >= 0; i--) after = after + before[i];
                after = after + " ";
                before = before.Remove(0, before.IndexOf(" ") + 1);
            }
            for (int i = before.Length - 1; i >= 0; i--) after = after + before[i];
            Console.WriteLine(after);
        }
    }
    class test2
    {
        public static void goc1(int[,] board, int[,] output)
        {
            //output = test2.nextgen(board);
            int soso1 = 0;
            int i, j;
            int m = board.GetLength(0), n = board.GetLength(1);
            //o goc [0,0]
            for (i = 0; i <= 1; i++)
                for (j = 0; j <= 1; j++)
                    if (board[i, j] == 1) soso1++;
            if (board[0, 0] == 1)
            {
                if (soso1 - 1 == 2 || soso1 - 1 == 3) output[0, 0] = 1;
                else output[0, 0] = 0;
            }
            else
            {
                if (soso1 == 3) output[0, 0] = 1;
            }
        }
        public static void goc2(int[,] board, int[,] output)
        {
            //output = board.Clone() as int[,];
            int soso1 = 0;
            int i=0, j=0;
            int m = board.GetLength(0), n = board.GetLength(1);
            for (i = m - 2; i <= m - 1; i++)
                for (j = n - 2; j <= n - 1; j++)
                    if (board[i, j] == 1) soso1++;
            if (board[m - 1, n - 1] == 1)
            {
                if (soso1 - 1 == 2 || soso1 - 1 == 3) output[m - 1, n - 1] = 1;
                else output[m - 1, n - 1] = 0;
            }
            else
            {
                if (soso1 == 3) output[m - 1, n - 1] = 1;
            }
        }
        public static void goc3(int[,] board, int[,] output)
        {
            //output = board.Clone() as int[,];
            //output = test2.nextgen(board);
            int soso1 = 0;
            int i=0, j=0;
            int m = board.GetLength(0), n = board.GetLength(1);
            for (i = 0; i <= 1; i++)
                for (j = n - 2; j <= n - 1; j++)
                    if (board[i, j] == 1) soso1++;
            if (board[0, n - 1] == 1)
            {
                if (soso1 - 1 == 2 || soso1 - 1 == 3) output[0, n - 1] = 1;
                else output[0, n - 1] = 0;
            }
            else
            {
                if (soso1 == 3) output[0, n - 1] = 1;
            }
        }
        public static void goc4(int[,] board, int[,] output)
        {
            //output = board.Clone() as int[,];
            //output = test2.nextgen(board);
            int soso1 = 0;
            int i=0, j=0;
            int m = board.GetLength(0), n = board.GetLength(1);
            for (i = m - 2; i <= m - 1; i++)
                for (j = 0; j <= 1; j++)
                    if (board[i, j] == 1) soso1++;
            if (board[m - 1, 0] == 1)
            {
                if (soso1 - 1 == 2 || soso1 - 1 == 3) output[m - 1, 0] = 1;
                else output[m - 1, 0] = 0;
            }
            else
            {
                if (soso1 == 3) output[m - 1, 0] = 1;
            }
        }
        public static void hangdau(int[,] board, int[,] output)
        {
            //output = board.Clone() as int[,];
            //output = test2.nextgen(board);
            int i=0, j=0;
            int soso1 = 0;
            int m = board.GetLength(0), n = board.GetLength(1);
            for (int k = 1; k <= n - 2; k++)
            {
                soso1 = 0;
                for (i = 0; i <= 1; i++)
                    for (j = k - 1; j <= k + 1; j++)
                        if (board[i, j] == 1) soso1++;
                if (board[0, k] == 1)
                {
                    if (soso1 - 1 == 2 || soso1 - 1 == 3) output[0, k] = 1;
                    else output[0, k] = 0;
                }
                else
                {
                    if (soso1 == 3) output[0, k] = 1;
                }
            }
        }
        public static void cotdau(int[,] board, int[,] output)
        {
            //output = board.Clone() as int[,];
            int soso1 = 0;
            int i=0, j=0;
            int m = board.GetLength(0), n = board.GetLength(1);
            for (int k = 1; k <= m - 2; k++)
            {
                soso1 = 0;
                for (i = k - 1; i <= k + 1; i++)
                    for (j = 0; j <= 1; j++)
                        if (board[i, j] == 1) soso1++;
                if (board[k, 0] == 1)
                {
                    if (soso1 - 1 == 2 || soso1 - 1 == 3) output[k, 0] = 1;
                    else output[k, 0] = 0;
                }
                else
                {
                    if (soso1 == 3) output[k, 0] = 1;
                }
            }
        }
        public static void hangcuoi(int[,] board, int[,] output)
        {
            //output = board.Clone() as int[,];
            //output = test2.nextgen(board);
            int soso1 = 0;
            int i=0, j=0;
            int m = board.GetLength(0), n = board.GetLength(1);
            for (int k = 1; k <= n - 2; k++)
            {
                soso1 = 0;
                for (i = m - 2; i <= m - 1; i++)
                    for (j = k - 1; j <= k + 1; j++)
                        if (board[i, j] == 1) soso1++;
                if (board[m - 1, k] == 1)
                {
                    if (soso1 - 1 == 2 || soso1 - 1 == 3) output[m - 1, k] = 1;
                    else output[m - 1, k] = 0;
                }
                else
                {
                    if (soso1 == 3) output[m - 1, k] = 1;
                }
            }
        }
        public static void cotcuoi(int[,] board, int[,] output)
        {
            //output = board.Clone() as int[,];
            //output = test2.nextgen(board);
            int soso1 = 0;
            int i=0, j=0;
            int m = board.GetLength(0), n = board.GetLength(1);
            for (int k = 1; k <= m - 2; k++)
            {
                soso1 = 0;
                for (i = k - 2; i <= k + 1; i++)
                    for (j = n - 2; j <= n - 1; j++)
                        if (board[i, j] == 1) soso1++;
                if (board[k, n - 1] == 1)
                {
                    if (soso1 - 1 == 2 || soso1 - 1 == 3) output[k, n - 1] = 1;
                    else output[k, n - 1] = 0;
                }
                else
                {
                    if (soso1 == 3) output[k, n - 1] = 1;
                }
            }
        }
        public static void ogiua(int[,] board, int[,] output)
        {
            //output = board.Clone() as int[,];
            //output = test2.nextgen(board);
            int soso1 = 0;
            int i=0, j=0,h=0,k=0;
            int m = board.GetLength(0), n = board.GetLength(1);
            for (i=1;i<=m-2;i++)
                for(j=1;j<=n-2;j++)
                {
                    soso1 = 0;
                    for (k = i - 1; k <= i + 1; k++)
                        for (h = j - 1; h <= j + 1; h++)
                            if (board[k, h] == 1) soso1++;
                    if (board[i, j] == 1)
                    {
                        if (soso1 - 1 == 2 || soso1 - 1 == 3) output[i, j] = 1;
                        else output[i, j] = 0;
                    }
                    else
                    {
                        if (soso1 == 3) output[i, j] = 1;
                    }
                }
        }
    }
    //class test3
    //{
    //    public static bool check(int[] nums)
    //    {
    //        int index, count,i;
    //        count = 0;
    //        i = 0;
    //        for (index=1;index<=nums.Length-1;index++)
    //        {
    //            if (nums[index-1] - nums[index] >= 0)
    //            {
    //                count++;
    //                i = index;
    //            }
    //        }
    //        if (count > 1) return false;
    //        else if (count == 1)
    //        {
    //            if (nums[i])
    //        }
    //    }
    //}
}
