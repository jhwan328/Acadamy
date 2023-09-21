using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInfo : MonoBehaviour
{
    public int[] Inventory = new int[12];
    public int Level = 9;
    public int MaxExp = 100;
    public int CurrentExp = 80;
    public int Hp = 200;
    public int Atk = 10;
    public int Def = 10;
    public int Cri = 10;
    public int Gold = 3000;
    public string Name = "AAB";
    public string Title = "Powerful";
    public string Desc = "위대한 모험을 꿈꾸는 기사";

    public event Action<int> PlayerGoldChanged;
    public event Action<Item> InventoryChange;

    public void UpdateGold(int newGold)
    {
        Gold = newGold;
        PlayerGoldChanged?.Invoke(Gold); 
    }

    public void UpdateInventory(Item item)
    {
        for (int i = 0; i < Inventory.Length; i++)
        {
            if (Inventory[i] == 0)
            {
                Inventory[i] = item.ItemNumber;
                InventoryChange?.Invoke(item);
                break; 
            }
        }
    }


}
