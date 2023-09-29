using System.Collections.Generic;
using UnityEngine;

namespace _Scripts
{
    public abstract class TimerSubject : MonoBehaviour ,ISubject
    {
        private List<ITimerObserver> _observers;
        
        protected void Notify(float time)
        {
            foreach (var obsever in _observers)
            {
                obsever.React(time);
            }
        }

        public void Attach(ITimerObserver timerObserver)
        {
            _observers.Add(timerObserver);
        }

        public void Detach(ITimerObserver timerObserver)
        {
            _observers.Remove(timerObserver);
        }
    }
}