using System;
using System.Collections;
using UnityEngine;

namespace _Scripts
{
    public class LevelTimer : TimerSubject
    {
        [SerializeField] private float _timeInSec;

        public void AddTime(float value)
        {
            if (value < 0) throw new ArgumentOutOfRangeException();
            
            _timeInSec += value;
            Notify(_timeInSec);
        }

        public void TakeTime(float value)
        {
            if (value < 0) throw new ArgumentOutOfRangeException();
            
            _timeInSec -= value;
            Notify(_timeInSec);
        }

        IEnumerator Timer()
        {
            while (true)
            {
                _timeInSec -= 1;
                if (_timeInSec <= 0)
                {
                    
                }

                Notify(_timeInSec);
                 
                yield return new WaitForSeconds(1);
            }
        }


    }
}