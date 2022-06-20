using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClassData : MonoBehaviour
{
    [Header("---Class Identifier---")]
    public string className;
    [Header("---Team Decider---")]
    public bool isBlu;
    [Header("---Variable Health---")]
    private int defaultHealth;
    public int currentHealth;
    [Header("---Variable Speed---")]
    private int defaultSpeed;
    public int currentSpeed;
    [Header("---Total slots should be <= 4---")]
    public int slotSpace;
    [Header("---Damage Calculations---")]
    public float bulletResist;
    public float explosiveResist;
    public float fireResist;
    public float meleeResist;
    public float bulletVulnerability;
    public float explosiveVulnerability;
    public float fireVulnerability;
    public float meleeVulnerability;
    [Header("---Basic Class Sprite---")]
    public Sprite classSprite;
    [Header("---Active when changing classes---")]
    public bool switchedClass;
    [Header("---Only active on death---")]
    public bool classDead;
    [Header("---What is currently held---")]
    public int equippedSlotNum;
    [Header("---Holds all weapons in slots---")]
    public int skillChoice1;
    public int skillChoice2;
    [Header("---Current Skill and Logo of equipped Weapon---")]
    public Sprite equippedLogo1;
    public string equippedSkill1;
    public Sprite equippedLogo2;
    public string equippedSkill2;
    [Header("---If extra slot is needed---")]
    public bool showExtraSlot;
    [Header("---Holds all weapons in slots---")]
    public WeaponMaker primarySlot;
    public WeaponMaker secondarySlot;
    public WeaponMaker meleeSlot;
    public WeaponMaker extraSlot;
    [Header("---Class Sprites---")]
    public ClassSprites spriteDatabase;

    // Start is called before the first frame update
    void Start()
    {
        className = "Scout";
        isBlu = false;
        slotSpace = 1;

        bulletResist = 0;
        explosiveResist = 0;
        fireResist = 0;
        meleeResist = 0;

        bulletVulnerability = 0;
        explosiveVulnerability = 0;
        fireVulnerability = 0;
        meleeVulnerability = 0;

        equippedSlotNum = 1;

        skillChoice1 = 1;
        skillChoice2 = 2;

        showExtraSlot = false;

        classDead = false;

        switchedClass = false;
    }

    // Update is called once per frame
    void Update()
    {
        ClassCheck();
        switch (equippedSlotNum)
        {
            case 1:
                SkillCheck("Primary");
                break;
            case 2:
                SkillCheck("Secondary");
                break;
            case 3:
                SkillCheck("Melee");
                break;
            case 4:
                SkillCheck("Extra");
                break;
        }
    }

    public void SkillCheck(string equippedWeapon)
    {
        if (skillChoice1 == skillChoice2)
        {
            skillChoice1 = 1;
            skillChoice2 = 2;
        }

        switch (equippedWeapon)
        {
            case "Primary":
                switch (skillChoice1)
                {
                    case 1:
                        equippedLogo1 = primarySlot.skillLogo1;
                        equippedSkill1 = primarySlot.skillDesc1;
                        break;
                    case 2:
                        equippedLogo1 = primarySlot.skillLogo2;
                        equippedSkill1 = primarySlot.skillDesc2;
                        break;
                    case 3:
                        equippedLogo1 = primarySlot.skillLogo3;
                        equippedSkill1 = primarySlot.skillDesc3;
                        break;
                    case 4:
                        equippedLogo1 = primarySlot.skillLogo4;
                        equippedSkill1 = primarySlot.skillDesc4;
                        break;
                }

                switch (skillChoice2)
                {
                    case 1:
                        equippedLogo2 = primarySlot.skillLogo1;
                        equippedSkill2 = primarySlot.skillDesc1;
                        break;
                    case 2:
                        equippedLogo2 = primarySlot.skillLogo2;
                        equippedSkill2 = primarySlot.skillDesc2;
                        break;
                    case 3:
                        equippedLogo2 = primarySlot.skillLogo3;
                        equippedSkill2 = primarySlot.skillDesc3;
                        break;
                    case 4:
                        equippedLogo2 = primarySlot.skillLogo4;
                        equippedSkill2 = primarySlot.skillDesc4;
                        break;
                }
                break;
            case "Secondary":
                switch (skillChoice1)
                {
                    case 1:
                        equippedLogo1 = secondarySlot.skillLogo1;
                        equippedSkill1 = secondarySlot.skillDesc1;
                        break;
                    case 2:
                        equippedLogo1 = secondarySlot.skillLogo2;
                        equippedSkill1 = secondarySlot.skillDesc2;
                        break;
                    case 3:
                        equippedLogo1 = secondarySlot.skillLogo3;
                        equippedSkill1 = secondarySlot.skillDesc3;
                        break;
                    case 4:
                        equippedLogo1 = secondarySlot.skillLogo4;
                        equippedSkill1 = secondarySlot.skillDesc4;
                        break;
                }

                switch (skillChoice2)
                {
                    case 1:
                        equippedLogo2 = secondarySlot.skillLogo1;
                        equippedSkill2 = secondarySlot.skillDesc1;
                        break;
                    case 2:
                        equippedLogo2 = secondarySlot.skillLogo2;
                        equippedSkill2 = secondarySlot.skillDesc2;
                        break;
                    case 3:
                        equippedLogo2 = secondarySlot.skillLogo3;
                        equippedSkill2 = secondarySlot.skillDesc3;
                        break;
                    case 4:
                        equippedLogo2 = secondarySlot.skillLogo4;
                        equippedSkill2 = secondarySlot.skillDesc4;
                        break;
                }
                break;
            case "Melee":
                switch (skillChoice1)
                {
                    case 1:
                        equippedLogo1 = meleeSlot.skillLogo1;
                        equippedSkill1 = meleeSlot.skillDesc1;
                        break;
                    case 2:
                        equippedLogo1 = meleeSlot.skillLogo2;
                        equippedSkill1 = meleeSlot.skillDesc2;
                        break;
                    case 3:
                        equippedLogo1 = meleeSlot.skillLogo3;
                        equippedSkill1 = meleeSlot.skillDesc3;
                        break;
                    case 4:
                        equippedLogo1 = meleeSlot.skillLogo4;
                        equippedSkill1 = meleeSlot.skillDesc4;
                        break;
                }

                switch (skillChoice2)
                {
                    case 1:
                        equippedLogo2 = meleeSlot.skillLogo1;
                        equippedSkill2 = meleeSlot.skillDesc1;
                        break;
                    case 2:
                        equippedLogo2 = meleeSlot.skillLogo2;
                        equippedSkill2 = meleeSlot.skillDesc2;
                        break;
                    case 3:
                        equippedLogo2 = meleeSlot.skillLogo3;
                        equippedSkill2 = meleeSlot.skillDesc3;
                        break;
                    case 4:
                        equippedLogo2 = meleeSlot.skillLogo4;
                        equippedSkill2 = meleeSlot.skillDesc4;
                        break;
                }
                break;
            case "Extra":
                switch (skillChoice1)
                {
                    case 1:
                        equippedLogo1 = extraSlot.skillLogo1;
                        equippedSkill1 = extraSlot.skillDesc1;
                        break;
                    case 2:
                        equippedLogo1 = extraSlot.skillLogo2;
                        equippedSkill1 = extraSlot.skillDesc2;
                        break;
                    case 3:
                        equippedLogo1 = extraSlot.skillLogo3;
                        equippedSkill1 = extraSlot.skillDesc3;
                        break;
                    case 4:
                        equippedLogo1 = extraSlot.skillLogo4;
                        equippedSkill1 = extraSlot.skillDesc4;
                        break;
                }

                switch (skillChoice2)
                {
                    case 1:
                        equippedLogo2 = extraSlot.skillLogo1;
                        equippedSkill2 = extraSlot.skillDesc1;
                        break;
                    case 2:
                        equippedLogo2 = extraSlot.skillLogo2;
                        equippedSkill2 = extraSlot.skillDesc2;
                        break;
                    case 3:
                        equippedLogo2 = extraSlot.skillLogo3;
                        equippedSkill2 = extraSlot.skillDesc3;
                        break;
                    case 4:
                        equippedLogo2 = extraSlot.skillLogo4;
                        equippedSkill2 = extraSlot.skillDesc4;
                        break;
                }
                break;
        }
    }

    public void ClassCheck()
    {
        if (!switchedClass)
        {
            switch (className)
            {
                case "Scout":
                    defaultHealth = 125;
                    defaultSpeed = 133;

                    if (!isBlu)
                    {
                        classSprite = spriteDatabase.redScouts[0];
                    }
                    else
                    {
                        classSprite = spriteDatabase.blueScouts[0];
                    }

                    primarySlot = WeaponDatabase.scoutPrimaries[Random.Range(0, WeaponDatabase.scoutPrimaries.Length)];
                    secondarySlot = WeaponDatabase.scoutSecondaries[Random.Range(0, WeaponDatabase.scoutSecondaries.Length)];
                    meleeSlot = WeaponDatabase.scoutMelees[Random.Range(0, WeaponDatabase.scoutMelees.Length)];
                    break;
                case "Soldier":
                    defaultHealth = 200;
                    defaultSpeed = 80;

                    if (!isBlu)
                    {
                        classSprite = spriteDatabase.redSoldier[0];
                    }
                    else
                    {
                        classSprite = spriteDatabase.blueSoldier[0];
                    }

                    primarySlot = WeaponDatabase.soldierPrimaries[Random.Range(0, WeaponDatabase.soldierPrimaries.Length)];
                    secondarySlot = WeaponDatabase.soldierSecondaries[Random.Range(0, WeaponDatabase.soldierSecondaries.Length)];
                    meleeSlot = WeaponDatabase.soldierMelees[Random.Range(0, WeaponDatabase.soldierMelees.Length)];
                    break;
                case "Pyro":
                    defaultHealth = 175;
                    defaultSpeed = 100;

                    if (!isBlu)
                    {
                        classSprite = spriteDatabase.redPyro[0];
                    }
                    else
                    {
                        classSprite = spriteDatabase.bluePyro[0];
                    }

                    primarySlot = WeaponDatabase.pyroPrimaries[Random.Range(0, WeaponDatabase.pyroPrimaries.Length)];
                    secondarySlot = WeaponDatabase.pyroSecondaries[Random.Range(0, WeaponDatabase.pyroSecondaries.Length)];
                    meleeSlot = WeaponDatabase.pyroMelees[Random.Range(0, WeaponDatabase.pyroMelees.Length)];
                    break;
                case "Demoman":
                    defaultHealth = 175;
                    defaultSpeed = 93;

                    if (!isBlu)
                    {
                        classSprite = spriteDatabase.redDemo[0];
                    }
                    else
                    {
                        classSprite = spriteDatabase.blueDemo[0];
                    }

                    primarySlot = WeaponDatabase.demomanPrimaries[Random.Range(0, WeaponDatabase.demomanPrimaries.Length)];
                    secondarySlot = WeaponDatabase.demomanSecondaries[Random.Range(0, WeaponDatabase.demomanSecondaries.Length)];
                    meleeSlot = WeaponDatabase.demomanMelees[Random.Range(0, WeaponDatabase.demomanMelees.Length)];
                    break;
                case "Heavy":
                    defaultHealth = 300;
                    defaultSpeed = 77;

                    if (!isBlu)
                    {
                        classSprite = spriteDatabase.redHeavy[0];
                    }
                    else
                    {
                        classSprite = spriteDatabase.blueHeavy[0];
                    }

                    primarySlot = WeaponDatabase.heavyPrimaries[Random.Range(0, WeaponDatabase.heavyPrimaries.Length)];
                    secondarySlot = WeaponDatabase.heavySecondaries[Random.Range(0, WeaponDatabase.heavySecondaries.Length)];
                    meleeSlot = WeaponDatabase.heavyMelees[Random.Range(0, WeaponDatabase.heavyMelees.Length)];
                    break;
                case "Engineer":
                    defaultHealth = 125;
                    defaultSpeed = 100;
                    slotSpace = 2;

                    if (!isBlu)
                    {
                        classSprite = spriteDatabase.redEngi[0];
                    }
                    else
                    {
                        classSprite = spriteDatabase.blueEngi[0];
                    }

                    primarySlot = WeaponDatabase.engineerPrimaries[Random.Range(0, WeaponDatabase.engineerPrimaries.Length)];
                    secondarySlot = WeaponDatabase.engineerSecondaries[Random.Range(0, WeaponDatabase.engineerSecondaries.Length)];
                    meleeSlot = WeaponDatabase.engineerMelees[Random.Range(0, WeaponDatabase.engineerMelees.Length)];
                    break;
                case "Medic":
                    defaultHealth = 150;
                    defaultSpeed = 107;

                    if (!isBlu)
                    {
                        classSprite = spriteDatabase.redMedic[0];
                    }
                    else
                    {
                        classSprite = spriteDatabase.blueMedic[0];
                    }

                    primarySlot = WeaponDatabase.medicPrimaries[Random.Range(0, WeaponDatabase.medicPrimaries.Length)];
                    secondarySlot = WeaponDatabase.medicSecondaries[Random.Range(0, WeaponDatabase.medicSecondaries.Length)];
                    meleeSlot = WeaponDatabase.medicMelees[Random.Range(0, WeaponDatabase.medicMelees.Length)];
                    break;
                case "Sniper":
                    defaultHealth = 125;
                    defaultSpeed = 100;

                    if (!isBlu)
                    {
                        classSprite = spriteDatabase.redSniper[0];
                    }
                    else
                    {
                        classSprite = spriteDatabase.blueSniper[0];
                    }

                    primarySlot = WeaponDatabase.sniperPrimaries[Random.Range(0, WeaponDatabase.sniperPrimaries.Length)];
                    secondarySlot = WeaponDatabase.sniperSecondaries[Random.Range(0, WeaponDatabase.sniperSecondaries.Length)];
                    meleeSlot = WeaponDatabase.sniperMelees[Random.Range(0, WeaponDatabase.sniperMelees.Length)];
                    break;
                case "Spy":
                    defaultHealth = 125;
                    defaultSpeed = 107;

                    if (!isBlu)
                    {
                        classSprite = spriteDatabase.redSpy[0];
                    }
                    else
                    {
                        classSprite = spriteDatabase.blueSpy[0];
                    }

                    showExtraSlot = true;

                    primarySlot = WeaponDatabase.spyPrimaries[Random.Range(0, WeaponDatabase.spyPrimaries.Length)];
                    secondarySlot = WeaponDatabase.spySecondaries[Random.Range(0, WeaponDatabase.spySecondaries.Length)];
                    meleeSlot = WeaponDatabase.spyMelees[Random.Range(0, WeaponDatabase.spyMelees.Length)];
                    extraSlot = WeaponDatabase.spyWatches[Random.Range(0, WeaponDatabase.spyWatches.Length)];
                    break;
            }

            currentHealth = defaultHealth;
            currentSpeed = defaultSpeed;

            switchedClass = true;
        }
    }

    public void SetSpeed(int speedChangeNum)
    {
        currentSpeed = speedChangeNum;
    }

    public void TakeHealing(int healthChangeNum, bool fromMedigun, bool isQuickFix)
    {
        if (healthChangeNum < 0)
        {
            healthChangeNum *= -1;
        }

        if ((currentHealth + healthChangeNum) > defaultHealth && !fromMedigun)
        { 
            currentHealth = defaultHealth;
        }
        else if ((currentHealth + healthChangeNum) > defaultHealth && fromMedigun)
        {
            if (currentHealth + healthChangeNum >= OverhealCalculate(defaultHealth, isQuickFix))
            {
                currentHealth = OverhealCalculate(defaultHealth, isQuickFix);
            }
            else
            {
                currentHealth += healthChangeNum;
            }
        }
        else
        {
            currentHealth += healthChangeNum;
        }
    }

    public void TakeDamage(float damageNum, string damageType, bool miniCrit, bool Crit)
    {
        float critDamage = 0;
        float resistDamage = 0;

        if (miniCrit && Crit)
        {
            critDamage = damageNum * 3;
        }
        else if (miniCrit && !Crit)
        {
            critDamage = damageNum * 1.35f;
        }
        else if (!miniCrit && Crit) 
        {
            critDamage = damageNum * 3;
        }
        else if (!miniCrit && !Crit) 
        {
            critDamage = 0;
        }

        switch (damageType)
        {
            case "Bullet":
                resistDamage = damageNum * (bulletResist * bulletVulnerability);
                break;
            case "Explosive":
                resistDamage = damageNum * (explosiveResist * explosiveVulnerability);
                break;
            case "Fire":
                resistDamage = damageNum * (fireResist * fireVulnerability);
                break;
            case "Melee":
                resistDamage = damageNum * (meleeResist * meleeVulnerability);
                break;
        }

        Mathf.RoundToInt(critDamage);
        Mathf.RoundToInt(resistDamage);

        if (currentHealth - ((int)critDamage + (int)(resistDamage)) <= 0)
        {
            currentHealth = 0;
            classDead = true;
        }
        else
        {
            currentHealth -= ((int)critDamage + (int)(resistDamage));
        }
    }

    public void ChangeResist(float resistIncrease, string resistType, bool shouldIncrease)
    {
        switch (resistType)
        {
            case "Bullet":
                if (bulletResist != 0 && shouldIncrease)
                {
                    bulletResist *= (1 - resistIncrease);
                }
                else if (bulletResist == 0 && shouldIncrease)
                {
                    bulletResist += (1 - resistIncrease);
                }
                else if (bulletResist != 0 && !shouldIncrease)
                {
                    bulletResist /= (1 - resistIncrease);
                }
                else if (bulletResist == 0 && !shouldIncrease)
                {
                    bulletResist = 0;
                }
                break;
            case "Explosive":
                if (explosiveResist != 0 && shouldIncrease)
                {
                    explosiveResist *= (1 - resistIncrease);
                }
                else if (explosiveResist == 0 && shouldIncrease) 
                {
                    explosiveResist += (1 - resistIncrease);
                }
                else if (explosiveResist != 0 && !shouldIncrease)
                {
                    explosiveResist /= (1 - resistIncrease);
                }
                else if (explosiveResist == 0 && !shouldIncrease)
                {
                    explosiveResist = 0;
                }
                break;
            case "Fire":
                if (fireResist != 0 && shouldIncrease)
                {
                    fireResist *= (1 - resistIncrease);
                }
                else if (fireResist == 0 && shouldIncrease)
                {
                    fireResist += (1 - resistIncrease);
                }
                else if (fireResist != 0 && !shouldIncrease)
                {
                    fireResist /= (1 - resistIncrease);
                }
                else if (fireResist == 0 && !shouldIncrease)
                {
                    fireResist = 0;
                }
                break;
            case "Melee":
                if (meleeResist != 0 && shouldIncrease)
                {
                    meleeResist *= (1 - resistIncrease);
                }
                else if (meleeResist == 0 && shouldIncrease)
                {
                    meleeResist += (1 - resistIncrease);
                }
                else if (meleeResist != 0 && !shouldIncrease)
                {
                    meleeResist /= (1 - resistIncrease);
                }
                else if (meleeResist == 0 && !shouldIncrease)
                {
                    meleeResist = 0;
                }
                break;
        }
    }

    public void ChangeVulnerability(float vulerabilityIncrease, string resistType, bool shouldIncrease)
    {
        switch (resistType)
        {
            case "Bullet":
                if (bulletVulnerability != 0 && shouldIncrease)
                {
                    bulletVulnerability *= (1 + vulerabilityIncrease);
                }
                else if (bulletVulnerability == 0 && shouldIncrease)
                {
                    bulletVulnerability += (1 + vulerabilityIncrease);
                }
                else if (bulletVulnerability != 0 && !shouldIncrease)
                {
                    bulletVulnerability /= (1 + vulerabilityIncrease);
                }
                else if (bulletVulnerability == 0 && !shouldIncrease)
                {
                    bulletVulnerability = 0;
                }
                break;
            case "Explosive":
                if (explosiveVulnerability != 0 && shouldIncrease)
                {
                    explosiveVulnerability *= (1 + vulerabilityIncrease);
                }
                else if (explosiveVulnerability == 0 && shouldIncrease)
                {
                    explosiveVulnerability += (1 + vulerabilityIncrease);
                }
                else if (explosiveVulnerability != 0 && !shouldIncrease)
                {
                    explosiveVulnerability /= (1 + vulerabilityIncrease);
                }
                else if (explosiveVulnerability == 0 && !shouldIncrease)
                {
                    explosiveVulnerability = 0;
                }
                break;
            case "Fire":
                if (fireVulnerability != 0 && shouldIncrease)
                {
                    fireVulnerability *= (1 + vulerabilityIncrease);
                }
                else if (fireVulnerability == 0 && shouldIncrease)
                {
                    fireVulnerability += (1 + vulerabilityIncrease);
                }
                else if (fireVulnerability != 0 && !shouldIncrease)
                {
                    fireVulnerability /= (1 + vulerabilityIncrease);
                }
                else if (fireVulnerability == 0 && !shouldIncrease)
                {
                    fireVulnerability = 0;
                }
                break;
            case "Melee":
                if (meleeVulnerability != 0 && shouldIncrease)
                {
                    meleeVulnerability *= (1 + vulerabilityIncrease);
                }
                else if (meleeVulnerability == 0 && shouldIncrease)
                {
                    meleeVulnerability += (1 + vulerabilityIncrease);
                }
                else if (meleeVulnerability != 0 && !shouldIncrease)
                {
                    meleeVulnerability /= (1 + vulerabilityIncrease);
                }
                else if (meleeVulnerability == 0 && !shouldIncrease)
                {
                    meleeVulnerability = 0;
                }
                break;
        }
    }


    public void RespawnClass()
    {
        currentHealth = defaultHealth;
        currentSpeed = defaultSpeed;
        classDead = false;
    }

    public int OverhealCalculate(int maxHealth, bool isQuickFix)
    {
        int maxOverheal = 0;

        if (!isQuickFix)
        {
            maxOverheal = (int)System.Math.Round((maxHealth * 1.5f) / 5);
        }
        else
        {
            maxOverheal = (int)System.Math.Round((maxHealth * 1.25f) / 5);
        }

        return maxOverheal;
    }
}
