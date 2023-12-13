using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemStatsHandler : MonoBehaviour
{
    [SerializeField] private ItemStats baseStats;

    public ItemStats CurrentStats { get; private set; }    
    private void Awake()
    {        
        UpdateItemStats();
    }

    private void UpdateItemStats()
    {
        CurrentStats = new ItemStats();
        CurrentStats.statsChangeType = baseStats.statsChangeType;

        CurrentStats.maxAttack = baseStats.maxAttack;
        CurrentStats.maxDefense = baseStats.maxDefense;
        CurrentStats.maxHealth = baseStats.maxHealth;
        CurrentStats.maxCritical = baseStats.maxCritical;
    }
}
