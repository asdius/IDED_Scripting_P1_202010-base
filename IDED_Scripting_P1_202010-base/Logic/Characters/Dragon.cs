using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDED_Scripting_P1_202010_base.Logic.Characters
{
    class Dragon : Unit
    {
        public EUnitClass Dragonn { get; }
        public Dragon(EUnitClass _unitClass, int _atk, int _def, int _spd, int _moveRange, int _range) : base(_unitClass, _atk, _def, _spd, _moveRange, _range)
        {
            _unitClass = Dragonn;
            _atk = 50;
            _def = 50;
            _spd = 50;
            _moveRange = 10;
            _range = 5;
            
        }
        public override bool Interact(Unit otherUnit)
        {
            return true;
        }
        public override float CalculoAtack(float BaseAttackAdd)
        {
            BaseAtkAdd = 5;
            return base.CalculoAtack(5);
        }
        public override float CalculoDef(float BaseDefAdd)
        {
            return base.CalculoDef(3);
        }
        public override float CalculoSpeed(float BaseSpeedAdd)
        {
            return base.CalculoSpeed(2);
        }

    }
}
