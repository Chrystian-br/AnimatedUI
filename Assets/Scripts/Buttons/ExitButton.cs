using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExitButton : MonoBehaviour
{
    #region VARIAVEIS
        public Typper typper;
        public List<Transform> buttons;
    #endregion
     
     
    #region METODOS
        public void Exit()
        {
            typper.textMesh.text = "";
            typper.phrase = "Bye Bye";
            typper.StartTyping();

            buttons.ForEach(i => i.gameObject.SetActive(false));
        }
    #endregion
     
     
    #region UNITY-METODOS
     
    #endregion
}
