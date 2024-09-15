using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.Linq;
[ExecuteAlways]
public class ItemDatabaseScript : MonoBehaviour
{
    [SerializeField]
    public Sprite[] images;
    public TextAsset itemDataDocument;
    public List<string> containerKinds;
    public ItemData[] itemData;
    public void Start()
    {
        ObtainData();
    }
    public void Update()
    {
        if (!Application.IsPlaying(gameObject))
        {
            ObtainData();
        }
    }
    public void ObtainData()
    {
        itemData = new ItemData[ushort.MaxValue + 1];
        List<ItemDataJson> data = new();
        foreach (string line in itemDataDocument.text.Split("\n"))
        {
            data.Add(JsonUtility.FromJson<ItemDataJson>(line));
        }
        for (int i = 0; i < data.Count(); i++)
        {
            itemData[i] = new ItemData(data[i], images[i]);
        }
    }
}
