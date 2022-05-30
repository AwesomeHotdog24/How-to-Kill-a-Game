using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using SimonAssets;
public class Skip : MonoBehaviour
{
    public SceneManager scenemanager;
    // Update is called once per frame
    void Update()
    {
     if(Input.GetKeyDown(KeyCode.Space))
     {
        scenemanager.NextLevel();
     }   
    }
}
