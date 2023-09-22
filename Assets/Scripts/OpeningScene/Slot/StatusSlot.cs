using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class StatusSlot : MonoBehaviour
{
    [SerializeField] private SpriteRenderer SpriteRenderer;
    [SerializeField] private TextMeshProUGUI StatValue;
    [SerializeField] private TextMeshProUGUI StatType;

    public void SetSprite(Sprite sprite)
    {
        if (SpriteRenderer != null)
        {
            SpriteRenderer.sprite = sprite;
        }
    }
    
    public void UpdateUI(string type, int value)
    {
        StatValue.text=value.ToString();
        StatType.text = type;
    }
    
}
