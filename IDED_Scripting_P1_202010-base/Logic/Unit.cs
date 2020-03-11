using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        public Unit(EUnitClass _unitClass, int _atk, int _def, int _spd, int _moveRange)
        {
            UnitClass = _unitClass;
            BaseAtk = _atk;
            BaseDef = _def;
            BaseSpd = _spd;
            MoveRange = (int)Limitador(_moveRange,1,10);
            AtkRange = AsignarAtakRange();

            // Inicia en una posicion aleatoria

            int x = new Random().Next();
            int y = new Random().Next();

            Position posicionInicial = new Position(x,y);
            CurrentPosition = posicionInicial;

            AsignarValores();
        }

        protected int AsignarAtakRange()
        {
            int rango = 0;
            switch (int.Parse(UnitClass.ToString()))
            {
                case 0:
                    break;
                case 3:
                    rango = 3;
                    break;
                case 4:
                    rango = 3;
                    break;
                case 7:
                    rango = 5;
                    break;
                default:
                    rango = 1;
                    break;
            }

            return rango;
        }
        protected void AsignarValores()
        {
            switch (int.Parse(UnitClass.ToString()))
            {
                default:                  
                    break;
                case 1:
                    AsignarAdiciones(2,1,0);
                    break;
                case 2:
                    AsignarAdiciones(3,2,1);
                    break;
                case 3:
                    AsignarAdiciones(1,0,3);
                    break;
                case 4:
                    AsignarAdiciones(3,1,-1);
                    break;
                case 5:
                    AsignarAdiciones(1,0,0);
                    break;
                case 6:
                    AsignarAdiciones(4,2,-2);
                    break;
                case 7:
                    AsignarAdiciones(5,3,2);
                    break;
            }
            
            Attack = Limitador(BaseAtk + (BaseAtk * (BaseAtkAdd / 100)),0,255);
            Defense = Limitador(BaseDef + (BaseDef * (BaseDefAdd / 100)), 0, 255);
            Speed = Limitador(BaseSpd + (BaseSpd * (BaseSpdAdd / 100)), 0, 255);
        }

        private void AsignarAdiciones(float a, float d, float s )
        {
            BaseAtkAdd = a;
            BaseDefAdd = d;
            BaseSpdAdd = s;
        }

        // Verifica las interacciones con unidades
        public virtual bool Interact(Unit otherUnit)
        {
            bool interactuble = false;
            switch (int.Parse(UnitClass.ToString()))
            {
                case 0:
                    interactuble = false;
                    break;
                case 1:
                    switch (int.Parse(otherUnit.UnitClass.ToString()))
                    {
                        case 0:
                            interactuble = false;
                            break;
                        default:
                            interactuble = true;
                            break;
                    }
                    break;
                case 2:
                    switch (int.Parse(otherUnit.UnitClass.ToString()))
                    {
                        case 0:
                            interactuble = false;
                            break;
                        default:
                            interactuble = true;
                            break;
                    }
                    break;
                case 3:
                    switch (int.Parse(otherUnit.UnitClass.ToString()))
                    {
                        case 4:
                            interactuble = false;
                            break;
                        case 7:
                            interactuble = false;
                            break;
                        default:
                            interactuble = true;
                            break;
                    }
                    break;
                case 4:
                    switch (int.Parse(otherUnit.UnitClass.ToString()))
                    {
                        case 4:
                            interactuble = false;
                            break;
                        default:
                            interactuble = true;
                            break;
                    }
                    break;
                case 5:
                    switch (int.Parse(otherUnit.UnitClass.ToString()))
                    {
                        case 7:
                            interactuble = false;
                            break;
                        default:
                            interactuble = true;
                            break;
                    }
                    break;
                case 6:
                    switch (int.Parse(otherUnit.UnitClass.ToString()))
                    {
                        case 7:
                            interactuble = false;
                            break;
                        default:
                            interactuble = true;
                            break;
                    }
                    break;
                case 7:
                    interactuble = true;
                    break;
            }
            return interactuble;
        }

        // Verifica las interacciones con props

        public virtual bool Interact(Prop prop)
        {
                return UnitClass == 0 ? true : false;
        }

        // Verifica si se puede mover
        public bool Move(Position targetPosition)
        {
            bool exito = false;
            if (targetPosition.x <= MoveRange && targetPosition.y <= MoveRange)
            {
                CurrentPosition = targetPosition;
                exito = true;
            }
            return exito;
        }

        // Limita entre un mínimo y un máximo

        protected float Limitador(float a, float min, float max)
        {
            float final = a;
            if (a < min)
            {
                a = min;
            }
            else if (a > max)
            {
                a = max;
            }
            return final;
        }
    }
}