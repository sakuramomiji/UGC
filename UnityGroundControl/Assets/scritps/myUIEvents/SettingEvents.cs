using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SettingEvents  {

    MyUIHeader myUIHeader;
    MyUIControllers myUIControllers;
    public SettingEvents(MyUIHeader _myUIHeader)
    {
        myUIHeader = _myUIHeader;
        myUIControllers = myUIHeader.myUIControllers;
        EventRegister();
    }
    void EventRegister()
    {
        myUIControllers.page_setting.swt_ObjControlEn.onValueChanged.AddListener(swt_ObjControlEn_onValueChanged);//是否启动仿真
    }
    void swt_ObjControlEn_onValueChanged(bool value)
    {
        myUIControllers.ardusub.isControl = value;
    }
}
