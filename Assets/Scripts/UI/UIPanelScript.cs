using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIPanelScript : MonoBehaviour
{
    public ItemDatabaseScript database;
    public GameObject itemDisplayPrefab;
    public int itemsPerPage;
    public int page;
    public Vector3 firstItemPosition;
    public float remainder;
    public float itemSize;
    public ContainerScript container;
    public UIPanelScript otherHalf;
    public void ShowItems()
    {
        foreach (UIItemDisplayScript displayScript in gameObject.GetComponentsInChildren<UIItemDisplayScript>())
        {
            displayScript.SelfDestruct();
        }
        
        itemSize = itemDisplayPrefab.GetComponent<RectTransform>().rect.height;
        remainder = gameObject.GetComponent<RectTransform>().rect.height % itemSize;
        itemsPerPage = (int)Mathf.Floor(gameObject.GetComponent<RectTransform>().rect.height / itemSize);


        int numPages = (int)Mathf.Ceil(container.GetComponent<ContainerScript>().contents.Count / (float)itemsPerPage);


        page = page >= numPages ? (numPages - 1) : page;
        page = page < 0 ? 0 : page;
        int itemIndex = 0;
        int itemsOnPage = Math.Min(container.GetComponent<ContainerScript>().contents.Count - (page * itemsPerPage), itemsPerPage);
        foreach (ushort item in container.contents.GetRange(page*itemsPerPage,itemsOnPage))
        {
            GameObject itemDisplayCopy = itemDisplayPrefab;
            itemDisplayCopy.GetComponent<UIItemDisplayScript>().itemID = item;
            itemDisplayCopy.GetComponent<UIItemDisplayScript>().database = database;
            itemDisplayCopy.GetComponent<UIItemDisplayScript>().index = (ushort)(itemIndex + (page * itemsPerPage));
            GameObject itemDisplayInstance = Instantiate(
                itemDisplayPrefab, 
                firstItemPosition + (Vector3.down * itemSize * itemIndex), 
                Quaternion.identity,
                gameObject.transform
            );
            itemDisplayInstance.GetComponent<UIItemDisplayScript>().Load();
            itemIndex++;
        }
    }
}
