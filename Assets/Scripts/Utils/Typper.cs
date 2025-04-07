using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Typper : MonoBehaviour
{
    #region VARIAVEIS
        public TextMeshProUGUI textMesh;
        public float timeBetweenLetters = .1f;

        public string phrase;
    #endregion
     
     
    #region METODOS
        public void StartTyping()
        {
            StartCoroutine(Typing(phrase));
        }

        IEnumerator Typing(string s)
        {
            textMesh.text = "";
            foreach(char i in s.ToCharArray())
            {
                textMesh.text += i;

                yield return new WaitForSeconds(timeBetweenLetters);
            }
        }
    #endregion
     
     
    #region UNITY-METODOS
     
    #endregion
}
