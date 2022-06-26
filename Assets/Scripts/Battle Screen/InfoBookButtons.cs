using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InfoBookButtons: MonoBehaviour
{
    public DisplayBattleUI[] uiInstances;
    public DisplayBattleUI currentBattleUI;

    private void Start()
    {

    }

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

    public void SkillChange(int skillNum)
    {
        int tempInt = 0;
        switch (currentBattleUI.dataInstance.equippedSlotNum)
        {
            case 1:
                tempInt = currentBattleUI.dataInstance.skillChoice1P;
                if (skillNum != currentBattleUI.dataInstance.skillChoice1P && skillNum != currentBattleUI.dataInstance.skillChoice2P)
                {
                    currentBattleUI.dataInstance.skillChoice1P = skillNum;
                    currentBattleUI.dataInstance.skillChoice2P = tempInt;
                }
                break;
            case 2:
                tempInt = currentBattleUI.dataInstance.skillChoice1S;
                if (skillNum != currentBattleUI.dataInstance.skillChoice1S && skillNum != currentBattleUI.dataInstance.skillChoice2S)
                {
                    currentBattleUI.dataInstance.skillChoice1S = skillNum;
                    currentBattleUI.dataInstance.skillChoice2S = tempInt;
                }
                break;
            case 3:
                tempInt = currentBattleUI.dataInstance.skillChoice1M;
                if (skillNum != currentBattleUI.dataInstance.skillChoice1M && skillNum != currentBattleUI.dataInstance.skillChoice2M)
                {
                    currentBattleUI.dataInstance.skillChoice1M = skillNum;
                    currentBattleUI.dataInstance.skillChoice2M = tempInt;
                }
                break;
            case 4:
                tempInt = currentBattleUI.dataInstance.skillChoice1E;
                if (skillNum != currentBattleUI.dataInstance.skillChoice1E && skillNum != currentBattleUI.dataInstance.skillChoice2E)
                {
                    currentBattleUI.dataInstance.skillChoice1E = skillNum;
                    currentBattleUI.dataInstance.skillChoice2E = tempInt;
                }
                break;
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
