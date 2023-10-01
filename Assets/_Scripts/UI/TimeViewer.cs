using TMPro;
using UnityEngine;

namespace _Scripts
{
    public class TimeViewer : MonoBehaviour, ITimerObserver
    {
        [SerializeField] private TextMeshProUGUI _timeText;

        public void Init(TimerSubject subject)
        {
            subject.Attach(this);
            _timeText = GetComponent<TextMeshProUGUI>();
        }

        public void React(float time)
        {
           UpdateText(time.ToString());
        }

        private void UpdateText(string text)
        {
             _timeText.text = text;
        }
        
        
    }
}