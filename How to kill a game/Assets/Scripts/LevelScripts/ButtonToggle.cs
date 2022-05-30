using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ButtonToggle : MonoBehaviour
{
    public bool on;
    public bool goal;
    public bool correct;
    public Image image;
    private Color onColor;
    private Color offColor;
    // Update is called once per frame
    void Start()
    {
        onColor = new Color(255,255,255);
        offColor = new Color(0,0,0);
    }

    void Update()
    {
        if(goal == on)
        {
            correct = true;
        }else{
            correct = false;
        }
        if(on)
        {
            image.color = onColor;
        }else{
            image.color = offColor;
        }   
    }
}
