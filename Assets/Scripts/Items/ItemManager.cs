using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Ebac.Core.Singleton;
using TMPro;

public class ItemManager : Singleton<ItemManager> 
{
    public SOint Coins;

    public TextMeshProUGUI coinsDisplay;

    public void UpdateUI()
    {
        //coinsDisplay.text = Coins.ToString();
        //UIInGameManager.updateTextCoins(Coins.value.ToString());
    }

    private void Start()
    {
        Reset();
    }

    private void Reset()
    {
        Coins.value = 0;
        UpdateUI();
    }

    public void addCoins(int amount = 1)
    {
        Coins.value += amount;
        UpdateUI();
    }

}
