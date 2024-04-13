using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;

public class TypingText : MonoBehaviour
{
    public TMP_Text textField;
    public float typingSpeed;
    public float delay;

    private string _initText;
    
    // Start is called before the first frame update
    void Start()
    {
        _initText = textField.text;
        textField.text = "";
        typingSpeed = 1 / typingSpeed;
        StartCoroutine(Type());

    }

    IEnumerator Type()
    {
        yield return new WaitForSeconds(delay);
        foreach (char c in _initText)
        {
            textField.text += c;
            yield return new WaitForSeconds(typingSpeed);
        }
    }
}
