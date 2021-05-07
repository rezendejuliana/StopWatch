using System;

namespace StopWatch
{
    partial class Program
    {
        public class StopWatch
        {
            private TimeSpan _duration;
            private DateTime _timeStart { get; set; }
            private DateTime _timeStop { get; set; }
            private bool _flgStart = false;
            
            public void Start()
            {
                if (!_flgStart)
                {
                    _flgStart = true;
                    _timeStart = DateTime.Now;
                }
                else
                {
                    throw new InvalidOperationException("StopWatch Already running");
                }

            }

            public void Stop()
            {
                if (_flgStart) {
                    _flgStart = false;
                    _timeStop = DateTime.Now;
               }
                
            }

            public TimeSpan Duration()
            {
                _duration = TimeSpan.Parse(Convert.ToString(_timeStop - _timeStart));
                return _duration ;
                    
            }

            

        }
    }
}
