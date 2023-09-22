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
    //������ �ѹ�
    public int ItemNumber;
    //���� ��ġ
    public int Value;
    //����
    public int Price;
    //������ �̸�
    public string Name;
    //������ ����
    public String Desc;
    //������ ������
    public Sprite ItemIcon;
    //������ ����
    public int Stack;
    //������ ��������
    public bool isEquiped;
    //������ Ÿ��
    public ItemStatsType Type;

}
