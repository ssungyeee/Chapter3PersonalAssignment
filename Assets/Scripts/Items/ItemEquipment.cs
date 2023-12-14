using System.Collections;
using System.Collections.Generic;
using Unity.Burst.Intrinsics;
using UnityEngine;

public class ItemEquipment : MonoBehaviour
{
    [SerializeField] private GameObject item;
    [SerializeField] private GameObject equipItemImage;

    [SerializeField] private GameObject aim;

    [SerializeField] private CharacterStatsHandler characterStatsHandler;
       
    public void EquipItem()
    {        
        bool isActive = equipItemImage.activeSelf;
        equipItemImage.SetActive(!isActive);
        item.SetActive(!isActive);

        aim.SetActive(isActive);

        if (item.activeSelf == true)
        {            
            characterStatsHandler.UpdateEquipedStats();
            gameManager.Instance.UpdateStatText();
        }
        else if (item.activeSelf == false)
        {            
            characterStatsHandler.UpdateUnEquipedStats();
            gameManager.Instance.UpdateStatText();
        }
    }
}