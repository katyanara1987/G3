using System;
using System.Collections.Generic;
using System.Text;

namespace HomeTask6.Model
{
    public class ColorGarland : Garland<ColorBulb>
    {
        public ColorGarland(int number) : base(number)
        {
            BulbsNumber = number;
        }

        public override List<ColorBulb> GetBulbsState(List<ColorBulb> bulbs)
        {
            for (int i = 0; i < bulbs.Count; i++)
            {
                ColorBulb bulb = new ColorBulb();
                bulb.SerialNumber = i;
                bulb.State = SetBulbState(i);
                bulb.Color = SetBulbColor(i);
                bulbs[i] = bulb;
            }

            return bulbs;
        }



            public BulbColor SetBulbColor(int bulbCounter)
        {
            if (bulbCounter % 4 == 0)
            {
                return BulbColor.BLUE;
            }
            else if (bulbCounter % 3 == 0)
            {
                return BulbColor.GREEN;
            }
            else if (bulbCounter % 2 == 0)
            {
                return BulbColor.YELLOW;
            }
            else
            {
                return BulbColor.RED;
            }               
        }

        protected override List<ColorBulb> Build(int count)
        {
            List<ColorBulb> garland = new List<ColorBulb>();

            for (int i = 0; i < count; i++)
            {
                ColorBulb bulb = new ColorBulb();
                garland.Add(bulb);
            }

            return garland;
        }

    }
}
    