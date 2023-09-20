using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpeningSceneManager : MonoBehaviour
{
    [SerializeField] private GameObject PlayerUI;
    [SerializeField] private GameObject PopUpManager;
    [SerializeField] private GameObject Character;
    [SerializeField] private GameObject ItemStateManager;


    void Awake()
    {
        GameObject Manager1=Instantiate(ItemStateManager);
        GameObject Manager2 = Instantiate(PopUpManager);
        GameObject PlayerUi = Instantiate(PlayerUI);
        GameObject Player = Instantiate(Character);

        ItemStatsManager itemStateManager = Manager1.GetComponent<ItemStatsManager>();
        PopUpManager popUpManager = Manager2.GetComponent<PopUpManager>();
        PlayerInfo player = Character.GetComponent<PlayerInfo>();

        popUpManager.SetItemStatesManager(itemStateManager);
        popUpManager.SetPlayerInfo(player);
    }
   

}
