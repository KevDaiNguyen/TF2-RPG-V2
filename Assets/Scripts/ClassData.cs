using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClassData : MonoBehaviour
{
    [Header("---Class Identifier---")]
    public string className;
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
    public bool switchedClass = false;
    [Header("---Only active on death---")]
    public bool classDead;
    [Header("---Holds all weapons in slots---")]
    public WeaponMaker primarySlot;
    public WeaponMaker secondarySlot;
    public WeaponMaker meleeSlot;
    public WeaponMaker extraSlot;

    // Start is called before the first frame update
    void Start()
    {
        className = "Spy";
        slotSpace = 1;
        bulletResist = 0;
        explosiveResist = 0;
        fireResist = 0;
        meleeResist = 0;
        primarySlot = WeaponDatabase.spyPrimaries[0];
        secondarySlot = WeaponDatabase.spySecondaries[0];
        meleeSlot = WeaponDatabase.spyMelees[0];
        extraSlot = WeaponDatabase.spyWatches[0];
        classDead = false;
    }

    // Update is called once per frame
    void Update()
    {
        ClassCheck();
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

                    primarySlot = WeaponDatabase.scoutPrimaries[Random.Range(0, WeaponDatabase.scoutPrimaries.Length)];
                    secondarySlot = WeaponDatabase.scoutSecondaries[Random.Range(0, WeaponDatabase.scoutSecondaries.Length)];
                    meleeSlot = WeaponDatabase.scoutMelees[Random.Range(0, WeaponDatabase.scoutMelees.Length)];
                    break;
                case "Soldier":
                    defaultHealth = 200;
                    defaultSpeed = 80;

                    primarySlot = WeaponDatabase.soldierPrimaries[Random.Range(0, WeaponDatabase.soldierPrimaries.Length)];
                    secondarySlot = WeaponDatabase.soldierSecondaries[Random.Range(0, WeaponDatabase.soldierSecondaries.Length)];
                    meleeSlot = WeaponDatabase.soldierMelees[Random.Range(0, WeaponDatabase.soldierMelees.Length)];
                    break;
                case "Pyro":
                    defaultHealth = 175;
                    defaultSpeed = 100;

                    primarySlot = WeaponDatabase.pyroPrimaries[Random.Range(0, WeaponDatabase.pyroPrimaries.Length)];
                    secondarySlot = WeaponDatabase.pyroSecondaries[Random.Range(0, WeaponDatabase.pyroSecondaries.Length)];
                    meleeSlot = WeaponDatabase.pyroMelees[Random.Range(0, WeaponDatabase.pyroMelees.Length)];
                    break;
                case "Demoman":
                    defaultHealth = 175;
                    defaultSpeed = 93;

                    primarySlot = WeaponDatabase.demomanPrimaries[Random.Range(0, WeaponDatabase.demomanPrimaries.Length)];
                    secondarySlot = WeaponDatabase.demomanSecondaries[Random.Range(0, WeaponDatabase.demomanSecondaries.Length)];
                    meleeSlot = WeaponDatabase.demomanMelees[Random.Range(0, WeaponDatabase.demomanMelees.Length)];
                    break;
                case "Heavy":
                    defaultHealth = 300;
                    defaultSpeed = 77;

                    primarySlot = WeaponDatabase.heavyPrimaries[Random.Range(0, WeaponDatabase.heavyPrimaries.Length)];
                    secondarySlot = WeaponDatabase.heavySecondaries[Random.Range(0, WeaponDatabase.heavySecondaries.Length)];
                    meleeSlot = WeaponDatabase.heavyMelees[Random.Range(0, WeaponDatabase.heavyMelees.Length)];
                    break;
                case "Engineer":
                    defaultHealth = 125;
                    defaultSpeed = 100;
                    slotSpace = 2;

                    primarySlot = WeaponDatabase.engineerPrimaries[Random.Range(0, WeaponDatabase.engineerPrimaries.Length)];
                    secondarySlot = WeaponDatabase.engineerSecondaries[Random.Range(0, WeaponDatabase.engineerSecondaries.Length)];
                    meleeSlot = WeaponDatabase.engineerMelees[Random.Range(0, WeaponDatabase.engineerMelees.Length)];
                    break;
                case "Medic":
                    defaultHealth = 150;
                    defaultSpeed = 107;

                    primarySlot = WeaponDatabase.medicPrimaries[Random.Range(0, WeaponDatabase.medicPrimaries.Length)];
                    secondarySlot = WeaponDatabase.medicSecondaries[Random.Range(0, WeaponDatabase.medicSecondaries.Length)];
                    meleeSlot = WeaponDatabase.medicMelees[Random.Range(0, WeaponDatabase.medicMelees.Length)];
                    break;
                case "Sniper":
                    defaultHealth = 125;
                    defaultSpeed = 100;

                    primarySlot = WeaponDatabase.sniperPrimaries[Random.Range(0, WeaponDatabase.sniperPrimaries.Length)];
                    secondarySlot = WeaponDatabase.sniperSecondaries[Random.Range(0, WeaponDatabase.sniperSecondaries.Length)];
                    meleeSlot = WeaponDatabase.sniperMelees[Random.Range(0, WeaponDatabase.sniperMelees.Length)];
                    break;
                case "Spy":
                    defaultHealth = 125;
                    defaultSpeed = 107;

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
