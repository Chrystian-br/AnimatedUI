using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;
using UnityEngine.EventSystems;

public class ButtonScale : MonoBehaviour, IPointerExitHandler, IPointerEnterHandler
{
    #region VARIAVEIS
        public float scaleSize = 1.1f;
        public float scaleDuration = .1f;

        private Vector3 _defaultScale;
        private Tween _currentTween;
    #endregion
     
     
    #region METODOS
    #endregion


    #region UNITY-METODOS
    public void OnPointerEnter(PointerEventData eventData)
    {
        _currentTween = transform.DOScale(scaleSize, scaleDuration);
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        
        _currentTween.Kill();
        transform.localScale = _defaultScale;
    }

    private void Awake()
    {
        _defaultScale = transform.localScale;
    }
    #endregion
}
