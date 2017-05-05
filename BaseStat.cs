using UnityEngine;
using System.Collections;
using System.Collections.Generic;



public class BaseStat
{
    public List<StatBonus> BaseAdditives { get; set; }



    public int Value { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public int FValue { get; set; }
    

    public BaseStat(int baseValue, string statName, string statDescription)
    {
        this.BaseAdditives = new List<StatBonus>();
        this.Value = baseValue;
        this.Name = statName;
        this.Description = statDescription;

    }

    public void AddStatBonus(StatBonus statBonus)
    {
        this.BaseAdditives.Add(statBonus);
    }

    public void RemoveStatBonus(StatBonus statBonus)
    {
        this.BaseAdditives.Remove(BaseAdditives.Find(x => x.BonusValue == statBonus.BonusValue));
    }

    public int GetCalculatedStatValue()
    {
        this.FValue = 0;
        this.BaseAdditives.ForEach(x => this.FValue += x.BonusValue);
        FValue += Value;
        return FValue;
    }
}
