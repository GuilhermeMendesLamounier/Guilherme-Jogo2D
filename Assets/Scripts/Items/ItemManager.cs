using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Ebac.Core.Singleton;

public class ItemManager : Singleton<ItemManager> 
{
    public int Coin;

    private void Start()
    {
        Reset();
    }

    private void Reset()
    {
        Coin = 0;
    }

    public void addCoins(int amount = 1)
    {
        Coin+= amount;
    }

}
