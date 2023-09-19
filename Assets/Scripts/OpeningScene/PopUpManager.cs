using UnityEngine;

public class PopUpManager : MonoBehaviour
{
    public GameObject ButtonUI;
    private GameObject CuButtonUI;
    private ButtonUI buttonUI;

    //활성화, 비활성화 용
    public GameObject currentPopupStatus;
    public GameObject currentPopupInventory;
    public GameObject currentPopupShop;

    private void Start()
    {
       CuButtonUI= Instantiate(ButtonUI);
       buttonUI = CuButtonUI.GetComponent<ButtonUI>();
       buttonUI.SetManager(this);
    }
}
