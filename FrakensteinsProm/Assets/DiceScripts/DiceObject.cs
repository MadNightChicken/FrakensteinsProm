using UnityEngine;
using UnityEngine.UI;

public class DiceObject : MonoBehaviour
{
    // Start is called before the first frame update
    private Sprite[] diceSides;
    private SpriteRenderer spriteRenderer;
    public Image imageIcon;
    public int value;

    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        diceSides = Resources.LoadAll<Sprite>("DiceSides/");
        RollTheDice();
    }

    public void RollTheDice()
    {
        var diceRolled = Random.Range(0, 6);
        value = diceRolled + 1;
        imageIcon.sprite = diceSides[diceRolled];

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
