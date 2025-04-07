using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using RysCorp.Core.Singleton;

namespace Screens
{
    public class ScreenManager : Singleton<ScreenManager>
    {
        #region VARIAVEIS
            public List<ScreenBase> screenBases;

            public ScreenType startScreen = ScreenType.Menu;

            private ScreenBase _currentScreen;
        #endregion
        
        
        #region METODOS
            public void ShowByType(ScreenType type)
            {
                if(_currentScreen != null) _currentScreen.Hide();

                var nextScreen = screenBases.Find(i => i.screenType == type);

                nextScreen.Show();
                _currentScreen = nextScreen;
            }

            public void HideAll()
            {
                screenBases.ForEach(i => i.Hide());
            }
        #endregion


        #region UNITY-METODOS
            public void Start()
            {
                HideAll();
                ShowByType(startScreen);
            }
        #endregion
    }
}


