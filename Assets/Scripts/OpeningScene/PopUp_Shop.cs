using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PopUp_Shop : MonoBehaviour
{
    //TODO
    private List<int> ShopInventory;
    public ItemStatsManager itemStatsManager;
    private ShopItemBar shopItemBar;

    public Transform[] SpawnPoints;
    public GameObject ShopItemBarPrefab;
    private GameObject ButtonUI;
    private List<GameObject> Bars;

    private Slot_Inventory slotScript;

    private bool startIsRun = true;
    private void Start()
    {
        Bars = new List<GameObject>();
        ShopInventory = new List<int>();
        AddItem(1);
        AddItem(2);
        AddItem(3);
        int Cur;
        for (int i = 0; i < SpawnPoints.Length; i++)
        {
            GameObject ShopItemBar = Instantiate(ShopItemBarPrefab, SpawnPoints[i].position, Quaternion.identity);
            Cur = ShopInventory[i];
            if (Cur != 0)
            {
                shopItemBar=ShopItemBar.GetComponent<ShopItemBar>();
                shopItemBar.UpdateUI(itemStatsManager.GetItem(Cur));
            }
            Bars.Add(ShopItemBar);
        }
        startIsRun = false;
    }

    private void OnEnable()
    {
        if (!startIsRun)
        {
            if (Bars != null)
            {
                for (int i = 0; i < Bars.Count; i++)
                {
                    Bars[i].SetActive(true);
                }
            }
        }
    }

    public void SetButtonUI(GameObject ButtonUI)
    {
        this.ButtonUI = ButtonUI;
    }

    public void ClickCloseButton()
    {
        foreach (GameObject slot in Bars)
        {
            slot.SetActive(false);
        }
        ButtonUI.SetActive(true);
        this.gameObject.SetActive(false);
    }
    public void AddItem(int ItemNumber)
    {
        ShopInventory.Add(ItemNumber);
    }
}