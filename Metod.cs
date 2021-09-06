using System.Collections.Generic;
using ParamsA;

namespace list1
{
    public interface IMetod
    {
        IEnumerable<Params> Items { get; }
        void Add(Params Paramms);
        int AircraftCapacity();
        int AircraftLiftingCapacity();
        void sorting();
        int MaximumFuelSupply();
        IEnumerable<Params> FuelConsumption(int max);
    }
}
