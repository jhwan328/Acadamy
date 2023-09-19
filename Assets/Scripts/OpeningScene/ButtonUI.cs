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
            popUpManager.currentPopupInventory = Instantiate(popUpInventoryPrefab);
        }
        else
        {
            popUpManager.currentPopupInventory.SetActive(true);
        }
    }

    public void OpenShopPopup()
    {
        if (popUpManager.currentPopupShop == null)
        {
            popUpManager.currentPopupShop = Instantiate(popUpShopPrefab);
        }
        else
        {
            popUpManager.currentPopupShop.SetActive(true);
        }
    }

}
