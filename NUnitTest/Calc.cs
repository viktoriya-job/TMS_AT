using System.Data;

namespace NUnitTest;

public class Calc
{
    public int Sum(int a, int b) => a + b;

    public int Div(int a, int b) => a / b;
    
    public double Div(double a, double b) => a / b;
}