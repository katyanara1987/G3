using System;
using System.Collections.Generic;
using System.Text;

namespace HomeTask6.Model
{
    public class SimpleGarland : Garland<Bulb>
    {
        public SimpleGarland(int number) : base(number)
        {
           // BulbsNumber = number;
        }

        public override List<Bulb> GetBulbs()
        {
            List<Bulb> list = new List<Bulb>();

            for (int i = 0; i < BulbsNumber; i++)
            {
                Bulb bulb = new Bulb();
                bulb.State = SetBulbState(i);
                list.Add(bulb);
            }

            return list;
        }

        protected override List<Bulb> Build()
        {
            return new List<Bulb>();
        }
    }
}
