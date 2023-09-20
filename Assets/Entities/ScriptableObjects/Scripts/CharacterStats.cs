using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum StatsChangeType
{
    Add,
    Multiple,
    Overrride
}

[Serializable]
public class CharacterStats 
{
    public StatsChangeType statsChangeType;
    [Range(0,100)]public int maxHealth;
    [Range(0, 20)] public int speed;

    //공격 데이터
   public AttackSO attackSO;
}
