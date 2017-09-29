
namespace MarketSimulation.Classes
{
    public class Structs
    {
        public struct Item
        {
            private string Name { get; set; }
            private int SerialNumber { get; set; }
            private float BaseProcessingTime { get; set; }

            public Item(string name, int serialNumber, float baseProcessingTime)
            {
                Name = name;
                SerialNumber = serialNumber;
                BaseProcessingTime = baseProcessingTime;
            }
        }
        public struct Counter
        {
            private int SerialNumber { get; set; }
            private int ItemsLimit { get; set; } //set to 0 if no limit

            public Counter(int serialNumber, int itemsLimit)
            {
                SerialNumber = serialNumber;
                ItemsLimit = itemsLimit;
            }

        }
        public struct Customer
        {
            private string Name { get; set; }
            private int SerialNumber { get; set; }
            private float BaseProcessingTime { get; set; }

            public Customer(string name, int serialNumber, float baseProcessingTime)
            {
                Name = name;
                SerialNumber = serialNumber;
                BaseProcessingTime = baseProcessingTime;
            }
        }
        public struct Cashier
        {
            private string Name { get; set; }
            private int SerialNumber { get; set; }
            private float BaseProcessingTime { get; set; }

            public Cashier(string name, int serialNumber, float baseProcessingTime)
            {
                Name = name;
                SerialNumber = serialNumber;
                BaseProcessingTime = baseProcessingTime;
            }
        }
    }
}
