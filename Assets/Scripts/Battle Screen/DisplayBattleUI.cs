using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class DisplayBattleUI : MonoBehaviour
{
    public ClassData dataInstance;
    public SkillCard cardInstance;

    [Header("---The sprite above the healthbar---")]
    public Image classBody;

    [Header("---Healthbar---")]
    public Image healthbarFill;
    private int originalHealth;

    [Header("---Class Stats---")]
    public TextMeshProUGUI className;
    public TextMeshProUGUI classHealthNum;

    public TextMeshProUGUI bulletResist;
    public TextMeshProUGUI explosiveResist;
    public TextMeshProUGUI fireResist;
    public TextMeshProUGUI meleeResist;
    public TextMeshProUGUI[] allResists = new TextMeshProUGUI[4];

    public TextMeshProUGUI bulletVulnerability;
    public TextMeshProUGUI explosiveVulnerability;
    public TextMeshProUGUI fireVulnerability;
    public TextMeshProUGUI meleeVulnerability;
    public TextMeshProUGUI[] allVulnerabilities = new TextMeshProUGUI[4];

    public TextMeshProUGUI speedNum;
    public TextMeshProUGUI dodgeChance;

    [Header("---Ammo/Reload Button---")]
    public TextMeshProUGUI ammoCount;

    [Header("---Stored Damage/Uber Bar---")]
    public GameObject chargeBarObject;
    public Image chargeBar;
    public TextMeshProUGUI chargeBarText;

    [Header("---Tab Display---")]
    public GameObject[] weaponTabs;

    [Header("---Tab Display---")]
    public Image[] weaponTabImages;

    [Header("---Skill Choice Box---")]
    public TextMeshProUGUI[] activeSkillChoices;

    [Header("---Active Skills---")]
    public Image skillLogo1;
    public TextMeshProUGUI skillDescription1;
    public TextMeshProUGUI skillAccuracy1;

    public Image skillLogo2;
    public TextMeshProUGUI skillDescription2;
    public TextMeshProUGUI skillAccuracy2;

    [Header("---Active when clicked on---")]
    public bool currentlySelected;

    private bool equipedPassives = false;
    private int previousSlotNum;

    // Start is called before the first frame update
    void Start()
    {
        originalHealth = dataInstance.currentHealth;

        allResists[0] = bulletResist;
        allResists[1] = explosiveResist;
        allResists[2] = fireResist;
        allResists[3] = meleeResist;

        allVulnerabilities[0] = bulletVulnerability;
        allVulnerabilities[1] = explosiveVulnerability;
        allVulnerabilities[2] = fireVulnerability;
        allVulnerabilities[3] = meleeVulnerability;
    }

    // Update is called once per frame
    void Update()
    {
        classBody.sprite = dataInstance.classSprite;
        healthbarFill.fillAmount = (dataInstance.currentHealth / originalHealth);

        if (dataInstance.canHit)
        {
            classBody.color = Color.green;
        }
        else
        {
            classBody.color = Color.white;
        }

        if (!equipedPassives)
        {
            PassiveEquip();
            // ------------------------------------------------------------------------
            if (dataInstance.allWeaponSlots[dataInstance.equippedSlotNum - 1].healthChange != 0)
            {
                originalHealth += dataInstance.allWeaponSlots[dataInstance.equippedSlotNum - 1].healthChange;
                dataInstance.ChangeMaxHealth(dataInstance.allWeaponSlots[dataInstance.equippedSlotNum - 1].healthChange);
            }
            // --------------------------------------------------------------------------
            if (dataInstance.allWeaponSlots[dataInstance.equippedSlotNum - 1].hasMeterBar && dataInstance.allWeaponSlots[dataInstance.equippedSlotNum - 1].startFullMeter)
            {
                dataInstance.IncreaseMeterBar(dataInstance.primarySlot.maxMeterNum, 1);
            }
            // -------------------------------------------------------------------------

            equipedPassives = true;
        }

        if (currentlySelected)
        {
            className.text = dataInstance.className;
            classHealthNum.text = dataInstance.currentHealth.ToString();

            ResistDisplay();

            speedNum.text = "Speed \n" + dataInstance.currentSpeed.ToString();
            dodgeChance.text = "Dodge Chance \n" + (dataInstance.currentSpeed - 75).ToString() + "%";

            weaponTabImages[0].sprite = dataInstance.primarySlot.weaponImage;
            weaponTabImages[1].sprite = dataInstance.secondarySlot.weaponImage;
            weaponTabImages[2].sprite = dataInstance.meleeSlot.weaponImage;
            weaponTabImages[3].sprite = dataInstance.extraSlot.weaponImage;


            if (dataInstance.allWeaponSlots[dataInstance.equippedSlotNum - 1].clipSize <= 0)
            {
                ammoCount.text = "Reload";
            }
            else
            {
                if (dataInstance.allWeaponSlots[dataInstance.equippedSlotNum - 1].reserveSize == 0)
                {
                    ammoCount.text = dataInstance.allWeaponSlots[dataInstance.equippedSlotNum - 1].clipSize.ToString();
                }
                else if (dataInstance.allWeaponSlots[dataInstance.equippedSlotNum - 1].reserveSize == 9999)
                {
                    ammoCount.text = dataInstance.allWeaponSlots[dataInstance.equippedSlotNum - 1].clipSize.ToString() + "/INF";
                }
                else
                {
                    ammoCount.text = dataInstance.allWeaponSlots[dataInstance.equippedSlotNum - 1].clipSize.ToString() + "/" + dataInstance.allWeaponSlots[dataInstance.equippedSlotNum - 1].reserveSize.ToString();
                }
            }
            // ----------------------------------------------------------------
            if (dataInstance.allWeaponSlots[dataInstance.equippedSlotNum - 1].hasMeterBar)
            {
                chargeBarObject.SetActive(true);
                chargeBarText.text = dataInstance.allWeaponSlots[dataInstance.equippedSlotNum - 1].meterText;
                chargeBar.fillAmount = (dataInstance.allMeterNums[dataInstance.equippedSlotNum - 1] / dataInstance.allWeaponSlots[dataInstance.equippedSlotNum - 1].maxMeterNum);
            }
            else
            {
                chargeBarObject.SetActive(false);
            }
            // ----------------------------------------------------------------
            weaponTabs[0].transform.localPosition = new Vector3(-360, (weaponTabs[0].transform.localPosition).y, (weaponTabs[0].transform.localPosition).z);

            weaponTabs[1].transform.localPosition = new Vector3(-300, (weaponTabs[1].transform.localPosition).y, (weaponTabs[1].transform.localPosition).z);
            weaponTabs[2].transform.localPosition = new Vector3(-300, (weaponTabs[2].transform.localPosition).y, (weaponTabs[2].transform.localPosition).z);

            if (dataInstance.showExtraSlot)
            {
                weaponTabs[3].SetActive(true);
                weaponTabs[3].transform.localPosition = new Vector3(-300, (weaponTabs[3].transform.localPosition).y, (weaponTabs[3].transform.localPosition).z);
            }
            else
            {
                weaponTabs[3].SetActive(false);
            }
            // ---------------------------------------------------------------
            skillLogo1.sprite = dataInstance.allEquippedLogos[0];
            skillDescription1.text = dataInstance.allEquippedSkills[0];

            skillLogo2.sprite = dataInstance.allEquippedLogos[1];
            skillDescription2.text = dataInstance.allEquippedSkills[1];
            // ---------------------------------------------------------------
            for (int i = 0; i < activeSkillChoices.Length; i++)
            {
                if (dataInstance.allSkillChoices[i,0] == i)
                {
                    activeSkillChoices[i].color = Color.white;
                }
                else if (dataInstance.allSkillChoices[i,1] == i)
                {
                    activeSkillChoices[i].color = Color.white;
                }
                else
                {
                    activeSkillChoices[i].color = Color.black;
                }
            }
        }
    }

    public void ResistDisplay()
    {
        for (int i = 0; i < 4; i++)
        {
            if (dataInstance.allResists[i] == 0)
            {
                allResists[i].text = "+0%";
            }
            else
            {
                allResists[i].text = "+" + ((1 - dataInstance.allResists[i]) * 100).ToString() + "%";
            }

            if (dataInstance.allVulnerabilities[i] == 0)
            {
                allVulnerabilities[i].text = "-0%";
            }
            else
            {
                allVulnerabilities[i].text = "+" + ((dataInstance.allVulnerabilities[i] - 1) * 100).ToString() + "%";
            }
        }
    }

    public void SelectClass()
    {
        if (!cardInstance.currentlyChoosingTarget)
        {
            currentlySelected = true;
        }
        else
        {
            cardInstance.targetSlot = dataInstance.currentPosition;
            cardInstance.currentlyChoosingTarget = false;
            cardInstance.foundTarget = true;
        }
    }

    public void DeselectClass()
    {
        currentlySelected = false;
    }

    public void EquipWeapon(int slotNum)
    {
        previousSlotNum = dataInstance.equippedSlotNum;

        if (dataInstance.allWeaponSlots[slotNum - 1].activeWeapon)
        {
            dataInstance.equippedSlotNum = slotNum;
        }

        OnDequip(previousSlotNum);
        OnEquip(slotNum);
    }

    public void OnEquip(int weaponSlotNum)
    {
        if (!dataInstance.allWeaponSlots[weaponSlotNum].passiveStats)
        {
            ResistVunlerabilityChange(weaponSlotNum, true);
            dataInstance.ChangeSpeed(dataInstance.allWeaponSlots[dataInstance.equippedSlotNum - 1].speedChange);
        }
    }

    public void OnDequip(int weaponSlotNum)
    {
        if (!dataInstance.allWeaponSlots[dataInstance.equippedSlotNum - 1].passiveStats)
        {
            ResistVunlerabilityChange(weaponSlotNum, false);
            dataInstance.ChangeSpeed(dataInstance.allWeaponSlots[dataInstance.equippedSlotNum - 1].speedChange * -1);
        }
    }

    public void PassiveEquip()
    {
        for (int i = 0; i < 4; i++)
        {
            if (dataInstance.allWeaponSlots[i].passiveStats)
            {
                ResistVunlerabilityChange(i, true);
            }
        }
    }

    public void ResistVunlerabilityChange(int slotNum, bool shouldIncrease)
    {
        dataInstance.ChangeResist(dataInstance.allWeaponSlots[slotNum - 1].bulletResist, "Bullet", shouldIncrease);
        dataInstance.ChangeResist(dataInstance.allWeaponSlots[slotNum - 1].fireResist, "Fire", shouldIncrease);
        dataInstance.ChangeResist(dataInstance.allWeaponSlots[slotNum - 1].explosiveResist, "Explosive", shouldIncrease);
        dataInstance.ChangeResist(dataInstance.allWeaponSlots[slotNum - 1].meleeResist, "Melee", shouldIncrease);

        dataInstance.ChangeVulnerability(dataInstance.allWeaponSlots[slotNum - 1].bulletVulnerability, "Bullet", shouldIncrease);
        dataInstance.ChangeVulnerability(dataInstance.allWeaponSlots[slotNum - 1].fireVulnerability, "Fire", shouldIncrease);
        dataInstance.ChangeVulnerability(dataInstance.allWeaponSlots[slotNum - 1].explosiveVulnerability, "Explosive", shouldIncrease);
        dataInstance.ChangeVulnerability(dataInstance.allWeaponSlots[slotNum - 1].meleeVulnerability, "Melee", shouldIncrease);
    }

    public void TempBuff(float resistIncrease, string damageType, bool shouldIncrease)
    {
        dataInstance.ChangeResist(resistIncrease, damageType, shouldIncrease);
    }
}
