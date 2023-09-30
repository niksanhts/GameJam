using System;
using Unity.VisualScripting;
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

        private TimerSubject _timerSubject;
        
        private void Awake()
        {
            _timerSubject = new TimerSubject();
            Instantiate(_player);
            
            _timeViewer.Init(_timerSubject);
            _timer.Init(_timerSubject);
            
            

        }
    }
}