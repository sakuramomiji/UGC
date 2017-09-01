using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class YawInstrument : MonoBehaviour {
    public bool isClockWise = true;
    public float value=0;
    public float valueOffset=0;
    public float trueValue=0;

    private float _value;
    RectTransform RT;
    Text text;
    void Awake()
    {
        RT = this.transform.FindChild("TextBar").GetComponent<RectTransform>();
        text = this.transform.Find("Text").GetComponent<Text>();
        _value = RT.position.x;
    }
	// Use this for initialization
	void Start () {
		
	}
     float TrueValue(float Value)
    {
        float v = Value;
        if (!isClockWise)
            v = -v;
        v += valueOffset;
        return v;
    }
	// Update is called once per frame
	void Update () {

        trueValue = TrueValue(value);
        text.text = String.Format("{0:F}", value);
        Vector3 v = RT. position;
        v.x = _value+ trueValue;
         RT.position = v;
        //print("x:"+ v.x);

    }
}
