using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.UI;
using UnityEngine.EventSystems;

public class EngineManager : MonoBehaviour
{

    public GameObject SelectedObject;

    private Color selectedColor = new Color(1f, 0.9f, 0.9f, 1f);

    private Color unselectedColor = new Color(0.9f, 1f, 0.9f, 1f);

    private bool isActive = true;


    public void switchVisibility()
    {
        EventSystem.current.currentSelectedGameObject.GetComponent<Image>().color = isActive ? selectedColor : unselectedColor;
        SelectedObject.SetActive(!isActive);
        isActive = !isActive;
    }


}
