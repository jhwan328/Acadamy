using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PopUp_Shop : MonoBehaviour
{
    public Transform[] SpawnPoints;
    public GameObject ShopItemBarPrefab;
    private GameObject ButtonUI;
    private List<GameObject> Bars;
    private bool startIsRun = true;
    private void Start()
    {
        Bars = new List<GameObject>();
        for (int i = 0; i < SpawnPoints.Length; i++)
        {
            GameObject ShopItemBar = Instantiate(ShopItemBarPrefab, SpawnPoints[i].position, Quaternion.identity);
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
}
