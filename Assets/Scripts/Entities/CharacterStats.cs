using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public enum StatsChangeType
{
    Add,
    Multiple,
    Override,
}

[Serializable]

public class CharacterStats
{
    public StatsChangeType statsChangeType;
    [Range(1, 100)] public int maxAttack;
    [Range(1, 100)] public int maxDefense;
    [Range(1, 200)] public int maxHealth;
    [Range(1, 100)] public int maxCritical;
    [Range(1f, 20f)] public float speed;    
}

