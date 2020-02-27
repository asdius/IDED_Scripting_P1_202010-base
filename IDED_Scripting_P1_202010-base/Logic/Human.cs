namespace IDED_Scripting_P1_202010_base.Logic
{
    abstract class Human : Unit
    {
        public float Potential { get; set; }

        public Human(EUnitClass _unitClass, int _atk, int _def, int _spd, int _moveRange, float _potential, int _range)
            : base(_unitClass, _atk, _def, _spd, _moveRange, _range)
        {
            Potential = _potential;
        }
        

        public virtual bool ChangeClass(EUnitClass newClass)
        {
            return false;
        }

        //internal abstract bool Interact(EUnitClass villagerr);
    }
}