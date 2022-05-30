using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class DialogManager : MonoBehaviour
{
    public TextMeshProUGUI text;
    public float typingSpeed;
    public string toBeTyped;
    private char[] period= ".".ToCharArray();
    public bool onStart;
    public void RegType(string toType)
    {
        text.text = toType;
    }

    IEnumerator SlowType(string toType)
    {
        text.text = "";
        foreach(char letter in toType.ToCharArray())
        {
            if(letter !=period[0])
            {
                text.text += letter;
                yield return new WaitForSeconds(typingSpeed);
            }else{
                text.text += letter;
                yield return new WaitForSeconds(typingSpeed*6);
            }
        }
    }
    void Start()
    {
        if(onStart)
        {
            StartCoroutine(SlowType(toBeTyped));
        }
    }
    public void StartType(string toType)
    {
        text.text = "";
        StartCoroutine(SlowType(toType));
    }

}
