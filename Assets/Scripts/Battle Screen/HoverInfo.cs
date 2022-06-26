using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class HoverInfo : MonoBehaviour
{
    public InfoBookButtons infoBookInstance;

    [Header("---For Gameobject---")]
    public GameObject hoverObject;

    public TextMeshProUGUI weaponName;
    public TextMeshProUGUI weaponDesc;

    [Header("---Where Mouse Activates It---")]
    public GameObject primarySlotArea;
    public GameObject secondarySlotArea;
    public GameObject meleeSlotArea;
    public GameObject extraSlotArea;

    private int hoveringSlot;

    // Start is called before the first frame update
    void Start()
    {
        hoverObject.GetComponent<Image>().color = new Vector4(255, 255, 255, 0);
        weaponName.color = new Vector4(0, 0, 0, 0);
        weaponDesc.color = new Vector4(0, 0, 0, 0);
    }

    // Update is called once per frame
    void Update()
    {
        MouseCheck();

        switch (hoveringSlot)
        {
            case 1:
                hoverObject.GetComponent<Image>().color = new Vector4(255, 255, 255, 255);
                weaponName.color = new Vector4(0, 0, 0, 255);
                weaponDesc.color = new Vector4(0, 0, 0, 255);

                weaponName.text = infoBookInstance.currentBattleUI.dataInstance.primarySlot.weaponName;
                weaponDesc.text = infoBookInstance.currentBattleUI.dataInstance.primarySlot.weaponDescription;
                break;
            case 2:
                hoverObject.GetComponent<Image>().color = new Vector4(255, 255, 255, 255);
                weaponName.color = new Vector4(0, 0, 0, 255);
                weaponDesc.color = new Vector4(0, 0, 0, 255);

                weaponName.text = infoBookInstance.currentBattleUI.dataInstance.secondarySlot.weaponName;
                weaponDesc.text = infoBookInstance.currentBattleUI.dataInstance.secondarySlot.weaponDescription;
                break;
            case 3:
                hoverObject.GetComponent<Image>().color = new Vector4(255, 255, 255, 255);
                weaponName.color = new Vector4(0, 0, 0, 255);
                weaponDesc.color = new Vector4(0, 0, 0, 255);

                weaponName.text = infoBookInstance.currentBattleUI.dataInstance.meleeSlot.weaponName;
                weaponDesc.text = infoBookInstance.currentBattleUI.dataInstance.meleeSlot.weaponDescription;
                break;
            case 4:
                hoverObject.GetComponent<Image>().color = new Vector4(255, 255, 255, 255);
                weaponName.color = new Vector4(0, 0, 0, 255);
                weaponDesc.color = new Vector4(0, 0, 0, 255);

                weaponName.text = infoBookInstance.currentBattleUI.dataInstance.extraSlot.weaponName;
                weaponDesc.text = infoBookInstance.currentBattleUI.dataInstance.extraSlot.weaponDescription;
                break;
            default:
                hoverObject.GetComponent<Image>().color = new Vector4(255, 255, 255, 0);
                weaponName.color = new Vector4(0, 0, 0, 0);
                weaponDesc.color = new Vector4(0, 0, 0, 0);
                break;
        }
    }

    public void MouseCheck()
    {
        if (Input.mousePosition.x < (primarySlotArea.transform.position.x + 25) && Input.mousePosition.x > (primarySlotArea.transform.position.x - 25)
            && Input.mousePosition.y < (primarySlotArea.transform.position.y + 25) && Input.mousePosition.y > (primarySlotArea.transform.position.y - 25) && primarySlotArea.activeInHierarchy)
        {
            hoveringSlot = 1;
        }
        else if (Input.mousePosition.x < (secondarySlotArea.transform.position.x + 25) && Input.mousePosition.x > (secondarySlotArea.transform.position.x - 25)
            && Input.mousePosition.y < (secondarySlotArea.transform.position.y + 25) && Input.mousePosition.y > (secondarySlotArea.transform.position.y - 25) && secondarySlotArea.activeInHierarchy)
        {
            hoveringSlot = 2;
        }
        else if (Input.mousePosition.x < (meleeSlotArea.transform.position.x + 25) && Input.mousePosition.x > (meleeSlotArea.transform.position.x - 25)
            && Input.mousePosition.y < (meleeSlotArea.transform.position.y + 25) && Input.mousePosition.y > (meleeSlotArea.transform.position.y - 25) && meleeSlotArea.activeInHierarchy)
        {
            hoveringSlot = 3;
        }
        else if (Input.mousePosition.x < (extraSlotArea.transform.position.x + 25) && Input.mousePosition.x > (extraSlotArea.transform.position.x - 25)
            && Input.mousePosition.y < (extraSlotArea.transform.position.y + 25) && Input.mousePosition.y > (extraSlotArea.transform.position.y - 25) && extraSlotArea.activeInHierarchy)
        {
            hoveringSlot = 4;
        }
        else
        {
            hoveringSlot = 0;
        }
    }
}
