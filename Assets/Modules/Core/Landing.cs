using UnityEngine;

namespace Game.Core
{
    internal class Landing : MonoBehaviour
    {
        private void Start() {
            Debug.Log("Start Landing");
            ApplicationManager.OpenMainMenu();
        }
    }
}