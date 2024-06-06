using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToggleCategoryVisibility : MonoBehaviour
{
    public GameObject[] PantsGroup;
    public GameObject[] BootsGroup;
    public GameObject[] HatsGroup;
    public GameObject[] ShirtsGroup;

    public void TogglePants(bool isVisible)
    {
        SetVisibility(PantsGroup, isVisible);
    }

    public void ToggleBoots(bool isVisible)
    {
        SetVisibility(BootsGroup, isVisible);
    }

    public void ToggleHats(bool isVisible)
    {
        SetVisibility(HatsGroup, isVisible);
    }

    public void ToggleShirts(bool isVisible)
    {
        SetVisibility(ShirtsGroup, isVisible);
    }


    private void SetVisibility(GameObject[] items, bool isVisible)
    {
        foreach (GameObject item in items)
        {
            item.SetActive(isVisible);
        }
    }
}
