using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "DefaultAttackData", menuName = "TopDownController/Attack/Ranged", order = 1)]
public class RangedAttackData : AttackSO
{
    [Header("Ranged Attack Date")]
    public string bulletNameTag;
    public float duration;
    public float spread;
    public int numberofProjectilesAngel;
    public float multipleProjectilesAngel;
    public Color projectileColor;
}
