using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChestUIScript : MonoBehaviour
{
    public GameObject inventoryPanel;
    public GameObject chestPanel;
    public void Load() 
    {
        foreach (UIPanelScript panelScript in gameObject.GetComponentsInChildren<UIPanelScript>())
        {
            panelScript.ShowItems();
        }
    }
}

