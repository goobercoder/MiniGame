using UnityEngine;
using UnityEngine.EventSystems;

public class drückenmaxim : MonoBehaviour, IPointerEnterHandler, IPointerClickHandler
{
    public int zweihunderteinundsiebzichtausend;
    public sector sector;

    public void OnPointerEnter(PointerEventData eventData)
    {

    }
    public void OnPointerClick(PointerEventData eventData)
    {
        sector.ActivateItem(zweihunderteinundsiebzichtausend);
    }
}
