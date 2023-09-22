using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using static UnityEditorInternal.ReorderableList;

[CreateAssetMenu(fileName = "DefaultItemData", menuName = "TopDownController / Item / Defalut", order = 0)]

public class Item : ScriptableObject
{
    public enum ItemStatsType { Atk, Def, Hp, Cri };
    [Header("Item Info")]
    //아이템 넘버
    public int ItemNumber;
    //증감 수치
    public int Value;
    //가격
    public int Price;
    //아이템 이름
    public string Name;
    //아이템 설명
    public String Desc;
    //아이템 아이콘
    public Sprite ItemIcon;
    //아이템 갯수
    public int Stack;
    //아이템 장착여부
    public bool isEquiped;
    //아이템 타입
    public ItemStatsType Type;

}
