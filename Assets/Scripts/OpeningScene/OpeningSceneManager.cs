using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpeningSceneManager : MonoBehaviour
{
    public GameObject PlayerUI;
    public GameObject ButtonUI;
    public GameObject Character;


    void Start()
    {
        Instantiate(PlayerUI);
        Instantiate(ButtonUI);
        Instantiate(Character);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
