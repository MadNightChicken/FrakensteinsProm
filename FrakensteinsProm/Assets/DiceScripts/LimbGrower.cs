using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LimbGrower : Incubator
{
    // Start is called before the first frame update
    void Start()
    {
        name.text = "Limb Grower";
        _isUsable = true;
    }

    // Update is called once per frame
    void Update()
    {

    }

    public override bool CanUseDice(int diceValue)
    {
        if (!_isUsable)
            return false;
        return true;
    }

    public override void RunIncubate(int diceValue)
    {
        //add to inventory
        Debug.Log("run dice " + diceValue);

        if(diceValue%2 == 1)
        {
            Debug.Log("You grew a leg");
        }
        else
        {
            Debug.Log("You grew an arm");
        }


        _isUsable = false;
        //gray out????
    }
}
