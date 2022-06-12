using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Class", menuName = "Class")]
public class ClassMaker : ScriptableObject
{
    public string className;

    [Header("Starting Health and Speed"), Space(5)]
    public int defaultHealth;
    public int defaultSpeed;

    [Header("How many Slots this class takes up"), Space(5)]
    public int slotSpace;

    [Header("Current weapon slot number equipped"), Space(5)]
    public int equipNum;

    [Header("Current loadout of Weapons"), Space(5)]
    public WeaponMaker primarySlot;
    public WeaponMaker secondarySlot;
    public WeaponMaker meleeSlot;
}
