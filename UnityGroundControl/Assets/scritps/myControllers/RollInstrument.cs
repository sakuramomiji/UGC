using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RollInstrument : MonoBehaviour {
    public bool isClockWise = true;
    public float value = 0;
    public float valueOffset = 0;
    public float trueValue = 0;
    private float _value;
    RectTransform RT;
    Text text;
    float TrueValue(float Value)
    {
        float v = Value;
        if (!isClockWise)
            v = -v;
        v += valueOffset;
        return v;
    }
    // Use this for initialization
    void Awake()
    {
        RT = this.transform.Find("roller").GetComponent<RectTransform>();
        text = this.transform.Find("Text").GetComponent<Text>();
        _value = RT.eulerAngles.z;
    }
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        trueValue = TrueValue(value);
        text.text = String.Format("{0:F}", value);
        Vector3 v = RT.eulerAngles;
        v.z = _value + trueValue;
        RT.eulerAngles = v;
    }
}
