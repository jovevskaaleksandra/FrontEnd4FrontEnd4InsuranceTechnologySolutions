namespace FrontEnd4FrontEnd4InsuranceTechnologySolutions.Models
{
    public class FleetItem
    {
        public string ShipDesignation { get; set; } = "";
        public SizeDto SingleShipDimensions { get; set; } = new SizeDto();
        public int ShipCount { get; set; } 
    }
}