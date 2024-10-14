using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KT
{
    public class Vehicle : Property
    {
        private int engine_volume;

        public Vehicle(int worth,int EnginVolum) : base(worth)
        {
            engine_volume = EnginVolum;
        }

        public override int Tax()
        {
            return (worth * engine_volume / 3000);
        }
        public override string ToString() => $"Стоимость - {worth}, налог - {Tax()}, двигатель объём - {engine_volume}";
    }
}
