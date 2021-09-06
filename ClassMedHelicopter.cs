using TypeHelicopters;

namespace TypeMilitaryHelicopters
{
    public enum TypeOfMilitaryHelicopter { Fighters, Bombers, Scouts }//Типы военных вертолётов 
    public class TypeMilitaryHelicopter : MilitaryHelicopter
    {
        public new TypeOfMilitaryHelicopter mili;
        public TypeMilitaryHelicopter(string TypeMilitaryHelicopterName, int TypeMilitaryHelicopterCapacity, int TypeMilitaryHelicopterLiftingCapacity, int TypeMilitaryHelicopterRangeOfFlight, int TypeMilitaryHelicopterParamsFuel, TypeOfMilitaryHelicopter mili)
            : base(TypeMilitaryHelicopterName, TypeMilitaryHelicopterCapacity, TypeMilitaryHelicopterLiftingCapacity, TypeMilitaryHelicopterRangeOfFlight, TypeMilitaryHelicopterParamsFuel, mili)
        {
            this.mili = mili;
        }
    }
}