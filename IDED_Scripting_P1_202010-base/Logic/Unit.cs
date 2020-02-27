namespace IDED_Scripting_P1_202010_base.Logic
{
    public class Unit
    {
        public int BaseAtk { get; protected set; }
        public int BaseDef { get; protected set; }
        public int BaseSpd { get; protected set; }

        public int MoveRange { get; protected set; }
        public int AtkRange { get; protected set; }

        public float BaseAtkAdd { get; protected set; }
        public float BaseDefAdd { get; protected set; }
        public float BaseSpdAdd { get; protected set; }

        public float Attack { get; protected set; }
        public float Defense { get; protected set; }
        public float Speed { get; protected set; }

        protected Position CurrentPosition;

        public EUnitClass UnitClass { get; protected set; }

        public Unit(EUnitClass _unitClass, int _atk, int _def, int _spd, int _moveRange, int _range)
        {
            UnitClass = _unitClass;
            BaseAtk = _atk;
            BaseDef = _def;
            BaseSpd = _spd;
            MoveRange = _moveRange;
            AtkRange = _range;
        }
        public virtual float CalculoAtack(float BaseAttackAdd)
        {
            Attack = Attack * BaseAtkAdd;
            return Attack;
        }
        public virtual float CalculoDef(float BaseDefAdd)
        {
            Defense = Defense * BaseDefAdd;
            return Defense;
        }
        public virtual float CalculoSpeed(float BaseSpeedAdd)
        {
            Speed = Speed * BaseSpdAdd;
            return Speed;
        }

        public virtual bool Interact(Unit otherUnit)
        {
            return false;
        }

        public virtual bool Interact(Prop prop) => false;

        public bool Move(Position targetPosition) => false;
    }
}