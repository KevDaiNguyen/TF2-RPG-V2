using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponLists : MonoBehaviour
{
    [Header("All weapons that can be picked up"), Space(5)]
    public WeaponMaker[] nonStockWeapons;

    [Header("---Scout Weapons---"), Space(5)]
    public WeaponMaker[] scoutPrimaries; [Space(3)]
    public WeaponMaker[] scoutSecondaries; [Space(3)]
    public WeaponMaker[] scoutMelees;

    [Header("---Soldier Weapons---"), Space(5)]
    public WeaponMaker[] soldierPrimaries; [Space(3)]
    public WeaponMaker[] soldierSecondaries;[Space(3)]
    public WeaponMaker[] soldierMelees;

    [Header("---Pyro Weapons---"), Space(5)]
    public WeaponMaker[] pyroPrimaries;[Space(3)]
    public WeaponMaker[] pyroSecondaries;[Space(3)]
    public WeaponMaker[] pyroMelees;

    [Header("---Demoman Weapons---"), Space(5)]
    public WeaponMaker[] demomanPrimaries;[Space(3)]
    public WeaponMaker[] demomanSecondaries;[Space(3)]
    public WeaponMaker[] demomanMelees;

    [Header("---Heavy Weapons---"), Space(5)]
    public WeaponMaker[] heavyPrimaries;[Space(3)]
    public WeaponMaker[] heavySecondaries;[Space(3)]
    public WeaponMaker[] heavyMelees;

    [Header("---Engineer Weapons---"), Space(5)]
    public WeaponMaker[] engineerPrimaries;[Space(3)]
    public WeaponMaker[] engineerSecondaries;[Space(3)]
    public WeaponMaker[] engineerMelees;

    [Header("---Medic Weapons---"), Space(5)]
    public WeaponMaker[] medicPrimaries;[Space(3)]
    public WeaponMaker[] medicSecondaries;[Space(3)]
    public WeaponMaker[] medicMelees;

    [Header("---Sniper Weapons---"), Space(5)]
    public WeaponMaker[] sniperPrimaries;[Space(3)]
    public WeaponMaker[] sniperSecondaries;[Space(3)]
    public WeaponMaker[] sniperMelees;

    [Header("---Spy Weapons---"), Space(5)]
    public WeaponMaker[] spyPrimaries;[Space(3)]
    public WeaponMaker[] spySecondaries;[Space(3)]
    public WeaponMaker[] spyMelees;[Space(3)]
    public WeaponMaker[] spyWatches;

}
