using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using NaughtyAttributes;
using DG.Tweening;

namespace Screens
{
    public enum ScreenType
    {
        Menu,
        Start,
        About,
        Exit
    }

    public class ScreenBase : MonoBehaviour
    {
        #region VARIAVEIS
            public ScreenType screenType;

            public List<Transform> listOfObjects;
            public List<Typper> listOfPhrases;

            public bool startHided = true;

            [Header("Animation")]
            public float animationDuration = .3f;
            public float delayBetweenObjects = .05f;
        #endregion
        
        
        #region METODOS
        
            [Button]
            public void Show()
            {
                ShowObjects();
            }

            [Button]
            public void Hide()
            {
                HideObjects();
            }


            private void ShowObjects()
            {
                for(int i = 0; i < listOfObjects.Count; i++)
                {
                    var obj = listOfObjects[i];

                    obj.gameObject.SetActive(true);
                    obj.DOScale(0, animationDuration).From().SetDelay(i * delayBetweenObjects);
                }

                Invoke(nameof(StartType), delayBetweenObjects * listOfObjects.Count);
            }

            private void HideObjects()
            {
                listOfObjects.ForEach(i => i.gameObject.SetActive(false));
            }

            private void StartType()
            {
                for(int i = 0; i < listOfPhrases.Count; i++)
                {
                    listOfPhrases[i].StartTyping();
                }
            }
        #endregion


        #region UNITY-METODOS
            public void Start()
            {
                if(startHided)
                {
                    HideObjects();
                }
            }
        #endregion
    }
}


