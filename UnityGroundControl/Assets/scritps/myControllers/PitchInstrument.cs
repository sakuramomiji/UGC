using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PitchInstrument : MonoBehaviour {

    public bool isClockWise = true;
    public float value = 0;
    public float valueOffset = 0;
    public float trueValue = 0;
    private float _value;
    RectTransform RT;
    Text text;
    // Use this for initialization
    void Awake () {
        RT = this.transform.Find("lines").GetComponent<RectTransform>();
        text = this.transform.Find("Text").GetComponent<Text>();
        _value = RT.position.y;
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
        text.text = String.Format("{0:F}", value);//.ToString();
        Vector3 v = RT.position;
        v.y = _value - 2*trueValue;
        RT.position = v;
    }
}
