using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyClock
{
    public class Clock
    {
        //instancefields
        private int _minutes;
        private int _hours;

        //constructors
        public Clock(int hours, int minutes)
        {
            _minutes = minutes;
            _hours = hours;
        }

        //properties

        public string Minutes
        {
            get {
                if (_minutes < 10)
                    return "0" + _minutes;
                else
                    return _minutes.ToString();
                // return _minutes.ToString("D2")
            }
        }

        public string Hours
        {
            get { return _hours.ToString("D2"); }
            set { _hours = int.Parse(value); }
        }

        //Metoder

        public void Set(int hours, int minutes)
        {
            _minutes = minutes;
            _hours = hours;
        }

        public void AdvanceOneMinute()
        {
            _minutes = _minutes + 1; //_minutes++
            if (_minutes >59)
            {
                _minutes = 0;
                _hours = _hours + 1;
                if (_hours >23)
                {
                    _hours = 0;
                }

            }

        }

    }
}
