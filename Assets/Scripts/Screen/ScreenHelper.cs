using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Screens
{
    public class ScreenHelper : MonoBehaviour
    {
        #region VARIAVEIS
            public ScreenType screenType;
        #endregion
        
        
        #region METODOS
        
        #endregion
        
        
        #region UNITY-METODOS
            public void OnClick()
            {
                ScreenManager.Instance.ShowByType(screenType);
            }
        #endregion
    }
}


