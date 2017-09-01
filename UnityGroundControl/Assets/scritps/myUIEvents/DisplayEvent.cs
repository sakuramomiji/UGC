using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisplayEvent
{
    MyUIHeader myUIHeader;
    MyUIControllers myUIControllers;
    public DisplayEvent(MyUIHeader _myUIHeader)
    {
        myUIHeader = _myUIHeader;
        myUIControllers = myUIHeader.myUIControllers;
        EventRegister();
    }
    void EventRegister()
    {
        myUIControllers.page_mavlink.tmr_MavlinkUpdata.Flush += Tmr_MavlinkUpdata_Flush;

        myUIControllers.page_mavlink.data_Mavlink.PlaneHeartBeatReceived += Data_Mavlink_PlaneHeartBeatReceived;
        myUIControllers.page_mavlink.data_Mavlink.PlaneAckCommandReceived += Data_Mavlink_PlaneAckCommandReceived;
        myUIControllers.page_mavlink.data_Mavlink.PlaneAckDataStreamReceived += Data_Mavlink_PlaneAckDataStreamReceived;
        myUIControllers.page_mavlink.data_Mavlink.PlaneAckStatusTextReceived += Data_Mavlink_PlaneAckStatusTextReceived;
    }
    int Ack = 0;
    private void Data_Mavlink_PlaneAckStatusTextReceived(object sender)
    {
        Ack++;
        MAVLink.mavlink_statustext_t statustext = (MAVLink.mavlink_statustext_t)sender;
        int i = 0;
        string str = "ROV:\r\n";
        while (i < statustext.text.Length)
        {
            if (statustext.text[i] > 0)
                str += (char)statustext.text[i];
            i++;
        }
        str += "\r\n\r\n";
        if (Ack > 10)
        {
            myUIControllers.page_commucation.ipt_TextBox.text = "";
            Ack = 0;
                }
        myUIControllers.page_commucation.ipt_TextBox.text += str;
        
        //throw new System.NotImplementedException();
    }

    private void Data_Mavlink_PlaneAckDataStreamReceived(object sender)
    {
        Ack++;
        MAVLink.mavlink_data_stream_t data_stream= (MAVLink.mavlink_data_stream_t)sender;
        string str = "ROV:\r\n";
        str += "AckDataStreamReceived:\r\n";
        str += string.Format("on_off:{0}\r\n", data_stream.on_off);
        str += string.Format("stream_id:{0}\r\n", data_stream.stream_id);
        str += string.Format("message_rate:{0}\r\n", data_stream.message_rate);
        str += "\r\n";

        if (Ack > 10)
        {
            myUIControllers.page_commucation.ipt_TextBox.text = "";
            Ack = 0;
        }
        myUIControllers.page_commucation.ipt_TextBox.text += str;
    }

    private void Data_Mavlink_PlaneAckCommandReceived(object sender)
    {
        Ack++;
        MAVLink.mavlink_command_ack_t command_ack = (MAVLink.mavlink_command_ack_t)sender;
        string str = "ROV:\r\n";
        str += "AckCommandReceived:\r\n";
        str += string.Format("command:{1}({0})\r\n", command_ack.command,(MAVLink.MAV_CMD)command_ack.command);
        str += string.Format("result:{1}({0})\r\n", command_ack.result,(MAVLink.MAV_CMD_ACK)command_ack.result);
        str += "\r\n;";
        if (Ack > 10)
        {
            myUIControllers.page_commucation.ipt_TextBox.text = "";
            Ack = 0;
        }
        myUIControllers.page_commucation.ipt_TextBox.text += str;
    }

    int I = 0;
    private void Data_Mavlink_PlaneHeartBeatReceived(object sender)
    {
        /*if (myUIControllers.appBar_title.lpi_ProgressBar.enabled)
        {
            if (I <= 4) I++;
            float f = I; f = f / 3f;

            if (I <= 3) myUIControllers.appBar_title.lpi_ProgressBar.SetProgress(f);
            else myUIControllers.appBar_title.lpi_ProgressBar.enabled = false;
        }
        else I = 0;*/
    }

    void Tmr_MavlinkUpdata_Flush(object Sender)
    {
       
        if (myUIControllers.page_setting.swt_ObjControlEn.isOn)
        {
            simulateDisplay();
        }
        else
        {
            if (!myUIControllers.page_commucation.udp_px4.isDatareceived) return;
            onPage_status();
            onPage_mavlink();
            onFlyScreem();
            onArdusub();
            onHud();
            onAppBar();
        }
    }
    void onPage_status()
    {
        string str1 = "";
        string str2 = "";
        str1 += MAVlinkToString.Print(myUIControllers.page_mavlink.data_Mavlink.planeHeartbeat); str1 += "\r\n";
        str1 += MAVlinkToString.Print(myUIControllers.page_mavlink.data_Mavlink.planeAttitude); str1 += "\r\n";
        str1 += MAVlinkToString.Print(myUIControllers.page_mavlink.data_Mavlink.planeHwstatus); str1 += "\r\n";
        str1 += MAVlinkToString.Print(myUIControllers.page_mavlink.data_Mavlink.planePowerStatus); str1 += "\r\n";
        str1 += MAVlinkToString.Print(myUIControllers.page_mavlink.data_Mavlink.planeRcChannels); str1 += "\r\n";
        str1 += MAVlinkToString.Print(myUIControllers.page_mavlink.data_Mavlink.planeRcChannelsRaw); str1 += "\r\n";
        str1 += MAVlinkToString.Print(myUIControllers.page_mavlink.data_Mavlink.planeScaledImu); str1 += "\r\n";

        str2 += MAVlinkToString.Print(myUIControllers.page_mavlink.data_Mavlink.planeScaledPressure); str2 += "\r\n";
        str2 += MAVlinkToString.Print(myUIControllers.page_mavlink.data_Mavlink.planeSensorOffsets); str2 += "\r\n";
        str2 += MAVlinkToString.Print(myUIControllers.page_mavlink.data_Mavlink.planeServoOutputRaw); str2 += "\r\n";
        str2 += MAVlinkToString.Print(myUIControllers.page_mavlink.data_Mavlink.planeSysStatus); str2 += "\r\n";
        str2 += MAVlinkToString.Print(myUIControllers.page_mavlink.data_Mavlink.planeSystemTime); str2 += "\r\n";
        str2 += MAVlinkToString.Print(myUIControllers.page_mavlink.data_Mavlink.planeVfrHud); str2 += "\r\n";

        myUIControllers.page_status.txt_statues1.text = str1;
        myUIControllers.page_status.txt_statues2.text = str2;

    }
    void onPage_mavlink()
    {
        string str1 = "";
        string str2 = "";
        str1 += MAVlinkToString.Print(myUIControllers.page_mavlink.data_Mavlink.planeHeartbeat); str1 += "\r\n";
        str1 += MAVlinkToString.Print(myUIControllers.page_mavlink.data_Mavlink.planeAttitude); str1 += "\r\n";
        str1 += MAVlinkToString.Print(myUIControllers.page_mavlink.data_Mavlink.planeHwstatus); str1 += "\r\n";
        str1 += MAVlinkToString.Print(myUIControllers.page_mavlink.data_Mavlink.planePowerStatus); str1 += "\r\n";
        str1 += MAVlinkToString.Print(myUIControllers.page_mavlink.data_Mavlink.planeRcChannels); str1 += "\r\n";
        str1 += MAVlinkToString.Print(myUIControllers.page_mavlink.data_Mavlink.planeRcChannelsRaw); str1 += "\r\n";
        str1 += MAVlinkToString.Print(myUIControllers.page_mavlink.data_Mavlink.planeScaledImu); str1 += "\r\n";

        str2 += MAVlinkToString.Print(myUIControllers.page_mavlink.data_Mavlink.planeScaledPressure); str2 += "\r\n";
        str2 += MAVlinkToString.Print(myUIControllers.page_mavlink.data_Mavlink.planeSensorOffsets); str2 += "\r\n";
        str2 += MAVlinkToString.Print(myUIControllers.page_mavlink.data_Mavlink.planeServoOutputRaw); str2 += "\r\n";
        str2 += MAVlinkToString.Print(myUIControllers.page_mavlink.data_Mavlink.planeSysStatus); str2 += "\r\n";
        str2 += MAVlinkToString.Print(myUIControllers.page_mavlink.data_Mavlink.planeSystemTime); str2 += "\r\n";
        str2 += MAVlinkToString.Print(myUIControllers.page_mavlink.data_Mavlink.planeVfrHud); str2 += "\r\n";

        myUIControllers.page_mavlink.txt_Mavlink1.text = str1;
        myUIControllers.page_mavlink.txt_Mavlink2.text = str2;

    }
    void onFlyScreem()
    {

        MAVLink.mavlink_attitude_t attitute = myUIControllers.page_mavlink.data_Mavlink.planeAttitude;

        myUIControllers.flyScreem.fist_Roll.value = attitute.roll * 180 / Mathf.PI;
       
        myUIControllers.flyScreem.fist_Yaw.value = attitute.yaw * 180 / Mathf.PI;
        myUIControllers.flyScreem.fist_Pitch.value = attitute.pitch * 180 / Mathf.PI;
    }
    void onArdusub()
    {
        MAVLink.mavlink_attitude_t attitute = myUIControllers.page_mavlink.data_Mavlink.planeAttitude;

        myUIControllers.ardusub.Roll = (attitute.roll * 180 / Mathf.PI);
        myUIControllers.ardusub.Yaw = (attitute.yaw * 180 / Mathf.PI);
        myUIControllers.ardusub.Pitch = (attitute.pitch * 180 / Mathf.PI);
    }
    void onHud()
    {
        MAVLink.mavlink_attitude_t attitute = myUIControllers.page_mavlink.data_Mavlink.planeAttitude;
        MAVLink.mavlink_vfr_hud_t vfr_hud = myUIControllers.page_mavlink.data_Mavlink.planeVfrHud;
        MAVLink.mavlink_scaled_pressure_t scaled_pressure = myUIControllers.page_mavlink.data_Mavlink.planeScaledPressure;
        MAVLink.mavlink_power_status_t power_status = myUIControllers.page_mavlink.data_Mavlink.planePowerStatus;
        MAVLink.mavlink_statustext_t statustext = myUIControllers.page_mavlink.data_Mavlink.planeAckStatusText;
        string str = "";

        myUIControllers.hud.ist_Pitch.Value = (attitute.pitch * 180 / Mathf.PI);
        myUIControllers.hud.ist_Roll.Value = (attitute.roll * 180 / Mathf.PI);
        myUIControllers.hud.ist_Yaw.Value = (attitute.yaw * 180 / Mathf.PI);

        myUIControllers.hud.ist2_Alt.Value = vfr_hud.alt;


        float v;
        v = power_status.Vcc;
        str += string.Format("Vcc:{0:F}\r\n", v / 1000f);
        v = power_status.Vservo;
        str += string.Format("VS:{0:F}\r\n", v / 1000f);
        v = scaled_pressure.temperature;
        str += string.Format("Tempurature:{0:f}\r\n", v / 100f);
        str += string.Format("Climb:{0}\r\n", vfr_hud.climb);
        int V = vfr_hud.heading; if (V > 180) V = V - 360;
        
        str += string.Format("handing:{0}\r\n", V);
        str += string.Format("Throttle:{0}\r\n", vfr_hud.throttle);
        str += string.Format("Alt:{0}\r\n", vfr_hud.alt);
        str += string.Format("Airspeed:{0}\r\n", vfr_hud.airspeed);
        str += string.Format("Groundspeed:{0}\r\n", vfr_hud.groundspeed);

        str += string.Format("statustext{0}\r\n", ":"+chartoString( statustext.text));
        myUIControllers.hud.txt_HUDStatus.text = str;
    }
    string chartoString(byte[] data)
    {
       
        string str = "";
        int i = 0;
        if (data == null) return str;
            while (i < data.Length)
        {
            if (data[i] != 0)
                str += (char)data[i];
            i++;
        }
        return str;
    }
    void onAppBar()
    {
        MAVLink.mavlink_heartbeat_t heartbeat = myUIControllers.page_mavlink.data_Mavlink.planeHeartbeat;
        MAVLink.mavlink_power_status_t power_status = myUIControllers.page_mavlink.data_Mavlink.planePowerStatus; ;
        switch (heartbeat.custom_mode)
        {
            case 0: myUIControllers.appBar_title.txt_Model.text = "stabilize"; break;
            case 19: myUIControllers.appBar_title.txt_Model.text = "manual"; break;
            default: myUIControllers.appBar_title.txt_Model.text = ("mode default:"+ heartbeat.custom_mode.ToString()); break;
        }
        float v = power_status.Vservo;
        v = v / 1000f;
        myUIControllers.appBar_title.txt_Power.text = string.Format("Power:{0:F} V\r\n", v);
    }
    void simulateDisplay()
    {
        float Roll = myUIControllers.ardusub.ROV.localEulerAngles.z;
        float Yaw = myUIControllers.ardusub.ROV.eulerAngles.y;
        float Pitch = myUIControllers.ardusub.ROV.localEulerAngles.x;

        if (Roll > 180) Roll = Roll - 360;
        if (Yaw > 180) Yaw = Yaw - 360;
        if (Pitch > 180) Pitch = Pitch - 360;

        Roll = -Roll;

        myUIControllers.flyScreem.fist_Roll.value = Roll;

        myUIControllers.flyScreem.fist_Yaw.value = Yaw;
        myUIControllers.flyScreem.fist_Pitch.value = Pitch;


        myUIControllers.hud.ist_Pitch.Value = Pitch;
        myUIControllers.hud.ist_Roll.Value = Roll;
        myUIControllers.hud.ist_Yaw.Value = Yaw;

        myUIControllers.hud.ist2_Alt.Value = myUIControllers.ardusub.transform.position.y;

        myUIControllers.appBar_title.txt_Model.text = "Simulate";
    }
    
}