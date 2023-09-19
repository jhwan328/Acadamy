using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class PopUp_Status : MonoBehaviour
{
    public GameObject StatusSlot;
    public Transform[] SpawnPoint;
    public Sprite[] Icons;
    private GameObject ButtonUI;
    private List<GameObject> SlotArray;
    private bool startIsRun = true;

    private void Start()
    {
        SlotArray = new List<GameObject>();
        for (int i = 0; i < SpawnPoint.Length; i++)
        {
            GameObject statusSlot = Instantiate(StatusSlot, SpawnPoint[i].position, Quaternion.identity);
            StatusSlot slotScript = statusSlot.GetComponent<StatusSlot>();
            slotScript.SetSprite(Icons[i]);
            SlotArray.Add(statusSlot);
        }
        startIsRun=false;
    }

    private void OnEnable()
    {
        if(!startIsRun)
        {
            if (SlotArray != null)
            {
                for (int i = 0; i < SlotArray.Count; i++)
                {
                    SlotArray[i].SetActive(true);
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
        foreach (GameObject slot in SlotArray)
        {
            slot.SetActive(false);
        }
        ButtonUI.SetActive(true);
        this.gameObject.SetActive(false);
    }

}
