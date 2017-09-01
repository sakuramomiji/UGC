using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using MaterialUI;

public class AppBar_titleEvent {
    MyUIHeader myUIHeader;
    MyUIControllers myUIControllers;
    GameObject HUD;bool HUDFlag = false;int HUDX;
    GameObject SettingPages;bool SettingPagesFlag = false;int SettingPagesX;
    GameObject FlyScreem;bool FlyScreemFlag=true;float FlyScreemA;
    public AppBar_titleEvent(MyUIHeader MyUIHeader)
    {
        myUIHeader = MyUIHeader;
        myUIControllers = myUIHeader.myUIControllers;
        EventRegister();
    }
    void EventRegister()
    {
        myUIControllers.appBar_title.btn_OutWin.onClick.AddListener(btn_OutWin_onClick);//退出程序
        myUIControllers.appBar_title.btn_MinWin.onClick.AddListener(btn_MinWin_onClick);//窗体最小化
        myUIControllers.appBar_title.dpd_Menue.onItemSelected.AddListener(dpd_Menue_onItemSelected); //窗体选择
        HUD = GameObject.Find("HUD");HUDX = (int)HUD.transform.position.x;
        SettingPages = GameObject.Find("SettingPages"); SettingPagesX = (int)SettingPages.transform.position.x;
        FlyScreem = GameObject.Find("FlyScreem"); FlyScreemA = FlyScreem.GetComponent<Image>().color.a;
    }
    void btn_OutWin_onClick()
    {
        Application.Quit();
        
        //退出程序
    }
    void btn_MinWin_onClick()
    {
        
        //窗体最小化
    }
    void dpd_Menue_onItemSelected(int I)
    {
        //Debug.Log("**+" + I);
        switch (I)
        {
            case -1://
                {

                } break;
            case 0://hud
                {
                    HUDFlag = !HUDFlag;
                    if (SettingPagesFlag)
                    {
                        SettingPagesFlag = false;
                        FlyScreemFlag = true;
                    }
                } break;
            case 1://Page
                {
                    FlyScreemFlag = !FlyScreemFlag;
                    SettingPagesFlag = !SettingPagesFlag;
                    if (HUDFlag)
                    {
                        HUDFlag = false;
                    }
                } break;
            case 2://info
                {

                    //介绍对话框
                    string str = "Thank you for using this Program;\r\n It was made by GRZ from NJIT \r\n 2017-02-24";

                    DialogAlert d = DialogManager.CreateAlert();
                    d.bodyText.text = str;
                    d.titleSection.text.text = "Info";
                    
                    d.buttonSection.SetButtons(null, "ok", null, "cancle");
                    //d.buttonSection.SetButtons

                    d.Show();
                    /*
                    DialogManager.ShowAlert(
                       str, 
                        () => {
                         //   ToastManager.Show("You clicked the affirmative button");
                        }, 
                        "OK",
                        "Info",
                        MaterialIconHelper.GetIcon(MaterialIconEnum.INFO)
                        );*/

                }
                break;
        }
        if (SettingPagesFlag)
        {
            Vector3 v = SettingPages.transform.position;
             v.x = SettingPagesX - 1024;
             SettingPages.transform.GetComponent<RectTransform>().position = v;
        }
        else
        {
            Vector3 v = SettingPages.transform.position;
             v.x = SettingPagesX;
           SettingPages.transform.GetComponent<RectTransform>().position = v;
        }
        if (HUDFlag)
        {
            Vector3 v = HUD.transform.position;
          
            v.x = HUDX+300;
            HUD.transform.position = v;
        }
        else
        {
            Vector3 v = HUD.transform.position;
           
            v.x = HUDX;
            HUD.transform.position = v;
        }
        if (FlyScreemFlag)
        {
            Color c = FlyScreem.GetComponent<Image>().color;
            c.a = FlyScreemA;
            FlyScreem.GetComponent<Image>().color=c;
        }
        else
        {
            Color c = FlyScreem.GetComponent<Image>().color;
            c.a = 0;
            FlyScreem.GetComponent<Image>().color = c;
        }
    }
}
