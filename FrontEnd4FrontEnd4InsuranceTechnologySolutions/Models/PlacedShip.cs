namespace FrontEnd4FrontEnd4InsuranceTechnologySolutions.Models
{
    public class PlacedShip
    {
        public Guid Id { get; set; } = Guid.NewGuid();

        public string ShipDesignation { get; set; } = string.Empty;

        public int X { get; set; }
        public int Y { get; set; }

        public int Width { get; set; }
        public int Height { get; set; }

        public bool IsRotated { get; set; } = false;
    }
}
