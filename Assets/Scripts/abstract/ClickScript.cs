using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public abstract class ClickScript : MonoBehaviour, IPointerClickHandler
{
    public abstract void ClickAction();
    public void OnPointerClick(PointerEventData pointerEventData)
    {
        if (pointerEventData.pointerCurrentRaycast.gameObject == gameObject)
        {
            ClickAction();
        }
    }
}
