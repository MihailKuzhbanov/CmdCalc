using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace CmdCalc
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                String exp;
                Console.WriteLine("Введите выражение");
                exp = Console.ReadLine();
                try
                {
                    Console.WriteLine("Значение: " + Calculate(exp));
                }
                catch
                {
                    Console.WriteLine("Неверные данные");
                }
            }
        }
        public static double Calculate(string expression)
        {
            DataTable table = new DataTable();
            table.Columns.Add("expression", typeof(string), expression);
            DataRow row = table.NewRow();
            table.Rows.Add(row);
            return double.Parse((string)row["expression"]);
        }
    }
}
