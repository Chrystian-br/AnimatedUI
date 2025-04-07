using System.Collections;
using System.Collections.Generic;
using NaughtyAttributes;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class AnswerChecker : MonoBehaviour
{
    #region VARIAVEIS
        public Typper typper;
    #endregion
     
     
    #region METODOS

        [Button]
        public void Check()
        {
            typper.textMesh.text = "";
            typper.phrase = "You Lose";
            typper.StartTyping();
        }
    #endregion
     
     
    #region UNITY-METODOS
     
    #endregion
}
