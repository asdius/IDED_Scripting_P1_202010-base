using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDED_Scripting_P1_202010_base.Logic
{
    class Villager : Human
    {
        public EUnitClass Villagerr { get; }
        public Villager(EUnitClass _unitClass, int _atk, int _def, int _spd, int _moveRange, float _potential, int _range) : base(_unitClass, _atk, _def, _spd, _moveRange, _potential, _range)
        {
            _unitClass = Villagerr;
            MoveRange = 3;
        }
        
        public override bool Interact(Prop prop)
        {
            return base.Interact(prop);
        }

     
    }
}
