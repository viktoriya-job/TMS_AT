using System.Data;

namespace NUnitTest;

public class Calc
{
    public int Sum(int a, int b) => a + b;

    public int Div(int a, int b) => a / b;
    
    public double Div(double a, double b)
    {
        if (b == 0)
            throw new DivideByZeroException(); //без if для double возвращается null в случае деления на 0 - прокинула Exception
        return a / b;
    }
}