using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class DiceSlot : MonoBehaviour, IDropHandler
{
    public GameObject incubator;

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
        var thing = incubator.GetComponent<Incubator>();
        var diceObject = DragHandler.itemBeingDragged.GetComponent<DiceObject>();
        //Dice formula
        if (!dice && thing.CanUseDice(diceObject.value))
        {
            thing.RunIncubate(diceObject.value);
            DragHandler.itemBeingDragged.transform.SetParent(transform);
        //do stuff
        }
    }
}
