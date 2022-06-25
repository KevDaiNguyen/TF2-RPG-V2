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
    [Header("---Which Skill Nums out of 0-3---")]
    public int skillChoice1P;
    public int skillChoice2P;

    public int skillChoice1S;
    public int skillChoice2S;

    public int skillChoice1M;
    public int skillChoice2M;

    public int skillChoice1E;
    public int skillChoice2E;
    [Header("---Current Skill and Logo of equipped Weapon---")]
    public Sprite equippedLogo1;
    public string equippedSkill1;
    public string equippedSkillAcc1;
    public Sprite equippedLogo2;
    public string equippedSkill2;
    public string equippedSkillAcc2;
    [Header("---Current Values of Meterbar---")]
    public int primaryMeterNum;
    public int secondaryMeterNum;
    public int meleeMeterNum;
    public int extraMeterNum;
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
        //className = "Scout";
        //isBlu = false;
        slotSpace = 1;

        defaultHealth = 125;
        defaultSpeed = 133;

        currentHealth = defaultHealth;
        currentSpeed = defaultSpeed;

        bulletResist = 0;
        explosiveResist = 0;
        fireResist = 0;
        meleeResist = 0;

        bulletVulnerability = 0;
        explosiveVulnerability = 0;
        fireVulnerability = 0;
        meleeVulnerability = 0;

        equippedSlotNum = 1;
     
        skillChoice1P = 0;
        skillChoice2P = 1;

        skillChoice1S = 0;
        skillChoice2S = 1;

        skillChoice1M = 0;
        skillChoice2M = 1;

        skillChoice1E = 0;
        skillChoice2E = 1;

        primaryMeterNum = 0;
        secondaryMeterNum = 0;
        meleeMeterNum = 0;
        extraMeterNum = 0;

        primarySlot = WeaponDatabase.scoutPrimaries[0];
        secondarySlot = WeaponDatabase.scoutSecondaries[0];
        meleeSlot = WeaponDatabase.scoutMelees[0];
        extraSlot = WeaponDatabase.spyWatches[0];

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
                    extraSlot = WeaponDatabase.spyWatches[0];
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
                    extraSlot = WeaponDatabase.spyWatches[0];
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
                    extraSlot = WeaponDatabase.spyWatches[0];
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
                    extraSlot = WeaponDatabase.spyWatches[0];
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
                    extraSlot = WeaponDatabase.spyWatches[0];
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
                    extraSlot = WeaponDatabase.spyWatches[0];
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
                    extraSlot = WeaponDatabase.spyWatches[0];
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
                    extraSlot = WeaponDatabase.spyWatches[0];
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

    public void SkillCheck(string equippedWeapon)
    {
        if (skillChoice1P == skillChoice2P)
        {
            skillChoice1P = 0;
            skillChoice2P = 1;
        }
        if (skillChoice1S == skillChoice2S)
        {
            skillChoice1S = 0;
            skillChoice2S = 1;
        }
        if (skillChoice1M == skillChoice2M)
        {
            skillChoice1M = 0;
            skillChoice2M = 1;
        }
        if (skillChoice1E == skillChoice2E)
        {
            skillChoice1E = 0;
            skillChoice2E = 1;
        }

        switch (equippedWeapon)
        {
            case "Primary":
                switch (skillChoice1P)
                {
                    case 0:
                        equippedLogo1 = primarySlot.skillLogo1;
                        equippedSkill1 = primarySlot.skillDesc1;
                        equippedSkillAcc1 = "Accuracy /n" + primarySlot.accuracy1.ToString() + "%";
                        break;
                    case 1:
                        equippedLogo1 = primarySlot.skillLogo2;
                        equippedSkill1 = primarySlot.skillDesc2;
                        equippedSkillAcc1 = "Accuracy /n" + primarySlot.accuracy2.ToString() + "%";
                        break;
                    case 2:
                        equippedLogo1 = primarySlot.skillLogo3;
                        equippedSkill1 = primarySlot.skillDesc3;
                        equippedSkillAcc1 = "Accuracy /n" + primarySlot.accuracy3.ToString() + "%";
                        break;
                    case 3:
                        equippedLogo1 = primarySlot.skillLogo4;
                        equippedSkill1 = primarySlot.skillDesc4;
                        equippedSkillAcc1 = "Accuracy /n" + primarySlot.accuracy4.ToString() + "%";
                        break;
                }

                switch (skillChoice2P)
                {
                    case 0:
                        equippedLogo2 = primarySlot.skillLogo1;
                        equippedSkill2 = primarySlot.skillDesc1;
                        equippedSkillAcc2 = "Accuracy /n" + primarySlot.accuracy1.ToString() + "%";
                        break;
                    case 1:
                        equippedLogo2 = primarySlot.skillLogo2;
                        equippedSkill2 = primarySlot.skillDesc2;
                        equippedSkillAcc2 = "Accuracy /n" + primarySlot.accuracy2.ToString() + "%";
                        break;
                    case 2:
                        equippedLogo2 = primarySlot.skillLogo3;
                        equippedSkill2 = primarySlot.skillDesc3;
                        equippedSkillAcc2 = "Accuracy /n" + primarySlot.accuracy3.ToString() + "%";
                        break;
                    case 3:
                        equippedLogo2 = primarySlot.skillLogo4;
                        equippedSkill2 = primarySlot.skillDesc4;
                        equippedSkillAcc2 = "Accuracy /n" + primarySlot.accuracy4.ToString() + "%";
                        break;
                }
                break;
            case "Secondary":
                switch (skillChoice1S)
                {
                    case 0:
                        equippedLogo1 = secondarySlot.skillLogo1;
                        equippedSkill1 = secondarySlot.skillDesc1;
                        equippedSkillAcc1 = "Accuracy /n" + secondarySlot.accuracy1.ToString() + "%";
                        break;
                    case 1:
                        equippedLogo1 = secondarySlot.skillLogo2;
                        equippedSkill1 = secondarySlot.skillDesc2;
                        equippedSkillAcc1 = "Accuracy /n" + secondarySlot.accuracy2.ToString() + "%";
                        break;
                    case 2:
                        equippedLogo1 = secondarySlot.skillLogo3;
                        equippedSkill1 = secondarySlot.skillDesc3;
                        equippedSkillAcc1 = "Accuracy /n" + secondarySlot.accuracy3.ToString() + "%";
                        break;
                    case 3:
                        equippedLogo1 = secondarySlot.skillLogo4;
                        equippedSkill1 = secondarySlot.skillDesc4;
                        equippedSkillAcc1 = "Accuracy /n" + secondarySlot.accuracy4.ToString() + "%";
                        break;
                }

                switch (skillChoice2S)
                {
                    case 0:
                        equippedLogo2 = secondarySlot.skillLogo1;
                        equippedSkill2 = secondarySlot.skillDesc1;
                        equippedSkillAcc2 = "Accuracy /n" + secondarySlot.accuracy1.ToString() + "%";
                        break;
                    case 1:
                        equippedLogo2 = secondarySlot.skillLogo2;
                        equippedSkill2 = secondarySlot.skillDesc2;
                        equippedSkillAcc2 = "Accuracy /n" + secondarySlot.accuracy2.ToString() + "%";
                        break;
                    case 2:
                        equippedLogo2 = secondarySlot.skillLogo3;
                        equippedSkill2 = secondarySlot.skillDesc3;
                        equippedSkillAcc2 = "Accuracy /n" + secondarySlot.accuracy3.ToString() + "%";
                        break;
                    case 3:
                        equippedLogo2 = secondarySlot.skillLogo4;
                        equippedSkill2 = secondarySlot.skillDesc4;
                        equippedSkillAcc2 = "Accuracy /n" + secondarySlot.accuracy4.ToString() + "%";
                        break;
                }
                break;
            case "Melee":
                switch (skillChoice1M)
                {
                    case 0:
                        equippedLogo1 = meleeSlot.skillLogo1;
                        equippedSkill1 = meleeSlot.skillDesc1;
                        equippedSkillAcc1 = "Accuracy /n" + meleeSlot.accuracy1.ToString() + "%";
                        break;
                    case 1:
                        equippedLogo1 = meleeSlot.skillLogo2;
                        equippedSkill1 = meleeSlot.skillDesc2;
                        equippedSkillAcc1 = "Accuracy /n" + meleeSlot.accuracy2.ToString() + "%";
                        break;
                    case 2:
                        equippedLogo1 = meleeSlot.skillLogo3;
                        equippedSkill1 = meleeSlot.skillDesc3;
                        equippedSkillAcc1 = "Accuracy /n" + meleeSlot.accuracy3.ToString() + "%";
                        break;
                    case 3:
                        equippedLogo1 = meleeSlot.skillLogo4;
                        equippedSkill1 = meleeSlot.skillDesc4;
                        equippedSkillAcc1 = "Accuracy /n" + meleeSlot.accuracy4.ToString() + "%";
                        break;
                }

                switch (skillChoice2M)
                {
                    case 0:
                        equippedLogo2 = meleeSlot.skillLogo1;
                        equippedSkill2 = meleeSlot.skillDesc1;
                        equippedSkillAcc2 = "Accuracy /n" + meleeSlot.accuracy1.ToString() + "%";
                        break;
                    case 1:
                        equippedLogo2 = meleeSlot.skillLogo2;
                        equippedSkill2 = meleeSlot.skillDesc2;
                        equippedSkillAcc2 = "Accuracy /n" + meleeSlot.accuracy2.ToString() + "%";
                        break;
                    case 2:
                        equippedLogo2 = meleeSlot.skillLogo3;
                        equippedSkill2 = meleeSlot.skillDesc3;
                        equippedSkillAcc2 = "Accuracy /n" + meleeSlot.accuracy3.ToString() + "%";
                        break;
                    case 3:
                        equippedLogo2 = meleeSlot.skillLogo4;
                        equippedSkill2 = meleeSlot.skillDesc4;
                        equippedSkillAcc2 = "Accuracy /n" + meleeSlot.accuracy4.ToString() + "%";
                        break;
                }
                break;
            case "Extra":
                switch (skillChoice1E)
                {
                    case 0:
                        equippedLogo1 = extraSlot.skillLogo1;
                        equippedSkill1 = extraSlot.skillDesc1;
                        equippedSkillAcc1 = "Accuracy /n" + extraSlot.accuracy1.ToString() + "%";
                        break;
                    case 1:
                        equippedLogo1 = extraSlot.skillLogo2;
                        equippedSkill1 = extraSlot.skillDesc2;
                        equippedSkillAcc1 = "Accuracy /n" + extraSlot.accuracy2.ToString() + "%";
                        break;
                    case 2:
                        equippedLogo1 = extraSlot.skillLogo3;
                        equippedSkill1 = extraSlot.skillDesc3;
                        equippedSkillAcc1 = "Accuracy /n" + extraSlot.accuracy3.ToString() + "%";
                        break;
                    case 3:
                        equippedLogo1 = extraSlot.skillLogo4;
                        equippedSkill1 = extraSlot.skillDesc4;
                        equippedSkillAcc1 = "Accuracy /n" + extraSlot.accuracy4.ToString() + "%";
                        break;
                }

                switch (skillChoice2E)
                {
                    case 0:
                        equippedLogo2 = extraSlot.skillLogo1;
                        equippedSkill2 = extraSlot.skillDesc1;
                        equippedSkillAcc2 = "Accuracy /n" + extraSlot.accuracy1.ToString() + "%";
                        break;
                    case 1:
                        equippedLogo2 = extraSlot.skillLogo2;
                        equippedSkill2 = extraSlot.skillDesc2;
                        equippedSkillAcc2 = "Accuracy /n" + extraSlot.accuracy2.ToString() + "%";
                        break;
                    case 2:
                        equippedLogo2 = extraSlot.skillLogo3;
                        equippedSkill2 = extraSlot.skillDesc3;
                        equippedSkillAcc2 = "Accuracy /n" + extraSlot.accuracy3.ToString() + "%";
                        break;
                    case 3:
                        equippedLogo2 = extraSlot.skillLogo4;
                        equippedSkill2 = extraSlot.skillDesc4;
                        equippedSkillAcc2 = "Accuracy /n" + extraSlot.accuracy4.ToString() + "%";
                        break;
                }
                break;
        }
    }


    public void IncreaseMeterBar(int increaseAmount)
    {
        switch (equippedSlotNum)
        {
            case 1:
                if (primaryMeterNum + increaseAmount >= primarySlot.maxMeterNum)
                {
                    primaryMeterNum = primarySlot.maxMeterNum;
                }
                else if (primaryMeterNum + increaseAmount > 0)
                {
                    primaryMeterNum += increaseAmount;
                }
                break;
            case 2:
                if (secondaryMeterNum + increaseAmount >= secondarySlot.maxMeterNum)
                {
                    secondaryMeterNum = secondarySlot.maxMeterNum;
                }
                else if (secondaryMeterNum + increaseAmount > 0)
                {
                    secondaryMeterNum += increaseAmount;
                }
                break;
            case 3:
                if (meleeMeterNum + increaseAmount >= meleeSlot.maxMeterNum)
                {
                    meleeMeterNum = meleeSlot.maxMeterNum;
                }
                else if (meleeMeterNum + increaseAmount > 0)
                {
                    meleeMeterNum += increaseAmount;
                }
                break;
            case 4:
                if (extraMeterNum + increaseAmount >= extraSlot.maxMeterNum)
                {
                    extraMeterNum = extraSlot.maxMeterNum;
                }
                else if (extraMeterNum + increaseAmount > 0)
                {
                    extraMeterNum += increaseAmount;
                }
                break;
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
                    bulletResist = (1 - resistIncrease);
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
                    explosiveResist = (1 - resistIncrease);
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
                    fireResist = (1 - resistIncrease);
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
                    meleeResist = (1 - resistIncrease);
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
                    bulletVulnerability = (1 + vulerabilityIncrease);
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
                    explosiveVulnerability = (1 + vulerabilityIncrease);
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
                    fireVulnerability = (1 + vulerabilityIncrease);
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
                    meleeVulnerability = (1 + vulerabilityIncrease);
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
