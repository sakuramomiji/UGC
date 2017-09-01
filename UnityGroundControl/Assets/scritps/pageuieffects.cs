using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
public class pageuieffects : MonoBehaviour {
    GameObject UIControllers;
    Slider PageUpDown;
    void Awake()
    {
        PageUpDown = this.transform.FindChild("PageUpDown").GetComponent<Slider>();
        UIControllers = this.transform.FindChild("UI Controllers").gameObject;
        PageUpDown.minValue = UIControllers.GetComponent<RectTransform>().anchoredPosition3D.y;
        /*GameObject[] uicontrollers=UIControllers.transform.ch
        int i = 0;
        float MaxValue = 0;
        while (i < UIControllers.transform.childCount)
        {
            float v = UIControllers.transform.GetChild(i).GetComponent<RectTransform>().sizeDelta.y - Screen.height;
            if (v < MaxValue)
                MaxValue = v;
            i++;
        }

        PageUpDown.maxValue = -MaxValue;
        */
        PageUpDown.maxValue = UIControllers.GetComponent<RectTransform>().sizeDelta.y-Screen.height-40;
        PageUpDown.onValueChanged.AddListener(PageUpDown_onValueChanged);
    }
    // Use this for initialization
    void Start () {
      


    }
	
	// Update is called once per frame
	void Update () {
		
	}
    void PageUpDown_onValueChanged(Single value)
    {
        Vector3 p = UIControllers.GetComponent<RectTransform>().anchoredPosition3D;
        p.y = value;
        UIControllers.GetComponent<RectTransform>().anchoredPosition3D = p;
    }
}
