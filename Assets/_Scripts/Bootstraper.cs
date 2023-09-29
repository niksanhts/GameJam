using System;
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
        
        
        
        private void Awake()
        {
            _timeViewer.Init();
            //_timer.Attach(_timeViewer);
            Instantiate(_player);

        }
    }
}