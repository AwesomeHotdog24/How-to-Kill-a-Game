using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnitySceneManager = UnityEngine.SceneManagement.SceneManager;

namespace SimonAssets
{
    public class SceneManager : MonoBehaviour
    {
        public void NextLevel()
        {
            UnitySceneManager.LoadScene(UnitySceneManager.GetActiveScene().buildIndex + 1);
        }
        public void LoadScene(int scene)
        {
            UnitySceneManager.LoadScene(scene);
        }
        public void BackLevel()
        {
            UnitySceneManager.LoadScene(UnitySceneManager.GetActiveScene().buildIndex - 1);
        }
    }
}