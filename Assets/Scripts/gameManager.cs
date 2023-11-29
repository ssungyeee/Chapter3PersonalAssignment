using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System;

public class gameManager : MonoBehaviour
{
    public TMP_Text TimeTxt;

    public static string GetCurrentDate()
    {
        return DateTime.Now.ToString(("HH:mm"));
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        TimeTxt.text = GetCurrentDate();
    }
}
