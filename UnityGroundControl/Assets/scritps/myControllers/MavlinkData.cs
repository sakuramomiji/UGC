using UnityEngine;


public class MavlinkData : MonoBehaviour {
    public MAVLink.MavlinkParse mavlink=new MAVLink.MavlinkParse();
    //数据流
    public MAVLink.mavlink_heartbeat_t planeHeartbeat;//#0 
    bool planeHeartbeatFlag = false;
    public MAVLink.mavlink_sys_status_t planeSysStatus;//#1
    public MAVLink.mavlink_system_time_t planeSystemTime;//#2
    public MAVLink.mavlink_scaled_imu_t planeScaledImu;//#26
    public MAVLink.mavlink_scaled_pressure_t planeScaledPressure;//#29
    public MAVLink.mavlink_attitude_t planeAttitude;//#30
    public MAVLink.mavlink_rc_channels_raw_t planeRcChannelsRaw;
    public MAVLink.mavlink_servo_output_raw_t planeServoOutputRaw;
    public MAVLink.mavlink_rc_channels_t planeRcChannels;//#26
    public MAVLink.mavlink_vfr_hud_t planeVfrHud;
    public MAVLink.mavlink_power_status_t planePowerStatus;
    public MAVLink.mavlink_sensor_offsets_t planeSensorOffsets;
    public MAVLink.mavlink_hwstatus_t planeHwstatus;//#165
    //应答
    public MAVLink.mavlink_data_stream_t planeAckDataStream; bool planeAckDataStreamFlag = false;
    public MAVLink.mavlink_command_ack_t planeAckCommand; bool planeAckCommandFlag = false;
    public MAVLink.mavlink_statustext_t planeAckStatusText; bool planeAckStatusTextFlag = false;
    //地面站发送
    public MAVLink.mavlink_heartbeat_t ugcHeartbeat;
    public MAVLink.mavlink_request_data_stream_t ugcRequestDataStream;
    public MAVLink.mavlink_manual_control_t ugcManualControl;
    public MAVLink.mavlink_command_long_t ugcCommandLong;

    public delegate void planeHeartBeatReceived(object sender);
    public delegate void planeAckDataStreamReceived(object sender);
    public delegate void planeAckCommandReceived(object sender);
    public delegate void planeAckStatusTextReceived(object sender);

    public event planeHeartBeatReceived PlaneHeartBeatReceived;
    public event planeAckDataStreamReceived PlaneAckDataStreamReceived;
    public event planeAckCommandReceived PlaneAckCommandReceived;
    public event planeAckStatusTextReceived PlaneAckStatusTextReceived;
    // Use this for initialization
    public object ReadPacketObj(byte[] data)
    {
        return mavlink.ReadPacketObj(data);
    }
    public byte[] GenerateMAVLinkPacket(MAVLink.MAVLINK_MSG_ID messageType,object indata)
    {
       return mavlink.GenerateMAVLinkPacket(messageType, indata);
    }
    void Awake()
    {
        ugcHeartbeat.type = 6;
        ugcHeartbeat.mavlink_version=3;
        ugcHeartbeat.base_mode = 192;
        ugcHeartbeat.autopilot = 6;
        ugcHeartbeat.custom_mode = 0;
        ugcHeartbeat.system_status = 4;

    }
    void Start () {
     
}
	
	// Update is called once per frame
	void Update ()
    {
        if (planeAckDataStreamFlag)
        {
            planeAckDataStreamFlag = false;
            if (PlaneAckDataStreamReceived != null)
                PlaneAckDataStreamReceived(planeAckDataStream);
        }
        if (planeAckCommandFlag)
        {
            planeAckCommandFlag = false;
            if (PlaneAckCommandReceived != null)
                PlaneAckCommandReceived(planeAckCommand);
        }
        if (planeAckDataStreamFlag)
        {
            planeAckStatusTextFlag = false;
            if (PlaneAckStatusTextReceived != null)
                PlaneAckStatusTextReceived(planeAckStatusText);
        }
        if(planeHeartbeatFlag)
        {
            planeHeartbeatFlag = false;
            if (PlaneHeartBeatReceived != null)
                PlaneHeartBeatReceived(planeHeartbeat);
        }

    }
    public void SetValue(object Object)
    {
        string type = Object.GetType().ToString();
        switch(type)
        { 
            case "MAVLink+mavlink_heartbeat_t": planeHeartbeat=(MAVLink . mavlink_heartbeat_t)Object; planeHeartbeatFlag = true; break;
            case "MAVLink+mavlink_sys_status_t": planeSysStatus = (MAVLink . mavlink_sys_status_t)Object; break;
            case "MAVLink+mavlink_system_time_t": planeSystemTime = (MAVLink . mavlink_system_time_t)Object; break;
            case "MAVLink+mavlink_scaled_imu_t": planeScaledImu = (MAVLink . mavlink_scaled_imu_t)Object; break;
            case "MAVLink+mavlink_scaled_pressure_t": planeScaledPressure = (MAVLink.mavlink_scaled_pressure_t)Object; break;
            case "MAVLink+mavlink_attitude_t": planeAttitude = (MAVLink . mavlink_attitude_t)Object; break;
            case "MAVLink+mavlink_rc_channels_raw_t": planeRcChannelsRaw=(MAVLink.mavlink_rc_channels_raw_t)Object; break;
            case "MAVLink+mavlink_servo_output_raw_t": planeServoOutputRaw=(MAVLink.mavlink_servo_output_raw_t)Object; break;
            case "MAVLink+mavlink_rc_channels_t": planeRcChannels=(MAVLink.mavlink_rc_channels_t)Object; break;
            case "MAVLink+mavlink_vfr_hud_t": planeVfrHud=(MAVLink . mavlink_vfr_hud_t)Object; break;
            case "MAVLink+mavlink_power_status_t": planePowerStatus=(MAVLink.mavlink_power_status_t)Object; break;
            case "MAVLink+mavlink_sensor_offsets_t":planeSensorOffsets = (MAVLink.mavlink_sensor_offsets_t)Object; break;
            case "MAVLink+mavlink_hwstatus_t": planeHwstatus = (MAVLink.mavlink_hwstatus_t)Object; break;

            case "MAVLink+mavlink_data_stream_t": planeAckDataStream=(MAVLink.mavlink_data_stream_t)Object; planeAckDataStreamFlag = true; ; break;
            case "MAVLink+mavlink_command_ack_t": planeAckCommand=(MAVLink.mavlink_command_ack_t)Object; planeAckCommandFlag = true; break;
            case "MAVLink+mavlink_statustext_t": planeAckStatusText=(MAVLink .mavlink_statustext_t)Object; planeAckStatusTextFlag = true; break;
        }
    }
}
