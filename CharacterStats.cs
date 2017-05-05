using UnityEngine;
using System.Collections;
using System.Collections.Generic;using UnityEngine.UI;


public class CharacterStats : MonoBehaviour {

    public List<BaseStat> stats = new List<BaseStat>();
    public int Health { get; set; }
    public int MaxHealth { get; set; }


    public Slider bar;
    void Start()
    {
        MaxHealth = 100;
        Health = MaxHealth;
        bar.value = MaxHealth;
        stats.Add(new BaseStat(4, "Power", "Your power level"));
        stats.Add(new BaseStat(2, "Vitality", "Your vitality level"));
        stats.Add(new BaseStat(MaxHealth, "Health", "Your health level"));
    }


    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            DealDamage(20);
        }
    }
    public void AddStatBonus(List<BaseStat> statBonuses)
    {
        foreach  (BaseStat statBonus in statBonuses)
        {
            stats.Find(x => x.StatName == statBonus.StatName).AddStatBonus(new StatBonus(statBonus.BaseValue));
        }
    }

    public void RemoveStatBonus(List<BaseStat> statBonuses)
    {
        foreach (BaseStat statBonus in statBonuses)
        {
            stats.Find(x => x.StatName == statBonus.StatName).RemoveStatBonus(new StatBonus(statBonus.BaseValue));
        }
    }

    void DealDamage(int damageValue)
    {
        Health -= damageValue;
        bar.value = Health;
        if(Health <= 0)
        {
            Die();
        }
    }



    void Die()
    {
        Health = 0;
        Debug.Log("You are dead");
    }

}
