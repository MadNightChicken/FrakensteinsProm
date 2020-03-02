using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class Incubator : MonoBehaviour
{

    [SerializeField] Text name;

    // Start is called before the first frame update
    void Start()
    {
        name.text = "Incubausator";
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    public bool CanUseDice(int diceValue)
    {
        if(diceValue  > 2)
            return true;
        return false;
    }

    public void RunIncubate(int diceValue)
    {
        Debug.Log("run dice " + diceValue);
        //possibly gray out and remove dice

        //add to inventory
    }
}
