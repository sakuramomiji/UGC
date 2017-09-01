using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class CommunicationEvent
{
    MyUIHeader myUIHeader;
    MyUIControllers myUIControllers;
   

    public CommunicationEvent(MyUIHeader _myUIHeader)
    {
        myUIHeader = _myUIHeader;
        myUIControllers = myUIHeader.myUIControllers;
        EventRegister();

    }
    void EventRegister()
    {
        //注册事件
        myUIControllers.page_commucation.btn_Connect.onClick.AddListener(btn_Connect_onClick);//连接设备
        myUIControllers.page_commucation.btn_DisConnect.onClick.AddListener(btn_DisConnect_onClick);//断开设备
        myUIControllers.page_commucation.udp_px4.UDPPortDataReceived += Udp_px4_UDPPortDataReceived;//接收数据

        myUIControllers.page_mavlink.tmr_UGCHeartbeat.Tick += Tmr_UGCHeartbeat_Tick;//发送心跳包
        myUIControllers.page_mavlink.tmr_UGCManualControl.Tick += Tmr_UGCManualControl_Tick;//发送控制指令


    }

    void Tmr_UGCManualControl_Tick(object Sender)
    {
        MAVLink.mavlink_manual_control_t manual_control = myUIControllers.page_mavlink.data_Mavlink.ugcManualControl;
        manual_control.target = 1;
        switch (myUIControllers.page_input.itd_InputDevice.direction)
        {
            case InputDevice.Direction.Forward:
                manual_control.x = (short)myUIControllers.page_input.sld_Pitch.value;
                manual_control.y = (short)myUIControllers.page_input.sld_Roll.value;
                break;
            case InputDevice.Direction.Right:
                manual_control.x = (short)myUIControllers.page_input.sld_Roll.value;
                manual_control.y = (short)myUIControllers.page_input.sld_Pitch.value;
                break;
            case InputDevice.Direction.Back:
                manual_control.x = (short)-myUIControllers.page_input.sld_Pitch.value;
                manual_control.y = (short)-myUIControllers.page_input.sld_Roll.value;
                break;
            case InputDevice.Direction.Left:
                manual_control.x = (short)-myUIControllers.page_input.sld_Roll.value;
                manual_control.y = (short)-myUIControllers.page_input.sld_Pitch.value;
                break;
            default:
                manual_control.x = (short)myUIControllers.page_input.sld_Pitch.value;
                manual_control.y = (short)myUIControllers.page_input.sld_Roll.value;
                break;
        }


        manual_control.z = (short)myUIControllers.page_input.sld_Throttle.value;
        manual_control.r = (short)myUIControllers.page_input.sld_Yaw.value;

        manual_control.buttons = 0;
        if (myUIControllers.page_input.itd_InputDevice.buttonArm.isClick)
            manual_control.buttons += 64;
        if (myUIControllers.page_input.itd_InputDevice.buttonDisArm.isClick)
            manual_control.buttons += 16;
        if (myUIControllers.page_input.itd_InputDevice.buttonModel1Manual.isClick)
            manual_control.buttons += 2;
        if (myUIControllers.page_input.itd_InputDevice.buttonModel2Stablize.isClick)
            manual_control.buttons += 4;
        if (myUIControllers.page_input.itd_InputDevice.buttonModel3DepthHold .isClick)
            manual_control.buttons += 8;

        if (myUIControllers.page_input.itd_InputDevice.buttonLightBrighter .isClick)
            manual_control.buttons += 1024;
        if (myUIControllers.page_input.itd_InputDevice.buttonLightDimmer .isClick)
            manual_control.buttons += 512;
        //************//

        if (myUIControllers.page_input.itd_InputDevice.anxisGain.Value < -500)
        manual_control.buttons += 2048; 

        if (myUIControllers.page_input.itd_InputDevice.anxisGain.Value > 500)
        manual_control.buttons += 4096; 


        //************//
        //manual_control.x = (short)myUIControllers.page_input.itd_InputDevice. sld_Pitch.value;



        byte[] data = myUIControllers.page_mavlink.data_Mavlink.mavlink.GenerateMAVLinkPacket(MAVLink.MAVLINK_MSG_ID.MANUAL_CONTROL, manual_control);
        myUIControllers.page_commucation.udp_px4.SendData(data);

        //data.Clone
       // Debug.Log("**");
    }

    void Tmr_UGCHeartbeat_Tick(object Sender)
    {
        //GC.Collect();
        byte[] data = myUIControllers.page_mavlink.data_Mavlink.mavlink.GenerateMAVLinkPacket(MAVLink.MAVLINK_MSG_ID.HEARTBEAT, myUIControllers.page_mavlink.data_Mavlink.ugcHeartbeat);
        myUIControllers.page_commucation.udp_px4.SendData(data);
    }

    
    void Udp_px4_UDPPortDataReceived(byte[] data)
    {
     
        var  obj=myUIControllers.page_mavlink.data_Mavlink.ReadPacketObj(data);
        myUIControllers.page_mavlink.data_Mavlink.SetValue(obj);

    }
  

    void btn_Connect_onClick()
    {
        myUIControllers.appBar_title.lpi_ProgressBar.enabled = true;
        myUIControllers.page_commucation.itf_IPAddress.text = myUIControllers.page_commucation.udp_px4.getLocalIPAddress();

        string ipaddress= myUIControllers.page_commucation.itf_IPAddress.text;
        string ipport = myUIControllers.page_commucation.itf_IPPort.text;
        myUIControllers.page_commucation.udp_px4.SetLocalIPAddress(ipaddress);
        myUIControllers.page_commucation.udp_px4.SetLocalIPPort(ipport);

        myUIControllers.page_commucation.udp_px4.Connect();

        myUIControllers.page_mavlink.tmr_UGCHeartbeat.TimmerStart(1000);
        myUIControllers.page_mavlink.tmr_UGCManualControl.TimmerStart(200);


    }
    void btn_DisConnect_onClick()
    {
        myUIControllers.appBar_title.lpi_ProgressBar.enabled = false;
        myUIControllers.page_commucation.udp_px4.DisConnect();
        myUIControllers.page_mavlink.tmr_UGCHeartbeat.TimmerStop();
        myUIControllers.page_mavlink.tmr_UGCManualControl.TimmerStop();

      
    }
}
