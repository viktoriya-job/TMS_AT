using OOP.TransportHierarchy;
using System.Security.Cryptography.X509Certificates;
using System.Text;

internal partial class Program
{
    private static void Main(string[] args)
    {
        Console.OutputEncoding = Encoding.Unicode;

        //var square = new Square(4);
        //Console.WriteLine(square.RectangleArea());

        //var rectangle = new Rectangle(2, 3);
        //Console.WriteLine(rectangle.RectangleArea());

        //var triangle = new Triangle(7, 10, 5);

        //Console.WriteLine(triangle.TriangleArea());

        //var triangleTwoSidesEqual = new TriangleTwoSidesEqual(7, 5, 5);
        //Console.WriteLine(triangleTwoSidesEqual.TriangleArea());

        //var triangleAllSidesEqual = new TriangleAllSidesEqual(7,7,7);
        //Console.WriteLine(triangleAllSidesEqual.TriangleArea());

        //var triangleRightAngle = new TriangleRightAngle(3, 4, 5);
        //Console.WriteLine(triangleRightAngle.TriangleArea());




        //var trian = new TriangleCreation(5, 5, 5);
        //Console.WriteLine(trian.ArmsEquality);

        //var trian = new TriangleAllSidesEqual(4);
        //Console.WriteLine(trian.TriangleArea()); 

        //Console.WriteLine("erghserh");

        //var tr = new TransportWater();
        //Console.WriteLine(tr.GetTransportType());

        //var tr1 = new TransportAir();
        //Console.WriteLine(tr1.GetTransportType());

        //var tr2 = new TransportBackward();
        //Console.WriteLine(tr2.GetTransportType());

        //var tr3 = new Transport();
        //Console.WriteLine(tr3.GetTransportType());

        //var tr4 = new TransportWaterRiver();
        //Console.WriteLine(tr4.GetTransportType());

        //var tr5 = new TransportWaterSea();
        //Console.WriteLine(tr5.GetTransportType());

        //var tr6 = new TransportAirAviation();
        //Console.WriteLine(tr6.GetTransportType());

        //var tr7 = new TransportAirAeronautical();
        //Console.WriteLine(tr7.GetTransportType());

        //var tr8 = new TransportBackwardRailway();
        //Console.WriteLine(tr8.GetTransportType());

        //var tr9 = new TransportBackwardAutomobile();
        //Console.WriteLine(tr9.GetTransportType());

        //var tr10 = new TransportWaterRiverFerry();
        //Console.WriteLine(tr10.GetTransportType());

        //var tr11 = new TransportWaterRiverTram();
        //Console.WriteLine(tr11.GetTransportType());



        var trn1 = new Transport();
        Transport.PrintRedText("Transport");
        Console.WriteLine(trn1.GetTransportInfo());

        var trn3 = new TransportWater();
        Transport.PrintRedText("TransportWater");
        Console.WriteLine(trn3.GetTransportInfo());

        var trn4 = new TransportWaterRiver();
        Transport.PrintRedText("TransportWaterRiver");
        Console.WriteLine(trn4.GetTransportInfo());

        var tr2 = new TransportWaterRiverTram();
        Transport.PrintRedText("TransportWaterRiverTram");
        Console.WriteLine(tr2.GetTransportInfo());

        var tr12 = new TransportWaterRiverTram("wef111");
        Transport.PrintRedText("TransportWaterRiverTram(\"wef111\")");
        Console.WriteLine(tr12.GetTransportInfo());

        var tr13 = new TransportWaterRiverTram("wef111", "Краснодар");
        Transport.PrintRedText("TransportWaterRiverTram(\"wef111\", \"Краснодар\")");
        Console.WriteLine(tr13.GetTransportInfo());

        var tr14 = new TransportWaterRiverTram("wef111", "Краснодар", 20);
        Transport.PrintRedText("TransportWaterRiverTram(\"wef111\", \"Краснодар\", 20)");
        Console.WriteLine(tr14.GetTransportInfo());

        var tr15 = new TransportWaterRiverTram("wef111", "Краснодар", 40, new DateTime(2024, 12, 20));
        Transport.PrintRedText("TransportWaterRiverTram(\"wef111\", \"Краснодар\", 40, new DateTime(2024, 12, 20))");
        Console.WriteLine(tr15.GetTransportInfo());

        var tr16 = new TransportWaterRiverFerry("jh36hjj", "Sity", 165, new DateTime(2023, 12, 31));
        Transport.PrintRedText("TransportWaterRiverFerry(\"jh36hjj\", \"Sity\", 165, new DateTime(2023, 12, 31))");
        Console.WriteLine(tr16.GetTransportInfo());



        //Transport[] transportArray = { tr, tr1};

    }
}