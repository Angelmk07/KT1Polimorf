using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KT
{
    public class Immovable : Property
    {
        private int Space;

        public Immovable(int worth,int Space) : base(worth)
        {
            this.Space = Space;
        }
        public override int Tax()
        {
            if(Space < 100)
            {
               return worth* (1 / 500);
            }
            else if(Space > 100&& Space< 300)
            {
                return (worth * (1 / 350));
            }
            else
            {
                return (worth * (1 / 250));
            }
        }
        public float PricePerSpace(int space)
        {
            return (float)worth / space;
        }
        public override string ToString() => $"Стоимость - {worth}, налог - {Tax()}, площадь - {Space},цена за кв м {PricePerSpace(Space)} ";
    }
}
