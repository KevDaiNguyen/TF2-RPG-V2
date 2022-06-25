using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InfoBookButtons: MonoBehaviour
{
    public DisplayBattleUI[] uiInstances;
    private DisplayBattleUI currentBattleUI;
    private int currentSlotSelected;

    private void Start()
    {
        currentSlotSelected = 0;
    }

    private void Update()
    {
        for (int i = 0; i < uiInstances.Length; i++)
        {
            if (uiInstances[i].currentlySelected)
            {
                currentBattleUI = uiInstances[i];
                currentSlotSelected = i;
            }
        }
    }

    public void SkillChange(int skillNum)
    {
        int tempInt = 0;
        switch (uiInstances[currentSlotSelected].dataInstance.equippedSlotNum)
        {
            case 1:
                tempInt = uiInstances[currentSlotSelected].dataInstance.skillChoice1P;
                if (skillNum != uiInstances[currentSlotSelected].dataInstance.skillChoice1P && skillNum != uiInstances[currentSlotSelected].dataInstance.skillChoice2P)
                {
                    uiInstances[currentSlotSelected].dataInstance.skillChoice1P = skillNum;
                    uiInstances[currentSlotSelected].dataInstance.skillChoice2P = tempInt;
                }
                break;
            case 2:
                tempInt = uiInstances[currentSlotSelected].dataInstance.skillChoice1S;
                if (skillNum != uiInstances[currentSlotSelected].dataInstance.skillChoice1S && skillNum != uiInstances[currentSlotSelected].dataInstance.skillChoice2S)
                {
                    uiInstances[currentSlotSelected].dataInstance.skillChoice1S = skillNum;
                    uiInstances[currentSlotSelected].dataInstance.skillChoice2S = tempInt;
                }
                break;
            case 3:
                tempInt = uiInstances[currentSlotSelected].dataInstance.skillChoice1M;
                if (skillNum != uiInstances[currentSlotSelected].dataInstance.skillChoice1M && skillNum != uiInstances[currentSlotSelected].dataInstance.skillChoice2M)
                {
                    uiInstances[currentSlotSelected].dataInstance.skillChoice1M = skillNum;
                    uiInstances[currentSlotSelected].dataInstance.skillChoice2M = tempInt;
                }
                break;
            case 4:
                tempInt = uiInstances[currentSlotSelected].dataInstance.skillChoice1E;
                if (skillNum != uiInstances[currentSlotSelected].dataInstance.skillChoice1E && skillNum != uiInstances[currentSlotSelected].dataInstance.skillChoice2E)
                {
                    uiInstances[currentSlotSelected].dataInstance.skillChoice1E = skillNum;
                    uiInstances[currentSlotSelected].dataInstance.skillChoice2E = tempInt;
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
