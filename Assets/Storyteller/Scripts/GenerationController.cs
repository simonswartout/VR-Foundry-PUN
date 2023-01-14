using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

namespace Foundry
{
    public class GenerationController : MonoBehaviour
    {
        [SerializeField] TMP_Text inputText;

        public void SubmitText() 
        {
            Debug.Log(inputText.text);
        }
    }
}
