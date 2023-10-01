using UnityEngine;

namespace _Scripts
{
    public class EndLevel : ITimerObserver
    {
        
        private EndLevelViewer _endLevelViewer;

        public EndLevel(EndLevelViewer endLevelViewer, TimerSubject subject)
        {
            _endLevelViewer = endLevelViewer;
            subject.Attach(this);
        }
        

        public void React(float time)
        {
            if (time <= 0)
                CompleteLevel();
        }

        private void CompleteLevel()
        {
            _endLevelViewer.View();
        }
    }
}