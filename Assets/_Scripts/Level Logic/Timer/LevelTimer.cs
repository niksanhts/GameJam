using System;
using System.Collections;
using UnityEngine;

namespace _Scripts
{
    public class LevelTimer : MonoBehaviour
    {
        [SerializeField] private float _timeInSec;
        
        private TimerSubject _timerSubject;

        public void Init(TimerSubject subject)
        {
            _timerSubject = subject;
            StartCoroutine(Timer());
        }

        public void AddTime(float value)
        {
            if (value < 0) throw new ArgumentOutOfRangeException();
            
            _timeInSec += value;
            _timerSubject.Notify(_timeInSec);
        }

        public void TakeTime(float value)
        {
            if (value < 0) throw new ArgumentOutOfRangeException();
            
            _timeInSec -= value;
            _timerSubject.Notify(_timeInSec);
        }
        
        IEnumerator Timer()
        {
            while (true)
            {
                _timeInSec -= 1;
                
                _timerSubject.Notify(_timeInSec);

                if (_timeInSec <= 0)
                {
                    StopCoroutine(Timer());
                }
                
                yield return new WaitForSeconds(1);
            }
        }


    }
}