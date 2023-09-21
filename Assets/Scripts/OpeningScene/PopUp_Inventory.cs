using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PopUp_Inventory : MonoBehaviour
{
    private PlayerInfo PlayerInfo;
    private ItemStatsManager itemStatsManager;
    public Transform[] SpawnPoints;
    public GameObject InventorySlotsPrefab;
    private GameObject ButtonUI;
    private List<GameObject> Slots;
    private bool startIsRun = true;

    private void Start()
    {
        Slots = new List<GameObject>();
        int[] inventory = PlayerInfo.Inventory;
        Item item;
        Slot_Inventory SlotScript;

        for (int i = 0; i < SpawnPoints.Length; i++)
        {
            GameObject InventorySlot = Instantiate(InventorySlotsPrefab, SpawnPoints[i].position, Quaternion.identity);
            if (inventory[i] != 0)
            {
                item = itemStatsManager.GetItem(inventory[i]);
                SlotScript = InventorySlot.GetComponent<Slot_Inventory>();
                SlotScript.ChangeSprite(item.ItemIcon);
                SlotScript.SetItem(item);
                if (item.isEquiped)
                {
                    SlotScript.EuquipUpdate(true);
                }
            }
            Slots.Add(InventorySlot);
        }

        PlayerInfo.InventoryChange += UpdateInventorySlot;

        startIsRun = false;
    }

    private void OnEnable()
    {
        if (!startIsRun)
        {
            if (Slots != null)
            {
                for (int i = 0; i < Slots.Count; i++)
                {
                    Slots[i].SetActive(true);
                }
            }
        }
    }

    public void SetButtonUI(GameObject ButtonUI)
    {
        this.ButtonUI = ButtonUI;
    }

    public void SetItemStatesManager(ItemStatsManager itemStatsManager)
    {
        this.itemStatsManager = itemStatsManager;
    }

    public void ClickCloseButton()
    {
        foreach (GameObject slot in Slots)
        {
            slot.SetActive(false);
        }
        ButtonUI.SetActive(true);
        this.gameObject.SetActive(false);
    }

    public void SetPlayerInfo(PlayerInfo PlayerInfo)
    {
        this.PlayerInfo = PlayerInfo;
    }

   
    private void UpdateInventorySlot(Item item)
    {
        for (int i = 0; i < Slots.Count; i++)
        {
            Slot_Inventory SlotScript = Slots[i].GetComponent<Slot_Inventory>();
            if (SlotScript.GetItem() == null)
            {
                SlotScript.ChangeSprite(item.ItemIcon);
                SlotScript.SetItem(item);
                if (item.isEquiped)
                {
                    SlotScript.EuquipUpdate(true);
                }
                break;
            }
        }
    }
}
