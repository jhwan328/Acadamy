using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Slot_Inventory : MonoBehaviour
{
    [SerializeField] private SpriteRenderer SpriteRenderer;
   
    public void ChangeSprite(Sprite sprite)
    {
        this.SpriteRenderer.sprite = sprite;
    }
}
