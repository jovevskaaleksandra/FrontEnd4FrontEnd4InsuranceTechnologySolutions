using FrontEnd4FrontEnd4InsuranceTechnologySolutions.Models;

namespace FrontEnd4FrontEnd4InsuranceTechnologySolutions.State
{
    public class AnchorageState
    {
        public List<PlacedShip> PlacedShips { get; set; } = new();
        public List<FleetItem> RemainingShips { get; set; } = new();

        public void Reset(List<FleetItem> newFleet)
        {
            RemainingShips = newFleet.Select(f => new FleetItem
            {
                ShipDesignation = f.ShipDesignation,
                SingleShipDimensions = f.SingleShipDimensions,
                ShipCount = f.ShipCount
            }).ToList();

            PlacedShips.Clear();
        }
    }
}
