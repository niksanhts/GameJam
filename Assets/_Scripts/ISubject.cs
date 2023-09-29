namespace _Scripts
{
    public interface ISubject
    {
        void Attach(ITimerObserver timerObserver);
        void Detach(ITimerObserver timerObserver);
    }
}