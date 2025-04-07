using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonStartGame : MonoBehaviour
{
    #region VARIAVEIS
        public ParticleSystem pSystem;
    #endregion
     
     
    #region METODOS
        public void OnClick()
        {
            pSystem.Play();
        }
    #endregion
     
     
    #region UNITY-METODOS
     
    #endregion
}
