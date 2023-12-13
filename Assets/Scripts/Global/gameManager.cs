using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System;

public class gameManager : MonoBehaviour
{
    public static gameManager Instance;
    public CharacterStatsHandler characterStatsHandler;

    public TMP_Text TimeTxt;
    [SerializeField] private GameObject OnStatus;
    [SerializeField] private GameObject OnInventory;
    [SerializeField] private GameObject StatusButton;
    [SerializeField] private GameObject InventoryButton;
    [SerializeField] private GameObject GoBackStatusButton;
    [SerializeField] private GameObject GoBackInventoryButton;

    [SerializeField] private TextMeshProUGUI LevelText;
    [SerializeField] private TextMeshProUGUI GoldText;

    [SerializeField] private TextMeshProUGUI AttackText;
    [SerializeField] private TextMeshProUGUI DefenseText;
    [SerializeField] private TextMeshProUGUI HealthPointText;
    [SerializeField] private TextMeshProUGUI CriticalText;

    

    public static string GetCurrentDate()
    {
        return DateTime.Now.ToString(("HH:mm"));
    }
    private void Awake()
    {
        Instance = this;
    }
    void Start()
    {        
        UpdateLevelText();
        UpdateGoldText();
        UpdateStatText();
    }    
    void Update()
    {
        TimeTxt.text = GetCurrentDate();
    }

    public void OnClickStatus()
    {
        OnStatus.SetActive(true);
        StatusButton.SetActive(false);
    }
    public void OnClickInventory()
    {
        OnInventory.SetActive(true);
        InventoryButton.SetActive(false);
    }

    public void OnClickStatusGoBack()
    {
        OnStatus.SetActive(false);
        StatusButton.SetActive(true);
    }
    public void OnClickInventoryGoBack()
    {
        OnInventory.SetActive(false);
        InventoryButton.SetActive(true);
    }

    private void UpdateLevelText()
    {
        float Level = 1f;
        LevelText.text = Level.ToString("00");
    }
    private void UpdateGoldText()
    {
        float Gold = 1500f;
        GoldText.text = Gold.ToString("");
    }

    public void UpdateStatText()
    {
        AttackText.text = characterStatsHandler.CurrentStats.maxAttack.ToString("");
        DefenseText.text = characterStatsHandler.CurrentStats.maxDefense.ToString("");
        HealthPointText.text = characterStatsHandler.CurrentStats.maxHealth.ToString("");
        CriticalText.text = characterStatsHandler.CurrentStats.maxCritical.ToString("");
    }
}
