using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIItemDisplayScript : MonoBehaviour
{
    public ushort itemID;
    public ushort index;
    public ItemDatabaseScript database;
    public void Load()
    {
        gameObject.GetComponent<Image>().sprite = database.itemData[itemID].image; 
    }
    public void ClickAction()
    {
        if (gameObject.GetComponentInParent<UIPanelScript>().otherHalf.container.Add(itemID))
            gameObject.GetComponentInParent<UIPanelScript>().container.Remove(index: index);
        gameObject.transform.parent.parent.gameObject.GetComponent<ChestUIScript>().Load();
    }
    public void SelfDestruct()
    {
        Destroy(gameObject);
    }
}
