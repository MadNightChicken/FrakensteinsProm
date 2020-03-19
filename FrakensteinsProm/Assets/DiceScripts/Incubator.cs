using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public abstract class Incubator : MonoBehaviour
{
    protected bool _isUsable;
    [SerializeField]
    protected Text name;

    public bool IsUseable()
    {
        return _isUsable;
    }

    public abstract bool CanUseDice(int diceValue);

    public abstract void RunIncubate(int diceValue);
}
