using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using SimonAssets;

public class MenuScript : MonoBehaviour
{
    public SceneManager sceneManager;
    public void PlayGame()
    {
        sceneManager.LoadScene(1);
        
    }
    public void QuitGame()
    {
        Debug.Log("Quit Game");
        Application.Quit();
        
    }
}
