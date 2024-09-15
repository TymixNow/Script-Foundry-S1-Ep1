using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UILeftPanelScript : AwakeScript
{
    public GameObject itemDisplayPrefab;
    public override void Reload()
    {
        float itemSize = itemDisplayPrefab.GetComponent<RectTransform>().rect.height;
        gameObject.GetComponent<UIPanelScript>().firstItemPosition = transform.TransformPoint(
            new Vector3
            (
                gameObject.GetComponent<RectTransform>().rect.xMax - gameObject.GetComponent<UIPanelScript>().itemSize,
                gameObject.GetComponent<RectTransform>().rect.yMax
            )
        ) + new Vector3(-(itemSize/2), -(itemSize/2));
    }
}
