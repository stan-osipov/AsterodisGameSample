using System;
using Game.Menu;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Game.Core
{
    internal class Landing : MonoBehaviour
    {
        private void Start() {
            Debug.Log("Start Landing");
            SceneManager.sceneLoaded += OnSceneLoaded;
            SceneManager.LoadScene(ScenesConfig.MeinMenuScene, LoadSceneMode.Additive);
        }

        void OnSceneLoaded(Scene scene, LoadSceneMode arg1)
        {
            switch (scene.name)
            {
                case ScenesConfig.MeinMenuScene:
                    var controllerGameObject = scene.GetRootGameObjects()[0];
                    var mainMenuView = controllerGameObject.GetComponent<IMainMenuView>();
                    OnMainMenuLoaded(mainMenuView);
                    break;
                default:
                    new InvalidOperationException($"Unknown Scene loaded: {scene.name}");
                    break;
            }
        }

        private void OnMainMenuLoaded(IMainMenuView mainMenuView)
        {
            mainMenuView.OnStartButtonPressed += () =>
            {
                SceneManager.LoadSceneAsync(ScenesConfig.FirstGameLevel, LoadSceneMode.Additive);
                SceneManager.UnloadSceneAsync(ScenesConfig.MeinMenuScene);
            };
        }
    }
}