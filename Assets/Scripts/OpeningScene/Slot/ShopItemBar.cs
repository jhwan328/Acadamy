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
    [SerializeField] private GameObject Buy;
    [SerializeField] private GameObject Out;
    private PlayerInfo playerInfo;
    private int price;
    private Item item;

    public void SetItem(Item item)
    {
        this.item = item;
    }
   public void UpdateUI(Item item)
    {
        SetItem(item);
        ItemName.text = item.Name;
        ItemDesc.text = item.Desc;
        price = item.Price;
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

    public void SetPlayerInfo(PlayerInfo playerInfo)
    {
        this.playerInfo = playerInfo;
    }

    public void ClickBuy()
    {
        if (playerInfo != null && playerInfo.Gold >= price)
        {
            // 아이템을 구매하고 Gold 차감
            int newGold = playerInfo.Gold - price;
            playerInfo.UpdateGold(newGold);
            playerInfo.UpdateInventory(item);
            Buy.SetActive(false);
            Out.SetActive(true);
        }
        else
        {
            Debug.Log("Not enough Gold!");
            if (playerInfo == null) Debug.Log("playerInfo is Null");
        }
    }
}
