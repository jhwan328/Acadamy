using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpeningSceneManager : MonoBehaviour
{
    public GameObject PlayerUI;
    public GameObject PopUpManager;
    public GameObject Character;


    void Start()
    {
        Instantiate(PlayerUI);
        Instantiate(PopUpManager);
        Instantiate(Character);
    }

}
