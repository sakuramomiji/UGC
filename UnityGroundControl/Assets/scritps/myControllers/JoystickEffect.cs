using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using MaterialUI;

public class JoystickEffect : MonoBehaviour {
    public string JoysickAxis = "null";
    public int JoysickButton = -1;
    float r;
    MaterialButton b;
    // Use this for initialization
    void Start()
    {
        b = this.gameObject.GetComponent<MaterialButton>();
        if(b!=null)
            r = b.textColor.r;
        
    }
    void show()
    {
        if (b == null) return;
        Color c = b.textColor;
        if (Mathf.Abs(Input.GetAxis(JoysickAxis) * 1000) < 50)
        {
          
            c.r = r;
         
        }
        else { c.r =r+ 100; }
        b.textColor = c;
    }
    void show(KeyCode K)
    {
        if (b == null) return;
        Color c = b.textColor;
        if (Input.GetKey(K))
        {

            c.r = 100+r;
        }
        else { c.r = r ; }
        b.textColor = c;
    }
    // Update is called once per frame
    void Update () {
        switch (JoysickAxis)
        {
            case "null":;break;
            case "XAnxis": show();break;
            case "YAnxis": show(); break;
            case "3thAnxis": show(); break;
            case "4thAnxis": show(); break;
            case "5thAnxis": show(); break;
            case "6thAnxis": show(); break;
            case "7thAnxis": show(); break;
        }
        switch (JoysickButton)
        {
            case -1:; break;
            case 0: show(KeyCode.JoystickButton0); break;
            case 1: show(KeyCode.JoystickButton1); break;
            case 2: show(KeyCode.JoystickButton2); break;
            case 3: show(KeyCode.JoystickButton3); break;
            case 4: show(KeyCode.JoystickButton4); break;
            case 5: show(KeyCode.JoystickButton5); break;
            case 6: show(KeyCode.JoystickButton6); break;
            case 7: show(KeyCode.JoystickButton7); break;
        }
    }
}
