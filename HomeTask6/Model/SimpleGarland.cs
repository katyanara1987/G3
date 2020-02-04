using System;
using System.Collections.Generic;
using System.Text;

namespace HomeTask6.Model
{
    public class SimpleGarland : Garland<Bulb>
    {
        public SimpleGarland(int number) : base(number)
        {
            BulbsNumber = number;
        }        

        public override List<Bulb> GetBulbsState(List<Bulb> bulbs)
        {
            for (int i = 0; i < bulbs.Count; i++)
            {
                Bulb bulb = new Bulb();
                bulb.SerialNumber = i;
                bulb.State = SetBulbState(i);
                bulbs[i] = bulb;
            }

            return bulbs;
        }

        protected override List<Bulb> Build(int count)
        {
            List<Bulb> garland = new List<Bulb>();

            for (int i = 0; i < count; i++)
            {
                Bulb bulb = new Bulb();
                garland.Add(bulb);
            }

            return garland;

        }
    }
}
