using UnityEngine;

public class PopUpManager : MonoBehaviour
{
    public GameObject ButtonUI;
    private GameObject CuButtonUI;
    private ButtonUI buttonUI;

    //Ȱ��ȭ, ��Ȱ��ȭ ��
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
