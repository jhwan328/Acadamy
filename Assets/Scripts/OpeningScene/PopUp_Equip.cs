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
    [SerializeField] private SpriteRenderer StatSprite;
    [SerializeField] private Sprite[] StatIcon;
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
        switch(item.Type)
        {
            case Item.ItemStatsType.Hp:
                StatSprite.sprite = StatIcon[0];
                break;
            case Item.ItemStatsType.Atk:
                StatSprite.sprite = StatIcon[1];
                break;
            case Item.ItemStatsType.Def:
                StatSprite.sprite = StatIcon[2];
                break;
            case Item.ItemStatsType.Cri:
                StatSprite.sprite = StatIcon[3];
                break;
            default:
                break;
        }

    }
    public void ClickCloseButton()
    {
        Destroy(this.gameObject);
    }
}
