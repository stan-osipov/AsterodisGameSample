using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Game.Menu
{
    internal class MeinMenuController : MonoBehaviour, IMainMenuView
    {
        public event Action OnStartButtonPressed;

        [SerializeField]
        private Button m_GameStartButton = default;

        private void Awake() {
            m_GameStartButton.onClick.AddListener(() => {
                Debug.Log("Button Clicked");
                OnStartButtonPressed?.Invoke();
            });
        }
    }
}