using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponDatabase : MonoBehaviour
{
    public WeaponLists listInstance;
    
    [Header("All weapons that can be picked up"), Space(5)]
    public static WeaponMaker[] nonStockWeapons = new WeaponMaker[136];

    public static WeaponMaker[] scoutPrimaries = new WeaponMaker[6];
    public static WeaponMaker[] scoutSecondaries = new WeaponMaker[7];
    public static WeaponMaker[] scoutMelees = new WeaponMaker[8];

    public static WeaponMaker[] soldierPrimaries = new WeaponMaker[7];
    public static WeaponMaker[] soldierSecondaries = new WeaponMaker[10];
    public static WeaponMaker[] soldierMelees = new WeaponMaker[7];

    public static WeaponMaker[] pyroPrimaries = new WeaponMaker[5];
    public static WeaponMaker[] pyroSecondaries = new WeaponMaker[9];
    public static WeaponMaker[] pyroMelees = new WeaponMaker[9];

    public static WeaponMaker[] demomanPrimaries = new WeaponMaker[6];
    public static WeaponMaker[] demomanSecondaries = new WeaponMaker[7];
    public static WeaponMaker[] demomanMelees = new WeaponMaker[8];

    public static WeaponMaker[] heavyPrimaries = new WeaponMaker[5];
    public static WeaponMaker[] heavySecondaries = new WeaponMaker[7];
    public static WeaponMaker[] heavyMelees = new WeaponMaker[7];

    public static WeaponMaker[] engineerPrimaries = new WeaponMaker[6];
    public static WeaponMaker[] engineerSecondaries = new WeaponMaker[3];
    public static WeaponMaker[] engineerMelees = new WeaponMaker[5];

    public static WeaponMaker[] medicPrimaries = new WeaponMaker[4];
    public static WeaponMaker[] medicSecondaries = new WeaponMaker[4];
    public static WeaponMaker[] medicMelees = new WeaponMaker[5];

    public static WeaponMaker[] sniperPrimaries = new WeaponMaker[7];
    public static WeaponMaker[] sniperSecondaries = new WeaponMaker[6];
    public static WeaponMaker[] sniperMelees = new WeaponMaker[4];

    public static WeaponMaker[] spyPrimaries = new WeaponMaker[5];
    public static WeaponMaker[] spySecondaries = new WeaponMaker[2];
    public static WeaponMaker[] spyMelees = new WeaponMaker[5];
    public static WeaponMaker[] spyWatches = new WeaponMaker[3];

    // Start is called before the first frame update
    void Start()
    {
        InitializeAll();

        FillScout();
        FillSoldier();
        FillPyro();
        FillDemo();
        FillHeavy();
        FillEngi();
        FillMedic();
        FillSniper();
        FillSpy();

        FillDatabase();
    }

    public void InitializeAll()
    {
        nonStockWeapons.Initialize();
        scoutPrimaries.Initialize();
        scoutSecondaries.Initialize();
        scoutMelees.Initialize();
        soldierPrimaries.Initialize();
        soldierSecondaries.Initialize();
        soldierMelees.Initialize();
        pyroPrimaries.Initialize();
        pyroSecondaries.Initialize();
        pyroMelees.Initialize();
        demomanPrimaries.Initialize();
        demomanSecondaries.Initialize();
        demomanMelees.Initialize();
        heavyPrimaries.Initialize();
        heavySecondaries.Initialize();
        heavyMelees.Initialize();
        engineerPrimaries.Initialize();
        engineerSecondaries.Initialize();
        engineerMelees.Initialize();
        medicPrimaries.Initialize();
        medicSecondaries.Initialize();
        medicMelees.Initialize();
        sniperPrimaries.Initialize();
        sniperSecondaries.Initialize();
        sniperMelees.Initialize();
        spyPrimaries.Initialize();
        spySecondaries.Initialize();
        spyMelees.Initialize();
        spyWatches.Initialize();
    }

    public void FillDatabase()
    {
        for (int i = 0; i < listInstance.nonStockWeapons.Length; i++)
        {
            nonStockWeapons[i] = listInstance.nonStockWeapons[i];
        }
    }

    public void FillScout()
    {
        for (int i = 0; i < listInstance.scoutPrimaries.Length; i++)
        {
            scoutPrimaries[i] = listInstance.scoutPrimaries[i];
        }
        for (int i = 0; i < listInstance.scoutSecondaries.Length; i++)
        {
            scoutSecondaries[i] = listInstance.scoutSecondaries[i];
        }
        for (int i = 0; i < listInstance.scoutMelees.Length; i++)
        {
            scoutMelees[i] = listInstance.scoutMelees[i];
        }
    }

    public void FillSoldier()
    {
        for (int i = 0; i < listInstance.soldierPrimaries.Length; i++)
        {
            soldierPrimaries[i] = listInstance.soldierPrimaries[i];
        }
        for (int i = 0; i < listInstance.soldierSecondaries.Length; i++)
        {
            soldierSecondaries[i] = listInstance.soldierSecondaries[i];
        }
        for (int i = 0; i < listInstance.soldierMelees.Length; i++)
        {
            soldierMelees[i] = listInstance.soldierMelees[i];
        }
    }

    public void FillPyro()
    {
        for (int i = 0; i < listInstance.pyroPrimaries.Length; i++)
        {
            pyroPrimaries[i] = listInstance.pyroPrimaries[i];
        }
        for (int i = 0; i < listInstance.pyroSecondaries.Length; i++)
        {
            pyroSecondaries[i] = listInstance.pyroSecondaries[i];
        }
        for (int i = 0; i < listInstance.pyroMelees.Length; i++)
        {
            pyroMelees[i] = listInstance.pyroMelees[i];
        }
    }

    public void FillDemo()
    {
        for (int i = 0; i < listInstance.demomanPrimaries.Length; i++)
        {
            demomanPrimaries[i] = listInstance.demomanPrimaries[i];
        }
        for (int i = 0; i < listInstance.demomanSecondaries.Length; i++)
        {
            demomanSecondaries[i] = listInstance.demomanSecondaries[i];
        }
        for (int i = 0; i < listInstance.demomanMelees.Length; i++)
        {
            demomanMelees[i] = listInstance.demomanMelees[i];
        }
    }

    public void FillHeavy()
    {
        for (int i = 0; i < listInstance.heavyPrimaries.Length; i++)
        {
            heavyPrimaries[i] = listInstance.heavyPrimaries[i];
        }
        for (int i = 0; i < listInstance.heavySecondaries.Length; i++)
        {
            heavySecondaries[i] = listInstance.heavySecondaries[i];
        }
        for (int i = 0; i < listInstance.heavyMelees.Length; i++)
        {
            heavyMelees[i] = listInstance.heavyMelees[i];
        }
    }

    public void FillEngi()
    {
        for (int i = 0; i < listInstance.engineerPrimaries.Length; i++)
        {
            engineerPrimaries[i] = listInstance.engineerPrimaries[i];
        }
        for (int i = 0; i < listInstance.engineerSecondaries.Length; i++)
        {
            engineerSecondaries[i] = listInstance.engineerSecondaries[i];
        }
        for (int i = 0; i < listInstance.engineerMelees.Length; i++)
        {
            engineerMelees[i] = listInstance.engineerMelees[i];
        }
    }

    public void FillMedic()
    {
        for (int i = 0; i < listInstance.medicPrimaries.Length; i++)
        {
            medicPrimaries[i] = listInstance.medicPrimaries[i];
        }
        for (int i = 0; i < listInstance.medicSecondaries.Length; i++)
        {
            medicSecondaries[i] = listInstance.medicSecondaries[i];
        }
        for (int i = 0; i < listInstance.medicMelees.Length; i++)
        {
            medicMelees[i] = listInstance.medicMelees[i];
        }
    }

    public void FillSniper()
    {
        for (int i = 0; i < listInstance.sniperPrimaries.Length; i++)
        {
            sniperPrimaries[i] = listInstance.sniperPrimaries[i];
        }
        for (int i = 0; i < listInstance.sniperSecondaries.Length; i++)
        {
            sniperSecondaries[i] = listInstance.sniperSecondaries[i];
        }
        for (int i = 0; i < listInstance.sniperMelees.Length; i++)
        {
            sniperMelees[i] = listInstance.sniperMelees[i];
        }
    }

    public void FillSpy()
    {
        for (int i = 0; i < listInstance.spyPrimaries.Length; i++)
        {
            spyPrimaries[i] = listInstance.spyPrimaries[i];
        }
        for (int i = 0; i < listInstance.spySecondaries.Length; i++)
        {
            spySecondaries[i] = listInstance.spySecondaries[i];
        }
        for (int i = 0; i < listInstance.spyMelees.Length; i++)
        {
            spyMelees[i] = listInstance.spyMelees[i];
        }
        for (int i = 0; i < listInstance.spyWatches.Length; i++)
        {
            spyWatches[i] = listInstance.spyWatches[i];
        }
    }
}
