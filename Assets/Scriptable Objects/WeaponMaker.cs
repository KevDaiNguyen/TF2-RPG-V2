using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Weapon", menuName = "Weapon")]
public class WeaponMaker : ScriptableObject
{
    public string weaponName;
    [TextArea(3, 9)]
    public string weaponDescription;
    public Sprite weaponImage;
    public int weaponSlot;

    [Header("If weapon has cooldowns/stored damage"), Space(5)]
    public bool hasMeterBar;
    public bool startFullMeter;
    [Header("Meter Bar Setup"), Space(5)]
    public int maxMeterNum;
    public string meterText;

    [Header("TRUE if weapon can be held out"), Space(5)]
    public bool activeWeapon;

    [Header("Resist/Vulnerabilities when equipped"), Space(5)]
    public float bulletResist;
    public float explosiveResist;
    public float fireResist;
    public float meleeResist;
    public float bulletVulnerability;
    public float explosiveVulnerability;
    public float fireVulnerability;
    public float meleeVulnerability;

    public bool passiveStats;

    [Header("Resist/Vulnerabilities when equipped"), Space(5)]
    public int healthChange;
    public int speedChange;
    public bool equipSpeedBoost;

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
    [Space(5)]
    public Sprite skillLogo1;

    [Space(3)]
    public int ammoCost1;
    public int accuracy1;

    [Space(4)]
    public string actionType1;
    public int skillRange1;
    public bool distanceChoice1;
    public bool secondarySkill1;

    [Space(4)]
    public int selfDamageMin1;
    public int enemyDamageMin1;
    public int selfDamageMax1;
    public int enemyDamageMax1;

    [Header("Skillslot #2"), Space(5)]
    public string skillName2;
    [TextArea(5, 10)]
    public string skillDesc2;
    [Space(5)]
    public Sprite skillLogo2;

    [Space(3)]
    public int ammoCost2;
    public int accuracy2;

    [Space(4)]
    public string actionType2;
    public int skillRange2;
    public bool distanceChoice2;
    public bool secondarySkill2;

    [Space(4)]
    public int selfDamageMin2;
    public int enemyDamageMin2;
    public int selfDamageMax2;
    public int enemyDamageMax2;

    [Header("Skillslot #3"), Space(5)]
    public string skillName3;
    [TextArea(5, 10)]
    public string skillDesc3;
    [Space(5)]
    public Sprite skillLogo3;

    [Space(3)]
    public int ammoCost3;
    public int accuracy3;

    [Space(4)]
    public string actionType3;
    public int skillRange3;
    public bool distanceChoice3;
    public bool secondarySkill3;

    [Space(4)]
    public int selfDamageMin3;
    public int enemyDamageMin3;
    public int selfDamageMax3;
    public int enemyDamageMax3;

    [Header("Skillslot #4"), Space(5)]
    public string skillName4;
    [TextArea(5, 10)]
    public string skillDesc4;
    [Space(5)]
    public Sprite skillLogo4;

    [Space(3)]
    public int ammoCost4;
    public int accuracy4;

    [Space(4)]
    public string actionType4;
    public int skillRange4;
    public bool distanceChoice4;
    public bool secondarySkill4;

    [Space(4)]
    public int selfDamageMin4;
    public int enemyDamageMin4;
    public int selfDamageMax4;
    public int enemyDamageMax4;

    // -------------------------------------------------------
    [Space(10)]
    public string[] allSkillNames = new string[4];
    public string[] allSkillDescs = new string[4];
    public Sprite[] allSkillLogos = new Sprite[4];
    public int[] allAmmoCosts = new int[4];
    public int[] allAccuracies = new int[4];
    public string[] allActionTypes = new string[4];
    public int[] allSkillRanges = new int[4];
    public bool[] allDistanceChoices = new bool[4];
    public bool[] allHasSecondarySkills = new bool[4];
    public int[] allSelfDamageMins = new int[4];
    public int[] allEnemyDamageMins = new int[4];
    public int[] allSelfDamageMaxs = new int[4];
    public int[] allEnemyDamageMaxs = new int[4];

    public void Awake()
    {
        FillStuff();
    }

    void Start()
    {

    }

    public void FillStuff()
    {
        allSkillNames[0] = skillName1;
        allSkillNames[1] = skillName2;
        allSkillNames[2] = skillName3;
        allSkillNames[3] = skillName4;


        allSkillDescs[0] = skillDesc1;
        allSkillDescs[1] = skillDesc2;
        allSkillDescs[2] = skillDesc3;
        allSkillDescs[3] = skillDesc4;


        allSkillLogos[0] = skillLogo1;
        allSkillLogos[1] = skillLogo2;
        allSkillLogos[2] = skillLogo3;
        allSkillLogos[3] = skillLogo4;


        allAmmoCosts[0] = ammoCost1;
        allAmmoCosts[1] = ammoCost2;
        allAmmoCosts[2] = ammoCost3;
        allAmmoCosts[3] = ammoCost4;


        allAccuracies[0] = accuracy1;
        allAccuracies[1] = accuracy2;
        allAccuracies[2] = accuracy3;
        allAccuracies[3] = accuracy4;


        allActionTypes[0] = actionType1;
        allActionTypes[1] = actionType2;
        allActionTypes[2] = actionType3;
        allActionTypes[3] = actionType4;


        allSkillRanges[0] = skillRange1;
        allSkillRanges[1] = skillRange2;
        allSkillRanges[2] = skillRange3;
        allSkillRanges[3] = skillRange4;


        allDistanceChoices[0] = distanceChoice1;
        allDistanceChoices[1] = distanceChoice2;
        allDistanceChoices[2] = distanceChoice3;
        allDistanceChoices[3] = distanceChoice4;


        allHasSecondarySkills[0] = secondarySkill1;
        allHasSecondarySkills[1] = secondarySkill2;
        allHasSecondarySkills[2] = secondarySkill3;
        allHasSecondarySkills[3] = secondarySkill4;


        allSelfDamageMins[0] = selfDamageMin1;
        allSelfDamageMins[1] = selfDamageMin2;
        allSelfDamageMins[2] = selfDamageMin3;
        allSelfDamageMins[3] = selfDamageMin4;

        allEnemyDamageMins[0] = enemyDamageMin1;
        allEnemyDamageMins[1] = enemyDamageMin2;
        allEnemyDamageMins[2] = enemyDamageMin3;
        allEnemyDamageMins[3] = enemyDamageMin4;

        allSelfDamageMaxs[0] = selfDamageMax1;
        allSelfDamageMaxs[1] = selfDamageMax2;
        allSelfDamageMaxs[2] = selfDamageMax3;
        allSelfDamageMaxs[3] = selfDamageMax4;

        allEnemyDamageMaxs[0] = enemyDamageMax1;
        allEnemyDamageMaxs[1] = enemyDamageMax2;
        allEnemyDamageMaxs[2] = enemyDamageMax3;
        allEnemyDamageMaxs[3] = enemyDamageMax4;
    }

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
