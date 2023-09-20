using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemStatsManager : MonoBehaviour
{
    [SerializeField] private List<Item> ItemArray;

    public Item GetItem(int index)
    {
        return ItemArray[index];
    }
}
