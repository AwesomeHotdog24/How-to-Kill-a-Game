using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Pl : MonoBehaviour
{
    public Button titleButton;
    public GameObject quitButton;
    public GameObject playButton;
    void Start()
    {
        titleButton.enabled = false;
        quitButton.SetActive(false);
    }
    public void EnableTitle()
    {
        titleButton.enabled = true;
    }
    public void PlayToQuit()
    {
        playButton.SetActive(false);
        quitButton.SetActive(true);
    }
}
