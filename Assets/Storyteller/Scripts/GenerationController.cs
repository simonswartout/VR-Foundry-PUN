using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GenerationController : MonoBehaviour
{
public List<ToggleObject> toggleObjects = new();
[SerializeField] TMP_Text inputText;

    public void SubmitText() 
    {
        string phrase = inputText.text;
        foreach (ToggleObject toggleObject in toggleObjects)
        {
            toggleObject.ToggleIfStringMatches(phrase);
        }
    }
}