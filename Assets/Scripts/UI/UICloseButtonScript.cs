using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UICloseButtonScript : MonoBehaviour
{
    public void Close()
    {
        transform.parent.gameObject.SetActive(false);
    }
}
