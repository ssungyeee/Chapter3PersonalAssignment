using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class CharacterStatsHandler : MonoBehaviour
{    
    [SerializeField] private CharacterStats baseStats;
    [SerializeField] private ItemStatsHandler itemStatsHandler;    

    public CharacterStats CurrentStats { get; private set; }    

    private void Awake()
    {        
        UpdateCharacterStats();        
    }
    
    public void UpdateCharacterStats()
    {
        CurrentStats = new CharacterStats();        
        CurrentStats.statsChangeType = baseStats.statsChangeType;

        CurrentStats.maxAttack = baseStats.maxAttack;
        CurrentStats.maxDefense = baseStats.maxDefense;
        CurrentStats.maxHealth = baseStats.maxHealth;
        CurrentStats.maxCritical = baseStats.maxCritical;

        CurrentStats.speed = baseStats.speed;
    }

    public void UpdateEquipedStats()
    {
        itemStatsHandler = GetComponentInChildren<ItemStatsHandler>();
        
        CurrentStats.maxAttack += itemStatsHandler.CurrentStats.maxAttack;
        CurrentStats.maxDefense += itemStatsHandler.CurrentStats.maxDefense;
        CurrentStats.maxHealth += itemStatsHandler.CurrentStats.maxHealth;
        CurrentStats.maxCritical += itemStatsHandler.CurrentStats.maxCritical;
    }
    public void UpdateUnEquipedStats()
    {        
        CurrentStats.maxAttack -= itemStatsHandler.CurrentStats.maxAttack;
        CurrentStats.maxDefense -= itemStatsHandler.CurrentStats.maxDefense;
        CurrentStats.maxHealth -= itemStatsHandler.CurrentStats.maxHealth;
        CurrentStats.maxCritical -= itemStatsHandler.CurrentStats.maxCritical;
    }
}
