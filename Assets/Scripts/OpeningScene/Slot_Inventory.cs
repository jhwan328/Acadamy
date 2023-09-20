using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Slot_Inventory : MonoBehaviour
{
    [SerializeField] private SpriteRenderer SpriteRenderer;
    [SerializeField] private GameObject EquipIcon;
    public void ChangeSprite(Sprite sprite)
    {
        this.SpriteRenderer.sprite = sprite;
    }
    public void EuquipUpdate(bool isEquied)
    {
        if (isEquied) EquipIcon.SetActive(true);
        else EquipIcon.SetActive(false);
    }
}
