using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class DisplayBattleUI : MonoBehaviour
{
    public ClassData dataInstance;

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

    // Start is called before the first frame update
    void Start()
    {
        originalHealth = dataInstance.currentHealth;
    }

    // Update is called once per frame
    void Update()
    {
        classBody.sprite = dataInstance.classSprite;
        healthbarFill.fillAmount = (dataInstance.currentHealth / originalHealth);

        if (currentlySelected)
        {
            //classBody.sprite = dataInstance.classSprite;

            className.text = dataInstance.className;
            classHealthNum.text = dataInstance.currentHealth.ToString();

            bulletResist.text = dataInstance.bulletResist.ToString() + "%";
            explosiveResist.text = dataInstance.explosiveResist.ToString() + "%";
            fireResist.text = dataInstance.fireResist.ToString() + "%";
            meleeResist.text = dataInstance.meleeResist.ToString() + "%";

            speedNum.text = "Speed \n" + dataInstance.currentSpeed.ToString();
            dodgeChance.text = "Dodge Chance \n" + (dataInstance.currentSpeed - 75).ToString() + "%";

            weaponTabImages[0].sprite = dataInstance.primarySlot.weaponImage;
            weaponTabImages[1].sprite = dataInstance.secondarySlot.weaponImage;
            weaponTabImages[2].sprite = dataInstance.meleeSlot.weaponImage;
            weaponTabImages[3].sprite = dataInstance.extraSlot.weaponImage;

            switch (dataInstance.equippedSlotNum)
            {
                case 1:
                    if (dataInstance.primarySlot.clipSize <= 0)
                    {
                        ammoCount.text = "Reload";
                    }
                    else
                    {
                        ammoCount.text = dataInstance.primarySlot.clipSize.ToString();
                    }
                    // ----------------------------------------------------------------
                    if (dataInstance.primarySlot.hasMeterBar)
                    {
                        chargeBarObject.SetActive(true);
                        chargeBarText.text = dataInstance.primarySlot.meterText;
                        chargeBar.fillAmount = (dataInstance.primaryMeterNum / dataInstance.primarySlot.maxMeterNum);
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
                    skillLogo1.sprite = dataInstance.equippedLogo1;
                    skillDescription1.text = dataInstance.equippedSkill1;

                    skillLogo2.sprite = dataInstance.equippedLogo2;
                    skillDescription2.text = dataInstance.equippedSkill2;
                    // ---------------------------------------------------------------
                    for (int i = 0; i < activeSkillChoices.Length; i++)
                    {
                        if (dataInstance.skillChoice1P == i)
                        {
                            activeSkillChoices[i].color = Color.white;
                        }
                        else if (dataInstance.skillChoice2P == i)
                        {
                            activeSkillChoices[i].color = Color.white;
                        }
                        else
                        {
                            activeSkillChoices[i].color = Color.black;
                        }
                    }


                    break;
                case 2:
                    if (dataInstance.secondarySlot.clipSize <= 0)
                    {
                        ammoCount.text = "Reload";
                    }
                    else
                    {
                        ammoCount.text = dataInstance.secondarySlot.clipSize.ToString();
                    }
                    // ----------------------------------------------------------------
                    if (dataInstance.secondarySlot.hasMeterBar)
                    {
                        chargeBarObject.SetActive(true);
                        chargeBarText.text = dataInstance.secondarySlot.meterText;
                        chargeBar.fillAmount = (dataInstance.secondaryMeterNum / dataInstance.secondarySlot.maxMeterNum);
                    }
                    else
                    {
                        chargeBarObject.SetActive(false);
                    }
                    // ----------------------------------------------------------------
                    weaponTabs[1].transform.localPosition = new Vector3(-360, (weaponTabs[1].transform.localPosition).y, (weaponTabs[1].transform.localPosition).z);

                    weaponTabs[0].transform.localPosition = new Vector3(-300, (weaponTabs[0].transform.localPosition).y, (weaponTabs[0].transform.localPosition).z);
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
                    skillLogo1.sprite = dataInstance.equippedLogo1;
                    skillDescription1.text = dataInstance.equippedSkill1;

                    skillLogo2.sprite = dataInstance.equippedLogo2;
                    skillDescription2.text = dataInstance.equippedSkill2;
                    // ---------------------------------------------------------------
                    for (int i = 0; i < activeSkillChoices.Length; i++)
                    {
                        if (dataInstance.skillChoice1S == i)
                        {
                            activeSkillChoices[i].color = Color.white;
                        }
                        else if (dataInstance.skillChoice2S == i)
                        {
                            activeSkillChoices[i].color = Color.white;
                        }
                        else
                        {
                            activeSkillChoices[i].color = Color.black;
                        }
                    }

                    break;
                case 3:
                    if (dataInstance.meleeSlot.clipSize <= 0)
                    {
                        ammoCount.text = "Reload";
                    }
                    else
                    {
                        ammoCount.text = dataInstance.meleeSlot.clipSize.ToString();
                    }
                    // ----------------------------------------------------------------
                    if (dataInstance.meleeSlot.hasMeterBar)
                    {
                        chargeBarObject.SetActive(true);
                        chargeBarText.text = dataInstance.meleeSlot.meterText;
                        chargeBar.fillAmount = (dataInstance.meleeMeterNum / dataInstance.meleeSlot.maxMeterNum);
                    }
                    else
                    {
                        chargeBarObject.SetActive(false);
                    }
                    // ----------------------------------------------------------------
                    weaponTabs[2].transform.localPosition = new Vector3(-360, (weaponTabs[2].transform.localPosition).y, (weaponTabs[2].transform.localPosition).z);

                    weaponTabs[0].transform.localPosition = new Vector3(-300, (weaponTabs[0].transform.localPosition).y, (weaponTabs[0].transform.localPosition).z);
                    weaponTabs[1].transform.localPosition = new Vector3(-300, (weaponTabs[1].transform.localPosition).y, (weaponTabs[1].transform.localPosition).z);
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
                    skillLogo1.sprite = dataInstance.equippedLogo1;
                    skillDescription1.text = dataInstance.equippedSkill1;

                    skillLogo2.sprite = dataInstance.equippedLogo2;
                    skillDescription2.text = dataInstance.equippedSkill2;
                    // ---------------------------------------------------------------
                    for (int i = 0; i < activeSkillChoices.Length; i++)
                    {
                        if (dataInstance.skillChoice1M == i)
                        {
                            activeSkillChoices[i].color = Color.white;
                        }
                        else if (dataInstance.skillChoice2M == i)
                        {
                            activeSkillChoices[i].color = Color.white;
                        }
                        else
                        {
                            activeSkillChoices[i].color = Color.black;
                        }
                    }

                    break;
                case 4:
                    if (dataInstance.showExtraSlot)
                    {
                        if (dataInstance.extraSlot.clipSize <= 0)
                        {
                            ammoCount.text = "Reload";
                        }
                        else
                        {
                            ammoCount.text = dataInstance.extraSlot.clipSize.ToString();
                        }
                        // ----------------------------------------------------------------
                        if (dataInstance.extraSlot.hasMeterBar)
                        {
                            chargeBarObject.SetActive(true);
                            chargeBarText.text = dataInstance.extraSlot.meterText;
                            chargeBar.fillAmount = (dataInstance.extraMeterNum / dataInstance.extraSlot.maxMeterNum);
                        }
                        else
                        {
                            chargeBarObject.SetActive(false);
                        }
                        // ----------------------------------------------------------------
                        weaponTabs[3].transform.localPosition = new Vector3(-360, (weaponTabs[3].transform.localPosition).y, (weaponTabs[3].transform.localPosition).z);

                        weaponTabs[0].transform.localPosition = new Vector3(-300, (weaponTabs[0].transform.localPosition).y, (weaponTabs[0].transform.localPosition).z);
                        weaponTabs[1].transform.localPosition = new Vector3(-300, (weaponTabs[1].transform.localPosition).y, (weaponTabs[1].transform.localPosition).z);
                        weaponTabs[2].transform.localPosition = new Vector3(-300, (weaponTabs[2].transform.localPosition).y, (weaponTabs[2].transform.localPosition).z);
                        // ---------------------------------------------------------------
                        skillLogo1.sprite = dataInstance.equippedLogo1;
                        skillDescription1.text = dataInstance.equippedSkill1;

                        skillLogo2.sprite = dataInstance.equippedLogo2;
                        skillDescription2.text = dataInstance.equippedSkill2;
                        // ---------------------------------------------------------------
                        for (int i = 0; i < activeSkillChoices.Length; i++)
                        {
                            if (dataInstance.skillChoice1E == i)
                            {
                                activeSkillChoices[i].color = Color.white;
                            }
                            else if (dataInstance.skillChoice2E == i)
                            {
                                activeSkillChoices[i].color = Color.white;
                            }
                            else
                            {
                                activeSkillChoices[i].color = Color.black;
                            }
                        }
                    }

                    break;
            }
        }
    }

    public void SelectClass()
    {
        currentlySelected = true;
    }

    public void DeselectClass()
    {
        currentlySelected = false;
    }

    public void EquipWeapon(int slotNum)
    {
        switch (slotNum)
        {
            case 1:
                if (dataInstance.primarySlot.activeWeapon)
                {
                    dataInstance.equippedSlotNum = slotNum;
                }
                break;
            case 2:
                if (dataInstance.secondarySlot.activeWeapon)
                {
                    dataInstance.equippedSlotNum = slotNum;
                }
                break;
            case 3:
                if (dataInstance.meleeSlot.activeWeapon)
                {
                    dataInstance.equippedSlotNum = slotNum;
                }
                break;
            case 4:
                if (dataInstance.extraSlot.activeWeapon)
                {
                    dataInstance.equippedSlotNum = slotNum;
                }
                break;
        }
    }

    public void SwitchValues()
    {

    }

    public void OnEquip(int weaponSlotNum)
    {

    }

    public void OnDequip(int weaponSlotNum)
    {
         
    }

    public void PassiveEquip() //idk how to do yet
    {

    }
}
