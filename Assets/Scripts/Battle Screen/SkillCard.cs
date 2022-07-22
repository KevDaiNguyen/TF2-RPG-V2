using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkillCard : MonoBehaviour
{
    public GameObject skillCard;
    public InfoBookButtons infoInstance;

    public ClassData[] classSlots;
    private ClassData currentClass;

    private int attackerSlot;
    public int targetSlot;

    public string leftRight;

    private bool hasSecondarySkill;

    private int skillChoiceLeft;
    private int skillChoiceRight;

    private string currentWeaponSlot;

    private bool canRightClick;

    public bool currentlyChoosingTarget;
    private bool usedASkill;
    public bool foundTarget;

    // Start is called before the first frame update
    void Start()
    {
        canRightClick = false;
        currentlyChoosingTarget = false;
        usedASkill = false;
        foundTarget = false;
    }

    // Update is called once per frame
    void Update()
    {
        attackerSlot = infoInstance.currentBattleUI.dataInstance.currentPosition;
        currentClass = classSlots[attackerSlot];

        CheckSkillChoice();
        CheckEquippedWeapon();

        if (leftRight == "Left")
        {
            switch (skillChoiceLeft)
            {
                case 0:
                    switch (currentWeaponSlot)
                    {
                        case "Primary":
                            hasSecondarySkill = currentClass.primarySlot.secondarySkill1;
                            break;
                        case "Secondary":
                            hasSecondarySkill = currentClass.primarySlot.secondarySkill2;
                            break;
                        case "Melee":
                            hasSecondarySkill = currentClass.primarySlot.secondarySkill3;
                            break;
                        case "Extra":
                            hasSecondarySkill = currentClass.primarySlot.secondarySkill4;
                            break;
                    }
                    break;
                case 1:
                    switch (currentWeaponSlot)
                    {
                        case "Primary":
                            hasSecondarySkill = currentClass.secondarySlot.secondarySkill1;
                            break;
                        case "Secondary":
                            hasSecondarySkill = currentClass.secondarySlot.secondarySkill2;
                            break;
                        case "Melee":
                            hasSecondarySkill = currentClass.secondarySlot.secondarySkill3;
                            break;
                        case "Extra":
                            hasSecondarySkill = currentClass.secondarySlot.secondarySkill4;
                            break;
                    }
                    break;
                case 2:
                    switch (currentWeaponSlot)
                    {
                        case "Primary":
                            hasSecondarySkill = currentClass.meleeSlot.secondarySkill1;
                            break;
                        case "Secondary":
                            hasSecondarySkill = currentClass.meleeSlot.secondarySkill2;
                            break;
                        case "Melee":
                            hasSecondarySkill = currentClass.meleeSlot.secondarySkill3;
                            break;
                        case "Extra":
                            hasSecondarySkill = currentClass.meleeSlot.secondarySkill4;
                            break;
                    }
                    break;
                case 3:
                    switch (currentWeaponSlot)
                    {
                        case "Primary":
                            hasSecondarySkill = currentClass.extraSlot.secondarySkill1;
                            break;
                        case "Secondary":
                            hasSecondarySkill = currentClass.extraSlot.secondarySkill2;
                            break;
                        case "Melee":
                            hasSecondarySkill = currentClass.extraSlot.secondarySkill3;
                            break;
                        case "Extra":
                            hasSecondarySkill = currentClass.extraSlot.secondarySkill4;
                            break;
                    }
                    break;
            }
        }
        else
        {
            switch (skillChoiceRight)
            {
                case 0:
                    switch (currentWeaponSlot)
                    {
                        case "Primary":
                            hasSecondarySkill = currentClass.primarySlot.secondarySkill1;
                            break;
                        case "Secondary":
                            hasSecondarySkill = currentClass.primarySlot.secondarySkill2;
                            break;
                        case "Melee":
                            hasSecondarySkill = currentClass.primarySlot.secondarySkill3;
                            break;
                        case "Extra":
                            hasSecondarySkill = currentClass.primarySlot.secondarySkill4;
                            break;
                    }
                    break;
                case 1:
                    switch (currentWeaponSlot)
                    {
                        case "Primary":
                            hasSecondarySkill = currentClass.secondarySlot.secondarySkill1;
                            break;
                        case "Secondary":
                            hasSecondarySkill = currentClass.secondarySlot.secondarySkill2;
                            break;
                        case "Melee":
                            hasSecondarySkill = currentClass.secondarySlot.secondarySkill3;
                            break;
                        case "Extra":
                            hasSecondarySkill = currentClass.secondarySlot.secondarySkill4;
                            break;
                    }
                    break;
                case 2:
                    switch (currentWeaponSlot)
                    {
                        case "Primary":
                            hasSecondarySkill = currentClass.meleeSlot.secondarySkill1;
                            break;
                        case "Secondary":
                            hasSecondarySkill = currentClass.meleeSlot.secondarySkill2;
                            break;
                        case "Melee":
                            hasSecondarySkill = currentClass.meleeSlot.secondarySkill3;
                            break;
                        case "Extra":
                            hasSecondarySkill = currentClass.meleeSlot.secondarySkill4;
                            break;
                    }
                    break;
                case 3:
                    switch (currentWeaponSlot)
                    {
                        case "Primary":
                            hasSecondarySkill = currentClass.extraSlot.secondarySkill1;
                            break;
                        case "Secondary":
                            hasSecondarySkill = currentClass.extraSlot.secondarySkill2;
                            break;
                        case "Melee":
                            hasSecondarySkill = currentClass.extraSlot.secondarySkill3;
                            break;
                        case "Extra":
                            hasSecondarySkill = currentClass.extraSlot.secondarySkill4;
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
    }

    private void CheckEquippedWeapon()
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

    private void CheckSkillChoice()
    {
        if (leftRight == "Left")
        {
            switch (currentClass.equippedSlotNum)
            {
                case 1:
                    skillChoiceLeft = currentClass.skillChoice1P;
                    break;
                case 2:
                    skillChoiceLeft = currentClass.skillChoice1S;
                    break;
                case 3:
                    skillChoiceLeft = currentClass.skillChoice1M;
                    break;
                case 4:
                    skillChoiceLeft = currentClass.skillChoice1E;
                    break;
            }
        }
        else
        {
            switch (currentClass.equippedSlotNum)
            {
                case 1:
                    skillChoiceRight = currentClass.skillChoice2P;
                    break;
                case 2:
                    skillChoiceRight = currentClass.skillChoice2S;
                    break;
                case 3:
                    skillChoiceRight = currentClass.skillChoice2M;
                    break;
                case 4:
                    skillChoiceRight = currentClass.skillChoice2E;
                    break;
            }
        }
    }

    public void LeftClick()
    {
        currentlyChoosingTarget = true;
    }

    public void RightClick()
    {
        if (canRightClick)
        {
            currentlyChoosingTarget = true;
        }
    }

}
