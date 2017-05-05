using UnityEngine;
using System.Collections;

public class StatBonus {

    public int Value { get; set; }

    public StatBonus(int bonusValue)
    {
        this.Value = bonusValue;
        Debug.Log("A new StatBonus initiated!");
    }
}
