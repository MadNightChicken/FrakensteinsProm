using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DiceManager : MonoBehaviour
{

    private List<GameObject> dices;
    public int numberOfDice;
    public GameObject dice;
    public Transform contentPanel;


    // Start is called before the first frame update
    void Start()
    {
        dices = new List<GameObject>();
        CreateDice();
    }

    public void CreateDice()
    {
        for (var i = 0; i < numberOfDice; i++)
        {
            var diceInstance = Instantiate(dice);
            diceInstance.transform.SetParent(contentPanel);
            DiceObject diceObject = diceInstance.GetComponent<DiceObject>();
            dices.Add(diceInstance);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
