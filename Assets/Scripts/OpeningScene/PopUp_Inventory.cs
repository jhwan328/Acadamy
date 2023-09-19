using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PopUp_Inventory : MonoBehaviour
{
    public Transform[] SpawnPoints;
    public GameObject InventorySlotsPrefab;
    private GameObject ButtonUI;
    private List<GameObject> Slots;
    private bool startIsRun = true;
    private void Start()
    {
        Slots = new List<GameObject>();
        for (int i = 0; i < SpawnPoints.Length; i++)
        {
            GameObject InventorySlot = Instantiate(InventorySlotsPrefab, SpawnPoints[i].position, Quaternion.identity);
            Slots.Add(InventorySlot);
        }
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


    public void ClickCloseButton()
    {
        foreach (GameObject slot in Slots)
        {
            slot.SetActive(false);
        }
        ButtonUI.SetActive(true);
        this.gameObject.SetActive(false);
    }

}
