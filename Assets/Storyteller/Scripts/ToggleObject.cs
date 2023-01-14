using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToggleObject : MonoBehaviour
{
    public GameObject toggleObject;
    public List<string> words = new();
 
    void Update()
    {
        
    }

    public void ToggleIfStringMatches(string phrase)
    {
        string lowercasePhase = phrase.ToLower();

        foreach (string word in words)
        {

            if (lowercasePhase.Contains(word.ToLower()))
            {
               
                toggleObject.SetActive(true);
                return;
            }

        }

        toggleObject.SetActive(false);
        

    }
}
