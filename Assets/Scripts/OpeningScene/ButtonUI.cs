using System;
using UnityEngine;

public class ButtonUI : MonoBehaviour
{
    public GameObject popUpStatusPrefab;
    public GameObject popUpInventoryPrefab;
    public GameObject popUpShopPrefab;

    private PopUpManager popUpManager;
    private ItemStatsManager itemStatsManager;

    private PlayerInfo playerInfo;

    public void SetPlayerInfo(PlayerInfo playerInfo)
    {
        this.playerInfo = playerInfo;
    }

    public void SetItemStatesManager(ItemStatsManager itemStatsManager)
    {
        this.itemStatsManager = itemStatsManager;
    }
    public void SetManager(PopUpManager Manager)
    {
        popUpManager = Manager;
    }

    public void OpenStatusPopup()
    {
        if (popUpManager.currentPopupStatus == null)
        {
            GameObject Obj= Instantiate(popUpStatusPrefab);
            popUpManager.currentPopupStatus = Obj;
            Obj.GetComponent<PopUp_Status>().SetButtonUI(this.gameObject);
            Obj.GetComponent<PopUp_Status>().SetPlayerInfo(this.playerInfo);
            this.gameObject.SetActive(false);
        }
        else
        {
            popUpManager.currentPopupStatus.SetActive(true);
            this.gameObject.SetActive(false);
        }
    }

    public void OpenInventoryPopup()
    {
        if (popUpManager.currentPopupInventory == null)
        {
            GameObject Obj= Instantiate(popUpInventoryPrefab);
            popUpManager.currentPopupInventory = Obj;
            PopUp_Inventory popUp_Inventory = Obj.GetComponent<PopUp_Inventory>();
            popUp_Inventory.SetButtonUI(this.gameObject);
            popUp_Inventory.SetItemStatesManager(itemStatsManager);
            popUp_Inventory.SetPlayerInfo(playerInfo);
            this.gameObject.SetActive(false);
        }
        else
        {
            popUpManager.currentPopupInventory.SetActive(true);
            this.gameObject.SetActive(false);
        }
    }

    public void OpenShopPopup()
    {
        if (popUpManager.currentPopupShop == null)
        {
            GameObject Obj = Instantiate(popUpShopPrefab);
            popUpManager.currentPopupShop = Obj;
            PopUp_Shop popUp_Shop = Obj.GetComponent<PopUp_Shop>();
            popUp_Shop.SetButtonUI(this.gameObject);
            popUp_Shop.SetItemStatesManager(itemStatsManager);
            popUp_Shop.SetPlayerInfo(playerInfo);
            this.gameObject.SetActive(false);
        }
        else
        {
            popUpManager.currentPopupShop.SetActive(true);
            this.gameObject.SetActive(false);
        }
    }

}
