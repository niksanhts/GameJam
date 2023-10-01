using TMPro;
using UnityEngine;

namespace _Scripts
{
    public class Bootstraper : MonoBehaviour
    {
        [Header("Timer for level")]
        [SerializeField] private TimeViewer _timeViewer;
        [SerializeField] private LevelTimer _timer;

        [Header("Player")]
        [SerializeField] private GameObject _player;
        [SerializeField] private Transform _playerSpawnPoint;

        
        [Header("Game end")]
        [SerializeField] private GameObject _endLevelMenu;
        [SerializeField] private EndLevelViewer _endLevelViewer;
        
        [Header("Sound")]
        [SerializeField] private SoundPlayer _soundPlayer;

        [Header("Input")]
        [SerializeField] private InputHandler _input;

            private void Awake()
        {
            SystemOptions.HideCursor(true);
            
            var timerSubject = new TimerSubject();
            var endLevel = new EndLevel(_endLevelViewer, timerSubject);
            
            timerSubject.Attach(_soundPlayer);
            timerSubject.Attach(_input);
            
            _timeViewer.Init(timerSubject);
            _timer.Init(timerSubject);
            _endLevelViewer.Init(_endLevelMenu);
        }

        
    }
}