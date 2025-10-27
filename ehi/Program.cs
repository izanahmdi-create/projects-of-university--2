using System;

namespace DrawLetters
{
    class Program
    {
        static void Main(string[] args)
        {
            int height = 7; // ارتفاع حرف (ترجیحا عدد فرد)
            int width = 5;  // پهنا برای حروف E و H (I اندازه‌اش وابسته به height است)

            string[] e = DrawE(height, width);
            string[] h = DrawH(height, width);
            string[] i = DrawI(height, width);

            // چاپ سه حرف کنار هم با یک فاصله بینشان
            for (int r = 0; r < height; r++)
            {
                Console.Write(e[r] + "  " + h[r] + "  " + i[r]);
                Console.WriteLine();
            }

            Console.ReadKey();
        }

        // رسم حرف E
        static string[] DrawE(int height, int width)
        {
            string[] rows = new string[height];
            int mid = height / 2;

            for (int r = 0; r < height; r++)
            {
                if (r == 0 || r == mid || r == height - 1)
                {
                    // خطوط کامل بالا، وسط و پایین
                    rows[r] = new string('*', width);
                }
                else
                {
                    // ستاره در ستون اول و بقیه فاصله
                    rows[r] = "*" + new string(' ', width - 1);
                }
            }
            return rows;
        }

        // رسم حرف H
        static string[] DrawH(int height, int width)
        {
            string[] rows = new string[height];
            int mid = height / 2;

            for (int r = 0; r < height; r++)
            {
                char[] line = new char[width];
                for (int c = 0; c < width; c++) line[c] = ' ';

                // ستاره در ستون اول و ستون آخر
                line[0] = '*';
                line[width - 1] = '*';

                // خط افقی در وسط
                if (r == mid)
                {
                    for (int c = 0; c < width; c++) line[c] = '*';
                }

                rows[r] = new string(line);
            }
            return rows;
        }

        // رسم حرف I (با پهنای یک ستاره در میانه و خطوط بالا/پایین کامل)
        static string[] DrawI(int height, int width)
        {
            string[] rows = new string[height];
            int midCol = width / 2; // ستون میانی برای | در I

            for (int r = 0; r < height; r++)
            {
                if (r == 0 || r == height - 1)
                {
                    // خطوط بالا و پایین کامل
                    rows[r] = new string('*', width);
                }
                else
                {
                    char[] line = new char[width];
                    for (int c = 0; c < width; c++) line[c] = ' ';
                    line[midCol] = '*';
                    rows[r] = new string(line);
                }
            }
            return rows;
        }
    }
}