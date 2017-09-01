using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Instrument2 : MonoBehaviour {

    public bool isUp;
    public float Value;
    public float Max;
    public float midValue;
    float HeightValue;
    float H;
    Transform UpDown;
    RectTransform rt;
    Text text;
    RawImage ri,ri2;
    //Color color;
    // Use this for initialization
    void Awake()
    {
        Max = 350;
        isUp = true;
        UpDown = this.transform.FindChild("UpDown");
        text = UpDown.transform.FindChild("Text").GetComponent<Text>();
        rt = UpDown.GetComponent<RectTransform>();
        midValue = rt.localPosition.y;
        ri = UpDown.GetComponent<RawImage>();
        ri2= UpDown.transform.FindChild("upDown").GetComponent<RawImage>();
        H = this.GetComponent<RectTransform>().rect.height-20;

        /*print("H:"+ this.GetComponent<RectTransform>().rect.height);
        print("W:" + this.GetComponent<RectTransform>().rect.width);
        print("x:" + this.GetComponent<RectTransform>().rect.x);
        print("xMax:" + this.GetComponent<RectTransform>().rect.xMax);
        print("xMin:" + this.GetComponent<RectTransform>().rect.xMin);
        print("y" + this.GetComponent<RectTransform>().rect.y);
        print("yMax:" + this.GetComponent<RectTransform>().rect.yMax);
        print("yMin:" + this.GetComponent<RectTransform>().rect.yMin);*/
       // print("H:" + this.GetComponent<RectTransform>().rect.);
       // print("W:" + this.GetComponent<RectTransform>().rect.width);

    }
    void Start () {
       
      
    }
	
	// Update is called once per frame
	void Update () {
         if (Value > Max) Value = Max;
         if (Value < -Max) Value = -Max;
         Vector3 p = rt.localPosition;


         HeightValue = Value / Max * H/2;
         p.y= midValue + HeightValue;
         rt.localPosition = p;
        Color color = ri.color;
        Color color2 = ri2.color;
        if (Value > 0) { color.r = Value / Max; color2.b = 0; }
        else if (Value == 0) { color.r = 0;color2.b = 0; }
        else { color2.b = -Value / Max; color.r=0; }
      
        ri.color = color;
        ri2.color = color2;

        text.text = String.Format("{0:F}", Value);
        /*
        Debug.Log("position.x:" + rt.position.x);
        Debug.Log("position.y:" + rt.position.y);
        Debug.Log("position.z:" + rt.position.z);
        Debug.Log("lposition.x:" + rt.localPosition.x);
        Debug.Log("lposition.y:" + rt.localPosition.y);
        Debug.Log("lposition.z:" + rt.localPosition.z);*/
    }
}
