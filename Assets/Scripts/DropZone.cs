using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
public class DropZone : MonoBehaviour, IDropHandler, IPointerEnterHandler, IPointerExitHandler
{
    
    public void OnDrop(PointerEventData eventData)
    {
        Debug.Log(eventData.pointerDrag.name+"was Drop To" + gameObject.name);

        DragDrop d = eventData.pointerDrag.GetComponent<DragDrop>();
        if(d!=null)
        {
            d.parentToReturnTo = this.transform;
        }
        
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        
    }

    public void OnPointerExit(PointerEventData eventData)
    {
       
    }
}
