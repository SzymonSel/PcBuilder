namespace PcBuilder.Models {
    public abstract class Component {
        public int Power { get; set; }
        public string Name { get; set; }
        public int TemperatureFlow { get; set; }
        public double Price { get; set; }
    }
}