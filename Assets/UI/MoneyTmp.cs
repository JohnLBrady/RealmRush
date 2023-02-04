using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class MoneyTmp : MonoBehaviour
{

    TMP_Text moneyTMP;
    
    void Start()
    {
        moneyTMP = GetComponent<TMP_Text>();
    }

    public void UpdateBalance(int amount){
        moneyTMP.text = $"Gold: {amount}";
    }
}
