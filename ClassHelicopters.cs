using ParamsA;


namespace TypeHelicopters
{
    public enum MedicalOfHelicopter { MedicalHelicopter }//Медецинские вертолёты
    public class MedicalHelicopter : Params
    {
        public MedicalOfHelicopter medic;
        public MedicalHelicopter(string MedicalHelicoptersName, int MedicalHelicoptersCapacity, int MedicalHelicoptersLiftingCapacity, int MedicalHelicoptersRangeOfFlight, int MedicalHelicoptersParamsFuel, MedicalOfHelicopter medic)
            : base(MedicalHelicoptersName, MedicalHelicoptersCapacity, MedicalHelicoptersLiftingCapacity, MedicalHelicoptersRangeOfFlight, MedicalHelicoptersParamsFuel, medic)
        {
            this.medic = medic;
        }
    }

    public enum PassengerOfHelicopter { PassengerHelicopters }//Пассажирские вертолёты
    public class PassengerHelicopter : Params
    {
        public PassengerOfHelicopter pass;
        public PassengerHelicopter(string PassengerHelicoptersName, int PassengerHelicoptersCapacity, int PassengerHelicoptersLiftingCapacity, int PassengerHelicoptersRangeOfFlight, int PassengerHelicoptersParamsFuel, PassengerOfHelicopter pass)
            : base(PassengerHelicoptersName, PassengerHelicoptersCapacity, PassengerHelicoptersLiftingCapacity, PassengerHelicoptersRangeOfFlight, PassengerHelicoptersParamsFuel, pass)
        {
            this.pass = pass;
        }
    }

    public enum MilitaryOfHelicopter { MilitaryHelicopter }//Военные вертолёты
    public class MilitaryHelicopter : Params
    {
        public MilitaryHelicopter(string Paramsname, int Paramscapacity, int ParamsLiftingCapacity, int ParamsRangeOfFlight, int Paramsfuel, object Paramstype)//наследует
            : base(Paramsname, Paramscapacity, ParamsLiftingCapacity, ParamsRangeOfFlight, Paramsfuel, Paramstype)
        {
        }
        public MilitaryOfHelicopter mili;
        public MilitaryHelicopter(string MilitaryHelicopterName, int MilitaryHelicopterCapacity, int MilitaryHelicopterLiftingCapacity, int MilitaryHelicopterRangeOfFlight, int MilitaryHelicopterParamsfuel, MilitaryOfHelicopter mili)
            : base(MilitaryHelicopterName, MilitaryHelicopterCapacity, MilitaryHelicopterLiftingCapacity, MilitaryHelicopterRangeOfFlight, MilitaryHelicopterParamsfuel, mili)
        {
            this.mili = mili;
        }
    }

}