using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class Incubusator : Incubator
{
    private int minDice;
    // Start is called before the first frame update
    void Start()
    {
        name.text = "Incubausator";
        _isUsable = true;
        minDice = 3;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public override bool CanUseDice(int diceValue)
    {
        if (!_isUsable)
            return false;
        if (diceValue >= minDice)
            return true;
        return false;
    }

    public override void RunIncubate(int diceValue)
    {
        //add to inventory
        Debug.Log("run dice " + diceValue);

        var reward = Random.Range(0, 21);
        if(reward == 20)
        {
            Debug.Log("ya got some sexy lips");
        }
        else if(reward > 15)
        {
            Debug.Log("You have a heart Kid!");
        }
        else if (reward > 10)
        {
            Debug.Log("Ya got some lungs");
        }
        else
        {
            Debug.Log("Ya got some Legs");
        }

        _isUsable = false;
        //gray out????
    }
}
