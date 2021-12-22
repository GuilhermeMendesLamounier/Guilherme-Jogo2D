using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Ebac.Core.Singleton;
using TMPro;

public class ItemManager : Singleton<ItemManager> 
{
    public int Coins;

    public TextMeshProUGUI coinsDisplay;

    public void UpdateUI()
    {
        coinsDisplay.text = Coins.ToString();
    }

    private void Start()
    {
        Reset();
    }

    private void Reset()
    {
        Coins = 0;
    }

    public void addCoins(int amount = 1)
    {
        Coins+= amount;
        UpdateUI();
    }

}
