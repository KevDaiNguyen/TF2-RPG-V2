using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HoverOnMouseEnter : MonoBehaviour
{
    public HoverInfo hoverInstance;
    public int slotNum;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnMouseOver()
    {
        hoverInstance.hoveringSlot = slotNum;
    }

    private void OnMouseExit()
    {
        hoverInstance.hoveringSlot = 0;
    }
}
