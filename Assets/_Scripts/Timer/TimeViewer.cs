
using TMPro;
using Unity.VisualScripting;
using UnityEngine;

namespace _Scripts
{
    public class TimeViewer : MonoBehaviour, ITimerObserver
    {
        private TextMeshProUGUI _timeText;

        public void Init()
        {
            _timeText = GetComponent<TextMeshProUGUI>();
            //subject.Attach(gameObject.GetComponent<ITimerObserver>());    TimerSubject subject
        }

        public void React(float time)
        {
            _timeText.text = time.ToString();
        }
        
    }
}