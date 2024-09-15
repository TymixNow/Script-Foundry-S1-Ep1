using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

[Serializable]
public class ItemDataJson
{
    public string itemName;
    public List<byte> efficiencies;
}

public class ItemData
{

    public string itemName;
    public List<byte> efficiencies;
    public Sprite image;
    public ItemData(ItemDataJson data, Sprite image)
    {
        itemName = data.itemName;
        efficiencies = data.efficiencies;
        this.image = image;
    }
}