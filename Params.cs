namespace ParamsA
{
    public abstract class Params
    {
        public string Name { get; set; }// марка самолёта 

        public int Capacity { get; set; }// вместимость 
        public int LiftingCapacity { get; set; } //грузоподъёмность

        public int RangeOfFlight { get; set; }//дальность полёта 
        public int Fuel { get; set; }//топливо

        public object Type { get; set; }

        public Params(string Paramsname, int Paramscapacity, int ParamsLiftingCapacity, int ParamsRangeOfFlight, int Paramsfuel, object Paramstype)
        {

            Name = Paramsname;
            Capacity = Paramscapacity;
            LiftingCapacity = ParamsLiftingCapacity;
            RangeOfFlight = ParamsRangeOfFlight;
            Fuel = Paramsfuel;
            Type = Paramstype;

        }

    }
}
