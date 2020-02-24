using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class DiceSlot : MonoBehaviour, IDropHandler
{
    public GameObject dice
    {
        get
        {
            if (transform.childCount > 0)
            {
                return transform.GetChild(0).gameObject;
            }
            return null;
        }
    }

    public void OnDrop(PointerEventData eventData)
    {
        Debug.Log("dragged");
        //if (!dice)
        //{
            DragHandler.itemBeingDragged.transform.SetParent(transform);
            //do stuff
        //}
    }
}
