using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Weapon", menuName = "Weapon")]
public class WeaponMaker : ScriptableObject
{
    public string weaponName;
    [TextArea(2, 5)]
    public string weaponDescription;
    public Sprite weaponImage;
    public int weaponSlot;
    
    [Header("TRUE if weapon can be held out"), Space(5)]
    public bool activeWeapon;
    
    [Header("Size of ammo capacities"), Space(5)]
    public int clipSize;
    public int reserveSize;

    [Header("Random Crit chance percent"), Space(5)]
    public float minCritChance;
    public float maxCritChance;
   
    [Header("Skillslot #1"), Space(5)]
    public string skillName1;
    [TextArea(5,10)]
    public string skillDesc1;
    
    [Space(3)]
    public int ammoCost1;
    public int accuracy1;
    public int skillRange1;
    
    [Space(3)]
    public int selfDamageMin1;
    public int enemyDamageMin1;
    public int selfDamageMax1;
    public int enemyDamageMax1;

    [Header("Skillslot #2"), Space(5)]
    public string skillName2;
    [TextArea(5, 10)]
    public string skillDesc2;

    [Space(3)]
    public int ammoCost2;
    public int accuracy2;
    public int skillRange2;

    [Space(3)]
    public int selfDamageMin2;
    public int enemyDamageMin2;
    public int selfDamageMax2;
    public int enemyDamageMax2;

    [Header("Skillslot #3"), Space(5)]
    public string skillName3;
    [TextArea(5, 10)]
    public string skillDesc3;

    [Space(3)]
    public int ammoCost3;
    public int accuracy3;
    public int skillRange3;

    [Space(3)]
    public int selfDamageMin3;
    public int enemyDamageMin3;
    public int selfDamageMax3;
    public int enemyDamageMax3;

    [Header("Skillslot #4"), Space(5)]
    public string skillName4;
    [TextArea(5, 10)]
    public string skillDesc4;

    [Space(3)]
    public int ammoCost4;
    public int accuracy4;
    public int skillRange4;

    [Space(3)]
    public int selfDamageMin4;
    public int enemyDamageMin4;
    public int selfDamageMax4;
    public int enemyDamageMax4;

    /* // This is for the actual weapon script
    public void UseSkill(int skillNum)
    {
        if (activeWeapon)
        {
            switch (skillNum)
            {
                case 1:
                    if (currentAmmo - ammoCost1 >= 0)
                    {
                        currentAmmo -= ammoCost1;
                    }
                    break;
                case 2:
                    if (currentAmmo - ammoCost2 >= 0)
                    {
                        currentAmmo -= ammoCost2;
                    }
                    break;
                case 3:
                    if (currentAmmo - ammoCost2 >= 0)
                    {
                        currentAmmo -= ammoCost3;
                    }
                    break;
                case 4:
                    if (currentAmmo - ammoCost2 >= 0)
                    {
                        currentAmmo -= ammoCost4;
                    }
                    break;
            }
        }
    }

    public void ResetWeapon()
    {
        currentAmmo = clipSize;
        reservedAmmo = reserveSize;
    }

    public void Reload()
    {
        if (reserveSize != 0)
        {
            currentAmmo += clipSize;
            reservedAmmo -= clipSize;
        }
    }
    */

}
