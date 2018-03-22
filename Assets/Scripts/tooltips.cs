using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class tooltips : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{

    public string tooltipText;
    private string displayedText = string.Empty;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnGUI()
    {
        GUI.color = Color.black;
        GUI.Label(new Rect(Input.mousePosition.x, Screen.height - Input.mousePosition.y + 20, displayedText.Length * 10, 20), displayedText);
    }


    public void OnPointerEnter(PointerEventData eventData)
    {
        displayedText = tooltipText;
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        displayedText = string.Empty;
    }
}
