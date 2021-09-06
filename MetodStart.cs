using list1;
using ParamsA;
using System.Collections.Generic;
using System.Linq;

namespace MetodStart
{
    public class Ms : IMetod
    {
        private ICollection<Params> items;

        public Ms()
        {
            items = new List<Params>();
        }
        public void Add(Params Paramms)
        {
            items.Add(Paramms);
        }
        public int AircraftCapacity()
        {
            return items.Sum(x => x.Capacity);
        }

        public int AircraftLiftingCapacity()
        {
            return items.Sum(x => x.LiftingCapacity);
        }

        public void sorting()
        {
            var G = items.OrderByDescending(x => x.RangeOfFlight).ToList();
            items.Clear();

            foreach (var item in G)
            {
                items.Add(item);
            }
        }
        public IEnumerable<Params> FuelConsumption(int max)
        {
            return items.Where(x => (x.Fuel <= max)).ToList();
        }

        public int MaximumFuelSupply()

        {
            return items.Max(x => x.Fuel);
        }

        public IEnumerable<Params> Items
        {
            get { return items; }
        }
    }
}
