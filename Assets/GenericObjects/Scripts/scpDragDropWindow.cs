using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class scpDragDropWindow : MonoBehaviour, IDragHandler, IPointerDownHandler
{
    [SerializeField] private RectTransform prtDragRectTransform;
    public RectTransform prtCanvas;

    public void OnDrag(PointerEventData eventData)
    {
        prtDragRectTransform.anchoredPosition += eventData.delta;
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        prtCanvas.SetAsLastSibling();
    }
}