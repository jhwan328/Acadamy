using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Slot_Inventory : MonoBehaviour
{
    [SerializeField] private SpriteRenderer SpriteRenderer;
    [SerializeField] private GameObject EquipIcon;
    [SerializeField] private GameObject PopUp_EquipPrefab;

    private Item Item;

    public void SetItem(Item item)
    {
        Item = item;
    }
    public void ChangeSprite(Sprite sprite)
    {
        this.SpriteRenderer.sprite = sprite;
    }
    public void EuquipUpdate(bool isEquied)
    {
        if (isEquied) EquipIcon.SetActive(true);
        else EquipIcon.SetActive(false);
    }

    public void ClickSprite()
    {
        if (Item != null)
        {
            GameObject PopUp_Equip = Instantiate(PopUp_EquipPrefab);
            PopUp_Equip popUpScript = PopUp_Equip.GetComponent<PopUp_Equip>();
            popUpScript.SetItem(Item);
            popUpScript.UpdateUI();
        }
    }
}
