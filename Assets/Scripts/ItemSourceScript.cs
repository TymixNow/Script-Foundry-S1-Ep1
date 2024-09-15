using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemSourceScript : ContainerScript
{
    public override void Remove(ushort index)
    {
        return;
    }
    public override bool Add(ushort itemID)
    {
        return true;
    }
}
