using System;
using System.Collections.Generic;
using System.Text;

namespace HomeTask6.Model
{
    public abstract class Garland<T>
        where T: Bulb
    {
        private List<T> _garland;
        public Garland(int count)
        {
            _garland = Build(count);
        }

        protected abstract List<T> Build(int count);

        public int BulbsNumber { get; set; }

        public abstract List<T> GetBulbsState(List<T> bulbs);

        public void PrintGarland() 
        {
            if (_garland.GetType() == typeof(List<ColorBulb>))
            {
                foreach (var bulb in GetBulbsState(_garland))
                {
                    ColorBulb tmp = new ColorBulb();
                    Console.Write($"{bulb.SerialNumber} : ");
                    if (bulb.State == BulbState.ON)
                    {
                      //  Console.WriteLine(bulb.Color);
                    }
                    else 
                    {
                        Console.WriteLine(BulbState.OFF);
                    }

                }
            }
            else if (_garland.GetType() == typeof(List<Bulb>))
            {
                foreach (T bulb in GetBulbsState(_garland))
                {
                    Console.WriteLine($"{bulb.SerialNumber} : {bulb.State}");

                }
            }
        }

        protected BulbState SetBulbState(int bulbCounter)
        {
            bool isEvenMinute = DateTime.Now.Minute % 2 == 0;
            if ((bulbCounter % 2 == 0 && isEvenMinute) || (bulbCounter % 2 == 1 && !isEvenMinute))
            {
                return BulbState.ON;
            }
            else
            {
                return BulbState.OFF;
            }
        }

    }
}
