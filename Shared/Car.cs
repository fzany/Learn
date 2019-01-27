using Newtonsoft.Json;
using System;

namespace Shared
{
    /// <summary>
    /// Create a class Insurance and add it to the car class as a property
    /// </summary>
    /// 
    public class Car
    {
        [JsonIgnore]
        public Insurance Insurance { get; set; }

        public string Color { get; set; }
        public string Type { get; set; }
        public string Maufacturer { get; set; }
        public string Model { get; set; }
        public string EngineNumber { get; set; }
        public string Platenumber { get; set; }
        public DateTime PurchaseData { get; set; }
        public double Milage { get; set; }
    }

    public class Insurance
    {
        public string CustomerName { get; set; }
    }
}

