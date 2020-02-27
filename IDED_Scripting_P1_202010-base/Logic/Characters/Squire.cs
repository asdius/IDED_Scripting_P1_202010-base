using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDED_Scripting_P1_202010_base.Logic.Characters
{
    class Squire : Human
    {
        public EUnitClass Ssquire { get; }
        public Squire(EUnitClass _unitClass, int _atk, int _def, int _spd, int _moveRange, float _potential, int _range) : base(_unitClass, _atk, _def, _spd, _moveRange, _potential, _range)
        {
            _unitClass = Ssquire;
            _atk = 20;
            _def = 10;
            _spd = 20;
            _moveRange = 5;
            _potential = 5;
            _range = 1;
        }
        public override bool Interact(Unit Villagerr)
        {
            return false;
        }

      

        public override bool ChangeClass(EUnitClass Soldierr)
        {
            return base.ChangeClass(Soldierr);
        }


    }
}
