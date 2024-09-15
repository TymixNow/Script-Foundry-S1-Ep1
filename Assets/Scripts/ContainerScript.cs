using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ContainerScript : ClickScript
{
    public GameObject chestUI;
    public ushort containerSize;
    public List<ushort> contents;
    public byte containerKind;
    public ItemDatabaseScript database;

    public virtual void Remove(ushort index)
    {
        contents.RemoveAt(index);
    }
    public virtual bool Add(ushort itemID)
    {
        int space = containerSize;
        foreach (ushort item in contents)
        {
            space -= database.itemData[item].efficiencies[containerKind];
        }
        bool possible = space >= database.itemData[itemID].efficiencies[containerKind];
        if (possible)
        {
            contents.Add(itemID);
        }
        return possible;
    }
    public override void ClickAction()
    {
        chestUI.SetActive(true);
        chestUI.GetComponent<ChestUIScript>().chestPanel.GetComponent<UIPanelScript>().container = this;
        chestUI.GetComponent<ChestUIScript>().Load();
    }
}
