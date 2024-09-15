using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class AwakeScript : MonoBehaviour
{
    public abstract void Reload();
    void Awake()
    {
        Reload();
    }
}
