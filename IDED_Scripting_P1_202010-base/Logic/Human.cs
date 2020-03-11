using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDED_Scripting_P1_202010_base.Logic
{
    public class Human : Unit
    {
        public float Potential { get; set; }

        public Human(EUnitClass _unitClass, int _atk, int _def, int _spd, int _moveRange, float _potential)
            : base(_unitClass, _atk, _def, _spd, _moveRange)
        {

            Potential = Limitador(_potential, 0,10);

            // Si es un monstruo cambia a villager

            if (int.Parse(_unitClass.ToString()) >= 5)
            {
                UnitClass = 0;
                AsignarValores();
            }
            AñadirPotencial();
        }

        // Suma el potencial
        private void AñadirPotencial()
        {
            Attack = Attack + (Attack * (Potential / 100));
            Defense = Defense + (Defense * (Potential / 100));

        }

        // Cambia entre clases de unidad
        public virtual bool ChangeClass(EUnitClass newClass)
        {
            bool changeable = false; 

            switch (int.Parse(UnitClass.ToString()))
            {
                case 0:
                    changeable = false;
                    break;
                   
                case 1:
                    switch (int.Parse(newClass.ToString()))
                    {
                        default:
                            changeable = false;
                            break;

                        case 2:
                            changeable = true;
                            break;

                    }
                    break;

                case 2:
                    switch (int.Parse(newClass.ToString()))
                    {
                        default:
                            changeable = false;
                            break;

                        case 1:
                            changeable = true;
                            break;

                    }
                    break;

                case 3:
                    switch (int.Parse(newClass.ToString()))
                    {
                        default:
                            changeable = false;
                            break;

                        case 4:
                            changeable = true;
                            break;

                    }
                    break;

                case 4:
                    switch (int.Parse(newClass.ToString()))
                    {
                        default:
                            changeable = false;
                            break;

                        case 3:
                            changeable = true;
                            break;

                    }
                    break;

            }
            return changeable;
        }
    }
}