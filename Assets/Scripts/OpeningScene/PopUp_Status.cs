using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class PopUp_Status : MonoBehaviour
{
    public GameObject StatusSlot;
    public Transform[] SpawnPoint;
    public Sprite[] Icons;

   

    private void Start()
    {
       for(int i = 0; i < SpawnPoint.Length; i++)
       {
            GameObject statusSlot = Instantiate(StatusSlot, SpawnPoint[i].position, Quaternion.identity);
            StatusSlot slotScript = statusSlot.GetComponent<StatusSlot>();
            slotScript.SetSprite(Icons[i]);
       }
       
    }
}
