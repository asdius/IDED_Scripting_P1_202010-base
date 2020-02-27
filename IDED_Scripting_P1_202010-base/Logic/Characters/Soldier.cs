using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDED_Scripting_P1_202010_base.Logic.Characters
{
    class Soldier : Human
    {
        public EUnitClass Soldierr { get; }
        public Soldier(EUnitClass _unitClass, int _atk, int _def, int _spd, int _moveRange, float _potential, int _range) : base(_unitClass, _atk, _def, _spd, _moveRange, _potential, _range)
        {
            _unitClass = Soldierr;
            _atk = 40;
            _def = 28;
            _spd = 12;
            _moveRange = 3;
            _potential = 5;
            _range = 1;
        }
        public override bool ChangeClass(EUnitClass Ssquire)
        {
            return base.ChangeClass(Ssquire);
        }
        public override bool Interact(Unit Villager)
        {
            return false;
        }

    }
}
