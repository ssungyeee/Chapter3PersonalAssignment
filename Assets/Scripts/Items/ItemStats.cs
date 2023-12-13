using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[Serializable]
public class ItemStats
{
    public StatsChangeType statsChangeType;
    [Range(0, 20)] public int maxAttack;
    [Range(0, 20)] public int maxDefense;
    [Range(0, 20)] public int maxHealth;
    [Range(0, 20)] public int maxCritical;    
}
