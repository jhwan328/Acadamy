using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StatusSlot : MonoBehaviour
{
    public SpriteRenderer SpriteRenderer;


    public void SetSprite(Sprite sprite)
    {
        if (SpriteRenderer != null)
        {
            SpriteRenderer.sprite = sprite;
        }
    }
}
