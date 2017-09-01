using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


public class MAVlinkToString
{
    public static string bytedata(byte[] b)
    {
        string str = "";
        int i = 0;
        while (i < b.Length)
        {
            str += b[i] + " "; i++;
        }
        return str;
    }
   public  static string byteToString(byte[] b)
    {
        string str = "";
        try
        {
            str = System.Text.Encoding.Default.GetString(b);
        }
        catch { str = "switch error!";Console.WriteLine(str); }
        return str;
    }
    public static string byteToCharArray(byte[] b)
    {
        string str = "";
        int i = 0;
        while (i < b.Length)
        {
            if(b[i]!=0)
            //if((b[i]>=20&&b[i]<=126)||(b[i] >= 8 && b[i] <= 15))
                 str +=(char)b[i];
            i++;
            
        }
        return str;
    }
   static string TenTOTwo(uint K)
    {
        int i = 0;
        uint k = K; 
        string str = "";
        string ss = "";
        while (i < 24)
        {
            if (k % 2 == 1)
            { ss = "1"; }
            else
            { ss = "0"; }
            ss += str;
            str = ss;
            k = k / 2;

            i++;
            if (i % 4 == 0)
            {
                ss = " ";
                ss += str;
                str = ss;
            }
            
        }
        return str;
    }
    static public string Print(object obj)
    {
        
        int id = 0;
        string str = "";
        try
        {
            switch (obj.GetType().ToString())
            {
                case "MAVLink+mavlink_heartbeat_t"://0 //不能有空格
                    MAVLink.mavlink_heartbeat_t heartbeat = (MAVLink.mavlink_heartbeat_t)obj;
                    str += string.Format("#{0} {1}\r\n", id = (int)MAVLink.MAVLINK_MSG_ID.HEARTBEAT, "mavlink_heartbeat_t");
                    str += string.Format("type:{0}\r\n", heartbeat.type);
                    str += string.Format("autopilot:{0}\r\n", heartbeat.autopilot);
                    str += string.Format("base_mode:{0}\r\n", heartbeat.base_mode);
                    str += string.Format("custom_mode:{0}\r\n", heartbeat.custom_mode);
                    str += string.Format("system_status:{0}\r\n", heartbeat.system_status);
                    str += string.Format("mavlink_version:{0}\r\n", heartbeat.mavlink_version);
                    break;
                case "MAVLink+mavlink_sys_status_t"://1
                    MAVLink.mavlink_sys_status_t sys_status = (MAVLink.mavlink_sys_status_t)obj;
                    str += string.Format("#{0} {1}\r\n", id = (int)MAVLink.MAVLINK_MSG_ID.SYS_STATUS, "mavlink_sys_status_t");
                    str += string.Format("onboard_control_sensors_present:{0}\r\n", TenTOTwo(sys_status.onboard_control_sensors_present));
                    str += string.Format("onboard_control_sensors_enabled:{0}\r\n", TenTOTwo(sys_status.onboard_control_sensors_enabled));
                    //str += string.Format("onboard_control_sensors_enabled:{0}\r\n", System.Convert.ToString(sys_status.onboard_control_sensors_enabled,2));
                    str += string.Format("onboard_control_sensors_health :{0}\r\n", TenTOTwo(sys_status.onboard_control_sensors_health));
                    str += string.Format("load:{0}\r\n", sys_status.load);
                    str += string.Format("voltage_battery:{0}\r\n", sys_status.voltage_battery);
                    str += string.Format("current_battery:{0}\r\n", sys_status.current_battery);
                    str += string.Format("battery_remaining:{0}\r\n", sys_status.battery_remaining);
                    str += string.Format("drop_rate_comm:{0}\r\n", sys_status.drop_rate_comm);
                    str += string.Format("errors_comm:{0}\r\n", sys_status.errors_comm);
                    str += string.Format("errors_count1:{0}\r\n", sys_status.errors_count1);
                    str += string.Format("errors_count2:{0}\r\n", sys_status.errors_count2);
                    str += string.Format("errors_count3:{0}\r\n", sys_status.errors_count3);
                    str += string.Format("errors_count4:{0}\r\n", sys_status.errors_count4); ;
                    break;
                case "MAVLink+mavlink_system_time_t"://2
                    MAVLink.mavlink_system_time_t system_time = (MAVLink.mavlink_system_time_t)obj;
                    str += string.Format("#{0} {1}\r\n", id = (int)MAVLink.MAVLINK_MSG_ID.SYSTEM_TIME, "mavlink_system_time_t");
                    str += string.Format("time_unix_usec:{0}\r\n", system_time.time_unix_usec);
                    str += string.Format("time_boot_ms:{0}\r\n", system_time.time_boot_ms);
                    break;
                //3
                case "MAVLink+mavlink_ping_t"://4
                    MAVLink.mavlink_ping_t mavlink_ping = (MAVLink.mavlink_ping_t)obj;
                    str += string.Format("#{0} {1}\r\n", id = (int)MAVLink.MAVLINK_MSG_ID.PING, "mavlink_ping_t");
                    str += string.Format("time_usec:{0}\r\n", mavlink_ping.time_usec);
                    str += string.Format("seq:{0}\r\n", mavlink_ping.seq);
                    str += string.Format("target_system:{0}\r\n", mavlink_ping.target_system);
                    str += string.Format("target_component:{0}\r\n", mavlink_ping.target_component);
                    break;
                case "MAVLink+mavlink_change_operator_control_t"://5 //
                    MAVLink.mavlink_change_operator_control_t change_operator_control = (MAVLink.mavlink_change_operator_control_t)obj;
                    str += string.Format("#{0} {1}\r\n", id = (int)MAVLink.MAVLINK_MSG_ID.CHANGE_OPERATOR_CONTROL, "mavlink_change_operator_control_t");
                    str += string.Format("target_system:{0}\r\n", change_operator_control.target_system);
                    str += string.Format("control_request:{0}\r\n", change_operator_control.control_request);
                    str += string.Format("version:{0}\r\n", change_operator_control.version);
                    str += string.Format("passkey:{0}\r\n", bytedata(change_operator_control.passkey));
                    break;
                case "MAVLink+mavlink_change_operator_control_ack_t"://6 //
                    MAVLink.mavlink_change_operator_control_ack_t change_operator_control_ack = (MAVLink.mavlink_change_operator_control_ack_t)obj;
                    str += string.Format("#{0} {1}\r\n", id = (int)MAVLink.MAVLINK_MSG_ID.CHANGE_OPERATOR_CONTROL_ACK, "mavlink_change_operator_control_ack_t");
                    str += string.Format("gcs_system_id:{0}\r\n", change_operator_control_ack.gcs_system_id);
                    str += string.Format("control_request:{0}\r\n", change_operator_control_ack.control_request);
                    str += string.Format("ack:{0}\r\n", change_operator_control_ack.ack);
                    break;
                case "MAVLink+mavlink_auth_key_t"://7 //
                    MAVLink.mavlink_auth_key_t auth_key = (MAVLink.mavlink_auth_key_t)obj;
                    str += string.Format("#{0} {1}\r\n", id = (int)MAVLink.MAVLINK_MSG_ID.AUTH_KEY, "mavlink_auth_key_t");
                    str += string.Format("key:{0}\r\n",bytedata( auth_key.key));
                    break;
                case "MAVLink+mavlink_set_mode_t"://11 //
                    MAVLink.mavlink_set_mode_t set_mode = (MAVLink.mavlink_set_mode_t)obj;
                    str += string.Format("#{0} {1}\r\n", id = (int)MAVLink.MAVLINK_MSG_ID.SET_MODE, "mavlink_set_mode_t");
                    str += string.Format("target_system:{0}\r\n", set_mode.target_system);
                    str += string.Format("base_mode:{0}\r\n", set_mode.base_mode);
                    str += string.Format("custom_mode:{0}\r\n", set_mode.custom_mode);
                    break;
                case "MAVLink+mavlink_param_request_read_t"://20 //
                    MAVLink.mavlink_param_request_read_t param_request_read = (MAVLink.mavlink_param_request_read_t)obj;
                    str += string.Format("#{0} {1}\r\n", id = (int)MAVLink.MAVLINK_MSG_ID.PARAM_REQUEST_READ, "mavlink_param_request_read_t");
                    str += string.Format("target_system:{0}\r\n", param_request_read.target_system);
                    str += string.Format("target_component:{0}\r\n", param_request_read.target_component);
                    str += string.Format("param_id:{0}\r\n", byteToCharArray(param_request_read.param_id));
                    str += string.Format("param_index:{0}\r\n", param_request_read.param_index);
                    break;
                case "MAVLink+mavlink_param_request_list_t"://21 //
                    MAVLink.mavlink_param_request_list_t param_request_list = (MAVLink.mavlink_param_request_list_t)obj;
                    str += string.Format("#{0} {1}\r\n", id = (int)MAVLink.MAVLINK_MSG_ID.PARAM_REQUEST_LIST, "mavlink_param_request_loist_t");
                    str += string.Format("target_system:{0}\r\n", param_request_list. target_system);
                    str += string.Format("target_component:{0}\r\n", param_request_list.target_component);
                    break;
                case "MAVLink+mavlink_param_value_t"://22 //
                    MAVLink.mavlink_param_value_t param_value = (MAVLink.mavlink_param_value_t)obj;
                    str += string.Format("#{0} {1}\r\n", id = (int)MAVLink.MAVLINK_MSG_ID.PARAM_VALUE, "mavlink_param_value_t");
                    str += string.Format("param_id:{0}\r\n",byteToCharArray(param_value.param_id));
                    str += string.Format("param_value:{0}\r\n", param_value.param_value);
                    str += string.Format("param_type:{0}\r\n", param_value.param_type);
                    str += string.Format("param_count:{0}\r\n", param_value.param_count);
                    str += string.Format("param_index:{0}\r\n", param_value.param_index);
                    break;
                case "MAVLink+mavlink_param_set_t"://23 //
                    MAVLink.mavlink_param_set_t param_set = (MAVLink.mavlink_param_set_t)obj;
                    str += string.Format("#{0} {1}\r\n", id = (int)MAVLink.MAVLINK_MSG_ID.PARAM_SET, "mavlink_param_set_t");
                    str += string.Format("target_system:{0}\r\n", param_set.target_system);
                    str += string.Format("target_component:{0}\r\n", param_set.target_component);
                    str += string.Format("param_id:{0}\r\n", byteToCharArray(param_set.param_id));
                    str += string.Format("param_value:{0}\r\n", param_set.param_value);
                    str += string.Format("param_type:{0}\r\n", param_set.param_type);
                    break;
                case "MAVLink+mavlink_gps_raw_int_t"://24 //
                    MAVLink.mavlink_gps_raw_int_t gps_raw_int = (MAVLink.mavlink_gps_raw_int_t)obj;
                    str += string.Format("#{0} {1}\r\n", id = (int)MAVLink.MAVLINK_MSG_ID.GPS_RAW_INT, "mavlink_gps_raw_int_t");
                    str += string.Format("time_usec:{0}\r\n", gps_raw_int.time_usec);
                    str += string.Format("fix_type:{0}\r\n", gps_raw_int.fix_type);
                    str += string.Format("lat:{0}\r\n", gps_raw_int.lat);
                    str += string.Format("lon:{0}\r\n", gps_raw_int.lon);
                    str += string.Format("alt:{0}\r\n", gps_raw_int.alt);
                    str += string.Format("eph:{0}\r\n", gps_raw_int.eph);
                    str += string.Format("epv:{0}\r\n", gps_raw_int.epv);
                    str += string.Format("vel:{0}\r\n", gps_raw_int.vel);
                    str += string.Format("cog:{0}\r\n", gps_raw_int.cog);
                    str += string.Format("satellites_visible:{0}\r\n", gps_raw_int.satellites_visible);
                    break;
                case "MAVLink+mavlink_gps_status_t"://25 //
                    MAVLink.mavlink_gps_status_t gps_status = (MAVLink.mavlink_gps_status_t)obj;
                    str += string.Format("#{0} {1}\r\n", id = (int)MAVLink.MAVLINK_MSG_ID.GPS_STATUS, "mavlink_gps_status_t");
                    str += string.Format("satellites_visible:{0}\r\n", gps_status.satellites_visible);
                    str += string.Format("satellite_prn      :{0}\r\n", bytedata( gps_status.satellite_prn));
                    str += string.Format("satellite_used     :{0}\r\n",bytedata( gps_status.satellite_used));
                    str += string.Format("satellite_elevation:{0}\r\n", bytedata(gps_status.satellite_elevation));
                    str += string.Format("satellite_azimuth  :{0}\r\n", bytedata(gps_status.satellite_azimuth));
                    str += string.Format("satellite_snr      :{0}\r\n", bytedata(gps_status.satellite_snr));
                    break;
                case "MAVLink+mavlink_scaled_imu_t"://26 //
                    MAVLink.mavlink_scaled_imu_t scaled_imu = (MAVLink.mavlink_scaled_imu_t)obj;
                    str += string.Format("#{0} {1}\r\n", id = (int)MAVLink.MAVLINK_MSG_ID.SCALED_IMU, "mavlink_scaled_imu_t");
                    str += string.Format("time_boot_ms:{0}\r\n", scaled_imu.time_boot_ms);
                    str += string.Format("xacc:{0}\r\n", scaled_imu.xacc);
                    str += string.Format("yacc:{0}\r\n", scaled_imu.yacc);
                    str += string.Format("zacc:{0}\r\n", scaled_imu.zacc);
                    str += string.Format("xgyro:{0}\r\n", scaled_imu.xgyro);
                    str += string.Format("ygyro:{0}\r\n", scaled_imu.ygyro);
                    str += string.Format("zgyro:{0}\r\n", scaled_imu.zgyro);
                    str += string.Format("xmag:{0}\r\n", scaled_imu.xmag);
                    str += string.Format("ymag:{0}\r\n", scaled_imu.ymag);
                    str += string.Format("zmag:{0}\r\n", scaled_imu.zmag);
                    break;
                case "MAVLink+mavlink_raw_imu_t"://27
                    MAVLink.mavlink_raw_imu_t raw_imu = (MAVLink.mavlink_raw_imu_t)obj;
                    str += string.Format("#{0} {1}\r\n", id = (int)MAVLink.MAVLINK_MSG_ID.RAW_IMU, "mavlink_raw_imu_t");
                    str += string.Format("time_usec:{0}\r\n", raw_imu.time_usec);
                    str += string.Format("xacc:{0}\r\n", raw_imu.xacc);
                    str += string.Format("yacc:{0}\r\n", raw_imu.yacc);
                    str += string.Format("zacc:{0}\r\n", raw_imu.zacc);
                    str += string.Format("xgyro:{0}\r\n", raw_imu.xgyro);
                    str += string.Format("ygyro:{0}\r\n", raw_imu.ygyro);
                    str += string.Format("zgyro:{0}\r\n", raw_imu.zgyro);
                    str += string.Format("xmag:{0}\r\n", raw_imu.xmag);
                    str += string.Format("ymag:{0}\r\n", raw_imu.ymag);
                    str += string.Format("zmag:{0}\r\n", raw_imu.zmag);
                    break;
                case "MAVLink+mavlink_raw_pressure_t"://28 //
                    MAVLink.mavlink_raw_pressure_t raw_pressure = (MAVLink.mavlink_raw_pressure_t)obj;
                    str += string.Format("#{0} {1}\r\n", id = (int)MAVLink.MAVLINK_MSG_ID.RAW_PRESSURE, "mavlink_raw_pressure_t");
                    str += string.Format("time_usec:{0}\r\n", raw_pressure.time_usec);
                    str += string.Format("press_abs:{0}\r\n", raw_pressure.press_abs);
                    str += string.Format("press_diff1:{0}\r\n", raw_pressure.press_diff1);
                    str += string.Format("press_diff2:{0}\r\n", raw_pressure.press_diff2);
                    str += string.Format("temperature:{0}\r\n", raw_pressure.temperature);
                    break;
                case "MAVLink+mavlink_scaled_pressure_t"://29
                    MAVLink.mavlink_scaled_pressure_t scaled_pressure = (MAVLink.mavlink_scaled_pressure_t)obj;
                    str += string.Format("#{0} {1}\r\n", id = (int)MAVLink.MAVLINK_MSG_ID.SCALED_PRESSURE, "mavlink_scaled_pressure_t");
                    str += string.Format("time_boot_ms:{0}\r\n", scaled_pressure.time_boot_ms);
                    str += string.Format("press_abs:{0}\r\n", scaled_pressure.press_abs);
                    str += string.Format("press_diff:{0}\r\n", scaled_pressure.press_diff);
                    str += string.Format("temperature:{0}\r\n", scaled_pressure.temperature);
                    break;
                case "MAVLink+mavlink_attitude_t"://30 //
                    MAVLink.mavlink_attitude_t attitude = (MAVLink.mavlink_attitude_t)obj;
                    str += string.Format("#{0} {1}\r\n", id = (int)MAVLink.MAVLINK_MSG_ID.ATTITUDE, "mavlink_attitude_t");
                    str += string.Format("roll:{0}\r\n", attitude.roll);
                    str += string.Format("pitch:{0}\r\n", attitude.pitch);
                    str += string.Format("yaw:{0}\r\n", attitude.yaw);
                    str += string.Format("rollspeed:{0}\r\n", attitude.rollspeed);
                    str += string.Format("pitchspeed:{0}\r\n", attitude.pitchspeed);
                    str += string.Format("yawspeed:{0}\r\n", attitude.yawspeed);
                    str += string.Format("time_boot_ms:{0}\r\n", attitude.time_boot_ms);
                    break;
                case "MAVLink+mavlink_attitude_quaternion_t"://31 //
                    MAVLink.mavlink_attitude_quaternion_t attitude_quaternion = (MAVLink.mavlink_attitude_quaternion_t)obj;
                    str += string.Format("#{0} {1}\r\n", id = (int)MAVLink.MAVLINK_MSG_ID.ATTITUDE_QUATERNION, "mavlink_attitude_quaternion_t");
                    str += string.Format("time_boot_ms:{0}\r\n", attitude_quaternion.time_boot_ms);
                    str += string.Format("q1:{0}\r\n", attitude_quaternion.q1);
                    str += string.Format("q2:{0}\r\n", attitude_quaternion.q2);
                    str += string.Format("q3:{0}\r\n", attitude_quaternion.q3);
                    str += string.Format("q4:{0}\r\n", attitude_quaternion.q4);
                    str += string.Format("rollspeed:{0}\r\n", attitude_quaternion.rollspeed);
                    str += string.Format("pitchspeed:{0}\r\n", attitude_quaternion.pitchspeed);
                    str += string.Format("yawspeed:{0}\r\n", attitude_quaternion.yawspeed);
                    break;
                case "MAVLink+mavlink_local_position_ned_t"://32 //
                    MAVLink.mavlink_local_position_ned_t local_position_ned = (MAVLink.mavlink_local_position_ned_t)obj;
                    str += string.Format("#{0} {1}\r\n", id = (int)MAVLink.MAVLINK_MSG_ID.LOCAL_POSITION_NED, "mavlink_local_position_ned_t");
                    str += string.Format("time_boot_ms:{0}\r\n", local_position_ned.time_boot_ms);
                    str += string.Format("x:{0}\r\n", local_position_ned.x);
                    str += string.Format("y:{0}\r\n", local_position_ned.y);
                    str += string.Format("z:{0}\r\n", local_position_ned.z);
                    str += string.Format("vx:{0}\r\n", local_position_ned.vx);
                    str += string.Format("vy:{0}\r\n", local_position_ned.vy);
                    str += string.Format("vz:{0}\r\n", local_position_ned.vz);
                    break;
                case "MAVLink+mavlink_global_position_int_t"://33 //
                    MAVLink.mavlink_global_position_int_t global_position_int = (MAVLink.mavlink_global_position_int_t)obj;
                    str += string.Format("#{0} {1}\r\n", id = (int)MAVLink.MAVLINK_MSG_ID.GLOBAL_POSITION_INT, "mavlink_global_position_int_t");
                    str += string.Format("time_boot_ms:{0}\r\n", global_position_int.time_boot_ms);
                    str += string.Format("lat:{0}\r\n", global_position_int.lat);
                    str += string.Format("lon:{0}\r\n", global_position_int.lon);
                    str += string.Format("relative_alt:{0}\r\n", global_position_int.relative_alt);
                    str += string.Format("vx:{0}\r\n", global_position_int.vx);
                    str += string.Format("vy:{0}\r\n", global_position_int.vy);
                    str += string.Format("vz:{0}\r\n", global_position_int.vz);
                    str += string.Format("hdg:{0}\r\n", global_position_int.hdg);
                    str += string.Format("alt:{0}\r\n", global_position_int.alt);
                    break;
                case "MAVLink+mavlink_rc_channels_scaled_t"://34 //
                    MAVLink.mavlink_rc_channels_scaled_t rc_channels_scaled = (MAVLink.mavlink_rc_channels_scaled_t)obj;
                    str += string.Format("#{0} {1}\r\n", id = (int)MAVLink.MAVLINK_MSG_ID.RC_CHANNELS_SCALED, "mavlink_rc_channels_scaled_t");
                    str += string.Format("time_boot_ms:{0}\r\n", rc_channels_scaled.time_boot_ms);
                    str += string.Format("port:{0}\r\n", rc_channels_scaled.port);
                    str += string.Format("chan1_scaled:{0}\r\n", rc_channels_scaled.chan1_scaled);
                    str += string.Format("chan2_scaled:{0}\r\n", rc_channels_scaled.chan2_scaled);
                    str += string.Format("chan3_scaled:{0}\r\n", rc_channels_scaled.chan3_scaled);
                    str += string.Format("chan4_scaled:{0}\r\n", rc_channels_scaled.chan4_scaled);
                    str += string.Format("chan5_scaled:{0}\r\n", rc_channels_scaled.chan5_scaled);
                    str += string.Format("chan6_scaled:{0}\r\n", rc_channels_scaled.chan6_scaled);
                    str += string.Format("chan7_scaled:{0}\r\n", rc_channels_scaled.chan7_scaled);
                    str += string.Format("chan8_scaled:{0}\r\n", rc_channels_scaled.chan8_scaled);
                    str += string.Format("rssi:{0}\r\n", rc_channels_scaled.rssi);
                    break;
                case "MAVLink+mavlink_rc_channels_raw_t"://35 //
                    MAVLink.mavlink_rc_channels_raw_t rc_channels_raw = (MAVLink.mavlink_rc_channels_raw_t)obj;
                    str += string.Format("#{0} {1}\r\n", id = (int)MAVLink.MAVLINK_MSG_ID.RC_CHANNELS_RAW, "mavlink_rc_channels_raw_t");
                    str += string.Format("time_boot_ms:{0}\r\n", rc_channels_raw.time_boot_ms);
                    str += string.Format("port:{0}\r\n", rc_channels_raw.port);
                    str += string.Format("chan1_raw:{0}\r\n", rc_channels_raw.chan1_raw);
                    str += string.Format("chan2_raw:{0}\r\n", rc_channels_raw.chan2_raw);
                    str += string.Format("chan3_raw:{0}\r\n", rc_channels_raw.chan3_raw);
                    str += string.Format("chan4_raw:{0}\r\n", rc_channels_raw.chan4_raw);
                    str += string.Format("chan5_raw:{0}\r\n", rc_channels_raw.chan5_raw);
                    str += string.Format("chan6_raw:{0}\r\n", rc_channels_raw.chan6_raw);
                    str += string.Format("chan7_raw:{0}\r\n", rc_channels_raw.chan7_raw);
                    str += string.Format("chan8_raw:{0}\r\n", rc_channels_raw.chan8_raw);
                    str += string.Format("rssi:{0}\r\n", rc_channels_raw.rssi);
                    break;
                case "MAVLink+mavlink_servo_output_raw_t"://36 //
                    MAVLink.mavlink_servo_output_raw_t servo_output_raw = (MAVLink.mavlink_servo_output_raw_t)obj;
                    str += string.Format("#{0} {1}\r\n", id = (int)MAVLink.MAVLINK_MSG_ID.SERVO_OUTPUT_RAW, "mavlink_servo_output_raw_t");
                    str += string.Format("time_usec:{0}\r\n", servo_output_raw.time_usec);
                    str += string.Format("port:{0}\r\n", servo_output_raw.port);
                    str += string.Format("servo1_raw:{0}\r\n", servo_output_raw.servo1_raw);
                    str += string.Format("servo2_raw:{0}\r\n", servo_output_raw.servo2_raw);
                    str += string.Format("servo3_raw:{0}\r\n", servo_output_raw.servo3_raw);
                    str += string.Format("servo4_raw:{0}\r\n", servo_output_raw.servo4_raw);
                    str += string.Format("servo5_raw:{0}\r\n", servo_output_raw.servo5_raw);
                    str += string.Format("servo6_raw:{0}\r\n", servo_output_raw.servo6_raw);
                    str += string.Format("servo7_raw:{0}\r\n", servo_output_raw.servo7_raw);
                    str += string.Format("servo8_raw:{0}\r\n", servo_output_raw.servo8_raw);
                   /* str += string.Format("servo9_raw:{0}\r\n", servo_output_raw.servo9_raw);
                    str += string.Format("servo10_raw:{0}\r\n", servo_output_raw.servo10_raw);
                    str += string.Format("servo11_raw:{0}\r\n", servo_output_raw.servo11_raw);
                    str += string.Format("servo12_raw:{0}\r\n", servo_output_raw.servo12_raw);
                    str += string.Format("servo13_raw:{0}\r\n", servo_output_raw.servo13_raw);
                    str += string.Format("servo14_raw:{0}\r\n", servo_output_raw.servo14_raw);
                    str += string.Format("servo15_raw:{0}\r\n", servo_output_raw.servo15_raw);
                    str += string.Format("servo16_raw:{0}\r\n", servo_output_raw.servo16_raw);*/
                    break;
                case "MAVLink+mavlink_mission_request_partial_list_t"://37 //
                    MAVLink.mavlink_mission_request_partial_list_t mission_request_partial_list = (MAVLink.mavlink_mission_request_partial_list_t)obj;
                    str += string.Format("#{0} {1}\r\n", id = (int)MAVLink.MAVLINK_MSG_ID.MISSION_REQUEST_PARTIAL_LIST, "mavlink_mission_request_partial_list_t");
                    str += string.Format("target_system:{0}\r\n", mission_request_partial_list.target_system);
                    str += string.Format("target_component:{0}\r\n", mission_request_partial_list.target_component);
                    str += string.Format("start_index:{0}\r\n", mission_request_partial_list.start_index);
                    str += string.Format("end_index:{0}\r\n", mission_request_partial_list.end_index);
                    break;
                case "MAVLink+mavlink_mission_write_partial_list_t"://38 //
                    MAVLink.mavlink_mission_write_partial_list_t mission_write_partial_list = (MAVLink.mavlink_mission_write_partial_list_t)obj;
                    str += string.Format("#{0} {1}\r\n", id = (int)MAVLink.MAVLINK_MSG_ID.MISSION_WRITE_PARTIAL_LIST, "mavlink_mission_write_partial_list_t");
                    str += string.Format("target_system:{0}\r\n", mission_write_partial_list.target_system);
                    str += string.Format("target_component:{0}\r\n", mission_write_partial_list.target_component);
                    str += string.Format("start_index:{0}\r\n", mission_write_partial_list.start_index);
                    str += string.Format("end_index:{0}\r\n", mission_write_partial_list.end_index);
                    break;
                case "MAVLink+mavlink_mission_item_t"://39 //
                    MAVLink.mavlink_mission_item_t mission_item = (MAVLink.mavlink_mission_item_t)obj;
                    str += string.Format("#{0} {1}\r\n", id = (int)MAVLink.MAVLINK_MSG_ID.MISSION_ITEM, "mavlink_mission_item_t");
                    str += string.Format("target_system:{0}\r\n", mission_item.target_system);
                    str += string.Format("target_component:{0}\r\n", mission_item.target_component);
                    str += string.Format("seq:{0}\r\n", mission_item.seq);
                    str += string.Format("frame:{0}\r\n", mission_item.frame);
                    str += string.Format("command:{0}\r\n", mission_item.command);
                    str += string.Format("current:{0}\r\n", mission_item.current);
                    str += string.Format("autocontinue:{0}\r\n", mission_item.autocontinue);
                    str += string.Format("param1:{0}\r\n", mission_item.param1);
                    str += string.Format("param2:{0}\r\n", mission_item.param2);
                    str += string.Format("param3:{0}\r\n", mission_item.param3);
                    str += string.Format("param4:{0}\r\n", mission_item.param4);
                    str += string.Format("x:{0}\r\n", mission_item.x);
                    str += string.Format("y:{0}\r\n", mission_item.y);
                    str += string.Format("z:{0}\r\n", mission_item.z);
                    break;
                case "MAVLink+mavlink_mission_request_t"://40 //
                    MAVLink.mavlink_mission_request_t mission_request = (MAVLink.mavlink_mission_request_t)obj;
                    str += string.Format("#{0} {1}\r\n", id = (int)MAVLink.MAVLINK_MSG_ID.MISSION_REQUEST, "mavlink_mission_request_t");
                    str += string.Format("target_system:{0}\r\n", mission_request.target_system);
                    str += string.Format("target_component:{0}\r\n", mission_request.target_component);
                    str += string.Format("seq:{0}\r\n", mission_request.seq);
                    break;
                case "MAVLink+mavlink_mission_set_current_t"://41 //
                    MAVLink.mavlink_mission_set_current_t mission_set_current = (MAVLink.mavlink_mission_set_current_t)obj;
                    str += string.Format("#{0} {1}\r\n", id = (int)MAVLink.MAVLINK_MSG_ID.MISSION_SET_CURRENT, "mavlink_mission_set_current_t");
                    str += string.Format("target_system:{0}\r\n", mission_set_current.target_system);
                    str += string.Format("target_component:{0}\r\n", mission_set_current.target_component);
                    str += string.Format("seq:{0}\r\n", mission_set_current.seq);
                    break;
                case "MAVLink+mavlink_mission_current_t"://42
                    MAVLink.mavlink_mission_current_t mission_current = (MAVLink.mavlink_mission_current_t)obj;
                    str += string.Format("#{0} {1}\r\n", id = (int)MAVLink.MAVLINK_MSG_ID.MISSION_CURRENT, "mavlink_mission_current_t");
                    str += string.Format("seq:{0}\r\n", mission_current.seq);
                    break;
                case "MAVLink+mavlink_mission_request_list_t"://43 //
                    MAVLink.mavlink_mission_request_list_t mission_request_list = (MAVLink.mavlink_mission_request_list_t)obj;
                    str += string.Format("#{0} {1}\r\n", id = (int)MAVLink.MAVLINK_MSG_ID.MISSION_REQUEST_LIST, "mavlink_mission_request_list_t");
                    str += string.Format("target_system:{0}\r\n", mission_request_list.target_system);
                    str += string.Format("target_component:{0}\r\n", mission_request_list.target_component);
                    break;
                case "MAVLink+mavlink_mission_count_t"://44 //
                    MAVLink.mavlink_mission_count_t mission_count = (MAVLink.mavlink_mission_count_t)obj;
                    str += string.Format("#{0} {1}\r\n", id = (int)MAVLink.MAVLINK_MSG_ID.MISSION_COUNT, "mavlink_mission_count_t");
                    str += string.Format("target_system:{0}\r\n", mission_count.target_system);
                    str += string.Format("target_component:{0}\r\n", mission_count.target_component);
                    str += string.Format("count:{0}\r\n", mission_count.count);
                    break;
                case "MAVLink+mavlink_mission_clear_all_t"://45 //
                    MAVLink.mavlink_mission_clear_all_t mission_clear_all = (MAVLink.mavlink_mission_clear_all_t)obj;
                    str += string.Format("#{0} {1}\r\n", id = (int)MAVLink.MAVLINK_MSG_ID.MISSION_CLEAR_ALL, "mavlink_mission_clear_all_t");
                    str += string.Format("target_system:{0}\r\n", mission_clear_all.target_system);
                    str += string.Format("target_component:{0}\r\n", mission_clear_all.target_component);
                    break;
                case "MAVLink+mavlink_mission_item_reached_t"://46 //
                    MAVLink.mavlink_mission_item_reached_t mission_item_reached = (MAVLink.mavlink_mission_item_reached_t)obj;
                    str += string.Format("#{0} {1}\r\n", id = (int)MAVLink.MAVLINK_MSG_ID.MISSION_ITEM_REACHED, "mavlink_mission_item_reached_t");
                    str += string.Format("seq:{0}\r\n", mission_item_reached.seq);
                    break;
                case "MAVLink+mavlink_mission_ack_t"://47 //
                    MAVLink.mavlink_mission_ack_t mission_ack = (MAVLink.mavlink_mission_ack_t)obj;
                    str += string.Format("#{0} {1}\r\n", id = (int)MAVLink.MAVLINK_MSG_ID.MISSION_ACK, "mavlink_mission_ack_t");
                    str += string.Format("target_system:{0}\r\n", mission_ack.target_system);
                    str += string.Format("target_component:{0}\r\n", mission_ack.target_component);
                    str += string.Format("type:{0}\r\n", mission_ack.type);
                    break;
                case "MAVLink+mavlink_set_gps_global_origin_t"://48 //
                    MAVLink.mavlink_set_gps_global_origin_t set_gps_global_origin = (MAVLink.mavlink_set_gps_global_origin_t)obj;
                    str += string.Format("#{0} {1}\r\n", id = (int)MAVLink.MAVLINK_MSG_ID.SET_GPS_GLOBAL_ORIGIN, "mavlink_set_gps_global_origin_t");
                    str += string.Format("target_system:{0}\r\n", set_gps_global_origin.target_system);
                    str += string.Format("latitude:{0}\r\n", set_gps_global_origin.latitude);
                    str += string.Format("longitude:{0}\r\n", set_gps_global_origin.longitude);
                    str += string.Format("altitude:{0}\r\n", set_gps_global_origin.altitude);
                    break;
                case "MAVLink+mavlink_gps_global_origin_t"://49 //
                    MAVLink.mavlink_gps_global_origin_t gps_global_origin = (MAVLink.mavlink_gps_global_origin_t)obj;
                    str += string.Format("#{0} {1}\r\n", id = (int)MAVLink.MAVLINK_MSG_ID.GPS_GLOBAL_ORIGIN, "mavlink_gps_global_origin_t");
                    str += string.Format("latitude:{0}\r\n", gps_global_origin.latitude);
                    str += string.Format("longitude:{0}\r\n", gps_global_origin.longitude);
                    str += string.Format("altitude:{0}\r\n", gps_global_origin.altitude);
                    break;
                case "MAVLink+mavlink_param_map_rc_t"://50 //
                    MAVLink.mavlink_param_map_rc_t param_map_rc = (MAVLink.mavlink_param_map_rc_t)obj;
                    str += string.Format("#{0} {1}\r\n", id = (int)MAVLink.MAVLINK_MSG_ID.PARAM_MAP_RC, "mavlink_param_map_rc_t");
                    str += string.Format("target_system:{0}\r\n", param_map_rc.target_system);
                    str += string.Format("target_component:{0}\r\n", param_map_rc.target_component);
                    str += string.Format("param_id:{0}\r\n",byteToCharArray( param_map_rc.param_id));
                    str += string.Format("param_index:{0}\r\n", param_map_rc.param_index);
                    str += string.Format("parameter_rc_channel_index:{0}\r\n", param_map_rc.parameter_rc_channel_index);
                    str += string.Format("param_value0:{0}\r\n", param_map_rc.param_value0);
                    str += string.Format("scale:{0}\r\n", param_map_rc.scale);
                    str += string.Format("param_value_min:{0}\r\n", param_map_rc.param_value_min);
                    str += string.Format("param_value_max:{0}\r\n", param_map_rc.param_value_max);
                    break;
               //51~53
                case "MAVLink+mavlink_safty_set_allowed_area_t"://54 //
                    MAVLink.mavlink_safety_set_allowed_area_t  safty_set_allowed_area = (MAVLink.mavlink_safety_set_allowed_area_t)obj;
                    str += string.Format("#{0} {1}\r\n", id = (int)MAVLink.MAVLINK_MSG_ID.SAFETY_SET_ALLOWED_AREA, "mavlink_safety_set_allowed_area_t");
                    str += string.Format("target_system:{0}\r\n", safty_set_allowed_area.target_system);
                    str += string.Format("target_component:{0}\r\n", safty_set_allowed_area.target_component);
                    str += string.Format("frame:{0}\r\n", safty_set_allowed_area.frame);
                    str += string.Format("p1x:{0}\r\n", safty_set_allowed_area.p1x);
                    str += string.Format("p1y:{0}\r\n", safty_set_allowed_area.p1y);
                    str += string.Format("p1z:{0}\r\n", safty_set_allowed_area.p1z);
                    str += string.Format("p2x:{0}\r\n", safty_set_allowed_area.p2x);
                    str += string.Format("p2y:{0}\r\n", safty_set_allowed_area.p2y);
                    str += string.Format("p2z:{0}\r\n", safty_set_allowed_area.p2z);
                    break;
                case "MAVLink+mavlink_safty_allowed_area_t"://55 //
                    MAVLink.mavlink_safety_allowed_area_t safty_allowed_area = (MAVLink.mavlink_safety_allowed_area_t)obj;
                    str += string.Format("#{0} {1}\r\n", id = (int)MAVLink.MAVLINK_MSG_ID.SAFETY_ALLOWED_AREA, "mavlink_safety_allowed_area_t");
                    str += string.Format("frame:{0}\r\n", safty_allowed_area.frame);
                    str += string.Format("p1x:{0}\r\n", safty_allowed_area.p1x);
                    str += string.Format("p1y:{0}\r\n", safty_allowed_area.p1y);
                    str += string.Format("p1z:{0}\r\n", safty_allowed_area.p1z);
                    str += string.Format("p2x:{0}\r\n", safty_allowed_area.p2x);
                    str += string.Format("p2y:{0}\r\n", safty_allowed_area.p2y);
                    str += string.Format("p2z:{0}\r\n", safty_allowed_area.p2z);
                    break;
                case "MAVLink+mavlink_attitude_quaternion_cov_t"://61 //
                    MAVLink.mavlink_attitude_quaternion_cov_t attitude_quaternion_cov = (MAVLink.mavlink_attitude_quaternion_cov_t)obj;
                    str += string.Format("#{0} {1}\r\n", id = (int)MAVLink.MAVLINK_MSG_ID.ATTITUDE_QUATERNION_COV, "mavlink_attitude_quaternion_cov_t");
                    str += string.Format("time_boot_ms:{0}\r\n", attitude_quaternion_cov.time_boot_ms);
                    str += string.Format("q:{0}\r\n", attitude_quaternion_cov.q);
                    str += string.Format("rollspeed:{0}\r\n", attitude_quaternion_cov.rollspeed);
                    str += string.Format("pitchspeed:{0}\r\n", attitude_quaternion_cov.pitchspeed);
                    str += string.Format("yawspeed:{0}\r\n", attitude_quaternion_cov.yawspeed);
                    str += string.Format("covariance:{0}\r\n", attitude_quaternion_cov.covariance);
                    break;
                case "MAVLink+mavlink_nav_controller_output_t"://62
                    MAVLink.mavlink_nav_controller_output_t nav_controller_output = (MAVLink.mavlink_nav_controller_output_t)obj;
                    str += string.Format("#{0} {1}\r\n", id = (int)MAVLink.MAVLINK_MSG_ID.NAV_CONTROLLER_OUTPUT, "mavlink_nav_controller_output_t");
                    str += string.Format("nav_roll:{0}\r\n", nav_controller_output.nav_roll);
                    str += string.Format("nav_pitch:{0}\r\n", nav_controller_output.nav_pitch);
                    str += string.Format("nav_bearing:{0}\r\n", nav_controller_output.nav_bearing);
                    str += string.Format("target_bearing:{0}\r\n", nav_controller_output.target_bearing);
                    str += string.Format("wp_dist:{0}\r\n", nav_controller_output.wp_dist);
                    str += string.Format("alt_error:{0}\r\n", nav_controller_output.alt_error);
                    str += string.Format("aspd_error:{0}\r\n", nav_controller_output.aspd_error);
                    str += string.Format("xtrack_error:{0}\r\n", nav_controller_output.xtrack_error);
                    break;
                case "MAVLink+mavlink_global_position_int_cov_t"://63 //
                    MAVLink.mavlink_global_position_int_cov_t global_position_int_cov = (MAVLink.mavlink_global_position_int_cov_t)obj;
                    str += string.Format("#{0} {1}\r\n", id = (int)MAVLink.MAVLINK_MSG_ID.GLOBAL_POSITION_INT_COV, "mavlink_global_position_int_cov_t");
                    str += string.Format("time_boot_ms:{0}\r\n", global_position_int_cov.time_boot_ms);
                    str += string.Format("time_utc:{0}\r\n", global_position_int_cov.time_utc);
                    str += string.Format("estimator_type:{0}\r\n", global_position_int_cov.estimator_type);
                    str += string.Format("lat:{0}\r\n", global_position_int_cov.lat);
                    str += string.Format("lon:{0}\r\n", global_position_int_cov.lon);
                    str += string.Format("alt:{0}\r\n", global_position_int_cov.alt);
                    str += string.Format("relative_alt:{0}\r\n", global_position_int_cov.relative_alt);
                    str += string.Format("vx:{0}\r\n", global_position_int_cov.vx);
                    str += string.Format("vy:{0}\r\n", global_position_int_cov.vy);
                    str += string.Format("vz:{0}\r\n", global_position_int_cov.vz);
                    str += string.Format("covariance:{0}\r\n", global_position_int_cov.covariance);
                    break;
                case "MAVLink+mavlink_local_position_ned_cov_t"://64 //
                    MAVLink.mavlink_local_position_ned_cov_t local_position_ned_cov = (MAVLink.mavlink_local_position_ned_cov_t)obj;
                    str += string.Format("#{0} {1}\r\n", id = (int)MAVLink.MAVLINK_MSG_ID.LOCAL_POSITION_NED_COV, "mavlink_local_position_ned_cov_t");
                    str += string.Format("time_boot_ms:{0}\r\n", local_position_ned_cov.time_boot_ms);
                    str += string.Format("time_utc:{0}\r\n", local_position_ned_cov.time_utc);
                    str += string.Format("estimator_type:{0}\r\n", local_position_ned_cov.estimator_type);
                    str += string.Format("x:{0}\r\n", local_position_ned_cov.x);
                    str += string.Format("y:{0}\r\n", local_position_ned_cov.y);
                    str += string.Format("z:{0}\r\n", local_position_ned_cov.z);
                    str += string.Format("vx:{0}\r\n", local_position_ned_cov.vx);
                    str += string.Format("vy:{0}\r\n", local_position_ned_cov.vy);
                    str += string.Format("vz:{0}\r\n", local_position_ned_cov.vz);
                    break;
                case "MAVLink+mavlink_rc_channels_t"://65 //
                    MAVLink.mavlink_rc_channels_t rc_channels = (MAVLink.mavlink_rc_channels_t)obj;
                    str += string.Format("#{0} {1}\r\n", id = (int)MAVLink.MAVLINK_MSG_ID.RC_CHANNELS, "mavlink_rc_channels_t");
                    str += string.Format("time_boot_ms:{0}\r\n", rc_channels.time_boot_ms);
                    str += string.Format("chancount:{0}\r\n", rc_channels.chancount);
                    str += string.Format("chan1_raw:{0}\r\n", rc_channels.chan1_raw);
                    str += string.Format("chan2_raw:{0}\r\n", rc_channels.chan2_raw);
                    str += string.Format("chan3_raw:{0}\r\n", rc_channels.chan3_raw);
                    str += string.Format("chan4_raw:{0}\r\n", rc_channels.chan4_raw);
                    str += string.Format("chan5_raw:{0}\r\n", rc_channels.chan5_raw);
                    str += string.Format("chan6_raw:{0}\r\n", rc_channels.chan6_raw);
                    str += string.Format("chan7_raw:{0}\r\n", rc_channels.chan7_raw);
                    str += string.Format("chan8_raw:{0}\r\n", rc_channels.chan8_raw);
                    str += string.Format("chan9_raw:{0}\r\n", rc_channels.chan9_raw);
                    str += string.Format("chan10_raw:{0}\r\n", rc_channels.chan10_raw);
                    str += string.Format("chan11_raw:{0}\r\n", rc_channels.chan11_raw);
                    str += string.Format("chan12_raw:{0}\r\n", rc_channels.chan12_raw);
                    str += string.Format("chan13_raw:{0}\r\n", rc_channels.chan13_raw);
                    str += string.Format("chan14_raw:{0}\r\n", rc_channels.chan14_raw);
                    str += string.Format("chan15_raw:{0}\r\n", rc_channels.chan15_raw);
                    str += string.Format("chan16_raw:{0}\r\n", rc_channels.chan16_raw);
                    str += string.Format("chan17_raw:{0}\r\n", rc_channels.chan17_raw);
                    str += string.Format("chan18_raw:{0}\r\n", rc_channels.chan18_raw);
                    str += string.Format("rssi:{0}\r\n", rc_channels.rssi);
                    break;
                case "MAVLink+mavlink_request_data_stream_t"://66
                    MAVLink.mavlink_request_data_stream_t request_data_stream = (MAVLink.mavlink_request_data_stream_t)obj;
                    str += string.Format("#{0} {1}\r\n", id = (int)MAVLink.MAVLINK_MSG_ID.REQUEST_DATA_STREAM, "mavlink_request_data_stream_t");
                    str += string.Format("target_system:{0}\r\n", request_data_stream.target_system);
                    str += string.Format("target_component:{0}\r\n", request_data_stream.target_component);
                    str += string.Format("req_stream_id:{0}\r\n", request_data_stream.req_stream_id);
                    str += string.Format("req_message_rate:{0}\r\n", request_data_stream.req_message_rate);
                    str += string.Format("start_stop:{0}\r\n", request_data_stream.start_stop);
                    break;
                case "MAVLink+mavlink_data_stream_t"://67 //
                    MAVLink.mavlink_data_stream_t data_stream = (MAVLink.mavlink_data_stream_t)obj;
                    str += string.Format("#{0} {1}\r\n", id = (int)MAVLink.MAVLINK_MSG_ID.DATA_STREAM, "mavlink_data_stream_t");
                    str += string.Format("stream_id:{0}\r\n", data_stream.stream_id);
                    str += string.Format("message_rate:{0}\r\n", data_stream.message_rate);
                    str += string.Format("on_off:{0}\r\n", data_stream.on_off);
                    break;
                case "MAVLink+mavlink_manual_control_t"://69 //
                    MAVLink.mavlink_manual_control_t manual_control = (MAVLink.mavlink_manual_control_t)obj;
                    str += string.Format("#{0} {1}\r\n", id = (int)MAVLink.MAVLINK_MSG_ID.MANUAL_CONTROL, "mavlink_manual_control_t");
                    str += string.Format("target:{0}\r\n", manual_control.target);
                    str += string.Format("x:{0}\r\n", manual_control.x);
                    str += string.Format("y:{0}\r\n", manual_control.y);
                    str += string.Format("z:{0}\r\n", manual_control.z);
                    str += string.Format("r:{0}\r\n", manual_control.r);
                    str += string.Format("buttons:{0}\r\n", manual_control.buttons);
                    break;
                case "MAVLink+mavlink_rc_channels_override_t"://70 //
                    MAVLink.mavlink_rc_channels_override_t rc_channels_override = (MAVLink.mavlink_rc_channels_override_t)obj;
                    str += string.Format("#{0} {1}\r\n", id = (int)MAVLink.MAVLINK_MSG_ID.RC_CHANNELS_OVERRIDE, "mavlink_rc_channels_override_t");
                    str += string.Format("target_system:{0}\r\n", rc_channels_override.target_system);
                    str += string.Format("target_component:{0}\r\n", rc_channels_override.target_component);
                    str += string.Format("chan1_raw:{0}\r\n", rc_channels_override.chan1_raw);
                    str += string.Format("chan2_raw:{0}\r\n", rc_channels_override.chan2_raw);
                    str += string.Format("chan3_raw:{0}\r\n", rc_channels_override.chan3_raw);
                    str += string.Format("chan4_raw:{0}\r\n", rc_channels_override.chan4_raw);
                    str += string.Format("chan5_raw:{0}\r\n", rc_channels_override.chan5_raw);
                    str += string.Format("chan6_raw:{0}\r\n", rc_channels_override.chan6_raw);
                    str += string.Format("chan7_raw:{0}\r\n", rc_channels_override.chan7_raw);
                    str += string.Format("chan8_raw:{0}\r\n", rc_channels_override.chan8_raw);
                    break;
                case "MAVLink+mavlink_mission_item_int_t"://73 //
                    MAVLink.mavlink_mission_item_int_t mission_item_int = (MAVLink.mavlink_mission_item_int_t)obj;
                    str += string.Format("#{0} {1}\r\n", id = (int)MAVLink.MAVLINK_MSG_ID.MISSION_ITEM_INT, "mavlink_mission_item_int_t");
                    str += string.Format("target_system:{0}\r\n", mission_item_int.target_system);
                    str += string.Format("target_component:{0}\r\n", mission_item_int.target_component);
                    str += string.Format("seq:{0}\r\n", mission_item_int.seq);
                    str += string.Format("frame:{0}\r\n", mission_item_int.frame);
                    str += string.Format("command:{0}\r\n", mission_item_int.command);
                    str += string.Format("current:{0}\r\n", mission_item_int.current);
                    str += string.Format("autocontinue:{0}\r\n", mission_item_int.autocontinue);
                    str += string.Format("param1:{0}\r\n", mission_item_int.param1);
                    str += string.Format("param2:{0}\r\n", mission_item_int.param2);
                    str += string.Format("param3:{0}\r\n", mission_item_int.param3);
                    str += string.Format("param4:{0}\r\n", mission_item_int.param4);
                    str += string.Format("x:{0}\r\n", mission_item_int.x);
                    str += string.Format("y:{0}\r\n", mission_item_int.y);
                    str += string.Format("z:{0}\r\n", mission_item_int.z);
                    break;
                case "MAVLink+mavlink_vfr_hud_t"://74 //
                    MAVLink.mavlink_vfr_hud_t vfr_hud = (MAVLink.mavlink_vfr_hud_t)obj;
                    str += string.Format("#{0} {1}\r\n", id = (int)MAVLink.MAVLINK_MSG_ID.VFR_HUD, "mavlink_vfr_hud_t");
                    str += string.Format("airspeed:{0}\r\n", vfr_hud.airspeed);
                    str += string.Format("groundspeed:{0}\r\n", vfr_hud.groundspeed);
                    str += string.Format("heading:{0}\r\n", vfr_hud.heading);
                    str += string.Format("throttle:{0}\r\n", vfr_hud.throttle);
                    str += string.Format("alt:{0}\r\n", vfr_hud.alt);
                    str += string.Format("climb:{0}\r\n", vfr_hud.climb);
                    break;
                case "MAVLink+mavlink_command_int_t"://75 //
                    MAVLink.mavlink_command_int_t command_int = (MAVLink.mavlink_command_int_t)obj;
                    str += string.Format("#{0} {1}\r\n", id = (int)MAVLink.MAVLINK_MSG_ID.COMMAND_INT, "mavlink_command_int_t");
                    str += string.Format("target_system:{0}\r\n", command_int.target_system);
                    str += string.Format("target_component:{0}\r\n", command_int.target_component);
                    str += string.Format("frame:{0}\r\n", command_int.frame);
                    str += string.Format("command:{0}\r\n", command_int.command);
                    str += string.Format("current:{0}\r\n", command_int.current);
                    str += string.Format("autocontinue:{0}\r\n", command_int.autocontinue);
                    str += string.Format("param1:{0}\r\n", command_int.param1);
                    str += string.Format("param2:{0}\r\n", command_int.param2);
                    str += string.Format("param3:{0}\r\n", command_int.param3);
                    str += string.Format("param4:{0}\r\n", command_int.param4);
                    str += string.Format("x:{0}\r\n", command_int.x);
                    str += string.Format("y:{0}\r\n", command_int.y);
                    str += string.Format("z:{0}\r\n", command_int.z);
                    break;
                case "MAVLink+mavlink_command_long_t"://76
                    MAVLink.mavlink_command_long_t command_long = (MAVLink.mavlink_command_long_t)obj;
                    str += string.Format("#{0} {1}\r\n", id = (int)MAVLink.MAVLINK_MSG_ID.COMMAND_LONG, "mavlink_command_long_t");
                    str += string.Format("target_system:{0}\r\n", command_long.target_system);
                    str += string.Format("target_component:{0}\r\n", command_long.target_component);
                    str += string.Format("command:{0}\r\n", command_long.command);
                    str += string.Format("confirmation:{0}\r\n", command_long.confirmation);
                    str += string.Format("param1:{0}\r\n", command_long.param1);
                    str += string.Format("param2:{0}\r\n", command_long.param2);
                    str += string.Format("param3:{0}\r\n", command_long.param3);
                    str += string.Format("param4:{0}\r\n", command_long.param4);
                    str += string.Format("param5:{0}\r\n", command_long.param5);
                    str += string.Format("param6:{0}\r\n", command_long.param6);
                    str += string.Format("param7:{0}\r\n", command_long.param7);
                    break;
                case "MAVLink+mavlink_command_ack_t"://77
                    MAVLink.mavlink_command_ack_t command_ack = (MAVLink.mavlink_command_ack_t)obj;
                    str += string.Format("#{0} {1}\r\n", id = (int)MAVLink.MAVLINK_MSG_ID.COMMAND_ACK, "mavlink_command_ack_t");
                    str += string.Format("command:{0}\r\n", command_ack.command);
                    str += string.Format("result:{0}\r\n", command_ack.result);
                    break;
                //77~80
                case "MAVLink+mavlink_manual_setpoint_t"://81
                    MAVLink.mavlink_manual_setpoint_t manual_setpoint = (MAVLink.mavlink_manual_setpoint_t)obj;
                    str += string.Format("#{0} {1}\r\n", id = (int)MAVLink.MAVLINK_MSG_ID.MANUAL_SETPOINT, "mavlink_manual_setpoint_t");
                    str += string.Format("time_boot_ms:{0}\r\n", manual_setpoint.time_boot_ms);
                    str += string.Format("roll:{0}\r\n", manual_setpoint.roll);
                    str += string.Format("pitch:{0}\r\n", manual_setpoint.pitch);
                    str += string.Format("yaw:{0}\r\n", manual_setpoint.yaw);
                    str += string.Format("thrust:{0}\r\n", manual_setpoint.thrust);
                    str += string.Format("mode_switch:{0}\r\n", manual_setpoint.mode_switch);
                    str += string.Format("manual_override_switch:{0}\r\n", manual_setpoint.manual_override_switch);
                    break;
                case "MAVLink+mavlink_set_attitude_target_t"://82
                    MAVLink.mavlink_set_attitude_target_t set_attitude_target = (MAVLink.mavlink_set_attitude_target_t)obj;
                    str += string.Format("#{0} {1}\r\n", id = (int)MAVLink.MAVLINK_MSG_ID.SET_ATTITUDE_TARGET, " mavlink_set_attitude_target_t");
                    str += string.Format("time_boot_ms:{0}\r\n", set_attitude_target.time_boot_ms);
                    str += string.Format("target_system:{0}\r\n", set_attitude_target.target_system);
                    str += string.Format("target_component:{0}\r\n", set_attitude_target.target_component);
                    str += string.Format("type_mask:{0}\r\n", set_attitude_target.type_mask);
                    str += string.Format("q:{0}\r\n", set_attitude_target.q);
                    str += string.Format("body_roll_rate:{0}\r\n", set_attitude_target.body_roll_rate);
                    str += string.Format("body_pitch_rate:{0}\r\n", set_attitude_target.body_pitch_rate);
                    str += string.Format("body_yaw_rate:{0}\r\n", set_attitude_target.body_yaw_rate);
                    str += string.Format("thrust:{0}\r\n", set_attitude_target.thrust);
                    break;
                case "MAVLink+mavlink_attitude_target_t"://83
                    MAVLink.mavlink_attitude_target_t attitude_target = (MAVLink.mavlink_attitude_target_t)obj;
                    str += string.Format("#{0} {1}\r\n", id = (int)MAVLink.MAVLINK_MSG_ID.ATTITUDE_TARGET, "mavlink_attitude_target_t");
                    str += string.Format("time_boot_ms:{0}\r\n", attitude_target.time_boot_ms);
                    str += string.Format("type_mask:{0}\r\n", attitude_target.type_mask);
                    str += string.Format("q:{0}\r\n", attitude_target.q);
                    str += string.Format("body_roll_rate:{0}\r\n", attitude_target.body_roll_rate);
                    str += string.Format("body_pitch_rate:{0}\r\n", attitude_target.body_pitch_rate);
                    str += string.Format("body_yaw_rate:{0}\r\n", attitude_target.body_yaw_rate);
                    str += string.Format("thrust:{0}\r\n", attitude_target.thrust);
                    break;
                case "MAVLink+mavlink_set_position_target_local_ned_t"://84
                    MAVLink.mavlink_set_position_target_local_ned_t set_position_target_local = (MAVLink.mavlink_set_position_target_local_ned_t)obj;
                    str += string.Format("#{0} {1}\r\n", id = (int)MAVLink.MAVLINK_MSG_ID.SET_POSITION_TARGET_LOCAL_NED, "mavlink_set_position_target_local_ned_t");
                    str += string.Format("time_boot_ms:{0}\r\n", set_position_target_local.time_boot_ms);
                    str += string.Format("target_system:{0}\r\n", set_position_target_local.target_system);
                    str += string.Format("target_component:{0}\r\n", set_position_target_local.target_component);
                    str += string.Format("coordinate_frame:{0}\r\n", set_position_target_local.coordinate_frame);
                    str += string.Format("type_mask:{0}\r\n", set_position_target_local.type_mask);
                    str += string.Format("x:{0}\r\n", set_position_target_local.x);
                    str += string.Format("y:{0}\r\n", set_position_target_local.y);
                    str += string.Format("z:{0}\r\n", set_position_target_local.z);
                    str += string.Format("vx:{0}\r\n", set_position_target_local.vx);
                    str += string.Format("vy:{0}\r\n", set_position_target_local.vy);
                    str += string.Format("vz:{0}\r\n", set_position_target_local.vz);
                    str += string.Format("afx:{0}\r\n", set_position_target_local.afx);
                    str += string.Format("afy:{0}\r\n", set_position_target_local.afy);
                    str += string.Format("afz:{0}\r\n", set_position_target_local.afz);
                    str += string.Format("yaw:{0}\r\n", set_position_target_local.yaw);
                    str += string.Format("yaw_rate:{0}\r\n", set_position_target_local.yaw_rate);
                    break;
                case "MAVLink+mavlink_position_target_local_ned_t"://85
                    MAVLink.mavlink_position_target_local_ned_t position_target_local_ned = (MAVLink.mavlink_position_target_local_ned_t)obj;
                    str += string.Format("#{0} {1}\r\n", id = (int)MAVLink.MAVLINK_MSG_ID.POSITION_TARGET_LOCAL_NED, "mavlink_position_target_local_ned_t");
                    str += string.Format("time_boot_ms:{0}\r\n", position_target_local_ned.time_boot_ms);
                    str += string.Format("coordinate_frame:{0}\r\n", position_target_local_ned.coordinate_frame);
                    str += string.Format("type_mask:{0}\r\n", position_target_local_ned.type_mask);
                    str += string.Format("x:{0}\r\n", position_target_local_ned.x);
                    str += string.Format("y:{0}\r\n", position_target_local_ned.y);
                    str += string.Format("z:{0}\r\n", position_target_local_ned.z);
                    str += string.Format("vx:{0}\r\n", position_target_local_ned.vx);
                    str += string.Format("vy:{0}\r\n", position_target_local_ned.vy);
                    str += string.Format("vz:{0}\r\n", position_target_local_ned.vz);
                    str += string.Format("afx:{0}\r\n", position_target_local_ned.afx);
                    str += string.Format("afy:{0}\r\n", position_target_local_ned.afy);
                    str += string.Format("afz:{0}\r\n", position_target_local_ned.afz);
                    str += string.Format("yaw:{0}\r\n", position_target_local_ned.yaw);
                    str += string.Format("yaw_rate:{0}\r\n", position_target_local_ned.yaw_rate);
                    break;
                case "MAVLink+mavlink_set_position_target_global_int_t"://86
                    MAVLink.mavlink_set_position_target_global_int_t set_position_target_global = (MAVLink.mavlink_set_position_target_global_int_t)obj;
                    str += string.Format("#{0} {1}\r\n", id = (int)MAVLink.MAVLINK_MSG_ID.SET_POSITION_TARGET_GLOBAL_INT, "mavlink_set_position_target_global_int_t");
                    str += string.Format("time_boot_ms:{0}\r\n", set_position_target_global.time_boot_ms);
                    str += string.Format("target_system:{0}\r\n", set_position_target_global.target_system);
                    str += string.Format("target_component:{0}\r\n", set_position_target_global.target_component);
                    str += string.Format("coordinate_frame:{0}\r\n", set_position_target_global.coordinate_frame);
                    str += string.Format("type_mask:{0}\r\n", set_position_target_global.type_mask);
                    str += string.Format("lat_int:{0}\r\n", set_position_target_global.lat_int);
                    str += string.Format("lon_int:{0}\r\n", set_position_target_global.lon_int);
                    str += string.Format("alt:{0}\r\n", set_position_target_global.alt);
                    str += string.Format("vx:{0}\r\n", set_position_target_global.vx);
                    str += string.Format("vy:{0}\r\n", set_position_target_global.vy);
                    str += string.Format("vz:{0}\r\n", set_position_target_global.vz);
                    str += string.Format("afx:{0}\r\n", set_position_target_global.afx);
                    str += string.Format("afy:{0}\r\n", set_position_target_global.afy);
                    str += string.Format("afz:{0}\r\n", set_position_target_global.afz);
                    str += string.Format("yaw:{0}\r\n", set_position_target_global.yaw);
                    str += string.Format("yaw_rate:{0}\r\n", set_position_target_global.yaw_rate);
                    break;
                case "MAVLink+mavlink_position_target_global_int_t"://87
                    MAVLink.mavlink_position_target_global_int_t position_target_global = (MAVLink.mavlink_position_target_global_int_t)obj;
                    str += string.Format("#{0} {1}\r\n", id = (int)MAVLink.MAVLINK_MSG_ID.POSITION_TARGET_GLOBAL_INT, "mavlink_position_target_global_int_t");
                    str += string.Format("time_boot_ms:{0}\r\n", position_target_global.time_boot_ms);
                    str += string.Format("coordinate_frame:{0}\r\n", position_target_global.coordinate_frame);
                    str += string.Format("type_mask:{0}\r\n", position_target_global.type_mask);
                    str += string.Format("lat_int:{0}\r\n", position_target_global.lat_int);
                    str += string.Format("lon_int:{0}\r\n", position_target_global.lon_int);
                    str += string.Format("alt:{0}\r\n", position_target_global.alt);
                    str += string.Format("vx:{0}\r\n", position_target_global.vx);
                    str += string.Format("vy:{0}\r\n", position_target_global.vy);
                    str += string.Format("vz:{0}\r\n", position_target_global.vz);
                    str += string.Format("afx:{0}\r\n", position_target_global.afx);
                    str += string.Format("afy:{0}\r\n", position_target_global.afy);
                    str += string.Format("afz:{0}\r\n", position_target_global.afz);
                    str += string.Format("yaw:{0}\r\n", position_target_global.yaw);
                    str += string.Format("yaw_rate:{0}\r\n", position_target_global.yaw_rate);
                    break;
                    //88
                case "MAVLink+mavlink_local_position_ned_system_global_offset_t"://89
                    MAVLink.mavlink_local_position_ned_system_global_offset_t local_position_ned_system_global_offset = (MAVLink.mavlink_local_position_ned_system_global_offset_t)obj;
                    str += string.Format("#{0} {1}\r\n", id = (int)MAVLink.MAVLINK_MSG_ID.LOCAL_POSITION_NED_SYSTEM_GLOBAL_OFFSET, "mavlink_local_position_ned_system_global_offset_t");
                    str += string.Format("time_boot_ms:{0}\r\n", local_position_ned_system_global_offset.time_boot_ms);
                    str += string.Format("x:{0}\r\n", local_position_ned_system_global_offset.x);
                    str += string.Format("y:{0}\r\n", local_position_ned_system_global_offset.y);
                    str += string.Format("z:{0}\r\n", local_position_ned_system_global_offset.z);
                    str += string.Format("roll:{0}\r\n", local_position_ned_system_global_offset.roll);
                    str += string.Format("pitch:{0}\r\n", local_position_ned_system_global_offset.pitch);
                    str += string.Format("tyaw:{0}\r\n", local_position_ned_system_global_offset.yaw);
                    break;
                case "MAVLink+mavlink_hil_state_t"://90
                    MAVLink.mavlink_hil_state_t hil_state = (MAVLink.mavlink_hil_state_t)obj;
                    str += string.Format("#{0} {1}\r\n", id = (int)MAVLink.MAVLINK_MSG_ID.HIL_STATE, "mavlink_hil_state_t");
                    str += string.Format("time_usec:{0}\r\n", hil_state.time_usec);
                    str += string.Format("roll:{0}\r\n", hil_state.roll);
                    str += string.Format("pitch:{0}\r\n", hil_state.pitch);
                    str += string.Format("yaw:{0}\r\n", hil_state.yaw);
                    str += string.Format("rollspeed:{0}\r\n", hil_state.rollspeed);
                    str += string.Format("pitchspeed:{0}\r\n", hil_state.pitchspeed);
                    str += string.Format("yawspeed:{0}\r\n", hil_state.yawspeed);
                    str += string.Format("lat:{0}\r\n", hil_state.lat);
                    str += string.Format("lon:{0}\r\n", hil_state.lon);
                    str += string.Format("alt:{0}\r\n", hil_state.alt);
                    str += string.Format("vx:{0}\r\n", hil_state.vx);
                    str += string.Format("vy:{0}\r\n", hil_state.vy);
                    str += string.Format("vz:{0}\r\n", hil_state.vz);
                    str += string.Format("xacc:{0}\r\n", hil_state.xacc);
                    str += string.Format("yacc:{0}\r\n", hil_state.yacc);
                    str += string.Format("zacc:{0}\r\n", hil_state.zacc);
                    break;
                case "MAVLink+mavlink_hil_controls_t"://91
                    MAVLink.mavlink_hil_controls_t hil_controls = (MAVLink.mavlink_hil_controls_t)obj;
                    str += string.Format("#{0} {1}\r\n", id = (int)MAVLink.MAVLINK_MSG_ID.HIL_CONTROLS, "mavlink_hil_controls_t_t");
                    str += string.Format("time_usec:{0}\r\n", hil_controls.time_usec);
                    str += string.Format("roll_ailerons:{0}\r\n", hil_controls.roll_ailerons);
                    str += string.Format("pitch_elevator:{0}\r\n", hil_controls.pitch_elevator);
                    str += string.Format("yaw_rudder:{0}\r\n", hil_controls.yaw_rudder);
                    str += string.Format("throttle:{0}\r\n", hil_controls.throttle);
                    str += string.Format("aux1:{0}\r\n", hil_controls.aux1);
                    str += string.Format("aux2:{0}\r\n", hil_controls.aux2);
                    str += string.Format("aux3:{0}\r\n", hil_controls.aux3);
                    str += string.Format("aux4:{0}\r\n", hil_controls.aux4);
                    str += string.Format("mode:{0}\r\n", hil_controls.mode);
                    str += string.Format("nav_mode:{0}\r\n", hil_controls.nav_mode);
                    break;
                case "MAVLink+mavlink_hil_rc_inputs_raw_t"://92
                    MAVLink.mavlink_hil_rc_inputs_raw_t hil_rc_inputs_raw = (MAVLink.mavlink_hil_rc_inputs_raw_t)obj;
                    str += string.Format("#{0} {1}\r\n", id = (int)MAVLink.MAVLINK_MSG_ID.HIL_RC_INPUTS_RAW, "mavlink_hil_rc_inputs_raw_t");
                    str += string.Format("time_usec:{0}\r\n", hil_rc_inputs_raw.time_usec);
                    str += string.Format("chan1_raw:{0}\r\n", hil_rc_inputs_raw.chan1_raw);
                    str += string.Format("chan2_raw:{0}\r\n", hil_rc_inputs_raw.chan2_raw);
                    str += string.Format("chan3_raw:{0}\r\n", hil_rc_inputs_raw.chan3_raw);
                    str += string.Format("chan4_raw:{0}\r\n", hil_rc_inputs_raw.chan4_raw);
                    str += string.Format("chan5_raw:{0}\r\n", hil_rc_inputs_raw.chan5_raw);
                    str += string.Format("chan6_raw:{0}\r\n", hil_rc_inputs_raw.chan6_raw);
                    str += string.Format("chan7_raw:{0}\r\n", hil_rc_inputs_raw.chan7_raw);
                    str += string.Format("chan8_raw:{0}\r\n", hil_rc_inputs_raw.chan8_raw);
                    str += string.Format("chan9_raw:{0}\r\n", hil_rc_inputs_raw.chan9_raw);
                    str += string.Format("chan10_raw:{0}\r\n", hil_rc_inputs_raw.chan10_raw);
                    str += string.Format("chan11_raw:{0}\r\n", hil_rc_inputs_raw.chan11_raw);
                    str += string.Format("chan12_raw:{0}\r\n", hil_rc_inputs_raw.chan12_raw);
                    str += string.Format("rssi:{0}\r\n", hil_rc_inputs_raw.rssi);
                    break;
                    //93~99 缺省
                case "MAVLink+mavlink_optical_flow_t"://100
                    MAVLink.mavlink_optical_flow_t optical_flow = (MAVLink.mavlink_optical_flow_t)obj;
                    str += string.Format("#{0} {1}\r\n", id = (int)MAVLink.MAVLINK_MSG_ID.OPTICAL_FLOW, "mavlink_optical_flow_t");
                    str += string.Format("time_usec:{0}\r\n", optical_flow.time_usec);
                    str += string.Format("sensor_id:{0}\r\n", optical_flow.sensor_id);
                    str += string.Format("flow_x:{0}\r\n", optical_flow.flow_x);
                    str += string.Format("flow_y:{0}\r\n", optical_flow.flow_y);
                    str += string.Format("flow_comp_m_x:{0}\r\n", optical_flow.flow_comp_m_x);
                    str += string.Format("flow_comp_m_y:{0}\r\n", optical_flow.flow_comp_m_y); 
                    str += string.Format("quality:{0}\r\n", optical_flow.quality);
                    str += string.Format("ground_distance:{0}\r\n", optical_flow.ground_distance);
                    break;
                case "MAVLink+mavlink_global_vision_position_estimate_t"://101
                    MAVLink.mavlink_global_vision_position_estimate_t global_vision_position_estimate = (MAVLink.mavlink_global_vision_position_estimate_t)obj;
                    str += string.Format("#{0} {1}\r\n", id = (int)MAVLink.MAVLINK_MSG_ID.GLOBAL_VISION_POSITION_ESTIMATE, "mavlink_global_vision_position_estimate_t");
                    str += string.Format("usec:{0}\r\n", global_vision_position_estimate.usec);
                    str += string.Format("x:{0}\r\n", global_vision_position_estimate.x);
                    str += string.Format("y:{0}\r\n", global_vision_position_estimate.y);
                    str += string.Format("z:{0}\r\n", global_vision_position_estimate.z);
                    str += string.Format("roll:{0}\r\n", global_vision_position_estimate.roll);
                    str += string.Format("pitch:{0}\r\n", global_vision_position_estimate.pitch);
                    str += string.Format("yaw:{0}\r\n", global_vision_position_estimate.yaw);
                    break;
                case "MAVLink+mavlink_vision_position_estimate_t"://102
                    MAVLink.mavlink_vision_position_estimate_t vision_position_estimate = (MAVLink.mavlink_vision_position_estimate_t)obj;
                    str += string.Format("#{0} {1}\r\n", id = (int)MAVLink.MAVLINK_MSG_ID.VISION_POSITION_ESTIMATE, "mavlink_vision_position_estimate_t");
                    str += string.Format("usec:{0}\r\n", vision_position_estimate.usec);
                    str += string.Format("x:{0}\r\n", vision_position_estimate.x);
                    str += string.Format("y:{0}\r\n", vision_position_estimate.y);
                    str += string.Format("z:{0}\r\n", vision_position_estimate.z);
                    str += string.Format("roll:{0}\r\n", vision_position_estimate.roll);
                    str += string.Format("pitch:{0}\r\n", vision_position_estimate.pitch);
                    str += string.Format("yaw:{0}\r\n", vision_position_estimate.yaw);
                    break;

                case "MAVLink+mavlink_vision_speed_estimate_t"://103
                    MAVLink.mavlink_vision_speed_estimate_t vision_speed_estimate = (MAVLink.mavlink_vision_speed_estimate_t)obj;
                    str += string.Format("#{0} {1}\r\n", id = (int)MAVLink.MAVLINK_MSG_ID.VISION_SPEED_ESTIMATE, "mavlink_vision_speed_estimate_t");
                    str += string.Format("usec:{0}\r\n", vision_speed_estimate.usec);
                    str += string.Format("x:{0}\r\n", vision_speed_estimate.x);
                    str += string.Format("y:{0}\r\n", vision_speed_estimate.y);
                    str += string.Format("z:{0}\r\n", vision_speed_estimate.z);
                    break;
              
                case "MAVLink+mavlink_vicon_position_estimate_t"://104
                    MAVLink.mavlink_vicon_position_estimate_t vicon_position_estimate = (MAVLink.mavlink_vicon_position_estimate_t)obj;
                    str += string.Format("#{0} {1}\r\n", id = (int)MAVLink.MAVLINK_MSG_ID.VICON_POSITION_ESTIMATE, "mavlink_vicon_position_estimate_t");
                    str += string.Format("usec:{0}\r\n", vicon_position_estimate.usec);
                    str += string.Format("x:{0}\r\n", vicon_position_estimate.x);
                    str += string.Format("y:{0}\r\n", vicon_position_estimate.y);
                    str += string.Format("z:{0}\r\n", vicon_position_estimate.z);
                    str += string.Format("roll:{0}\r\n", vicon_position_estimate.roll);
                    str += string.Format("pitch:{0}\r\n", vicon_position_estimate.pitch);
                    str += string.Format("yaw:{0}\r\n", vicon_position_estimate.yaw);
                    break;
                case "MAVLink+mavlink_highres_imu_t"://105
                    MAVLink.mavlink_highres_imu_t highres_imu = (MAVLink.mavlink_highres_imu_t)obj;
                    str += string.Format("#{0} {1}\r\n", id = (int)MAVLink.MAVLINK_MSG_ID.HIGHRES_IMU, "mavlink_highres_imu_t");
                    str += string.Format("time_usec:{0}\r\n", highres_imu.time_usec);
                    str += string.Format("xacc:{0}\r\n", highres_imu.xacc);
                    str += string.Format("yacc:{0}\r\n", highres_imu.yacc);
                    str += string.Format("zacc:{0}\r\n", highres_imu.zacc);
                    str += string.Format("xgyro:{0}\r\n", highres_imu.xgyro);
                    str += string.Format("ygyro:{0}\r\n", highres_imu.ygyro);
                    str += string.Format("zgyro:{0}\r\n", highres_imu.zgyro);
                    str += string.Format("xmag:{0}\r\n", highres_imu.xmag);
                    str += string.Format("ymag:{0}\r\n", highres_imu.ymag);
                    str += string.Format("zmag:{0}\r\n", highres_imu.zmag);
                    str += string.Format("abs_pressure:{0}\r\n", highres_imu.abs_pressure);
                    str += string.Format("diff_pressure:{0}\r\n", highres_imu.diff_pressure);
                    str += string.Format("pressure_alt:{0}\r\n", highres_imu.pressure_alt);
                    str += string.Format("temperature:{0}\r\n", highres_imu.temperature);
                    str += string.Format("fields_updated:{0}\r\n", highres_imu.fields_updated);
                    break;
                case "MAVLink+mavlink_optical_flow_rad_t"://106
                    MAVLink.mavlink_optical_flow_rad_t optical_flow_rad = (MAVLink.mavlink_optical_flow_rad_t)obj;
                    str += string.Format("#{0} {1}\r\n", id = (int)MAVLink.MAVLINK_MSG_ID.OPTICAL_FLOW_RAD, "mavlink_optical_flow_rad_t");
                    str += string.Format("time_usec:{0}\r\n", optical_flow_rad.time_usec);
                    str += string.Format("sensor_id:{0}\r\n", optical_flow_rad.sensor_id);
                    str += string.Format("integration_time_us:{0}\r\n", optical_flow_rad.integration_time_us);
                    str += string.Format("integrated_x:{0}\r\n", optical_flow_rad.integrated_x);
                    str += string.Format("integrated_y:{0}\r\n", optical_flow_rad.integrated_y);
                    str += string.Format("integrated_xgyro:{0}\r\n", optical_flow_rad.integrated_xgyro);
                    str += string.Format("integrated_ygyro:{0}\r\n", optical_flow_rad.integrated_ygyro);
                    str += string.Format("integrated_zgyro:{0}\r\n", optical_flow_rad.integrated_zgyro);
                    str += string.Format("temperature:{0}\r\n", optical_flow_rad.temperature);
                    str += string.Format("quality:{0}\r\n", optical_flow_rad.quality);
                    str += string.Format("time_delta_distance_us:{0}\r\n", optical_flow_rad.time_delta_distance_us);
                    str += string.Format("distance:{0}\r\n", optical_flow_rad.distance);
                    break;
                case "MAVLink+mavlink_hil_sensor_t"://107
                    MAVLink.mavlink_hil_sensor_t hil_sensor = (MAVLink.mavlink_hil_sensor_t)obj;
                    str += string.Format("#{0} {1}\r\n", id = (int)MAVLink.MAVLINK_MSG_ID.HIL_SENSOR, "mavlink_hil_sensor_t");
                    str += string.Format("time_usec:{0}\r\n", hil_sensor.time_usec);
                    str += string.Format("xacc:{0}\r\n", hil_sensor.xacc);
                    str += string.Format("yacc:{0}\r\n", hil_sensor.yacc);
                    str += string.Format("zacc:{0}\r\n", hil_sensor.zacc);
                    str += string.Format("xgyro:{0}\r\n", hil_sensor.xgyro);
                    str += string.Format("ygyro:{0}\r\n", hil_sensor.ygyro);
                    str += string.Format("zgyro:{0}\r\n", hil_sensor.zgyro);
                    str += string.Format("xmag:{0}\r\n", hil_sensor.xmag);
                    str += string.Format("ymag:{0}\r\n", hil_sensor.ymag);
                    str += string.Format("zmag:{0}\r\n", hil_sensor.zmag);
                    str += string.Format("abs_pressure:{0}\r\n", hil_sensor.abs_pressure);
                    str += string.Format("diff_pressure:{0}\r\n", hil_sensor.diff_pressure);
                    str += string.Format("pressure_alt:{0}\r\n", hil_sensor.pressure_alt);
                    str += string.Format("temperature:{0}\r\n", hil_sensor.temperature);
                    str += string.Format("fields_updated:{0}\r\n", hil_sensor.fields_updated);
                    break;
                case "MAVLink+mavlink_sim_state_t"://108
                    MAVLink.mavlink_sim_state_t sim_state = (MAVLink.mavlink_sim_state_t)obj;
                    str += string.Format("#{0} {1}\r\n", id = (int)MAVLink.MAVLINK_MSG_ID.SIM_STATE, "mavlink_sim_state_t");
                    str += string.Format("q1:{0}\r\n", sim_state.q1);
                    str += string.Format("q2:{0}\r\n", sim_state.q2);
                    str += string.Format("q3:{0}\r\n", sim_state.q3);
                    str += string.Format("q4:{0}\r\n", sim_state.q4);
                    str += string.Format("roll:{0}\r\n", sim_state.roll);
                    str += string.Format("pitch:{0}\r\n", sim_state.pitch);
                    str += string.Format("yaw:{0}\r\n", sim_state.yaw);
                    str += string.Format("xacc:{0}\r\n", sim_state.xacc);
                    str += string.Format("yacc:{0}\r\n", sim_state.yacc);
                    str += string.Format("zacc:{0}\r\n", sim_state.zacc);
                    str += string.Format("xgyro:{0}\r\n", sim_state.xgyro);
                    str += string.Format("ygyro:{0}\r\n", sim_state.ygyro);
                    str += string.Format("zgyro:{0}\r\n", sim_state.zgyro);
                    str += string.Format("lat:{0}\r\n", sim_state.lat);
                    str += string.Format("lon:{0}\r\n", sim_state.lon);
                    str += string.Format("alt:{0}\r\n", sim_state.alt);
                    str += string.Format("std_dev_horz:{0}\r\n", sim_state.std_dev_horz);
                    str += string.Format("std_dev_vert:{0}\r\n", sim_state.std_dev_vert);
                    str += string.Format("vn:{0}\r\n", sim_state.vn);
                    str += string.Format("ve:{0}\r\n", sim_state.ve);
                    str += string.Format("vd:{0}\r\n", sim_state.vd);
                    break;
                case "MAVLink+mavlink_radio_status_t"://109
                    MAVLink.mavlink_radio_status_t radio_status = (MAVLink.mavlink_radio_status_t)obj;
                    str += string.Format("#{0} {1}\r\n", id = (int)MAVLink.MAVLINK_MSG_ID.RADIO_STATUS, "mavlink_radio_status_t");
                    str += string.Format("rssi:{0}\r\n", radio_status.rssi);
                    str += string.Format("remrssi:{0}\r\n", radio_status.remrssi);
                    str += string.Format("txbuf:{0}\r\n", radio_status.txbuf);
                    str += string.Format("noise:{0}\r\n", radio_status.noise);
                    str += string.Format("remnoise:{0}\r\n", radio_status.remnoise);
                    str += string.Format("rxerrors:{0}\r\n", radio_status.rxerrors);
                    str += string.Format("fixed:{0}\r\n", radio_status.@fixed);
                    break;
                case "MAVLink+mavlink_file_transfer_protocol_t"://110
                    MAVLink.mavlink_file_transfer_protocol_t file_transfer_protocol = (MAVLink.mavlink_file_transfer_protocol_t)obj;
                    str += string.Format("#{0} {1}\r\n", id = (int)MAVLink.MAVLINK_MSG_ID.TIMESYNC, "mavlink_file_transfer_protocol_t");
                    str += string.Format("target_network:{0}\r\n", file_transfer_protocol.target_network);
                    str += string.Format("target_system:{0}\r\n", file_transfer_protocol.target_system);
                    str += string.Format("target_component:{0}\r\n", file_transfer_protocol.target_component);
                    str += string.Format("payload:{0}\r\n", file_transfer_protocol.payload);
                    break;
                case "MAVLink+mavlink_timesync_t"://111
                    MAVLink.mavlink_timesync_t timesync = (MAVLink.mavlink_timesync_t)obj;
                    str += string.Format("#{0} {1}\r\n", id = (int)MAVLink.MAVLINK_MSG_ID.TIMESYNC, "mavlink_timesync_t");
                    str += string.Format("tc1:{0}\r\n", timesync.tc1);
                    str += string.Format("ts1:{0}\r\n", timesync.ts1);
                    break;
                    //112
                case "MAVLink+mavlink_hil_gps_t"://113
                    MAVLink.mavlink_hil_gps_t hil_gps = (MAVLink.mavlink_hil_gps_t)obj;
                    str += string.Format("#{0} {1}\r\n", id = (int)MAVLink.MAVLINK_MSG_ID.HIL_GPS, "mavlink_hil_gps_t");
                    str += string.Format("time_usec:{0}\r\n", hil_gps.time_usec);
                    str += string.Format("fix_type:{0}\r\n", hil_gps.fix_type);
                    str += string.Format("lat:{0}\r\n", hil_gps.lat);
                    str += string.Format("lon:{0}\r\n", hil_gps.lon);
                    str += string.Format("alt:{0}\r\n", hil_gps.alt);
                    str += string.Format("eph:{0}\r\n", hil_gps.eph);
                    str += string.Format("epv:{0}\r\n", hil_gps.epv);
                    str += string.Format("vel:{0}\r\n", hil_gps.vel);
                    str += string.Format("vn:{0}\r\n", hil_gps.vn);
                    str += string.Format("ve:{0}\r\n", hil_gps.ve);
                    str += string.Format("vd:{0}\r\n", hil_gps.vd);
                    str += string.Format("cog:{0}\r\n", hil_gps.cog);
                    str += string.Format("satellites_visible:{0}\r\n", hil_gps.satellites_visible);
                    break;
                case "MAVLink+mavlink_hil_optical_flow_t"://114
                    MAVLink.mavlink_hil_optical_flow_t hil_optical_flow = (MAVLink.mavlink_hil_optical_flow_t)obj;
                    str += string.Format("#{0} {1}\r\n", id = (int)MAVLink.MAVLINK_MSG_ID.HIL_OPTICAL_FLOW, "mavlink_hil_optical_flow_t");
                    str += string.Format("time_usec:{0}\r\n", hil_optical_flow.time_usec);
                    str += string.Format("sensor_id:{0}\r\n", hil_optical_flow.sensor_id);
                    str += string.Format("integration_time_us:{0}\r\n", hil_optical_flow.integration_time_us);
                    str += string.Format("integrated_x:{0}\r\n", hil_optical_flow.integrated_x);
                    str += string.Format("integrated_y:{0}\r\n", hil_optical_flow.integrated_y);
                    str += string.Format("integrated_xgyro:{0}\r\n", hil_optical_flow.integrated_xgyro);
                    str += string.Format("integrated_ygyro:{0}\r\n", hil_optical_flow.integrated_ygyro);
                    str += string.Format("integrated_zgyro:{0}\r\n", hil_optical_flow.integrated_zgyro);
                    str += string.Format("temperature:{0}\r\n", hil_optical_flow.temperature);
                    str += string.Format("quality:{0}\r\n", hil_optical_flow.quality);
                    str += string.Format("time_delta_distance_us:{0}\r\n", hil_optical_flow.time_delta_distance_us);
                    str += string.Format("distance:{0}\r\n", hil_optical_flow.distance);
                    break;
                case "MAVLink+mavlink_hil_state_quaternion_t"://115
                    MAVLink.mavlink_hil_state_quaternion_t hil_state_quaternion = (MAVLink.mavlink_hil_state_quaternion_t)obj;
                    str += string.Format("#{0} {1}\r\n", id = (int)MAVLink.MAVLINK_MSG_ID.HIL_STATE_QUATERNION, "mavlink_hil_state_quaternion_t");
                    str += string.Format("time_usec:{0}\r\n", hil_state_quaternion.time_usec);
                    str += string.Format("attitude_quaternion:{0}\r\n", hil_state_quaternion.attitude_quaternion);
                    str += string.Format("rollspeed:{0}\r\n", hil_state_quaternion.rollspeed);
                    str += string.Format("pitchspeed:{0}\r\n", hil_state_quaternion.pitchspeed);
                    str += string.Format("yawspeed:{0}\r\n", hil_state_quaternion.yawspeed);
                    str += string.Format("lat:{0}\r\n", hil_state_quaternion.lat);
                    str += string.Format("lon:{0}\r\n", hil_state_quaternion.lon);
                    str += string.Format("alt:{0}\r\n", hil_state_quaternion.alt);
                    str += string.Format("vx:{0}\r\n", hil_state_quaternion.vx);
                    str += string.Format("vy:{0}\r\n", hil_state_quaternion.vy);
                    str += string.Format("vz:{0}\r\n", hil_state_quaternion.vz);
                    str += string.Format("ind_airspeed:{0}\r\n", hil_state_quaternion.ind_airspeed);
                    str += string.Format("true_airspeed:{0}\r\n", hil_state_quaternion.true_airspeed);
                    str += string.Format("xacc:{0}\r\n", hil_state_quaternion.xacc);
                    str += string.Format("yacc:{0}\r\n", hil_state_quaternion.yacc);
                    str += string.Format("zacc:{0}\r\n", hil_state_quaternion.zacc);
                    break;
                case "MAVLink+mavlink_scaled_imu2_t"://116
                    MAVLink.mavlink_scaled_imu2_t scaled_imu2 = (MAVLink.mavlink_scaled_imu2_t)obj;
                    str += string.Format("#{0} {1}\r\n", id = (int)MAVLink.MAVLINK_MSG_ID.SCALED_IMU2, "mavlink_scaled_imu2_t");
                    str += string.Format("time_boot_ms:{0}\r\n", scaled_imu2.time_boot_ms);
                    str += string.Format("xacc:{0}\r\n", scaled_imu2.xacc);
                    str += string.Format("yacc:{0}\r\n", scaled_imu2.yacc);
                    str += string.Format("zacc:{0}\r\n", scaled_imu2.zacc);
                    str += string.Format("xgyro:{0}\r\n", scaled_imu2.xgyro);
                    str += string.Format("ygyro:{0}\r\n", scaled_imu2.ygyro);
                    str += string.Format("zgyro:{0}\r\n", scaled_imu2.zgyro);
                    str += string.Format("xmag:{0}\r\n", scaled_imu2.xmag);
                    str += string.Format("ymag:{0}\r\n", scaled_imu2.ymag);
                    str += string.Format("zmag:{0}\r\n", scaled_imu2.zmag);
                    break;
                case "MAVLink+mavlink_log_request_list_t"://117
                    MAVLink.mavlink_log_request_list_t log_request_list = (MAVLink.mavlink_log_request_list_t)obj;
                    str += string.Format("#{0} {1}\r\n", id = (int)MAVLink.MAVLINK_MSG_ID.LOG_REQUEST_LIST, "mavlink_log_request_list_t");
                    str += string.Format("target_system:{0}\r\n", log_request_list.target_system);
                    str += string.Format("target_component:{0}\r\n", log_request_list.target_component);
                    str += string.Format("start:{0}\r\n", log_request_list.start);
                    str += string.Format("end:{0}\r\n", log_request_list.end);
                    break;
                case "MAVLink+mavlink_log_entry_t"://118
                    MAVLink.mavlink_log_entry_t log_entry = (MAVLink.mavlink_log_entry_t)obj;
                    str += string.Format("#{0} {1}\r\n", id = (int)MAVLink.MAVLINK_MSG_ID.LOG_ENTRY, "mavlink_log_entry_t");
                    str += string.Format("id:{0}\r\n", log_entry.id);
                    str += string.Format("num_logs:{0}\r\n", log_entry.num_logs);
                    str += string.Format("last_log_num:{0}\r\n", log_entry.last_log_num);
                    str += string.Format("time_utc:{0}\r\n", log_entry.time_utc);
                    str += string.Format("size:{0}\r\n", log_entry.size);
                    break;
                case "MAVLink+mavlink_log_request_data_t"://119
                    MAVLink. mavlink_log_request_data_t log_request_data= (MAVLink.mavlink_log_request_data_t)obj;
                    str += string.Format("#{0} {1}\r\n", id = (int)MAVLink.MAVLINK_MSG_ID.LOG_REQUEST_DATA, "mavlink_log_request_data_t");
                    str += string.Format("target_system:{0}\r\n", log_request_data.target_system);
                    str += string.Format("target_component:{0}\r\n", log_request_data.target_component);
                    str += string.Format("id:{0}\r\n", log_request_data.id);
                    str += string.Format("ofs:{0}\r\n", log_request_data.ofs);
                    str += string.Format("count:{0}\r\n", log_request_data.count);
                    break;
                case "MAVLink+mavlink_log_data_t"://120
                    MAVLink.mavlink_log_data_t log_data = (MAVLink.mavlink_log_data_t)obj;
                    str += string.Format("#{0} {1}\r\n", id = (int)MAVLink.MAVLINK_MSG_ID.LOG_DATA, "mavlink_log_data_t");
                    str += string.Format("id:{0}\r\n", log_data.id);
                    str += string.Format("ofs:{0}\r\n", log_data.ofs);
                    str += string.Format("count:{0}\r\n", log_data.count);
                    break;
                case "MAVLink+mavlink_log_erase_t"://121
                    MAVLink.mavlink_log_erase_t log_erase = (MAVLink.mavlink_log_erase_t)obj;
                    str += string.Format("#{0} {1}\r\n", id = (int)MAVLink.MAVLINK_MSG_ID.LOG_ERASE, "mavlink_log_erase_t");
                    str += string.Format("target_system:{0}\r\n", log_erase.target_system);
                    str += string.Format("target_component:{0}\r\n", log_erase.target_component);
                    break;
                   
                case "MAVLink+mavlink_log_request_end_t"://122
                    MAVLink.mavlink_log_request_end_t log_request_end = (MAVLink.mavlink_log_request_end_t)obj;
                    str += string.Format("#{0} {1}\r\n", id = (int)MAVLink.MAVLINK_MSG_ID.LOG_REQUEST_END, "mavlink_log_request_end_t");
                    str += string.Format("target_system:{0}\r\n", log_request_end.target_system);
                    str += string.Format("target_component:{0}\r\n", log_request_end.target_component);
                    break;

                case "MAVLink+mavlink_gps_inject_data_t"://123
                    MAVLink.mavlink_gps_inject_data_t gps_inject_data = (MAVLink.mavlink_gps_inject_data_t)obj;
                    str += string.Format("#{0} {1}\r\n", id = (int)MAVLink.MAVLINK_MSG_ID.GPS_INJECT_DATA, "mavlink_gps_inject_data_t");
                    str += string.Format("target_system:{0}\r\n", gps_inject_data.target_system);
                    str += string.Format("target_component:{0}\r\n", gps_inject_data.target_component);
                    str += string.Format("len:{0}\r\n", gps_inject_data.len);
                    str += string.Format("data:{0}\r\n", gps_inject_data.data);
                    break;
                case "MAVLink+mavlink_gps2_raw_t"://124
                    MAVLink.mavlink_gps2_raw_t gps2_raw = (MAVLink.mavlink_gps2_raw_t)obj;
                    str += string.Format("#{0} {1}\r\n", id = (int)MAVLink.MAVLINK_MSG_ID.GPS2_RAW, "mavlink_gps2_raw_t");
                    str += string.Format("time_usec:{0}\r\n", gps2_raw.time_usec);
                    str += string.Format("fix_type:{0}\r\n", gps2_raw.fix_type);
                    str += string.Format("lat:{0}\r\n", gps2_raw.lat);
                    str += string.Format("alt:{0}\r\n", gps2_raw.alt);
                    str += string.Format("eph:{0}\r\n", gps2_raw.eph);
                    str += string.Format("epv:{0}\r\n", gps2_raw.epv);
                    str += string.Format("vel:{0}\r\n", gps2_raw.vel);
                    str += string.Format("cog:{0}\r\n", gps2_raw.cog);
                    str += string.Format("satellites_visible:{0}\r\n", gps2_raw.satellites_visible);
                    str += string.Format("dgps_numch:{0}\r\n", gps2_raw.dgps_numch);
                    str += string.Format("dgps_age:{0}\r\n", gps2_raw.dgps_age);
                    break;
                case "MAVLink+mavlink_power_status_t"://125
                    MAVLink.mavlink_power_status_t power_status = (MAVLink.mavlink_power_status_t)obj;
                    str += string.Format("#{0} {1}\r\n", id = (int)MAVLink.MAVLINK_MSG_ID.POWER_STATUS, "mavlink_power_status_t");
                    str += string.Format("Vcc:{0}\r\n", power_status.Vcc);
                    str += string.Format("Vservo:{0}\r\n", power_status.Vservo);
                    str += string.Format("flags:{0}\r\n", Convert.ToString(power_status.flags, 2));
                    break;
                case "MAVLink+mavlink_serial_control_t"://126
                    MAVLink.mavlink_serial_control_t serial_control = (MAVLink.mavlink_serial_control_t)obj;
                    str += string.Format("#{0} {1}\r\n", id = (int)MAVLink.MAVLINK_MSG_ID.SERIAL_CONTROL, "mavlink_serial_control_t");
                    str += string.Format("device:{0}\r\n", serial_control.device);
                    str += string.Format("flags:{0}\r\n", serial_control.flags);
                    str += string.Format("timeout:{0}\r\n", serial_control.timeout);
                    str += string.Format("baudrate:{0}\r\n", serial_control.baudrate);
                    str += string.Format("count:{0}\r\n", serial_control.count);
                    str += string.Format("data:{0}\r\n", serial_control.data);
                    break;
                case "MAVLink+mavlink_gps_rtk_t"://127
                    MAVLink.mavlink_gps_rtk_t gps_rtk = (MAVLink.mavlink_gps_rtk_t)obj;
                    str += string.Format("#{0} {1}\r\n", id = (int)MAVLink.MAVLINK_MSG_ID.GPS_RTK, "mavlink_gps_rtk_t");
                    str += string.Format("time_last_baseline_ms:{0}\r\n", gps_rtk.time_last_baseline_ms);
                    str += string.Format("rtk_receiver_id:{0}\r\n", gps_rtk.rtk_receiver_id);
                    str += string.Format("wn:{0}\r\n", gps_rtk.wn);
                    str += string.Format("tow:{0}\r\n", gps_rtk.tow);
                    str += string.Format("rtk_health:{0}\r\n", gps_rtk.rtk_health);
                    str += string.Format("rtk_rate:{0}\r\n", gps_rtk.rtk_rate);
                    str += string.Format("nsats:{0}\r\n", gps_rtk.nsats);
                    str += string.Format("baseline_coords_type:{0}\r\n", gps_rtk.baseline_coords_type);
                    str += string.Format("baseline_a_mm:{0}\r\n", gps_rtk.baseline_a_mm);
                    str += string.Format("baseline_b_mm:{0}\r\n", gps_rtk.baseline_b_mm);
                    str += string.Format("baseline_c_mm:{0}\r\n", gps_rtk.baseline_c_mm);
                    str += string.Format("accuracy:{0}\r\n", gps_rtk.accuracy);
                    str += string.Format("iar_num_hypotheses:{0}\r\n", gps_rtk.iar_num_hypotheses);
                    break;
                case "MAVLink+mavlink_gps2_rtk_t"://128
                    MAVLink.mavlink_gps2_rtk_t gps2_rtk = (MAVLink.mavlink_gps2_rtk_t)obj;
                    str += string.Format("#{0} {1}\r\n", id = (int)MAVLink.MAVLINK_MSG_ID.GPS2_RTK, "mavlink_gps2_rtk_t");
                    str += string.Format("time_last_baseline_ms:{0}\r\n", gps2_rtk.time_last_baseline_ms);
                    str += string.Format("rtk_receiver_id:{0}\r\n", gps2_rtk.rtk_receiver_id);
                    str += string.Format("wn:{0}\r\n", gps2_rtk.wn);
                    str += string.Format("tow:{0}\r\n", gps2_rtk.tow);
                    str += string.Format("rtk_health:{0}\r\n", gps2_rtk.rtk_health);
                    str += string.Format("rtk_rate:{0}\r\n", gps2_rtk.rtk_rate);
                    str += string.Format("nsats:{0}\r\n", gps2_rtk.nsats);
                    str += string.Format("baseline_coords_type:{0}\r\n", gps2_rtk.baseline_coords_type);
                    str += string.Format("baseline_a_mm:{0}\r\n", gps2_rtk.baseline_a_mm);
                    str += string.Format("baseline_b_mm:{0}\r\n", gps2_rtk.baseline_b_mm);
                    str += string.Format("baseline_c_mm:{0}\r\n", gps2_rtk.baseline_c_mm);
                    str += string.Format("accuracy:{0}\r\n", gps2_rtk.accuracy);
                    str += string.Format("iar_num_hypotheses:{0}\r\n", gps2_rtk.iar_num_hypotheses);
                    break;
                case "MAVLink+mavlink_scaled_imu3_t"://129
                    MAVLink.mavlink_scaled_imu3_t scaled_imu3 = (MAVLink.mavlink_scaled_imu3_t)obj;
                    str += string.Format("#{0} {1}\r\n", id = (int)MAVLink.MAVLINK_MSG_ID.SCALED_IMU3, "mavlink_scaled_imu3_t");
                    str += string.Format("time_boot_ms:{0}\r\n", scaled_imu3.time_boot_ms);
                    str += string.Format("xacc:{0}\r\n", scaled_imu3.xacc);
                    str += string.Format("yacc:{0}\r\n", scaled_imu3.yacc);
                    str += string.Format("zacc:{0}\r\n", scaled_imu3.zacc);
                    str += string.Format("xgyro:{0}\r\n", scaled_imu3.xgyro);
                    str += string.Format("ygyro:{0}\r\n", scaled_imu3.ygyro);
                    str += string.Format("zgyro:{0}\r\n", scaled_imu3.zgyro);
                    str += string.Format("xmag:{0}\r\n", scaled_imu3.xmag);
                    str += string.Format("ymag:{0}\r\n", scaled_imu3.ymag);
                    str += string.Format("zmag:{0}\r\n", scaled_imu3.zmag);
                    break;
                case "MAVLink+mavlink_data_transmission_handshake_t"://130
                    MAVLink.mavlink_data_transmission_handshake_t data_transmission_handshake = (MAVLink.mavlink_data_transmission_handshake_t)obj;
                    str += string.Format("#{0} {1}\r\n", id = (int)MAVLink.MAVLINK_MSG_ID.DATA_TRANSMISSION_HANDSHAKE, "mavlink_data_transmission_handshake_t");
                    str += string.Format("type:{0}\r\n", data_transmission_handshake.type);
                    str += string.Format("size:{0}\r\n", data_transmission_handshake.size);
                    str += string.Format("width:{0}\r\n", data_transmission_handshake.width);
                    str += string.Format("height:{0}\r\n", data_transmission_handshake.height);
                    str += string.Format("packets:{0}\r\n", data_transmission_handshake.packets);
                    str += string.Format("payload:{0}\r\n", data_transmission_handshake.payload);
                    str += string.Format("jpg_quality:{0}\r\n", data_transmission_handshake.jpg_quality);
                    break;
                case "MAVLink+mavlink_encapsulated_data_t"://131
                    MAVLink.mavlink_encapsulated_data_t encapsulated_data = (MAVLink.mavlink_encapsulated_data_t)obj;
                    str += string.Format("#{0} {1}\r\n", id = (int)MAVLink.MAVLINK_MSG_ID.ENCAPSULATED_DATA, "mavlink_encapsulated_data_t");
                    str += string.Format("seqnr:{0}\r\n", encapsulated_data.seqnr);
                    str += string.Format("data:{0}\r\n", encapsulated_data.data);
                    break;
                case "MAVLink+mavlink_distance_sensor_t"://132
                    MAVLink.mavlink_distance_sensor_t distance_sensor = (MAVLink.mavlink_distance_sensor_t)obj;
                    str += string.Format("#{0} {1}\r\n", id = (int)MAVLink.MAVLINK_MSG_ID.DISTANCE_SENSOR, "mavlink_distance_sensor_t");
                    str += string.Format("time_boot_ms:{0}\r\n", distance_sensor.time_boot_ms);
                    str += string.Format("min_distance:{0}\r\n", distance_sensor.min_distance);
                    str += string.Format("max_distance:{0}\r\n", distance_sensor.max_distance);
                    str += string.Format("current_distance:{0}\r\n", distance_sensor.current_distance);
                    str += string.Format("id:{0}\r\n", distance_sensor.id);
                    str += string.Format("orientation:{0}\r\n", distance_sensor.orientation);
                    str += string.Format("covariance:{0}\r\n", distance_sensor.covariance);
                    break;
                case "MAVLink+mavlink_terrain_request_t"://133
                    MAVLink.mavlink_terrain_request_t terrain_request = (MAVLink.mavlink_terrain_request_t)obj;
                    str += string.Format("#{0} {1}\r\n", id = (int)MAVLink.MAVLINK_MSG_ID.TERRAIN_REQUEST, "mavlink_terrain_request_t");
                    str += string.Format("lat:{0}\r\n", terrain_request.lat);
                    str += string.Format("lon:{0}\r\n", terrain_request.lon);
                    str += string.Format("grid_spacing:{0}\r\n", terrain_request.grid_spacing);
                    str += string.Format("mask:{0}\r\n", terrain_request.mask);
                    break;
                case "MAVLink+mavlink_terrain_data_t"://134
                    MAVLink.mavlink_terrain_data_t terrain_data = (MAVLink.mavlink_terrain_data_t)obj;
                    str += string.Format("#{0} {1}\r\n", id = (int)MAVLink.MAVLINK_MSG_ID.TERRAIN_DATA, "mavlink_terrain_data_t");
                    str += string.Format("lat:{0}\r\n", terrain_data.lat);
                    str += string.Format("lon:{0}\r\n", terrain_data.lon);
                    str += string.Format("grid_spacing:{0}\r\n", terrain_data.grid_spacing);
                    str += string.Format("gridbit:{0}\r\n", terrain_data.gridbit);
                    str += string.Format("data:{0}\r\n", terrain_data.data);
                    break;
                case "MAVLink+mavlink_terrain_check_t"://135
                    MAVLink.mavlink_terrain_data_t terrain_check = (MAVLink.mavlink_terrain_data_t)obj;
                    str += string.Format("#{0} {1}\r\n", id = (int)MAVLink.MAVLINK_MSG_ID.TERRAIN_CHECK, "mavlink_terrain_check_t");
                    str += string.Format("lat:{0}\r\n", terrain_check.lat);
                    str += string.Format("lon:{0}\r\n", terrain_check.lon);
                    break;
                case "MAVLink+mavlink_terrain_report_t"://136
                    MAVLink.mavlink_terrain_report_t terrain_report = (MAVLink.mavlink_terrain_report_t)obj;
                    str += string.Format("#{0} {1}\r\n", id = (int)MAVLink.MAVLINK_MSG_ID.DISTANCE_SENSOR, "mavlink_distance_report_t");
                    str += string.Format("lat:{0}\r\n", terrain_report.lat);
                    str += string.Format("lon:{0}\r\n", terrain_report.lon);
                    str += string.Format("spacing:{0}\r\n", terrain_report.spacing);
                    str += string.Format("terrain_height:{0}\r\n", terrain_report.terrain_height);
                    str += string.Format("current_height:{0}\r\n", terrain_report.current_height);
                    str += string.Format("pending:{0}\r\n", terrain_report.pending);
                    str += string.Format("loaded:{0}\r\n", terrain_report.loaded);
                    break;
                case "MAVLink+mavlink_scaled_pressure2_t"://137
                    MAVLink.mavlink_scaled_pressure2_t scaled_pressure2 = (MAVLink.mavlink_scaled_pressure2_t)obj;
                    str += string.Format("#{0} {1}\r\n", id = (int)MAVLink.MAVLINK_MSG_ID.DISTANCE_SENSOR, "mavlink_scaled_pressure2_t");
                    str += string.Format("time_boot_ms:{0}\r\n", scaled_pressure2.time_boot_ms);
                    str += string.Format("press_abs:{0}\r\n", scaled_pressure2.press_abs);
                    str += string.Format("press_diff:{0}\r\n", scaled_pressure2.press_diff);
                    str += string.Format("temperature:{0}\r\n", scaled_pressure2.temperature);
                    break;
                case "MAVLink+mavlink_att_pos_mocap_t"://138
                    MAVLink.mavlink_att_pos_mocap_t att_pos_mocap = (MAVLink.mavlink_att_pos_mocap_t)obj;
                    str += string.Format("#{0} {1}\r\n", id = (int)MAVLink.MAVLINK_MSG_ID.DISTANCE_SENSOR, "mavlink_att_pos_mocap_t");
                    str += string.Format("time_usec:{0}\r\n", att_pos_mocap.time_usec);
                    str += string.Format("q:{0}\r\n", att_pos_mocap.q);
                    str += string.Format("x:{0}\r\n", att_pos_mocap.x);
                    str += string.Format("y:{0}\r\n", att_pos_mocap.y);
                    str += string.Format("z:{0}\r\n", att_pos_mocap.z);
                    break;
                case "MAVLink+mavlink_set_actuator_control_target_t"://139
                    MAVLink.mavlink_set_actuator_control_target_t set_actuator_control_target = (MAVLink.mavlink_set_actuator_control_target_t)obj;
                    str += string.Format("#{0} {1}\r\n", id = (int)MAVLink.MAVLINK_MSG_ID.SET_ACTUATOR_CONTROL_TARGET, "mavlink_set_actuator_control_target_t ");
                    str += string.Format("time_usec:{0}\r\n", set_actuator_control_target.time_usec);
                    str += string.Format("group_mlx:{0}\r\n", set_actuator_control_target.group_mlx);
                    str += string.Format("target_system:{0}\r\n", set_actuator_control_target.target_system);
                    str += string.Format("target_component:{0}\r\n", set_actuator_control_target.target_component);
                    str += string.Format("controls:{0}\r\n", set_actuator_control_target.controls);
                    break;
                case "MAVLink+mavlink_actuator_control_target_t"://140
                    MAVLink.mavlink_actuator_control_target_t actuator_control_target = (MAVLink.mavlink_actuator_control_target_t)obj;
                    str += string.Format("#{0} {1}\r\n", id = (int)MAVLink.MAVLINK_MSG_ID.ACTUATOR_CONTROL_TARGET, "mavlink_actuator_control_target_t ");
                    str += string.Format("time_usec:{0}\r\n", actuator_control_target.time_usec);
                    str += string.Format("group_mlx:{0}\r\n", actuator_control_target.group_mlx);
                    str += string.Format("controls:{0}\r\n", actuator_control_target.controls);
                    break;
                //141 142没有
                case "MAVLink+mavlink_scaled_pressure3_t"://143
                    MAVLink.mavlink_scaled_pressure3_t scaled_pressure3 = (MAVLink.mavlink_scaled_pressure3_t)obj;
                    str += string.Format("#{0} {1}\r\n", id = (int)MAVLink.MAVLINK_MSG_ID.SCALED_PRESSURE3, "mavlink_scaled_pressure3_t ");
                    str += string.Format("time_boot_ms:{0}\r\n", scaled_pressure3.time_boot_ms);
                    str += string.Format("press_abs:{0}\r\n", scaled_pressure3.press_abs);
                    str += string.Format("press_diff:{0}\r\n", scaled_pressure3.press_diff);
                    str += string.Format("temperature:{0}\r\n", scaled_pressure3.temperature);
                    break;
                //144 145 146没有
                case "MAVLink+mavlink_battery_status_t"://147
                    MAVLink.mavlink_battery_status_t battery_status = (MAVLink.mavlink_battery_status_t)obj;
                    str += string.Format("#{0} {1}\r\n", id = (int)MAVLink.MAVLINK_MSG_ID.BATTERY_STATUS, "mavlink_battery_status_t ");
                    str += string.Format("id:{0}\r\n", battery_status.id);
                    str += string.Format("battery_function:{0}\r\n", battery_status.battery_function);
                    str += string.Format("type:{0}\r\n", battery_status.type);
                    str += string.Format("temperature:{0}\r\n", battery_status.temperature);
                    str += string.Format("current_battery:{0}\r\n", battery_status.current_battery);
                    str += string.Format("current_consumed:{0}\r\n", battery_status.current_consumed);
                    str += string.Format("energy_consumed:{0}\r\n", battery_status.energy_consumed);
                    str += string.Format("battery_remaining:{0}\r\n", battery_status.battery_remaining);
                    break;
                case "MAVLink+mavlink_autopilot_version_t"://148
                    MAVLink.mavlink_autopilot_version_t autopilot_version = (MAVLink.mavlink_autopilot_version_t)obj;
                    str += string.Format("#{0} {1}\r\n", id = (int)MAVLink.MAVLINK_MSG_ID.AUTOPILOT_VERSION, "mavlink_autopilot_version_t");
                    str += string.Format("capabilities:{0}\r\n", autopilot_version.capabilities);
                    str += string.Format("flight_sw_version:{0}\r\n", autopilot_version.flight_sw_version);
                    str += string.Format("middleware_sw_version:{0}\r\n", autopilot_version.middleware_sw_version);
                    str += string.Format("os_sw_version:{0}\r\n", autopilot_version.os_sw_version);
                    str += string.Format("board_version:{0}\r\n", autopilot_version.board_version);
                    //str += string.Format("flight_custom_version:{0}\r\n", bytedata(autopilot_version.flight_custom_version));
                    str += string.Format("flight_custom_version:{0}\r\n", byteToString(autopilot_version.flight_custom_version)); Console.WriteLine("***");
                    //str += string.Format("flight_custom_version:{0}\r\n", autopilot_version.flight_custom_version[0], autopilot_version.flight_custom_version[1], autopilot_version.flight_custom_version[2], autopilot_version.flight_custom_version[3], autopilot_version.flight_custom_version[4], autopilot_version.flight_custom_version[5], autopilot_version.flight_custom_version[6], autopilot_version.flight_custom_version[7]);
                    //str += string.Format("flight_custom_version:{0} {1} {2} {3} {4} {5} {6} {7}\r\n", autopilot_version.flight_custom_version[0], autopilot_version.flight_custom_version[1], autopilot_version.flight_custom_version[2], autopilot_version.flight_custom_version[3], autopilot_version.flight_custom_version[4], autopilot_version.flight_custom_version[5], autopilot_version.flight_custom_version[6], autopilot_version.flight_custom_version[7]);
                    str += string.Format("middleware_custom_version:{0}\r\n", byteToString(autopilot_version.middleware_custom_version));
                    str += string.Format("os_custom_version:{0}\r\n", byteToString(autopilot_version.os_custom_version));
                    str += string.Format("vendor_id:{0}\r\n", autopilot_version.vendor_id);
                    str += string.Format("product_id:{0}\r\n", autopilot_version.product_id);
                    str += string.Format("uid:{0}\r\n", autopilot_version.uid);
                    break;
                case "MAVLink+mavlink_landing_target_t"://149
                    MAVLink.mavlink_landing_target_t landing_target = (MAVLink.mavlink_landing_target_t)obj;
                    str += string.Format("#{0} {1}\r\n", id = (int)MAVLink.MAVLINK_MSG_ID.LANDING_TARGET, "mavlink_landing_target_t");
                    str += string.Format("time_usec:{0}\r\n", landing_target.time_usec);
                    str += string.Format("target_num:{0}\r\n", landing_target.target_num);
                    str += string.Format("frame:{0}\r\n", landing_target.frame);
                    str += string.Format("angle_x:{0}\r\n", landing_target.angle_x);
                    str += string.Format("angle_y:{0}\r\n", landing_target.angle_y);
                    str += string.Format("distance:{0}\r\n", landing_target.distance);
                    str += string.Format("size_x:{0}\r\n", landing_target.size_x);
                    str += string.Format("size_y:{0}\r\n", landing_target.size_y);
                    break;
                //150-248没有
                case "MAVLink+mavlink_sensor_offsets_t"://150
                    MAVLink.mavlink_sensor_offsets_t sensor_offsets = (MAVLink.mavlink_sensor_offsets_t)obj;
                    str += string.Format("#{0} {1}\r\n", id = (int)MAVLink.MAVLINK_MSG_ID.SENSOR_OFFSETS, "sensor_offsets");
                    str += string.Format("accel_cal_x:{0}\r\n", sensor_offsets.accel_cal_x);
                    str += string.Format("accel_cal_y:{0}\r\n", sensor_offsets.accel_cal_y);
                    str += string.Format("accel_cal_z:{0}\r\n", sensor_offsets.accel_cal_z);
                    str += string.Format("gyro_cal_x:{0}\r\n", sensor_offsets.gyro_cal_x);
                    str += string.Format("gyro_cal_y:{0}\r\n", sensor_offsets.gyro_cal_y);
                    str += string.Format("gyro_cal_z:{0}\r\n", sensor_offsets.gyro_cal_z);
                    str += string.Format("mag_declination:{0}\r\n", sensor_offsets.mag_declination);
                    str += string.Format("mag_ofs_x:{0}\r\n", sensor_offsets.mag_ofs_x);
                    str += string.Format("mag_ofs_y:{0}\r\n", sensor_offsets.mag_ofs_y);
                    str += string.Format("mag_ofs_z:{0}\r\n", sensor_offsets.mag_ofs_z);
                    str += string.Format("raw_press:{0}\r\n", sensor_offsets.raw_press);
                    str += string.Format("raw_temp:{0}\r\n", sensor_offsets.raw_temp);
                    break;
                case "MAVLink+mavlink_meminfo_t"://152
                    MAVLink.mavlink_meminfo_t meminfo = (MAVLink.mavlink_meminfo_t)obj;
                    str += string.Format("#{0} {1}\r\n", id = (int)MAVLink.MAVLINK_MSG_ID.MEMINFO, "mavlink_meminfo_t");
                    str += string.Format("brkval:{0}\r\n", meminfo.brkval);
                    str += string.Format("freemem:{0}\r\n", meminfo.freemem);
                    break;
                case "MAVLink+mavlink_ahrs_t"://163
                    MAVLink.mavlink_ahrs_t ahrs = (MAVLink.mavlink_ahrs_t)obj;
                    str += string.Format("#{0} {1}\r\n", id = (int)MAVLink.MAVLINK_MSG_ID.AHRS, "mavlink_ahrs_t");
                    str += string.Format("renorm_val:{0}\r\n", ahrs.renorm_val);
                    str += string.Format("accel_weight:{0}\r\n", ahrs.accel_weight);
                    str += string.Format("error_rp:{0}\r\n", ahrs.error_rp);
                    str += string.Format("error_yaw:{0}\r\n", ahrs.error_yaw);
                    str += string.Format("omegaIx:{0}\r\n", ahrs.omegaIx);
                    str += string.Format("omegaIy:{0}\r\n", ahrs.omegaIy);
                    str += string.Format("omegaIz:{0}\r\n", ahrs.omegaIz);
                    break;
                case "MAVLink+mavlink_hwstatus_t"://163
                    MAVLink.mavlink_hwstatus_t hwstatus = (MAVLink.mavlink_hwstatus_t)obj;
                    str += string.Format("#{0} {1}\r\n", id = (int)MAVLink.MAVLINK_MSG_ID.HWSTATUS, "mavlink_hwstatus_t");
                    str += string.Format("Vcc:{0}\r\n", hwstatus.Vcc);
                    str += string.Format("hwstatus.I2Cerr:{0}\r\n", hwstatus.I2Cerr);
                    break;
                case "MAVLink+mavlink_ahrs2_t"://178
                    MAVLink.mavlink_ahrs2_t ahrs2 = (MAVLink.mavlink_ahrs2_t)obj;
                    str += string.Format("#{0} {1}\r\n", id = (int)MAVLink.MAVLINK_MSG_ID.AHRS2, "mavlink_ahrs2_t");
                    str += string.Format("altitude:{0}\r\n", ahrs2.altitude);
                    str += string.Format("lat:{0}\r\n", ahrs2.lat);
                    str += string.Format("lng:{0}\r\n", ahrs2.lng);
                    str += string.Format("pitch:{0}\r\n", ahrs2.pitch);
                    str += string.Format("roll:{0}\r\n", ahrs2.roll);
                    str += string.Format("yaw:{0}\r\n", ahrs2.yaw);
                    break;
                case "MAVLink+mavlink_ahrs3_t"://182
                    MAVLink.mavlink_ahrs3_t ahrs3 = (MAVLink.mavlink_ahrs3_t)obj;
                    str += string.Format("#{0} {1}\r\n", id = (int)MAVLink.MAVLINK_MSG_ID.AHRS3, "mavlink_ahrs3_t");
                    str += string.Format("altitude:{0}\r\n", ahrs3.altitude);
                    str += string.Format("lat:{0}\r\n", ahrs3.lat);
                    str += string.Format("lng:{0}\r\n", ahrs3.lng);
                    str += string.Format("pitch:{0}\r\n", ahrs3.pitch);
                    str += string.Format("roll:{0}\r\n", ahrs3.roll);
                    str += string.Format("yaw:{0}\r\n", ahrs3.yaw);
                    str += string.Format("v1:{0}\r\n", ahrs3.v1);
                    str += string.Format("v2:{0}\r\n", ahrs3.v2);
                    str += string.Format("v3:{0}\r\n", ahrs3.v3);
                    str += string.Format("v4:{0}\r\n", ahrs3.v4);
                    break;
                case "MAVLink+mavlink_ekf_status_report_t"://193
                    MAVLink.mavlink_ekf_status_report_t ekf_status_report = (MAVLink.mavlink_ekf_status_report_t)obj;
                    str += string.Format("#{0} {1}\r\n", id = (int)MAVLink.MAVLINK_MSG_ID.EKF_STATUS_REPORT, "mavlink_ekf_status_report_t");
                    str += string.Format("compass_variance:{0}\r\n", ekf_status_report.compass_variance);
                    str += string.Format("flags:{0}\r\n", ekf_status_report.flags);
                    str += string.Format("pos_horiz_variance:{0}\r\n", ekf_status_report.pos_horiz_variance);
                    str += string.Format("pos_vert_variance:{0}\r\n", ekf_status_report.pos_vert_variance);
                    str += string.Format("terrain_alt_variance:{0}\r\n", ekf_status_report.terrain_alt_variance);
                    str += string.Format("velocity_variance:{0}\r\n", ekf_status_report.velocity_variance);
                    break;
                case "MAVLink+mavlink_pid_tuning_t"://194
                    MAVLink.mavlink_pid_tuning_t pid_tuning = (MAVLink.mavlink_pid_tuning_t)obj;
                    str += string.Format("#{0} {1}\r\n", id = (int)MAVLink.MAVLINK_MSG_ID.PID_TUNING, "mavlink_pid_tuning_t");
                    str += string.Format("P:{0}\r\n", pid_tuning.P);
                    str += string.Format("I:{0}\r\n", pid_tuning.I);
                    str += string.Format("D:{0}\r\n", pid_tuning.D);
                    str += string.Format("achieved:{0}\r\n", pid_tuning.achieved);
                    str += string.Format("axis:{0}\r\n", pid_tuning.axis);
                    str += string.Format("desired:{0}\r\n", pid_tuning.desired);
                    str += string.Format("FF:{0}\r\n", pid_tuning.FF);
                    break;
                case "MAVLink+mavlink_vibration_t"://241
                    MAVLink.mavlink_vibration_t vibration = (MAVLink.mavlink_vibration_t)obj;
                    str += string.Format("#{0} {1}\r\n", id = (int)MAVLink.MAVLINK_MSG_ID.VIBRATION, "mavlink_vibration_t");
                    str += string.Format("time_usec:{0}\r\n", vibration.time_usec);
                    str += string.Format("vibration_x:{0}\r\n", vibration.vibration_x);
                    str += string.Format("vibration_y:{0}\r\n", vibration.vibration_y);
                    str += string.Format("vibration_z:{0}\r\n", vibration.vibration_z);
                    str += string.Format("clipping_0:{0}\r\n", vibration.clipping_0);
                    str += string.Format("clipping_1:{0}\r\n", vibration.clipping_1);
                    str += string.Format("clipping_2:{0}\r\n", vibration.clipping_2);
                    break;
                case "MAVLink+mavlink_memory_vect_t"://249
                    MAVLink.mavlink_memory_vect_t memory_vect = (MAVLink.mavlink_memory_vect_t)obj;
                    str += string.Format("#{0} {1}\r\n", id = (int)MAVLink.MAVLINK_MSG_ID.MEMORY_VECT, "mavlink_memory_vect_t");
                    str += string.Format("address:{0}\r\n", memory_vect.address);
                    str += string.Format("ver:{0}\r\n", memory_vect.ver);
                    str += string.Format("type:{0}\r\n", memory_vect.type);
                    str += string.Format("value:{0}\r\n", memory_vect.value);
                    break;
                //250没有
                case "MAVLink+mavlink_named_value_float_t"://251
                    MAVLink.mavlink_named_value_float_t named_value_float = (MAVLink.mavlink_named_value_float_t)obj;
                    str += string.Format("#{0} {1}\r\n", id = (int)MAVLink.MAVLINK_MSG_ID.NAMED_VALUE_FLOAT, "mavlink_named_value_float_t");
                    str += string.Format("time_boot_ms:{0}\r\n", named_value_float.time_boot_ms);
                    str += string.Format("name:{0}\r\n", named_value_float.name);
                    str += string.Format("value:{0}\r\n", named_value_float.value);
                    break;
                case "MAVLink+mavlink_named_value_int_t"://252
                    MAVLink.mavlink_named_value_int_t named_value_int = (MAVLink.mavlink_named_value_int_t)obj;
                    str += string.Format("#{0} {1}\r\n", id = (int)MAVLink.MAVLINK_MSG_ID.NAMED_VALUE_INT, "mavlink_named_value_int_t");
                    str += string.Format("time_boot_ms:{0}\r\n", named_value_int.time_boot_ms);
                    str += string.Format("name:{0}\r\n", named_value_int.name);
                    str += string.Format("value:{0}\r\n", named_value_int.value);
                    break;
                case "MAVLink+mavlink_statustext_t"://253
                    MAVLink.mavlink_statustext_t statustext = (MAVLink.mavlink_statustext_t)obj;
                    str += string.Format("#{0} {1}\r\n", id = (int)MAVLink.MAVLINK_MSG_ID.STATUSTEXT, "mavlink_statustext_t");
                    str += string.Format("severity:{0}\r\n", statustext.severity);
                    str += string.Format("text:{0}\r\n", (byteToCharArray(statustext.text)));
                    break;
                case "MAVLink+mavlink_debug_t"://254
                    MAVLink.mavlink_debug_t debug = (MAVLink.mavlink_debug_t)obj;
                    str += string.Format("#{0} {1}\r\n", id = (int)MAVLink.MAVLINK_MSG_ID.DEBUG, "mavlink_debug_t");
                    str += string.Format("time_boot_ms:{0}\r\n", debug.time_boot_ms);
                    str += string.Format("ind:{0}\r\n", debug.ind);
                    str += string.Format("value:{0}\r\n", debug.value);
                    break;
                //255没有
                default: str = "unknow type !" + obj.GetType(); break;
        
            }
        }
        catch { str = String.Format("error ! id={0}", id); }
        //finally { }
        return str;
    }
}
    

