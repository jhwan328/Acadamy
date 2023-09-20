using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ShopItemBar : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI ItemName;
    [SerializeField] private TextMeshProUGUI ItemDesc;
    [SerializeField] private TextMeshProUGUI ItemStatsValue;
    [SerializeField] private TextMeshProUGUI ItemPriceValue;
    [SerializeField] private SpriteRenderer ItemIcon;
    [SerializeField] private SpriteRenderer StateIcon;
    [SerializeField] private Sprite[] StateIcons;

   public void UpdateUI(Item item)
    {
        ItemName.text = item.Name;
        ItemDesc.text = item.Desc;
        ItemStatsValue.text = item.Value.ToString();
        ItemPriceValue.text = item.Price.ToString();
        ItemIcon.sprite = item.ItemIcon;
        switch (item.Type)
        {
            case Item.ItemStatsType.Hp:
                StateIcon.sprite = StateIcons[0];
                break;
            case Item.ItemStatsType.Atk:
                StateIcon.sprite = StateIcons[1];
                break;
            case Item.ItemStatsType.Def:
                StateIcon.sprite = StateIcons[2];
                break;
            case Item.ItemStatsType.Cri:
                StateIcon.sprite = StateIcons[3];
                break;
        }
    }
}
