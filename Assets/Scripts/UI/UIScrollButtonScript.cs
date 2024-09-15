using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIScrollButtonScript : MonoBehaviour
{
    public void Up()
    {
        gameObject.GetComponentInParent<UIPanelScript>().page--;
        gameObject.GetComponentInParent<UIPanelScript>().ShowItems();
    }
    public void Down()
    {
        gameObject.GetComponentInParent<UIPanelScript>().page++;
        gameObject.GetComponentInParent<UIPanelScript>().ShowItems();
    }
}
