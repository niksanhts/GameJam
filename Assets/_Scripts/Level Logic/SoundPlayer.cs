using UnityEngine;

namespace _Scripts
{
    public class SoundPlayer : MonoBehaviour, ITimerObserver
    {
        [SerializeField, Range(0,3)] private float _endgameThemePitch;
        [SerializeField, Range(0, 60)] private float _endgameTime;
        
        [SerializeField] private AudioSource _mainTheme;
        [SerializeField] private AudioSource _pickUpSound;
        [SerializeField] private AudioSource _throwSound;
        [SerializeField] private AudioSource _endgameSound;
        
        public void React(float time)
        {
            if (time <= _endgameTime)
            {
                UpdateMainTheme();
            }

            if (time != 0) return;
            StopMainTheme();
            PlayEndgameSound();
        }

        public void PlayThrowSound() => _throwSound.Play();
        public void PlayPickUpSound() => _pickUpSound.Play();
        private void PlayEndgameSound() => _endgameSound.Play();
        private void UpdateMainTheme() => _mainTheme.pitch = _endgameThemePitch;
        private void StopMainTheme() => _mainTheme.Stop();






    }
}