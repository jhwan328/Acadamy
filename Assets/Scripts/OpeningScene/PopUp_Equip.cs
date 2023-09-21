using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class PopUp_Equip : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI ItemName;
    [SerializeField] private TextMeshProUGUI ItemDesc;
    [SerializeField] private TextMeshProUGUI StatValue;
    [SerializeField] private SpriteRenderer ItemSprite;
    private Item item;

    public void SetItem(Item item)
    {
        this.item = item;
    }

    public void UpdateUI()
    {
        ItemName.text = item.Name;
        ItemDesc.text = item.Desc;
        StatValue.text = item.Value.ToString();
        ItemSprite.sprite = item.ItemIcon;

    }
    public void ClickCloseButton()
    {
        Destroy(this.gameObject);
    }
}
