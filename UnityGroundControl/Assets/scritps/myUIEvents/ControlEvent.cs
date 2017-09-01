using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using MaterialUI;
public class ControlEvent
{
    MyUIHeader myUIHeader;
    MyUIControllers myUIControllers;
    public ControlEvent(MyUIHeader _myUIHeader)
    {
        myUIHeader = _myUIHeader;
        myUIControllers = myUIHeader.myUIControllers;
        EventRegister();
    }
    void EventRegister()
    {
       
        //x
        myUIControllers.page_input.itd_InputDevice.anxisPitch.Initialization
            (
            "5thAnxis",
            KeyCode.I, KeyCode.K,
            myUIControllers.page_input.ipt_PitchMax,
            myUIControllers.page_input.ipt_PitchKeyMax,
            myUIControllers.page_input.ipt_PitchMid,
            1000,
            myUIControllers.page_input.sld_Pitch
            );
        //y
        myUIControllers.page_input.itd_InputDevice.anxisRoll .Initialization
            (
            "4thAnxis", 
            KeyCode.J, KeyCode.L,
            myUIControllers.page_input.ipt_RollMax,
            myUIControllers.page_input.ipt_RollKeyMax,
            myUIControllers.page_input.ipt_RollMid,
            1000,
            myUIControllers.page_input.sld_Roll
            );
        //z
        myUIControllers.page_input.itd_InputDevice.anxisThrottle.Initialization
            ("YAnxis",
             KeyCode.W, KeyCode.S,
            //-1000, -500, 1000, 0,
            myUIControllers.page_input.ipt_ThrottleMax,
            myUIControllers.page_input.ipt_ThrottleKeyMax,
            myUIControllers.page_input.ipt_ThrottleMid,
            1000,
            myUIControllers.page_input.sld_Throttle
            );
        //r
        myUIControllers.page_input.itd_InputDevice.anxisYaw .Initialization
            (
            "XAnxis",
              KeyCode.A, KeyCode.D,
            myUIControllers.page_input.ipt_YawMax,
            myUIControllers.page_input.ipt_YawKeyMax,
            myUIControllers.page_input.ipt_YawMid,
            1000,
            myUIControllers.page_input.sld_Yaw
            );
        myUIControllers.page_input.itd_InputDevice.anxisTrimPitch .Initialization
            ("7thAnxis", KeyCode.UpArrow, KeyCode.DownArrow,
            myUIControllers.page_input.ipt_TrimPitchMax,
            myUIControllers.page_input.ipt_TrimPitchKeyMax,
            myUIControllers.page_input.ipt_TrimPitchMid,
            1000,
            myUIControllers.page_input.sld_TrimPitch
            );
        myUIControllers.page_input.itd_InputDevice.anxisTrimRoll.Initialization
            ("6thAnxis", 
            KeyCode.LeftArrow,
            KeyCode.RightArrow,
            myUIControllers.page_input.ipt_TrimRollMax,
            myUIControllers.page_input.ipt_TrimRollKeyMax,
            myUIControllers.page_input.ipt_TrimRollMid,
            1000,
            myUIControllers.page_input.sld_TrimRoll
            );
        myUIControllers.page_input.itd_InputDevice.anxisGain .Initialization
            ("3thAnxis",
            KeyCode.KeypadPlus,
            KeyCode.KeypadMinus,
            1000f,
            1000f,
            1000f,
            0f,
            null//myUIControllers.page_input.sld_TrimRoll
            );

        myUIControllers.page_input.itd_InputDevice.buttonArm.Initialization(KeyCode.Joystick1Button7, KeyCode.Keypad9, myUIControllers.page_input.mbtn_Arm);
        myUIControllers.page_input.itd_InputDevice.buttonDisArm.Initialization(KeyCode.Joystick1Button6, KeyCode.Keypad0, myUIControllers.page_input.mbtn_DisArm);
        myUIControllers.page_input.itd_InputDevice.buttonLightBrighter .Initialization(KeyCode.Joystick1Button5, KeyCode.Keypad7, myUIControllers.page_input.mbtn_LightBrighter);
        myUIControllers.page_input.itd_InputDevice.buttonLightDimmer .Initialization(KeyCode.Joystick1Button4, KeyCode.Keypad8, myUIControllers.page_input.mbtn_LightDimmer);
        myUIControllers.page_input.itd_InputDevice.buttonModel1Manual.Initialization(KeyCode.Joystick1Button1, KeyCode.Keypad1, myUIControllers.page_input.mbtn_Model1);
        myUIControllers.page_input.itd_InputDevice.buttonModel2Stablize .Initialization(KeyCode.Joystick1Button2, KeyCode.Keypad2, myUIControllers.page_input.mbtn_Model2);
        myUIControllers.page_input.itd_InputDevice.buttonModel3DepthHold .Initialization(KeyCode.Joystick1Button3, KeyCode.Keypad3, myUIControllers.page_input.mbtn_Model3);

        myUIControllers.page_input.dpd_XAnxis.onItemSelected2.AddListener(dpd_Anxises_onItemSelected2);
        myUIControllers.page_input.dpd_YAnxis.onItemSelected2.AddListener(dpd_Anxises_onItemSelected2);
        myUIControllers.page_input.dpd_3thAnxis.onItemSelected2.AddListener(dpd_Anxises_onItemSelected2);
        myUIControllers.page_input.dpd_4thAnxis.onItemSelected2.AddListener(dpd_Anxises_onItemSelected2);
        myUIControllers.page_input.dpd_5thAnxis.onItemSelected2.AddListener(dpd_Anxises_onItemSelected2);
        myUIControllers.page_input.dpd_6thAnxis.onItemSelected2.AddListener(dpd_Anxises_onItemSelected2);
        myUIControllers.page_input.dpd_7thAnxis.onItemSelected2.AddListener(dpd_Anxises_onItemSelected2);

        myUIControllers.page_input.dpd_Button0.onItemSelected2.AddListener(dpd_Button0_onItemSelected2);
        myUIControllers.page_input.dpd_Button1.onItemSelected2.AddListener(dpd_Button0_onItemSelected2);
        myUIControllers.page_input.dpd_Button2.onItemSelected2.AddListener(dpd_Button0_onItemSelected2);
        myUIControllers.page_input.dpd_Button3.onItemSelected2.AddListener(dpd_Button0_onItemSelected2);
        myUIControllers.page_input.dpd_Button4.onItemSelected2.AddListener(dpd_Button0_onItemSelected2);
        myUIControllers.page_input.dpd_Button5.onItemSelected2.AddListener(dpd_Button0_onItemSelected2);
        myUIControllers.page_input.dpd_Button6.onItemSelected2.AddListener(dpd_Button0_onItemSelected2);
        myUIControllers.page_input.dpd_Button7.onItemSelected2.AddListener(dpd_Button0_onItemSelected2);

        myUIControllers.page_input.btn_anxisValueFlush.onClick.AddListener(btn_anxisValueFlush_onClick);
        myUIControllers.page_input.btn_northMain.onClick.AddListener(btn_northMain_onClick);
        myUIControllers.page_input.btn_southMain.onClick.AddListener(btn_southMain_onClick);
        myUIControllers.page_input.btn_eastMain.onClick.AddListener(btn_eastMain_onClick);
        myUIControllers.page_input.btn_westMain.onClick.AddListener(btn_westMain_onClick);


}
    void dpd_Anxises_onItemSelected2(object sender)
    {
        MaterialDropdown dpd = sender as MaterialDropdown;
        int i = dpd.currentlySelected;
        string anxis = dpd.transform.name.Split(new char[] { '_' }, System.StringSplitOptions.RemoveEmptyEntries)[1];
        //dpd.optionDataList.options[0].text

        if (i != 0)
        {
            myUIControllers.page_input.itd_InputDevice.anxises[i].AnxisName = anxis;
           
        }
        //Debug.Log(anxis + "***" + dpd.optionDataList.options[i].text+"||");
    }
    void dpd_Button0_onItemSelected2(object sender)
    {
        MaterialDropdown dpd = sender as MaterialDropdown;
        int i = dpd.currentlySelected;
        string button = dpd.transform.name.Split(new char[] { '_' }, System.StringSplitOptions.RemoveEmptyEntries)[1];
        if (i != 0)
        {
            switch (button)
            {
                case "Button0": myUIControllers.page_input.itd_InputDevice.keyButtons[i].First = KeyCode.Joystick1Button0; break;
                case "Button1": myUIControllers.page_input.itd_InputDevice.keyButtons[i].First = KeyCode.Joystick1Button1; break;
                case "Button2": myUIControllers.page_input.itd_InputDevice.keyButtons[i].First = KeyCode.Joystick1Button2; break;
                case "Button3": myUIControllers.page_input.itd_InputDevice.keyButtons[i].First = KeyCode.Joystick1Button3; break;
                case "Button4": myUIControllers.page_input.itd_InputDevice.keyButtons[i].First = KeyCode.Joystick1Button4; break;
                case "Button5": myUIControllers.page_input.itd_InputDevice.keyButtons[i].First = KeyCode.Joystick1Button5; break;
                case "Button6": myUIControllers.page_input.itd_InputDevice.keyButtons[i].First = KeyCode.Joystick1Button6; break;
                case "Button7": myUIControllers.page_input.itd_InputDevice.keyButtons[i].First = KeyCode.Joystick1Button7; break;
            }
        }
    }
    void btn_anxisValueFlush_onClick()
    {
        int i = 0;
        while (i < myUIControllers.page_input.itd_InputDevice.anxises.Count)
        {
            if (myUIControllers.page_input.itd_InputDevice.anxises[i] != null)
                myUIControllers.page_input.itd_InputDevice.anxises[i].ResetAnxisValue();
            i++;
        }
    }
    void btn_northMain_onClick()
    {
        myUIControllers.page_input.itd_InputDevice.direction = InputDevice.Direction.Forward;
    }
    void btn_southMain_onClick()
    { myUIControllers.page_input.itd_InputDevice.direction = InputDevice.Direction.Back; }
    void btn_eastMain_onClick()
    { myUIControllers.page_input.itd_InputDevice.direction = InputDevice.Direction.Right; }
    void btn_westMain_onClick()
    { myUIControllers.page_input.itd_InputDevice.direction = InputDevice.Direction.Left; }
  

}
