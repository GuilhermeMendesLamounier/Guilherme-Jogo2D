using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemManager : MonoBehaviour
{
    public static ItemManager Instance;

    public int Coin;

    private void Awake()
    {
        if (Instance == null)
            Instance = this;
        else
            Destroy(gameObject);
    }

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
