using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class PlayerUI : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI Title;
    [SerializeField] private TextMeshProUGUI Name;
    [SerializeField] private TextMeshProUGUI Desc;
    [SerializeField] private TextMeshProUGUI CurrentExp;
    [SerializeField] private TextMeshProUGUI LV;
    [SerializeField] private TextMeshProUGUI Gold;

    private PlayerInfo PlayerInfo;

    public void SetPlayerInfo(PlayerInfo info)
    {
        this.PlayerInfo = info;
        this.PlayerInfo.PlayerGoldChanged += OnPlayerGoldChanged;
    }

    public void UpdatrUI()
    {
        Title.text = PlayerInfo.Title;
        Name.text = PlayerInfo.Name;
        CurrentExp.text = PlayerInfo.CurrentExp.ToString();
        Desc.text = PlayerInfo.Desc;
        LV.text=PlayerInfo.Level.ToString();
        Gold.text=PlayerInfo.Gold.ToString();
    }
    private void OnPlayerGoldChanged(int newGold)
    {
        // Gold 업데이트
        Gold.text = newGold.ToString();
    }

}
