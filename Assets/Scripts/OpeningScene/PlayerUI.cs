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

    private PlayerInfo PlayerInfo;

    public void SetPlayerInfo(PlayerInfo info)
    {
        PlayerInfo = info;
    }

    public void UpdatrUI()
    {
        Title.text = PlayerInfo.Title;
        Name.text = PlayerInfo.Name;
        CurrentExp.text = PlayerInfo.CurrentExp.ToString();
        Desc.text = PlayerInfo.Desc;
        LV.text=PlayerInfo.Level.ToString();
    }
}
