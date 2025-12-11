namespace FrontEnd4FrontEnd4InsuranceTechnologySolutions.Models
{
    public class FleetResponse
    {
        public SizeDto AnchorageSize { get; set; } = new();
        public List<FleetItem> Fleets { get; set; } = new();
    }
}
