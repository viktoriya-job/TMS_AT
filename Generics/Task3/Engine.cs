namespace Generics
{
    internal abstract class Engine
    {
        public int EnginePower { get; set; }
    }

    internal class DieselEngine : Engine
    {
        public int EngineCapacity { get; set; }
    }

    internal class GasEngine : Engine
    {
        public int EngineCapacity { get; set; }
    }

    internal class ElectricEngine : Engine
    {

    }
}