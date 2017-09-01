using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Instrument : MonoBehaviour {

    public bool isClockWise;
    public float Value;
    float ClockValue;
    public float ValueOffset;
    Transform ClockWise;
    RectTransform rt;
    Text text;
    // Use this for initialization
    void Awake()
    {
        isClockWise = true;
        ClockWise = this.transform.FindChild("ClockWise");
        text = this.transform.FindChild("Text").GetComponent<Text>();
        rt = ClockWise.GetComponent<RectTransform>();
    }
    void Start() {
        // Debug.Log("ttt:"+rt.localRotation.z);
    }

    // Update is called once per frame
    void Update() {
        //Debug.Log("ttt:" + rt.localRotation.z);


        if (isClockWise) ClockValue = -Value;
        else ClockValue = Value;
        ClockValue += ValueOffset;
        // if (ClockValue > 180) ClockValue = 180;
        //  if (ClockValue < -180) ClockValue = -180;
        ClockValue = ClockValue % 360;
           /*

           Debug.Log("localRotation.z:" + rt.localRotation.z);
           Debug.Log("Rotation.z:" + rt.rotation.z);
           Debug.Log("eulerAngles.z:" + rt.eulerAngles.z);// yes
           */
           Vector3 v = rt.eulerAngles;
        v.z = ClockValue ;
        rt.eulerAngles = v;
        text.text = String.Format("{0:F}", Value);// System.Convert.ToString((int)ClockValue);
    }
}

