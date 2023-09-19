using System;
using UnityEngine;

public class ButtonUI : MonoBehaviour
{
    public GameObject popUpStatusPrefab;
    public GameObject popUpInventoryPrefab;
    public GameObject popUpShopPrefab;

    PopUpManager popUpManager;

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
            Obj.GetComponent<PopUp_Inventory>().SetButtonUI(this.gameObject);
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
            Obj.GetComponent<PopUp_Shop>().SetButtonUI(this.gameObject);
            this.gameObject.SetActive(false);
        }
        else
        {
            popUpManager.currentPopupShop.SetActive(true);
            this.gameObject.SetActive(false);
        }
    }

}
