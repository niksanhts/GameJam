using UnityEngine;

namespace _Scripts
{
    public class EndLevelViewer : MonoBehaviour
    {
        private GameObject _endLevelMenu;

        public void Init(GameObject endLevelMenu)
        {
            _endLevelMenu = endLevelMenu;
            _endLevelMenu.SetActive(false);
        }

        public void View()
        {
            _endLevelMenu.SetActive(true);
        }
    }
}