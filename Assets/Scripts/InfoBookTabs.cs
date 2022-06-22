using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InfoBookTabs : MonoBehaviour
{
    public DisplayBattleUI[] uiInstances;
    private DisplayBattleUI currentBattleUI;

    private void Update()
    {
        for (int i = 0; i < uiInstances.Length; i++)
        {
            if (uiInstances[i].currentlySelected)
            {
                currentBattleUI = uiInstances[i];
            }
        }
    }

    public void PrimaryTab()
    {
        currentBattleUI.EquipWeapon(1);
    }

    public void SecondaryTab()
    {
        currentBattleUI.EquipWeapon(2);
    }

    public void MeleeTab()
    {
        currentBattleUI.EquipWeapon(3);
    }

    public void ExtraTab()
    {
        currentBattleUI.EquipWeapon(4);
    }
}
