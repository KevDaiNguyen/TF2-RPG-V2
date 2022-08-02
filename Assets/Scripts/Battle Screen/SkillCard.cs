using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SkillCard : MonoBehaviour
{
    public GameObject skillCard;
    public InfoBookButtons infoInstance;

    public ClassData[] classSlots;
    public ClassData currentClass;

    public int attackerSlot;
    public int targetSlot;

    public string leftRight;

    public bool hasSecondarySkill;

    public int skillChoice;

    public string currentWeaponSlot;

    public bool canRightClick;

    public bool currentlyChoosingTarget;
    public bool usedASkill;
    public bool foundTarget;

    public int attackRange;

    // Start is called before the first frame update
    void Start()
    {
        hasSecondarySkill = false;
        canRightClick = false;
        currentlyChoosingTarget = false;
        usedASkill = false;
        foundTarget = false;
    }

    // Update is called once per frame
    void Update()
    {
        attackerSlot = infoInstance.currentBattleUI.dataInstance.currentPosition;
        currentClass = classSlots[attackerSlot - 1];

        CheckSkillChoice();
        CheckEquippedWeapon();

        if (leftRight == "Left")
        {
            switch (currentWeaponSlot)
            {
                case "Primary":
                    switch (skillChoice)
                    {
                        case 0:
                            hasSecondarySkill = currentClass.allWeaponSlots[0].allHasSecondarySkills[0];
                            break;
                        case 1:
                            hasSecondarySkill = currentClass.allWeaponSlots[0].allHasSecondarySkills[1];
                            break;
                        case 2:
                            hasSecondarySkill = currentClass.allWeaponSlots[0].allHasSecondarySkills[2];
                            break;
                        case 3:
                            hasSecondarySkill = currentClass.allWeaponSlots[0].allHasSecondarySkills[3];
                            break;
                    }
                    break;
                case "Secondary":
                    switch (skillChoice)
                    {
                        case 0:
                            hasSecondarySkill = currentClass.secondarySlot.allHasSecondarySkills[0];
                            break;
                        case 1:
                            hasSecondarySkill = currentClass.secondarySlot.allHasSecondarySkills[1];
                            break;
                        case 2:
                            hasSecondarySkill = currentClass.secondarySlot.allHasSecondarySkills[2];
                            break;
                        case 3:
                            hasSecondarySkill = currentClass.secondarySlot.allHasSecondarySkills[3];
                            break;
                    }
                    break;
                case "Melee":
                    switch (skillChoice)
                    {
                        case 0:
                            hasSecondarySkill = currentClass.meleeSlot.allHasSecondarySkills[0];
                            break;
                        case 1:
                            hasSecondarySkill = currentClass.meleeSlot.allHasSecondarySkills[1];
                            break;
                        case 2:
                            hasSecondarySkill = currentClass.meleeSlot.allHasSecondarySkills[2];
                            break;
                        case 3:
                            hasSecondarySkill = currentClass.meleeSlot.allHasSecondarySkills[3];
                            break;
                    }
                    break;
                case "Extra":
                    switch (skillChoice)
                    {
                        case 0:
                            hasSecondarySkill = currentClass.extraSlot.allHasSecondarySkills[0];
                            break;
                        case 1:
                            hasSecondarySkill = currentClass.extraSlot.allHasSecondarySkills[1];
                            break;
                        case 2:
                            hasSecondarySkill = currentClass.extraSlot.allHasSecondarySkills[2];
                            break;
                        case 3:
                            hasSecondarySkill = currentClass.extraSlot.allHasSecondarySkills[3];
                            break;
                    }
                    break;
            }
        }
        else
        {
            switch (currentWeaponSlot)
            {
                case "Primary":
                    switch (skillChoice)
                    {
                        case 0:
                            hasSecondarySkill = currentClass.allWeaponSlots[0].allHasSecondarySkills[0];
                            break;
                        case 1:
                            hasSecondarySkill = currentClass.allWeaponSlots[0].allHasSecondarySkills[1];
                            break;
                        case 2:
                            hasSecondarySkill = currentClass.allWeaponSlots[0].allHasSecondarySkills[2];
                            break;
                        case 3:
                            hasSecondarySkill = currentClass.allWeaponSlots[0].allHasSecondarySkills[3];
                            break;
                    }
                    break;
                case "Secondary":
                    switch (skillChoice)
                    {
                        case 0:
                            hasSecondarySkill = currentClass.secondarySlot.allHasSecondarySkills[0];
                            break;
                        case 1:
                            hasSecondarySkill = currentClass.secondarySlot.allHasSecondarySkills[1];
                            break;
                        case 2:
                            hasSecondarySkill = currentClass.secondarySlot.allHasSecondarySkills[2];
                            break;
                        case 3:
                            hasSecondarySkill = currentClass.secondarySlot.allHasSecondarySkills[3];
                            break;
                    }
                    break;
                case "Melee":
                    switch (skillChoice)
                    {
                        case 0:
                            hasSecondarySkill = currentClass.meleeSlot.allHasSecondarySkills[0];
                            break;
                        case 1:
                            hasSecondarySkill = currentClass.meleeSlot.allHasSecondarySkills[1];
                            break;
                        case 2:
                            hasSecondarySkill = currentClass.meleeSlot.allHasSecondarySkills[2];
                            break;
                        case 3:
                            hasSecondarySkill = currentClass.meleeSlot.allHasSecondarySkills[3];
                            break;
                    }
                    break;
                case "Extra":
                    switch (skillChoice)
                    {
                        case 0:
                            hasSecondarySkill = currentClass.extraSlot.allHasSecondarySkills[0];
                            break;
                        case 1:
                            hasSecondarySkill = currentClass.extraSlot.allHasSecondarySkills[1];
                            break;
                        case 2:
                            hasSecondarySkill = currentClass.extraSlot.allHasSecondarySkills[2];
                            break;
                        case 3:
                            hasSecondarySkill = currentClass.extraSlot.allHasSecondarySkills[3];
                            break;
                    }
                    break;
            }
        }

        if ((Input.mousePosition.x < (skillCard.transform.position.x + 25) && Input.mousePosition.x > (skillCard.transform.position.x - 25) && hasSecondarySkill
            && Input.mousePosition.y < (skillCard.transform.position.y + 25) && Input.mousePosition.y > (skillCard.transform.position.y - 25)))
        {
            canRightClick = true;
        }
        else
        {
            canRightClick = false;
        }

        if (foundTarget && !usedASkill)
        {

            usedASkill = true;
        }
        else if (canRightClick && Input.GetMouseButtonDown(1))
        {
            RightClick();
        }

        if (currentClass.isBlu && currentlyChoosingTarget && !foundTarget)
        {
            classSlots[attackerSlot - attackRange].InRange();
        }
        else
        {
            classSlots[attackerSlot + attackRange].InRange();
        }
    }

    private void CheckEquippedWeapon() // To find which weapon to focus on in slots
    {
        switch (currentClass.equippedSlotNum)
        {
            case 1:
                currentWeaponSlot = "Primary";
                break;
            case 2:
                currentWeaponSlot = "Secondary";
                break;
            case 3:
                currentWeaponSlot = "Melee";
                break;
            case 4:
                currentWeaponSlot = "Extra";
                break;
        }
    }

    private void CheckSkillChoice() // To find which skill number directly connects to the skill card
    {
        if (leftRight == "Left")
        {
            switch (currentClass.equippedSlotNum)
            {
                case 1:
                    skillChoice = currentClass.skillChoice1P;
                    break;
                case 2:
                    skillChoice = currentClass.skillChoice1S;
                    break;
                case 3:
                    skillChoice = currentClass.skillChoice1M;
                    break;
                case 4:
                    skillChoice = currentClass.skillChoice1E;
                    break;
            }
        }
        else
        {
            switch (currentClass.equippedSlotNum)
            {
                case 1:
                    skillChoice = currentClass.skillChoice2P;
                    break;
                case 2:
                    skillChoice = currentClass.skillChoice2S;
                    break;
                case 3:
                    skillChoice = currentClass.skillChoice2M;
                    break;
                case 4:
                    skillChoice = currentClass.skillChoice2E;
                    break;
            }
        }
    }

    private void CheckRanges()
    {
        switch(currentWeaponSlot)
        {
            case "Primary":
                if (leftRight == "Left")
                {
                    switch (skillChoice)
                    {
                        case 0:
                            attackRange = currentClass.primarySlot.skillRange1;
                            break;
                        case 1:
                            attackRange = currentClass.primarySlot.skillRange2;
                            break;
                        case 2:
                            attackRange = currentClass.primarySlot.skillRange3;
                            break;
                        case 3:
                            attackRange = currentClass.primarySlot.skillRange4;
                            break;
                    }
                }
                else
                {
                    switch (skillChoice)
                    {
                        case 0:
                            attackRange = currentClass.primarySlot.skillRange1;
                            break;
                        case 1:
                            attackRange = currentClass.primarySlot.skillRange2;
                            break;
                        case 2:
                            attackRange = currentClass.primarySlot.skillRange3;
                            break;
                        case 3:
                            attackRange = currentClass.primarySlot.skillRange4;
                            break;
                    }
                }
                break;
            case "Secondary":
                if (leftRight == "Left")
                {
                    switch (skillChoice)
                    {
                        case 0:
                            attackRange = currentClass.secondarySlot.skillRange1;
                            break;
                        case 1:
                            attackRange = currentClass.secondarySlot.skillRange2;
                            break;
                        case 2:
                            attackRange = currentClass.secondarySlot.skillRange3;
                            break;
                        case 3:
                            attackRange = currentClass.secondarySlot.skillRange4;
                            break;
                    }
                }
                else
                {
                    switch (skillChoice)
                    {
                        case 0:
                            attackRange = currentClass.secondarySlot.skillRange1;
                            break;
                        case 1:
                            attackRange = currentClass.secondarySlot.skillRange2;
                            break;
                        case 2:
                            attackRange = currentClass.secondarySlot.skillRange3;
                            break;
                        case 3:
                            attackRange = currentClass.secondarySlot.skillRange4;
                            break;
                    }
                }
                break;
            case "Melee":
                if (leftRight == "Left")
                {
                    switch (skillChoice)
                    {
                        case 0:
                            attackRange = currentClass.meleeSlot.skillRange1;
                            break;
                        case 1:
                            attackRange = currentClass.meleeSlot.skillRange2;
                            break;
                        case 2:
                            attackRange = currentClass.meleeSlot.skillRange3;
                            break;
                        case 3:
                            attackRange = currentClass.meleeSlot.skillRange4;
                            break;
                    }
                }
                else
                {
                    switch (skillChoice)
                    {
                        case 0:
                            attackRange = currentClass.meleeSlot.skillRange1;
                            break;
                        case 1:
                            attackRange = currentClass.meleeSlot.skillRange2;
                            break;
                        case 2:
                            attackRange = currentClass.meleeSlot.skillRange3;
                            break;
                        case 3:
                            attackRange = currentClass.meleeSlot.skillRange4;
                            break;
                    }
                }
                break;
            case "Extra":
                if (leftRight == "Left")
                {
                    switch (skillChoice)
                    {
                        case 0:
                            attackRange = currentClass.extraSlot.skillRange1;
                            break;
                        case 1:
                            attackRange = currentClass.extraSlot.skillRange2;
                            break;
                        case 2:
                            attackRange = currentClass.extraSlot.skillRange3;
                            break;
                        case 3:
                            attackRange = currentClass.extraSlot.skillRange4;
                            break;
                    }
                }
                else
                {
                    switch (skillChoice)
                    {
                        case 0:
                            attackRange = currentClass.extraSlot.skillRange1;
                            break;
                        case 1:
                            attackRange = currentClass.extraSlot.skillRange2;
                            break;
                        case 2:
                            attackRange = currentClass.extraSlot.skillRange3;
                            break;
                        case 3:
                            attackRange = currentClass.extraSlot.skillRange4;
                            break;
                    }
                }
                break;
        }
    }// Checks what the current range the skill select has 

    public void LeftClick() // Activates on clicking button on skill card
    {
        currentlyChoosingTarget = true;
        foundTarget = false;
    }

    public void RightClick() // Activates on right clicking over skill card
    {
        if (canRightClick)
        {
            currentlyChoosingTarget = true;
            foundTarget = false;
        }
    }

}
