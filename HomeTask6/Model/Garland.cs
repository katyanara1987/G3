using System;
using System.Collections.Generic;
using System.Text;

namespace HomeTask6.Model
{
    public abstract class Garland<T> 
        where T : Bulb
    {
        private List<T> _garland;
        public Garland(int count)
        {
            _garland = Build();
        }

        protected abstract List<T> Build();








        public int BulbsNumber { get; set; }

        public abstract List<Bulb> GetBulbs();

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
