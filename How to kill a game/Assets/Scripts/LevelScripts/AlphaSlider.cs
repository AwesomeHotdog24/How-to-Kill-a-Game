using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AlphaSlider : MonoBehaviour
{
    public Slider slider;
    public float goalValue;
    public Text text;
    Color textColor;
    public Text sliderNum;
    public Button button;
    // Update is called once per frame
    void Start()
    {
        textColor = text.color;
        button.enabled = false;
    }
    void Update()
    {
        float sliderValue = (slider.value/255);
        if(slider.value == goalValue)
        {
            button.enabled = true;
        }

        textColor.a = sliderValue;
        text.color = textColor;
        sliderNum.text = (sliderValue*255).ToString();

    }
}

