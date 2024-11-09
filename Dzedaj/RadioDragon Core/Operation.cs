using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class RD
{
    public static void Operate(string value1, string operation, string value2)
    {
        int result;
        if (operation == "+")
        {
            int V1 = int.Parse(value1);
            int V2 = int.Parse(value2);
            result = Operation.Add(V1, V2);
            Console.WriteLine(result);
            Terminal.Prompt();
        }
        if (operation == "-")
        {
            int V1 = int.Parse(value1);
            int V2 = int.Parse(value2);
            result = Operation.Subtract(V1, V2);
            Console.WriteLine(result);
            Terminal.Prompt();
        }
        if (operation == "*")
        {
            int V1 = int.Parse(value1);
            int V2 = int.Parse(value2);
            result = Operation.Multiply(V1, V2);
            Console.WriteLine(result);
            Terminal.Prompt();
        }
        if (operation == "/")
        {
            int V1 = int.Parse(value1);
            int V2 = int.Parse(value2);
            result = Operation.Divide(V1, V2);
            Console.WriteLine(result);
            Terminal.Prompt();
        }
        if (operation == "s")
        {
            int V = int.Parse(value1);
            double resultD = Operation.SQRT(V);
            Console.WriteLine(resultD);
            Terminal.Prompt();
        }
        if (operation == "^")
        {
            int V1 = int.Parse(value1);
            int V2 = int.Parse(value1);
            double resultD = Operation.POW(V1, V2);
            Console.WriteLine(resultD);
            Terminal.Prompt();
        }
        if (operation == "A")
        {
            int V = int.Parse(value1);
            decimal resultD = Operation.ABS(V);
            Console.WriteLine(resultD);
            Terminal.Prompt();
        }
    }
}
public class Operation
{
    public static int Add(int value1, int value2)
    {
        return value1 + value2;
    }
    public static int Subtract(int value1, int value2)
    {
        return value1 - value2;
    }
    public static int Multiply(int value1, int value2)
    {
        return value1 * value2;
    }
    public static int Divide(int value1, int value2)
    {
        return value1 / value2;
    }
    public static double SQRT(int value1)
    {
        return Math.Sqrt(value1);
    }
    public static double POW(int value1, int value2)
    {
        return Math.Pow(value1, value2);
    }
    public static decimal ABS(int value1)
    {
        return Math.Abs(value1);
    }
}