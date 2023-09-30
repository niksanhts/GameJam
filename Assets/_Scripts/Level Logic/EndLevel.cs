namespace _Scripts
{
    public class EndLevel : ITimerObserver
    {
        
        
        public void React(float time)
        {
            if (time <= 0)
                CompleteLevel();
        }

        private void CompleteLevel()
        {
            // показать конечное меню
            
        }
    }
}