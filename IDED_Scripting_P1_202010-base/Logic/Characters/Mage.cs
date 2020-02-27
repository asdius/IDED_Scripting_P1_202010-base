using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDED_Scripting_P1_202010_base.Logic.Characters
{
    class Mage : Human
    {
        public EUnitClass Magee { get; }
        public Mage(EUnitClass _unitClass, int _atk, int _def, int _spd, int _moveRange, float _potential, int _range) : base(_unitClass, _atk, _def, _spd, _moveRange, _potential, _range)
        {
            _unitClass = Magee;
            _atk = 25;
            _def = 15;
            _spd = 15;
            _moveRange = 2;
            _potential = 7;
            _range = 3;
        }

       

        public override bool ChangeClass(EUnitClass Reanger)
        {
            return base.ChangeClass(Reanger);
        }
        public override bool Interact(Unit Reanger)
        {
            return false;
        }

    }
}
