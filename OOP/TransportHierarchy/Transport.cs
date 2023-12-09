
namespace OOP.TransportHierarchy
{
    internal abstract class Transport
    {
        protected string TransportType { get; set; } = "Транспорт";

        public virtual string GetTransportType() => TransportType;

        public abstract void PrintInfo();

        // "Определить метод в суперклассе, который нельзя будет переопределить
        // в классах наследниках и запретить это переопределение"
        //
        //Следующий метод нельзя переопределить, так как он не virtual или abstract
        //sead здесь не подходит, так как он используется, если метод уже override
        public void PrintTransportType()
        {
            Console.WriteLine(TransportType);
        }
    }
}
