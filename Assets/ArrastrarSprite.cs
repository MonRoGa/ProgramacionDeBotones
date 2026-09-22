using UnityEngine;
using UnityEngine.EventSystems;

public class ArrastrarSprite : MonoBehaviour, IBeginDragHandler, IDragHandler
{
    private RectTransform objeto;

    private void Awake()
    {
        objeto = GetComponent<RectTransform>();
    }

    public void OnBeginDrag(PointerEventData eventData)
    {
        // Inicia el arrastre del objeto.
    }

    public void OnDrag(PointerEventData eventData)
    {
        objeto.anchoredPosition += eventData.delta;
    }
}