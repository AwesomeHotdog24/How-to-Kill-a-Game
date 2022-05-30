using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class NewBehaviourScript : MonoBehaviour
{
    public TextMeshProUGUI textDisplay;

    public void Type(string hint)
    {
        textDisplay.text = hint;
    }
}
