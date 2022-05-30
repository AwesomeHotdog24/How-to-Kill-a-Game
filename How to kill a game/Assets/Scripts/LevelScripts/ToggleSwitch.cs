using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ToggleSwitch : MonoBehaviour
{

    public ButtonToggle[] buttons;
    private int correctToggles;
    public GameObject quitButton;

    void Start()
    {
        if(buttons == null)
        {
            Debug.Log("button list null");
        }
        
    }
    public void Toggle(ButtonToggle toggle)
    {
        if(toggle.on)
        {
            toggle.on = false;
        }else{
            toggle.on = true;
        }
    }
    void Update()
    {
        correctToggles = 0;
        foreach(ButtonToggle toggle in buttons)
        {
            if(toggle.correct)
            {
                correctToggles++;
            }
        }
        if(correctToggles == buttons.Length)
        {
            quitButton.SetActive(true);

        }else{
            quitButton.SetActive(false);
        }
    }
}
