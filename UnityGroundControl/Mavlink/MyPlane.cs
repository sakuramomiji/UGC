
using System;
using System.Collections.Generic;

public class MyPlane
{

    public List<object> message = new List<object>();
    //message list:
    public MAVLink.mavlink_heartbeat_t heartbeat_t { get { return (MAVLink.mavlink_heartbeat_t)message[0]; } set { message[0] = value; } }//0
    public MAVLink.mavlink_sys_status_t sys_status_t { get { return (MAVLink.mavlink_sys_status_t)message[1]; } set { message[1] = value; } }//1
    public MAVLink.mavlink_system_time_t system_time_t { get { return (MAVLink.mavlink_system_time_t)message[2]; } set { message[2] = value; } } //2
                                                                                                                                                 //3
    public MAVLink.mavlink_ping_t ping_t { get { return (MAVLink.mavlink_ping_t)message[4]; } set { message[4] = value; } }//4
    public MAVLink.mavlink_change_operator_control_t change_operator_control_t { get { return (MAVLink.mavlink_change_operator_control_t)message[5]; } set { message[5] = value; } }//5
    public MAVLink.mavlink_change_operator_control_ack_t change_operator_control_ack_t { get { return (MAVLink.mavlink_change_operator_control_ack_t)message[6]; } set { message[6] = value; } }//6
    public MAVLink.mavlink_auth_key_t auth_key_t { get { return (MAVLink.mavlink_auth_key_t)message[7]; } set { message[7] = value; } }//7
                                                                                                                                       //8
                                                                                                                                       //9
                                                                                                                                       //10
    public MAVLink.mavlink_set_mode_t set_mode_t { get { return (MAVLink.mavlink_set_mode_t)message[11]; } set { message[11] = value; } }//11
                                                                                                                                         //12
                                                                                                                                         //13
                                                                                                                                         //14
                                                                                                                                         //15
                                                                                                                                         //16
                                                                                                                                         //17
                                                                                                                                         //18
                                                                                                                                         //19
    public MAVLink.mavlink_param_request_read_t param_request_read_t { get { return (MAVLink.mavlink_param_request_read_t)message[20]; } set { message[20] = value; } }//20
    public MAVLink.mavlink_param_request_list_t param_request_list_t { get { return (MAVLink.mavlink_param_request_list_t)message[21]; } set { message[21] = value; } }//21
    public MAVLink.mavlink_param_value_t param_value_t { get { return (MAVLink.mavlink_param_value_t)message[22]; } set { message[22] = value; } }//22
    public MAVLink.mavlink_param_set_t param_set_t { get { return (MAVLink.mavlink_param_set_t)message[23]; } set { message[23] = value; } }//23
    public MAVLink.mavlink_gps_raw_int_t gps_raw_int_t { get { return (MAVLink.mavlink_gps_raw_int_t)message[24]; } set { message[24] = value; } }//24
    public MAVLink.mavlink_gps_status_t gps_status_t { get { return (MAVLink.mavlink_gps_status_t)message[25]; } set { message[25] = value; } }//25
    public MAVLink.mavlink_scaled_imu_t scaled_imu_t { get { return (MAVLink.mavlink_scaled_imu_t)message[26]; } set { message[26] = value; } }//26
    public MAVLink.mavlink_raw_imu_t raw_imu_t { get { return (MAVLink.mavlink_raw_imu_t)message[27]; } set { message[27] = value; } }//27
    public MAVLink.mavlink_raw_pressure_t raw_pressure_t { get { return (MAVLink.mavlink_raw_pressure_t)message[28]; } set { message[28] = value; } }//28
    public MAVLink.mavlink_scaled_pressure_t scaled_pressure_t { get { return (MAVLink.mavlink_scaled_pressure_t)message[29]; } set { message[29] = value; } }//29
    public MAVLink.mavlink_attitude_t attitude_t { get { return (MAVLink.mavlink_attitude_t)message[30]; } set { message[30] = value; } }//30
    public MAVLink.mavlink_attitude_quaternion_t attitude_quaternion_t { get { return (MAVLink.mavlink_attitude_quaternion_t)message[31]; } set { message[31] = value; } }//31
    public MAVLink.mavlink_local_position_ned_t local_position_ned_t { get { return (MAVLink.mavlink_local_position_ned_t)message[32]; } set { message[32] = value; } }//32
    public MAVLink.mavlink_global_position_int_t global_position_int_t { get { return (MAVLink.mavlink_global_position_int_t)message[33]; } set { message[33] = value; } }//33
    public MAVLink.mavlink_rc_channels_scaled_t rc_channels_scaled_t { get { return (MAVLink.mavlink_rc_channels_scaled_t)message[34]; } set { message[34] = value; } }//34
    public MAVLink.mavlink_rc_channels_raw_t rc_channels_raw_t { get { return (MAVLink.mavlink_rc_channels_raw_t)message[35]; } set { message[35] = value; } }//35
    public MAVLink.mavlink_servo_output_raw_t servo_output_raw_t { get { return (MAVLink.mavlink_servo_output_raw_t)message[36]; } set { message[36] = value; } }//36
    public MAVLink.mavlink_mission_request_partial_list_t mission_request_partial_list_t { get { return (MAVLink.mavlink_mission_request_partial_list_t)message[37]; } set { message[37] = value; } }//37
    public MAVLink.mavlink_mission_write_partial_list_t mission_write_partial_list_t { get { return (MAVLink.mavlink_mission_write_partial_list_t)message[38]; } set { message[38] = value; } }//38
    public MAVLink.mavlink_mission_item_t mission_item_t { get { return (MAVLink.mavlink_mission_item_t)message[39]; } set { message[39] = value; } }//39
    public MAVLink.mavlink_mission_request_t mission_request_t { get { return (MAVLink.mavlink_mission_request_t)message[40]; } set { message[40] = value; } }//40
    public MAVLink.mavlink_mission_set_current_t mission_set_current_t { get { return (MAVLink.mavlink_mission_set_current_t)message[41]; } set { message[41] = value; } }//41
    public MAVLink.mavlink_mission_current_t mission_current_t { get { return (MAVLink.mavlink_mission_current_t)message[42]; } set { message[42] = value; } }//42
    public MAVLink.mavlink_mission_request_list_t mission_request_list_t { get { return (MAVLink.mavlink_mission_request_list_t)message[43]; } set { message[43] = value; } }//43
    public MAVLink.mavlink_mission_count_t mission_count_t { get { return (MAVLink.mavlink_mission_count_t)message[44]; } set { message[44] = value; } }// 44,
    public MAVLink.mavlink_mission_clear_all_t mission_clear_all_t { get { return (MAVLink.mavlink_mission_clear_all_t)message[45]; } set { message[45] = value; } }// 45,
    public MAVLink.mavlink_mission_item_reached_t mission_item_reached_t { get { return (MAVLink.mavlink_mission_item_reached_t)message[46]; } set { message[46] = value; } }// 46,
    public MAVLink.mavlink_mission_ack_t mission_ack_t { get { return (MAVLink.mavlink_mission_ack_t)message[47]; } set { message[47] = value; } }// 47,
    public MAVLink.mavlink_set_gps_global_origin_t set_gps_global_origin_t { get { return (MAVLink.mavlink_set_gps_global_origin_t)message[48]; } set { message[48] = value; } }// 48,
    public MAVLink.mavlink_gps_global_origin_t _gps_global_origin_t { get { return (MAVLink.mavlink_gps_global_origin_t)message[49]; } set { message[49] = value; } }// 49,
    public MAVLink.mavlink_param_map_rc_t param_map_rc_t { get { return (MAVLink.mavlink_param_map_rc_t)message[50]; } set { message[50] = value; } }// 50,
                                                                                                                                                     //51
                                                                                                                                                     //52
                                                                                                                                                     //53
    public MAVLink.mavlink_safety_set_allowed_area_t safety_set_allowed_area_t { get { return (MAVLink.mavlink_safety_set_allowed_area_t)message[54]; } set { message[54] = value; } }// 54,
    public MAVLink.mavlink_safety_allowed_area_t safety_allowed_area_t { get { return (MAVLink.mavlink_safety_allowed_area_t)message[55]; } set { message[55] = value; } }// 55,
                                                                                                                                                                          //56
                                                                                                                                                                          //57
                                                                                                                                                                          //58
                                                                                                                                                                          //59
                                                                                                                                                                          //60
    public MAVLink.mavlink_attitude_quaternion_cov_t attitude_quaternion_cov_t { get { return (MAVLink.mavlink_attitude_quaternion_cov_t)message[61]; } set { message[61] = value; } }// 61,
    public MAVLink.mavlink_nav_controller_output_t nav_controller_output_t { get { return (MAVLink.mavlink_nav_controller_output_t)message[62]; } set { message[62] = value; } }// 62,
    public MAVLink.mavlink_global_position_int_cov_t global_position_int_cov_t { get { return (MAVLink.mavlink_global_position_int_cov_t)message[63]; } set { message[63] = value; } }// 63,
    public MAVLink.mavlink_local_position_ned_cov_t local_position_ned_cov_t { get { return (MAVLink.mavlink_local_position_ned_cov_t)message[64]; } set { message[64] = value; } }// 64,
    public MAVLink.mavlink_rc_channels_t rc_channels_t { get { return (MAVLink.mavlink_rc_channels_t)message[65]; } set { message[65] = value; } }// 65,
    public MAVLink.mavlink_request_data_stream_t request_data_stream_t { get { return (MAVLink.mavlink_request_data_stream_t)message[66]; } set { message[66] = value; } }// 66,
    public MAVLink.mavlink_data_stream_t data_stream_t { get { return (MAVLink.mavlink_data_stream_t)message[67]; } set { message[67] = value; } }// 67,
    public MAVLink.mavlink_manual_control_t manual_control_t { get { return (MAVLink.mavlink_manual_control_t)message[69]; } set { message[69] = value; } }// 69,
    public MAVLink.mavlink_rc_channels_override_t rc_channels_override_t { get { return (MAVLink.mavlink_rc_channels_override_t)message[70]; } set { message[70] = value; } }// 70,
                                                                                                                                                                             //71
                                                                                                                                                                             //72
    public MAVLink.mavlink_mission_item_int_t mission_item_int_t { get { return (MAVLink.mavlink_mission_item_int_t)message[73]; } set { message[73] = value; } }// 73,
    public MAVLink.mavlink_vfr_hud_t vfr_hud_t { get { return (MAVLink.mavlink_vfr_hud_t)message[74]; } set { message[74] = value; } }// 74,
    public MAVLink.mavlink_command_int_t command_int_t { get { return (MAVLink.mavlink_command_int_t)message[75]; } set { message[75] = value; } }// 75,
    public MAVLink.mavlink_command_long_t command_long_t { get { return (MAVLink.mavlink_command_long_t)message[76]; } set { message[76] = value; } }// 76,
    public MAVLink.mavlink_command_ack_t command_ack_t { get { return (MAVLink.mavlink_command_ack_t)message[77]; } set { message[77] = value; } }// 77,
                                                                                                                                                  //78
                                                                                                                                                  //79
                                                                                                                                                  //80
    public MAVLink.mavlink_manual_setpoint_t manual_setpoint_t { get { return (MAVLink.mavlink_manual_setpoint_t)message[81]; } set { message[81] = value; } }// 81,
    public MAVLink.mavlink_set_attitude_target_t set_attitude_target_t { get { return (MAVLink.mavlink_set_attitude_target_t)message[82]; } set { message[82] = value; } }// 82,
    public MAVLink.mavlink_attitude_target_t _attitude_target_t { get { return (MAVLink.mavlink_attitude_target_t)message[83]; } set { message[83] = value; } }// 83,
    public MAVLink.mavlink_set_position_target_local_ned_t set_position_target_local_ned_t { get { return (MAVLink.mavlink_set_position_target_local_ned_t)message[84]; } set { message[84] = value; } }// 84,
    public MAVLink.mavlink_position_target_local_ned_t _position_target_local_ned_t { get { return (MAVLink.mavlink_position_target_local_ned_t)message[85]; } set { message[85] = value; } }// 85,
    public MAVLink.mavlink_set_position_target_global_int_t set_position_target_global_int_t { get { return (MAVLink.mavlink_set_position_target_global_int_t)message[86]; } set { message[86] = value; } }// 86,
    public MAVLink.mavlink_position_target_global_int_t _position_target_global_int_t { get { return (MAVLink.mavlink_position_target_global_int_t)message[87]; } set { message[87] = value; } }// 87,
                                                                                                                                                                                                //88
    public MAVLink.mavlink_local_position_ned_system_global_offset_t local_position_ned_system_global_offset_t { get { return (MAVLink.mavlink_local_position_ned_system_global_offset_t)message[89]; } set { message[89] = value; } }// 89,
    public MAVLink.mavlink_hil_state_t hil_state_t { get { return (MAVLink.mavlink_hil_state_t)message[90]; } set { message[90] = value; } }// 90,
    public MAVLink.mavlink_hil_controls_t hil_controls_t { get { return (MAVLink.mavlink_hil_controls_t)message[91]; } set { message[91] = value; } }// 91,
    public MAVLink.mavlink_hil_rc_inputs_raw_t hil_rc_inputs_raw_t { get { return (MAVLink.mavlink_hil_rc_inputs_raw_t)message[92]; } set { message[92] = value; } }// 92,
                                                                                                                                                                    //93
                                                                                                                                                                    //94
                                                                                                                                                                    //95
                                                                                                                                                                    //96
                                                                                                                                                                    //97
                                                                                                                                                                    //98
                                                                                                                                                                    //99
    public MAVLink.mavlink_optical_flow_t optical_flow_t { get { return (MAVLink.mavlink_optical_flow_t)message[100]; } set { message[100] = value; } }// 100,
    public MAVLink.mavlink_global_vision_position_estimate_t global_vision_position_estimate_t { get { return (MAVLink.mavlink_global_vision_position_estimate_t)message[101]; } set { message[101] = value; } }// 101,
    public MAVLink.mavlink_vision_position_estimate_t vision_position_estimate_t { get { return (MAVLink.mavlink_vision_position_estimate_t)message[102]; } set { message[102] = value; } }// 102,
    public MAVLink.mavlink_vision_speed_estimate_t vision_speed_estimate_t { get { return (MAVLink.mavlink_vision_speed_estimate_t)message[103]; } set { message[103] = value; } }// 103,
    public MAVLink.mavlink_vicon_position_estimate_t vicon_position_estimate_t { get { return (MAVLink.mavlink_vicon_position_estimate_t)message[104]; } set { message[104] = value; } }// 104,
    public MAVLink.mavlink_highres_imu_t highres_imu_t { get { return (MAVLink.mavlink_highres_imu_t)message[105]; } set { message[105] = value; } }// 105,
    public MAVLink.mavlink_optical_flow_rad_t optical_flow_rad_t { get { return (MAVLink.mavlink_optical_flow_rad_t)message[106]; } set { message[106] = value; } }// 106,
    public MAVLink.mavlink_hil_sensor_t hil_sensor_t { get { return (MAVLink.mavlink_hil_sensor_t)message[107]; } set { message[107] = value; } }// 107,
    public MAVLink.mavlink_sim_state_t sim_state_t { get { return (MAVLink.mavlink_sim_state_t)message[108]; } set { message[108] = value; } }// 108,
    public MAVLink.mavlink_radio_status_t radio_status_t { get { return (MAVLink.mavlink_radio_status_t)message[109]; } set { message[109] = value; } }// 109,
    public MAVLink.mavlink_file_transfer_protocol_t file_transfer_protocol_t { get { return (MAVLink.mavlink_file_transfer_protocol_t)message[110]; } set { message[110] = value; } }// 110,
    public MAVLink.mavlink_timesync_t timesync_t { get { return (MAVLink.mavlink_timesync_t)message[111]; } set { message[111] = value; } }//= 111,
                                                                                                                                           //112
    public MAVLink.mavlink_hil_gps_t hil_gps_t { get { return (MAVLink.mavlink_hil_gps_t)message[113]; } set { message[113] = value; } }// 113,
    public MAVLink.mavlink_hil_optical_flow_t hil_optical_flow_t { get { return (MAVLink.mavlink_hil_optical_flow_t)message[114]; } set { message[114] = value; } }// 114,
    public MAVLink.mavlink_hil_state_quaternion_t hil_state_quaternion_t { get { return (MAVLink.mavlink_hil_state_quaternion_t)message[115]; } set { message[115] = value; } }// 115,
    public MAVLink.mavlink_scaled_imu2_t scaled_imu2_t { get { return (MAVLink.mavlink_scaled_imu2_t)message[116]; } set { message[116] = value; } }// 116,
    public MAVLink.mavlink_log_request_list_t log_request_list_t { get { return (MAVLink.mavlink_log_request_list_t)message[117]; } set { message[117] = value; } }// 117,
    public MAVLink.mavlink_log_entry_t log_entry_t { get { return (MAVLink.mavlink_log_entry_t)message[118]; } set { message[118] = value; } }// 118,
    public MAVLink.mavlink_log_request_data_t log_request_data_t { get { return (MAVLink.mavlink_log_request_data_t)message[119]; } set { message[119] = value; } }// 119,
    public MAVLink.mavlink_log_data_t log_data_t { get { return (MAVLink.mavlink_log_data_t)message[120]; } set { message[120] = value; } }// 120,
    public MAVLink.mavlink_log_erase_t log_erase_t { get { return (MAVLink.mavlink_log_erase_t)message[121]; } set { message[121] = value; } }// 121,
    public MAVLink.mavlink_log_request_end_t log_request_end_t { get { return (MAVLink.mavlink_log_request_end_t)message[122]; } set { message[122] = value; } }// 122,
    public MAVLink.mavlink_gps_inject_data_t gps_inject_data_t { get { return (MAVLink.mavlink_gps_inject_data_t)message[123]; } set { message[123] = value; } }// 123,
    public MAVLink.mavlink_gps2_raw_t gps2_raw_t { get { return (MAVLink.mavlink_gps2_raw_t)message[124]; } set { message[124] = value; } }// 124,
    public MAVLink.mavlink_power_status_t power_status_t { get { return (MAVLink.mavlink_power_status_t)message[125]; } set { message[125] = value; } }// 125,
    public MAVLink.mavlink_serial_control_t serial_control_t { get { return (MAVLink.mavlink_serial_control_t)message[126]; } set { message[126] = value; } }// 126,
    public MAVLink.mavlink_gps_rtk_t gps_rtk_t { get { return (MAVLink.mavlink_gps_rtk_t)message[127]; } set { message[127] = value; } }// 127,
    public MAVLink.mavlink_gps2_rtk_t gps2_rtk_t { get { return (MAVLink.mavlink_gps2_rtk_t)message[128]; } set { message[128] = value; } }// 128,
    public MAVLink.mavlink_scaled_imu3_t scaled_imu3_t { get { return (MAVLink.mavlink_scaled_imu3_t)message[129]; } set { message[129] = value; } }// 129,
    public MAVLink.mavlink_data_transmission_handshake_t data_transmission_handshake_t { get { return (MAVLink.mavlink_data_transmission_handshake_t)message[130]; } set { message[130] = value; } }// 130,
    public MAVLink.mavlink_encapsulated_data_t encapsulated_data_t { get { return (MAVLink.mavlink_encapsulated_data_t)message[131]; } set { message[131] = value; } }// 131,
    public MAVLink.mavlink_distance_sensor_t distance_sensor_t { get { return (MAVLink.mavlink_distance_sensor_t)message[132]; } set { message[132] = value; } }// 132,
    public MAVLink.mavlink_terrain_request_t terrain_request_t { get { return (MAVLink.mavlink_terrain_request_t)message[133]; } set { message[133] = value; } }// 133,
    public MAVLink.mavlink_terrain_data_t terrain_data_t { get { return (MAVLink.mavlink_terrain_data_t)message[134]; } set { message[134] = value; } }//134,
    public MAVLink.mavlink_terrain_check_t terrain_check_t { get { return (MAVLink.mavlink_terrain_check_t)message[135]; } set { message[135] = value; } }// 135,
    public MAVLink.mavlink_terrain_report_t terrain_report_t { get { return (MAVLink.mavlink_terrain_report_t)message[136]; } set { message[136] = value; } }// 136,
    public MAVLink.mavlink_scaled_pressure2_t scaled_pressure2_t { get { return (MAVLink.mavlink_scaled_pressure2_t)message[137]; } set { message[137] = value; } }// 137,
    public MAVLink.mavlink_att_pos_mocap_t att_pos_mocap_t { get { return (MAVLink.mavlink_att_pos_mocap_t)message[138]; } set { message[138] = value; } }// 138,
    public MAVLink.mavlink_set_actuator_control_target_t set__actuator_control_target_t { get { return (MAVLink.mavlink_set_actuator_control_target_t)message[139]; } set { message[139] = value; } }// 139,
    public MAVLink.mavlink_actuator_control_target_t actuator_control_target_t
    {
        get
        {
            return (MAVLink.mavlink_actuator_control_target_t)message[140];
        }
        set
        {
            message[140] = value;
        }
    }// 140,    
     //141
     //142
    public MAVLink.mavlink_scaled_pressure3_t scaled_pressure3_t { get { return (MAVLink.mavlink_scaled_pressure3_t)message[143]; } set { message[143] = value; } }// 143,
                                                                                                                                                                   //144
                                                                                                                                                                   //145
                                                                                                                                                                   //146
    public MAVLink.mavlink_battery_status_t battery_status_t { get { return (MAVLink.mavlink_battery_status_t)message[147]; } set { message[147] = value; } }// 147,
    public MAVLink.mavlink_autopilot_version_t autopilot_version_t { get { return (MAVLink.mavlink_autopilot_version_t)message[148]; } set { message[148] = value; } }// 148,
    public MAVLink.mavlink_landing_target_t landing_target_t { get { return (MAVLink.mavlink_landing_target_t)message[149]; } set { message[149] = value; } }// 149,
    public MAVLink.mavlink_sensor_offsets_t sensor_offsets_t { get { return (MAVLink.mavlink_sensor_offsets_t)message[150]; } set { message[150] = value; } }// 150,
    public MAVLink.mavlink_set_mag_offsets_t set_mag_offsets_t { get { return (MAVLink.mavlink_set_mag_offsets_t)message[151]; } set { message[151] = value; } }// 151,
    public MAVLink.mavlink_meminfo_t meminfo_t { get { return (MAVLink.mavlink_meminfo_t)message[152]; } set { message[152] = value; } }// 152,
    public MAVLink.mavlink_ap_adc_t ap_adc_t { get { return (MAVLink.mavlink_ap_adc_t)message[153]; } set { message[153] = value; } }// 153,
    public MAVLink.mavlink_digicam_configure_t digicam_configure_t { get { return (MAVLink.mavlink_digicam_configure_t)message[154]; } set { message[154] = value; } }// 154,
    public MAVLink.mavlink_digicam_control_t digicam_control_t { get { return (MAVLink.mavlink_digicam_control_t)message[155]; } set { message[155] = value; } }// 155,
    public MAVLink.mavlink_mount_configure_t mount_configure_t { get { return (MAVLink.mavlink_mount_configure_t)message[156]; } set { message[156] = value; } }// 156,
    public MAVLink.mavlink_mount_control_t mount_control_t { get { return (MAVLink.mavlink_mount_control_t)message[157]; } set { message[157] = value; } }// 157,
    public MAVLink.mavlink_mount_status_t mount_status_t { get { return (MAVLink.mavlink_mount_status_t)message[159]; } set { message[159] = value; } }// 158,
                                                                                                                                                       //159
    public MAVLink.mavlink_fence_point_t fence_point_t { get { return (MAVLink.mavlink_fence_point_t)message[160]; } set { message[160] = value; } }// 160,
    public MAVLink.mavlink_fence_fetch_point_t fence_fetch_point_t { get { return (MAVLink.mavlink_fence_fetch_point_t)message[161]; } set { message[161] = value; } }// 161,
    public MAVLink.mavlink_fence_status_t fence_status_t { get { return (MAVLink.mavlink_fence_status_t)message[162]; } set { message[162] = value; } }// 162,
    public MAVLink.mavlink_ahrs_t ahrs_t { get { return (MAVLink.mavlink_ahrs_t)message[163]; } set { message[163] = value; } }// 163,
    public MAVLink.mavlink_simstate_t simstate_t { get { return (MAVLink.mavlink_simstate_t)message[164]; } set { message[164] = value; } }// 164,
    public MAVLink.mavlink_hwstatus_t hwstatus_t { get { return (MAVLink.mavlink_hwstatus_t)message[165]; } set { message[165] = value; } }//  165,
    public MAVLink.mavlink_radio_t radio_t { get { return (MAVLink.mavlink_radio_t)message[166]; } set { message[166] = value; } }// 166,
    public MAVLink.mavlink_limits_status_t limits_status_t { get { return (MAVLink.mavlink_limits_status_t)message[167]; } set { message[167] = value; } }// 167,
    public MAVLink.mavlink_wind_t wind_t { get { return (MAVLink.mavlink_wind_t)message[168]; } set { message[168] = value; } }// 168,
    public MAVLink.mavlink_data16_t data16_t { get { return (MAVLink.mavlink_data16_t)message[169]; } set { message[169] = value; } }// 169,
    public MAVLink.mavlink_data32_t data32_t { get { return (MAVLink.mavlink_data32_t)message[170]; } set { message[170] = value; } }// 170,
    public MAVLink.mavlink_data64_t data64_t { get { return (MAVLink.mavlink_data64_t)message[171]; } set { message[171] = value; } }// 171,
    public MAVLink.mavlink_data96_t data96_t { get { return (MAVLink.mavlink_data96_t)message[172]; } set { message[172] = value; } }// 172,
    public MAVLink.mavlink_rangefinder_t rangefinder_t { get { return (MAVLink.mavlink_rangefinder_t)message[173]; } set { message[173] = value; } }// 173,
    public MAVLink.mavlink_airspeed_autocal_t airspeed_autocal_t { get { return (MAVLink.mavlink_airspeed_autocal_t)message[174]; } set { message[174] = value; } }// 174,
    public MAVLink.mavlink_rally_point_t rally_point_t { get { return (MAVLink.mavlink_rally_point_t)message[175]; } set { message[175] = value; } }// 175,
    public MAVLink.mavlink_rally_fetch_point_t rally_fetch_point_t { get { return (MAVLink.mavlink_rally_fetch_point_t)message[176]; } set { message[176] = value; } }// 176,
    public MAVLink.mavlink_compassmot_status_t compassmot_status_t { get { return (MAVLink.mavlink_compassmot_status_t)message[177]; } set { message[177] = value; } }// 177,
    public MAVLink.mavlink_ahrs2_t ahrs2_t { get { return (MAVLink.mavlink_ahrs2_t)message[178]; } set { message[178] = value; } }// 178,
    public MAVLink.mavlink_camera_status_t camera_status_t { get { return (MAVLink.mavlink_camera_status_t)message[179]; } set { message[179] = value; } } // 179,
    public MAVLink.mavlink_camera_feedback_t camera_feedback_t { get { return (MAVLink.mavlink_camera_feedback_t)message[180]; } set { message[180] = value; } }// 180,
    public MAVLink.mavlink_battery2_t battery2_t { get { return (MAVLink.mavlink_battery2_t)message[181]; } set { message[181] = value; } }// 181,
    public MAVLink.mavlink_ahrs3_t ahrs3_t { get { return (MAVLink.mavlink_ahrs3_t)message[182]; } set { message[182] = value; } }// 182,
    public MAVLink.mavlink_autopilot_version_request_t autopilot_version_request_t { get { return (MAVLink.mavlink_autopilot_version_request_t)message[183]; } set { message[183] = value; } }// 183,
                                                                                                                                                                                              //184
                                                                                                                                                                                              //185
    public MAVLink.mavlink_led_control_t led_control_t { get { return (MAVLink.mavlink_led_control_t)message[186]; } set { message[186] = value; } }// 186,
                                                                                                                                                    //187
                                                                                                                                                    //188
                                                                                                                                                    //189
                                                                                                                                                    //190
    public MAVLink.mavlink_mag_cal_progress_t mag_cal_progress_t { get { return (MAVLink.mavlink_mag_cal_progress_t)message[191]; } set { message[191] = value; } }// 191,
    public MAVLink.mavlink_mag_cal_report_t mag_cal_report_t { get { return (MAVLink.mavlink_mag_cal_report_t)message[192]; } set { message[192] = value; } }// 192,
    public MAVLink.mavlink_ekf_status_report_t ekf_status_report_t { get { return (MAVLink.mavlink_ekf_status_report_t)message[193]; } set { message[193] = value; } }// 193,
    public MAVLink.mavlink_pid_tuning_t pid_tuning_t { get { return (MAVLink.mavlink_pid_tuning_t)message[194]; } set { message[194] = value; } }// 194,
                                                                                                                                                 //195
                                                                                                                                                 //196
                                                                                                                                                 //197
                                                                                                                                                 //198
                                                                                                                                                 //199
    public MAVLink.mavlink_gimbal_report_t gimbal_report_t { get { return (MAVLink.mavlink_gimbal_report_t)message[200]; } set { message[200] = value; } }// 200,
    public MAVLink.mavlink_gimbal_control_t gimbal_control_t { get { return (MAVLink.mavlink_gimbal_control_t)message[201]; } set { message[201] = value; } }// 201,
    public MAVLink.mavlink_gimbal_reset_t gimbal_reset_t { get { return (MAVLink.mavlink_gimbal_reset_t)message[202]; } set { message[202] = value; } }// 202,
    public MAVLink.mavlink_gimbal_axis_calibration_progress_t gimbal_axis_calibration_progress_t { get { return (MAVLink.mavlink_gimbal_axis_calibration_progress_t)message[203]; } set { message[203] = value; } }// 203,
    public MAVLink.mavlink_gimbal_set_home_offsets_t gimbal_set_home_offsets_t { get { return (MAVLink.mavlink_gimbal_set_home_offsets_t)message[204]; } set { message[204] = value; } }// 204,
    public MAVLink.mavlink_gimbal_home_offset_calibration_result_t gimbal_home_offset_calibration_result_t { get { return (MAVLink.mavlink_gimbal_home_offset_calibration_result_t)message[205]; } set { message[205] = value; } }// 205,
    public MAVLink.mavlink_gimbal_set_factory_parameters_t gimbal_set_factory_parameters_t { get { return (MAVLink.mavlink_gimbal_set_factory_parameters_t)message[206]; } set { message[206] = value; } }// 206,
    public MAVLink.mavlink_gimbal_factory_parameters_loaded_t gimbal_factory_parameters_loaded_t { get { return (MAVLink.mavlink_gimbal_factory_parameters_loaded_t)message[207]; } set { message[207] = value; } }// 207,
    public MAVLink.mavlink_gimbal_erase_firmware_and_config_t gimbal_erase_firmware_and_config_t { get { return (MAVLink.mavlink_gimbal_erase_firmware_and_config_t)message[208]; } set { message[208] = value; } }// 208,
    public MAVLink.mavlink_gimbal_perform_factory_tests_t gimbal_perform_factory_tests_t { get { return (MAVLink.mavlink_gimbal_perform_factory_tests_t)message[209]; } set { message[209] = value; } }// 209,
    public MAVLink.mavlink_gimbal_report_factory_tests_progress_t gimbal_report_factory_tests_progress_t { get { return (MAVLink.mavlink_gimbal_report_factory_tests_progress_t)message[210]; } set { message[210] = value; } }// 210,
    public MAVLink.mavlink_gimbal_request_axis_calibration_status_t gimbal_request_axis_calibration_status_t { get { return (MAVLink.mavlink_gimbal_request_axis_calibration_status_t)message[211]; } set { message[211] = value; } }// 211,
    public MAVLink.mavlink_gimbal_report_axis_calibration_status_t gimbal_report_axis_calibration_status_t { get { return (MAVLink.mavlink_gimbal_report_axis_calibration_status_t)message[212]; } set { message[212] = value; } }// 212,
    public MAVLink.mavlink_gimbal_request_axis_calibration_t gimbal_request_axis_calibration_t { get { return (MAVLink.mavlink_gimbal_request_axis_calibration_t)message[213]; } set { message[213] = value; } }// 213,
                                                                                                                                                                                                                //214
    public MAVLink.mavlink_gopro_heartbeat_t gopro_heartbeat_t { get { return (MAVLink.mavlink_gopro_heartbeat_t)message[215]; } set { message[215] = value; } }// 215,
    public MAVLink.mavlink_gopro_get_request_t gopro_get_request_t { get { return (MAVLink.mavlink_gopro_get_request_t)message[216]; } set { message[216] = value; } }//216,
    public MAVLink.mavlink_gopro_get_response_t gopro_get_response_t { get { return (MAVLink.mavlink_gopro_get_response_t)message[217]; } set { message[217] = value; } }//217,
    public MAVLink.mavlink_gopro_set_request_t gopro_set_request_t { get { return (MAVLink.mavlink_gopro_set_request_t)message[218]; } set { message[218] = value; } }//218,
    public MAVLink.mavlink_gopro_set_response_t gopro_set_response_t { get { return (MAVLink.mavlink_gopro_set_response_t)message[219]; } set { message[219] = value; } }// 219,
                                                                                                                                                                         //220
                                                                                                                                                                         //221
                                                                                                                                                                         //222
                                                                                                                                                                         //223
                                                                                                                                                                         //224
                                                                                                                                                                         //225
    public MAVLink.mavlink_rpm_t rpm_t { get { return (MAVLink.mavlink_rpm_t)message[226]; } set { message[226] = value; } }// 226,
                                                                                                                            //227
                                                                                                                            //228
                                                                                                                            //229
                                                                                                                            //230
                                                                                                                            //231
                                                                                                                            //232
                                                                                                                            //233
                                                                                                                            //234
                                                                                                                            //235
                                                                                                                            //236
                                                                                                                            //237
                                                                                                                            //238
                                                                                                                            //239
                                                                                                                            //240
    public MAVLink.mavlink_vibration_t vibration_t { get { return (MAVLink.mavlink_vibration_t)message[241]; } set { message[241] = value; } }// 241,
                                                                                                                                              //242
                                                                                                                                              //243
                                                                                                                                              //244
                                                                                                                                              //245
                                                                                                                                              //246
                                                                                                                                              //247
    public MAVLink.mavlink_v2_extension_t v2_extension_t { get { return (MAVLink.mavlink_v2_extension_t)message[248]; } set { message[248] = value; } }// 248,
    public MAVLink.mavlink_memory_vect_t memory_vect_t { get { return (MAVLink.mavlink_memory_vect_t)message[249]; } set { message[249] = value; } }// 249,
    public MAVLink.mavlink_debug_vect_t debug_vect_t { get { return (MAVLink.mavlink_debug_vect_t)message[250]; } set { message[250] = value; } }// 250,
    public MAVLink.mavlink_named_value_float_t named_value_float_t { get { return (MAVLink.mavlink_named_value_float_t)message[251]; } set { message[251] = value; } }// 251,
    public MAVLink.mavlink_named_value_int_t named_value_int_t { get { return (MAVLink.mavlink_named_value_int_t)message[242]; } set { message[242] = value; } }// 252,
    public MAVLink.mavlink_statustext_t statustext_t { get { return (MAVLink.mavlink_statustext_t)message[253]; } set { message[253] = value; } }// 253,
    public MAVLink.mavlink_debug_t debug_t { get { return (MAVLink.mavlink_debug_t)message[254]; } set { message[254] = value; } }// 254,





    public MyPlane()
    {
        message.Add(new MAVLink.mavlink_heartbeat_t());//0
        message.Add(new MAVLink.mavlink_sys_status_t());// 1,
        message.Add(new MAVLink.mavlink_system_time_t());// 2,
        message.Add(new byte[270]);//3
        message.Add(new MAVLink.mavlink_ping_t());// 4,
        message.Add(new MAVLink.mavlink_change_operator_control_t());// 5,
        message.Add(new MAVLink.mavlink_change_operator_control_ack_t());// 6,
        message.Add(new MAVLink.mavlink_auth_key_t());// 7,
        message.Add(new byte[270]);//8
        message.Add(new byte[270]);//9
        message.Add(new byte[270]);//10
        message.Add(new MAVLink.mavlink_set_mode_t());// 11,
        message.Add(new byte[270]);//12
        message.Add(new byte[270]);//13
        message.Add(new byte[270]);//14
        message.Add(new byte[270]);//15
        message.Add(new byte[270]);//16
        message.Add(new byte[270]);//17
        message.Add(new byte[270]);//18
        message.Add(new byte[270]);//19
        message.Add(new MAVLink.mavlink_param_request_read_t());// 20,
        message.Add(new MAVLink.mavlink_param_request_list_t());// 21,
        message.Add(new MAVLink.mavlink_param_value_t());// 22,
        message.Add(new MAVLink.mavlink_param_set_t());// 23,
        message.Add(new MAVLink.mavlink_gps_raw_int_t());// 24,
        message.Add(new MAVLink.mavlink_gps_status_t());// 25,
        message.Add(new MAVLink.mavlink_scaled_imu_t());// 26,
        message.Add(new MAVLink.mavlink_raw_imu_t());// 27,
        message.Add(new MAVLink.mavlink_raw_pressure_t());// 28,
        message.Add(new MAVLink.mavlink_scaled_pressure_t());// 29,
        message.Add(new MAVLink.mavlink_attitude_t());// 30,
        message.Add(new MAVLink.mavlink_attitude_quaternion_t());// 31,
        message.Add(new MAVLink.mavlink_local_position_ned_t());// 32,
        message.Add(new MAVLink.mavlink_global_position_int_t());// 33,
        message.Add(new MAVLink.mavlink_rc_channels_scaled_t());// 34,
        message.Add(new MAVLink.mavlink_rc_channels_raw_t());// 35,
        message.Add(new MAVLink.mavlink_servo_output_raw_t());// 36,
        message.Add(new MAVLink.mavlink_mission_request_partial_list_t());// 37,
        message.Add(new MAVLink.mavlink_mission_write_partial_list_t());// 38,
        message.Add(new MAVLink.mavlink_mission_item_t());// 39,
        message.Add(new MAVLink.mavlink_mission_request_t());// 40,
        message.Add(new MAVLink.mavlink_mission_set_current_t());// 41,
        message.Add(new MAVLink.mavlink_mission_current_t());// 42,
        message.Add(new MAVLink.mavlink_mission_request_list_t());// 43,
        message.Add(new MAVLink.mavlink_mission_count_t());// 44,
        message.Add(new MAVLink.mavlink_mission_clear_all_t());// 45,
        message.Add(new MAVLink.mavlink_mission_item_reached_t());// 46,
        message.Add(new MAVLink.mavlink_mission_ack_t());// 47,
        message.Add(new MAVLink.mavlink_set_gps_global_origin_t());// 48,
        message.Add(new MAVLink.mavlink_gps_global_origin_t());// 49,
        message.Add(new MAVLink.mavlink_param_map_rc_t());// 50,
        message.Add(new byte[270]);//51
        message.Add(new byte[270]);//52
        message.Add(new byte[270]);//53
        message.Add(new MAVLink.mavlink_safety_set_allowed_area_t());// 54,
        message.Add(new MAVLink.mavlink_safety_allowed_area_t());// 55,
        message.Add(new byte[270]);//56
        message.Add(new byte[270]);//57
        message.Add(new byte[270]);//58
        message.Add(new byte[270]);//59
        message.Add(new byte[270]);//60
        message.Add(new MAVLink.mavlink_attitude_quaternion_cov_t());// 61,
        message.Add(new MAVLink.mavlink_nav_controller_output_t());// 62,
        message.Add(new MAVLink.mavlink_global_position_int_cov_t());// 63,
        message.Add(new MAVLink.mavlink_local_position_ned_cov_t());// 64,
        message.Add(new MAVLink.mavlink_rc_channels_t());// 65,
        message.Add(new MAVLink.mavlink_request_data_stream_t());// 66,
        message.Add(new MAVLink.mavlink_data_stream_t());// 67,
        message.Add(new byte[270]);//68
        message.Add(new MAVLink.mavlink_manual_control_t());// 69,
        message.Add(new MAVLink.mavlink_rc_channels_override_t());// 70,
        message.Add(new byte[270]);//71
        message.Add(new byte[270]);//72
        message.Add(new MAVLink.mavlink_mission_item_int_t());// 73,
        message.Add(new MAVLink.mavlink_vfr_hud_t());// 74,
        message.Add(new MAVLink.mavlink_command_int_t());// 75,
        message.Add(new MAVLink.mavlink_command_long_t());// 76,
        message.Add(new MAVLink.mavlink_command_ack_t());// 77,
        message.Add(new byte[270]);//78
        message.Add(new byte[270]);//79
        message.Add(new byte[270]);//80
        message.Add(new MAVLink.mavlink_manual_setpoint_t());// 81,
        message.Add(new MAVLink.mavlink_set_attitude_target_t());// 82,
        message.Add(new MAVLink.mavlink_attitude_target_t());// 83,
        message.Add(new MAVLink.mavlink_set_position_target_local_ned_t());// 84,
        message.Add(new MAVLink.mavlink_position_target_local_ned_t());// 85,
        message.Add(new MAVLink.mavlink_set_position_target_global_int_t());// 86,
        message.Add(new MAVLink.mavlink_position_target_global_int_t());// 87,
        message.Add(new byte[270]);//88
        message.Add(new MAVLink.mavlink_local_position_ned_system_global_offset_t());// 89,
        message.Add(new MAVLink.mavlink_hil_state_t());// 90,
        message.Add(new MAVLink.mavlink_hil_controls_t());// 91,
        message.Add(new MAVLink.mavlink_hil_rc_inputs_raw_t());// 92,
        message.Add(new byte[270]);//93
        message.Add(new byte[270]);//94
        message.Add(new byte[270]);//95
        message.Add(new byte[270]);//96
        message.Add(new byte[270]);//97
        message.Add(new byte[270]);//98
        message.Add(new byte[270]);//99
        message.Add(new MAVLink.mavlink_optical_flow_t());// 100,
        message.Add(new MAVLink.mavlink_global_vision_position_estimate_t());// 101,
        message.Add(new MAVLink.mavlink_vision_position_estimate_t());// 102,
        message.Add(new MAVLink.mavlink_vision_speed_estimate_t());// 103,
        message.Add(new MAVLink.mavlink_vicon_position_estimate_t());// 104,
        message.Add(new MAVLink.mavlink_highres_imu_t());// 105,
        message.Add(new MAVLink.mavlink_optical_flow_rad_t());// 106,
        message.Add(new MAVLink.mavlink_hil_sensor_t());// 107,
        message.Add(new MAVLink.mavlink_sim_state_t());// 108,
        message.Add(new MAVLink.mavlink_radio_status_t());// 109,
        message.Add(new MAVLink.mavlink_file_transfer_protocol_t());// 110,
        message.Add(new MAVLink.mavlink_timesync_t());// 111,
        message.Add(new byte[270]);//112
        message.Add(new MAVLink.mavlink_hil_gps_t());// 113,
        message.Add(new MAVLink.mavlink_hil_optical_flow_t());// 114,
        message.Add(new MAVLink.mavlink_hil_state_quaternion_t());// 115,
        message.Add(new MAVLink.mavlink_scaled_imu2_t());// 116,
        message.Add(new MAVLink.mavlink_log_request_list_t());// 117,
        message.Add(new MAVLink.mavlink_log_entry_t());// 118,
        message.Add(new MAVLink.mavlink_log_request_data_t());// 119,
        message.Add(new MAVLink.mavlink_log_data_t());// 120,
        message.Add(new MAVLink.mavlink_log_erase_t());// 121,
        message.Add(new MAVLink.mavlink_log_request_end_t());// 122,
        message.Add(new MAVLink.mavlink_gps_inject_data_t());// 123,
        message.Add(new MAVLink.mavlink_gps2_raw_t());// 124,
        message.Add(new MAVLink.mavlink_power_status_t());// 125,
        message.Add(new MAVLink.mavlink_serial_control_t());// 126,
        message.Add(new MAVLink.mavlink_gps_rtk_t());// 127,
        message.Add(new MAVLink.mavlink_gps2_rtk_t());// 128,
        message.Add(new MAVLink.mavlink_scaled_imu3_t());// 129,
        message.Add(new MAVLink.mavlink_data_transmission_handshake_t());// 130,
        message.Add(new MAVLink.mavlink_encapsulated_data_t());// 131,
        message.Add(new MAVLink.mavlink_distance_sensor_t());// 132,
        message.Add(new MAVLink.mavlink_terrain_request_t());// 133,
        message.Add(new MAVLink.mavlink_terrain_data_t());// 134,
        message.Add(new MAVLink.mavlink_terrain_check_t());// 135,
        message.Add(new MAVLink.mavlink_terrain_report_t());// 136,
        message.Add(new MAVLink.mavlink_scaled_pressure2_t());// 137,
        message.Add(new MAVLink.mavlink_att_pos_mocap_t());// 138,
        message.Add(new MAVLink.mavlink_set_actuator_control_target_t());// 139,
        message.Add(new MAVLink.mavlink_actuator_control_target_t());// 140,
        message.Add(new byte[270]);//141
        message.Add(new byte[270]);//142
        message.Add(new MAVLink.mavlink_scaled_pressure3_t());// 143,
        message.Add(new byte[270]);//144
        message.Add(new byte[270]);//145
        message.Add(new byte[270]);//146
        message.Add(new MAVLink.mavlink_battery_status_t());// 147,
        message.Add(new MAVLink.mavlink_autopilot_version_t());// 148,
        message.Add(new MAVLink.mavlink_landing_target_t());// 149,
        message.Add(new MAVLink.mavlink_sensor_offsets_t());// 150,
        message.Add(new MAVLink.mavlink_set_mag_offsets_t());// 151,
        message.Add(new MAVLink.mavlink_meminfo_t());// 152,
        message.Add(new MAVLink.mavlink_ap_adc_t());// 153,
        message.Add(new MAVLink.mavlink_digicam_configure_t());// 154,
        message.Add(new MAVLink.mavlink_digicam_control_t());// 155,
        message.Add(new MAVLink.mavlink_mount_configure_t());// 156,
        message.Add(new MAVLink.mavlink_mount_control_t());// 157,
        message.Add(new MAVLink.mavlink_mount_status_t());// 158,
        message.Add(new byte[270]);//159
        message.Add(new MAVLink.mavlink_fence_point_t());// 160,
        message.Add(new MAVLink.mavlink_fence_fetch_point_t());// 161,
        message.Add(new MAVLink.mavlink_fence_status_t());// 162,
        message.Add(new MAVLink.mavlink_ahrs_t());// 163,
        message.Add(new MAVLink.mavlink_simstate_t());// 164,
        message.Add(new MAVLink.mavlink_hwstatus_t());// 165,
        message.Add(new MAVLink.mavlink_radio_t());// 166,
        message.Add(new MAVLink.mavlink_limits_status_t());// 167,
        message.Add(new MAVLink.mavlink_wind_t());// 168,
        message.Add(new MAVLink.mavlink_data16_t());// 169,
        message.Add(new MAVLink.mavlink_data32_t());// 170,
        message.Add(new MAVLink.mavlink_data64_t());// 171,
        message.Add(new MAVLink.mavlink_data96_t());// 172,
        message.Add(new MAVLink.mavlink_rangefinder_t());// 173,
        message.Add(new MAVLink.mavlink_airspeed_autocal_t());// 174,
        message.Add(new MAVLink.mavlink_rally_point_t());// 175,
        message.Add(new MAVLink.mavlink_rally_fetch_point_t());// 176,
        message.Add(new MAVLink.mavlink_compassmot_status_t());// 177,
        message.Add(new MAVLink.mavlink_ahrs2_t());// 178,
        message.Add(new MAVLink.mavlink_camera_status_t());// 179,
        message.Add(new MAVLink.mavlink_camera_feedback_t());// 180,
        message.Add(new MAVLink.mavlink_battery2_t());// 181,
        message.Add(new MAVLink.mavlink_ahrs3_t());// 182,
        message.Add(new MAVLink.mavlink_autopilot_version_request_t());// 183,
        message.Add(new byte[270]);//184
        message.Add(new byte[270]);//185
        message.Add(new MAVLink.mavlink_led_control_t());// 186,
        message.Add(new byte[270]);//187
        message.Add(new byte[270]);//188
        message.Add(new byte[270]);//189
        message.Add(new byte[270]);//190
        message.Add(new MAVLink.mavlink_mag_cal_progress_t());// 191,
        message.Add(new MAVLink.mavlink_mag_cal_report_t());// 192,
        message.Add(new MAVLink.mavlink_ekf_status_report_t());// 193,
        message.Add(new MAVLink.mavlink_pid_tuning_t());// 194,
        message.Add(new byte[270]);//195
        message.Add(new byte[270]);//196
        message.Add(new byte[270]);//197
        message.Add(new byte[270]);//198
        message.Add(new byte[270]);//199
        message.Add(new MAVLink.mavlink_gimbal_report_t());// 200,
        message.Add(new MAVLink.mavlink_gimbal_control_t());// 201,
        message.Add(new MAVLink.mavlink_gimbal_reset_t());// 202,
        message.Add(new MAVLink.mavlink_gimbal_axis_calibration_progress_t());// 203,
        message.Add(new MAVLink.mavlink_gimbal_set_home_offsets_t());// 204,
        message.Add(new MAVLink.mavlink_gimbal_home_offset_calibration_result_t());// 205,
        message.Add(new MAVLink.mavlink_gimbal_set_factory_parameters_t());// 206,
        message.Add(new MAVLink.mavlink_gimbal_factory_parameters_loaded_t());// 207,
        message.Add(new MAVLink.mavlink_gimbal_erase_firmware_and_config_t());// 208,
        message.Add(new MAVLink.mavlink_gimbal_perform_factory_tests_t());// 209,
        message.Add(new MAVLink.mavlink_gimbal_report_factory_tests_progress_t());// 210,
        message.Add(new MAVLink.mavlink_gimbal_request_axis_calibration_status_t());// 211,
        message.Add(new MAVLink.mavlink_gimbal_report_axis_calibration_status_t());// 212,
        message.Add(new MAVLink.mavlink_gimbal_request_axis_calibration_t());// 213,
        message.Add(new byte[270]);//214
        message.Add(new MAVLink.mavlink_gopro_heartbeat_t());// 215,
        message.Add(new MAVLink.mavlink_gopro_get_request_t());// 216,
        message.Add(new MAVLink.mavlink_gopro_get_response_t());// 217,
        message.Add(new MAVLink.mavlink_gopro_set_request_t());// 218,
        message.Add(new MAVLink.mavlink_gopro_set_response_t());// 219,
        message.Add(new byte[270]);//220
        message.Add(new byte[270]);//221
        message.Add(new byte[270]);//222
        message.Add(new byte[270]);//223
        message.Add(new byte[270]);//224
        message.Add(new byte[270]);//225
        message.Add(new MAVLink.mavlink_rpm_t());// 226,
        message.Add(new byte[270]);//227
        message.Add(new byte[270]);//228
        message.Add(new byte[270]);//229
        message.Add(new byte[270]);//230
        message.Add(new byte[270]);//231
        message.Add(new byte[270]);//232
        message.Add(new byte[270]);//233
        message.Add(new byte[270]);//234
        message.Add(new byte[270]);//235
        message.Add(new byte[270]);//236
        message.Add(new byte[270]);//237
        message.Add(new byte[270]);//238
        message.Add(new byte[270]);//239
        message.Add(new byte[270]);//240
        message.Add(new MAVLink.mavlink_vibration_t());// 241,
        message.Add(new byte[270]);//242
        message.Add(new byte[270]);//243
        message.Add(new byte[270]);//244
        message.Add(new byte[270]);//245
        message.Add(new byte[270]);//246
        message.Add(new byte[270]);//247
        message.Add(new MAVLink.mavlink_v2_extension_t());// 248,
        message.Add(new MAVLink.mavlink_memory_vect_t());// 249,
        message.Add(new MAVLink.mavlink_debug_vect_t());// 250,
        message.Add(new MAVLink.mavlink_named_value_float_t());// 251,
        message.Add(new MAVLink.mavlink_named_value_int_t());// 252,
        message.Add(new MAVLink.mavlink_statustext_t());// 253,
        message.Add(new MAVLink.mavlink_debug_t());// 254,


    }
    public static bool judgeByteData(byte[] data)
    {
        if (data == null) return false;
        if (data.Length < 8) return false;
        if (data[0] != 254) return false;
        if (data.Length != data[1] + 8) return false;

        return true;
    }
    public static string strByteData(byte[] data)
    {
        string str = "";
        int i = 0;
        while (i < data.Length)
        {
            str += data[i] + " ";
            i++;
        }
        str += "\r\n";
        return str;
    }
    /*public MyPlane()
    {

      message.Add(heartbeat_t);//0
        message.Add(sys_status_t);// 1,
        message.Add(system_time_t);// 2,
        message.Add(new byte[270]);//3
        message.Add(ping_t);// 4,
        message.Add(change_operator_control_t);// 5,
        message.Add(change_operator_control_ack_t);// 6,
        message.Add(auth_key_t);// 7,
        message.Add(new byte[270]);//8
        message.Add(new byte[270]);//9
        message.Add(new byte[270]);//10
        message.Add(set_mode_t);// 11,
        message.Add(new byte[270]);//12
        message.Add(new byte[270]);//13
        message.Add(new byte[270]);//14
        message.Add(new byte[270]);//15
        message.Add(new byte[270]);//16
        message.Add(new byte[270]);//17
        message.Add(new byte[270]);//18
        message.Add(new byte[270]);//19
        message.Add(param_request_read_t);// 20,
        message.Add(param_request_list_t);// 21,
        message.Add(param_value_t);// 22,
        message.Add(param_set_t);// 23,
        message.Add(gps_raw_int_t);// 24,
        message.Add(gps_status_t);// 25,
        message.Add(scaled_imu_t);// 26,
        message.Add(raw_imu_t);// 27,
        message.Add(raw_pressure_t);// 28,
        message.Add(scaled_pressure_t);// 29,
        message.Add(attitude_t);// 30,
        message.Add(attitude_quaternion_t);// 31,
        message.Add(local_position_ned_t);// 32,
        message.Add(global_position_int_t);// 33,
        message.Add(rc_channels_scaled_t);// 34,
        message.Add(rc_channels_raw_t);// 35,
        message.Add(servo_output_raw_t);// 36,
        message.Add(mission_request_partial_list_t);// 37,
        message.Add(mission_write_partial_list_t);// 38,
        message.Add(mission_item_t);// 39,
        message.Add(mission_request_t);// 40,
        message.Add(mission_set_current_t);// 41,
        message.Add(mission_current_t);// 42,
        message.Add(mission_request_list_t);// 43,
        message.Add(mission_count_t);// 44,
        message.Add(mission_clear_all_t);// 45,
        message.Add(mission_item_reached_t);// 46,
        message.Add(mission_ack_t);// 47,
        message.Add(set_gps_global_origin_t);// 48,
        message.Add(gps_global_origin_t);// 49,
        message.Add(param_map_rc_t);// 50,
        message.Add(new byte[270]);//51
        message.Add(new byte[270]);//51
        message.Add(new byte[270]);//53
        message.Add(safety_set_allowed_area_t);// 54,
        message.Add(safety_allowed_area_t);// 55,
        message.Add(new byte[270]);//56
        message.Add(new byte[270]);//57
        message.Add(new byte[270]);//58
        message.Add(new byte[270]);//59
        message.Add(new byte[270]);//60
        message.Add(attitude_quaternion_cov_t);// 61,
        message.Add(nav_controller_output_t);// 62,
        message.Add(global_position_int_cov_t);// 63,
        message.Add(local_position_ned_cov_t);// 64,
        message.Add(rc_channels_t);// 65,
        message.Add(request_data_stream_t);// 66,
        message.Add(data_stream_t);// 67,
        message.Add(new byte[270]);//68
        message.Add(manual_control_t);// 69,
        message.Add(rc_channels_override_t);// 70,
        message.Add(new byte[270]);//71
        message.Add(new byte[270]);//72
        message.Add(mission_item_int_t);// 73,
        message.Add(vfr_hud_t);// 74,
        message.Add(command_int_t);// 75,
        message.Add(command_long_t);// 76,
        message.Add(command_ack_t);// 77,
        message.Add(new byte[270]);//78
        message.Add(new byte[270]);//79
        message.Add(new byte[270]);//80
        message.Add(manual_setpoint_t);// 81,
        message.Add(set_attitude_target_t);// 82,
        message.Add(attitude_target_t);// 83,
        message.Add(set_position_target_local_ned_t);// 84,
        message.Add(position_target_local_ned_t);// 85,
        message.Add(set_position_target_global_int_t);// 86,
        message.Add(position_target_global_int_t);// 87,
        message.Add(new byte[270]);//88
        message.Add(local_position_ned_system_global_offset_t);// 89,
        message.Add(hil_state_t);// 90,
        message.Add(hil_controls_t);// 91,
        message.Add(hil_rc_inputs_raw_t);// 92,
        message.Add(new byte[270]);//93
        message.Add(new byte[270]);//94
        message.Add(new byte[270]);//95
        message.Add(new byte[270]);//96
        message.Add(new byte[270]);//97
        message.Add(new byte[270]);//98
        message.Add(new byte[270]);//99
        message.Add(optical_flow_t);// 100,
        message.Add(global_vision_position_estimate_t);// 101,
        message.Add(vision_position_estimate_t);// 102,
        message.Add(vision_speed_estimate_t);// 103,
        message.Add(vicon_position_estimate_t);// 104,
        message.Add(highres_imu_t);// 105,
        message.Add(optical_flow_rad_t);// 106,
        message.Add(hil_sensor_t);// 107,
        message.Add(sim_state_t);// 108,
        message.Add(radio_status_t);// 109,
        message.Add(file_transfer_protocol_t);// 110,
        message.Add(timesync_t);// 111,
        message.Add(new byte[270]);//112
        message.Add(hil_gps_t);// 113,
        message.Add(hil_optical_flow_t);// 114,
        message.Add(hil_state_quaternion_t);// 115,
        message.Add(scaled_imu2_t);// 116,
        message.Add(log_request_list_t);// 117,
        message.Add(log_entry_t);// 118,
        message.Add(log_request_data_t);// 119,
        message.Add(log_data_t);// 120,
        message.Add(log_erase_t);// 121,
        message.Add(log_request_end_t);// 122,
        message.Add(gps_inject_data_t);// 123,
        message.Add(gps2_raw_t);// 124,
        message.Add(power_status_t);// 125,
        message.Add(serial_control_t);// 126,
        message.Add(gps_rtk_t);// 127,
        message.Add(gps2_rtk_t);// 128,
        message.Add(scaled_imu3_t);// 129,
        message.Add(data_transmission_handshake_t);// 130,
        message.Add(encapsulated_data_t);// 131,
        message.Add(distance_sensor_t);// 132,
        message.Add(terrain_request_t);// 133,
        message.Add(terrain_data_t);// 134,
        message.Add(terrain_check_t);// 135,
        message.Add(terrain_report_t);// 136,
        message.Add(scaled_pressure2_t);// 137,
        message.Add(att_pos_mocap_t);// 138,
        message.Add(set_actuator_control_target_t);// 139,
        message.Add(actuator_control_target_t);// 140,
        message.Add(new byte[270]);//141
        message.Add(new byte[270]);//142
        message.Add(scaled_pressure3_t);// 143,
        message.Add(new byte[270]);//144
        message.Add(new byte[270]);//145
        message.Add(new byte[270]);//146
        message.Add(battery_status_t);// 147,
        message.Add(autopilot_version_t);// 148,
        message.Add(landing_target_t);// 149,
        message.Add(sensor_offsets_t);// 150,
        message.Add(set_mag_offsets_t);// 151,
        message.Add(meminfo_t);// 152,
        message.Add(ap_adc_t);// 153,
        message.Add(digicam_configure_t);// 154,
        message.Add(digicam_control_t);// 155,
        message.Add(mount_configure_t);// 156,
        message.Add(mount_control_t);// 157,
        message.Add(mount_status_t);// 158,
        message.Add(new byte[270]);//159
        message.Add(fence_point_t);// 160,
        message.Add(fence_fetch_point_t);// 161,
        message.Add(fence_status_t);// 162,
        message.Add(ahrs_t);// 163,
        message.Add(simstate_t);// 164,
        message.Add(hwstatus_t);// 165,
        message.Add(radio_t);// 166,
        message.Add(limits_status_t);// 167,
        message.Add(wind_t);// 168,
        message.Add(data16_t);// 169,
        message.Add(data32_t);// 170,
        message.Add(data64_t);// 171,
        message.Add(data96_t);// 172,
        message.Add(rangefinder_t);// 173,
        message.Add(airspeed_autocal_t);// 174,
        message.Add(rally_point_t);// 175,
        message.Add(rally_fetch_point_t);// 176,
        message.Add(compassmot_status_t);// 177,
        message.Add(ahrs2_t);// 178,
        message.Add(camera_status_t);// 179,
        message.Add(camera_feedback_t);// 180,
        message.Add(battery2_t);// 181,
        message.Add(ahrs3_t);// 182,
        message.Add(autopilot_version_request_t);// 183,
        message.Add(new byte[270]);//184
        message.Add(new byte[270]);//185
        message.Add(led_control_t);// 186,
        message.Add(new byte[270]);//187
        message.Add(new byte[270]);//188
        message.Add(new byte[270]);//189
        message.Add(new byte[270]);//190
        message.Add(mag_cal_progress_t);// 191,
        message.Add(mag_cal_report_t);// 192,
        message.Add(ekf_status_report_t);// 193,
        message.Add(pid_tuning_t);// 194,
        message.Add(new byte[270]);//195
        message.Add(new byte[270]);//196
        message.Add(new byte[270]);//197
        message.Add(new byte[270]);//198
        message.Add(new byte[270]);//199
        message.Add(gimbal_report_t);// 200,
        message.Add(gimbal_control_t);// 201,
        message.Add(gimbal_reset_t);// 202,
        message.Add(gimbal_axis_calibration_progress_t);// 203,
        message.Add(gimbal_set_home_offsets_t);// 204,
        message.Add(gimbal_home_offset_calibration_result_t);// 205,
        message.Add(gimbal_set_factory_parameters_t);// 206,
        message.Add(gimbal_factory_parameters_loaded_t);// 207,
        message.Add(gimbal_erase_firmware_and_config_t);// 208,
        message.Add(gimbal_perform_factory_tests_t);// 209,
        message.Add(gimbal_report_factory_tests_progress_t);// 210,
        message.Add(gimbal_request_axis_calibration_status_t);// 211,
        message.Add(gimbal_report_axis_calibration_status_t);// 212,
        message.Add(gimbal_request_axis_calibration_t);// 213,
        message.Add(new byte[270]);//214
        message.Add(gopro_heartbeat_t);// 215,
        message.Add(gopro_get_request_t);// 216,
        message.Add(gopro_get_response_t);// 217,
        message.Add(gopro_set_request_t);// 218,
        message.Add(gopro_set_response_t);// 219,
        message.Add(new byte[270]);//220
        message.Add(new byte[270]);//221
        message.Add(new byte[270]);//222
        message.Add(new byte[270]);//223
        message.Add(new byte[270]);//224
        message.Add(new byte[270]);//225
        message.Add(rpm_t);// 226,
        message.Add(new byte[270]);//227
        message.Add(new byte[270]);//228
        message.Add(new byte[270]);//229
        message.Add(new byte[270]);//230
        message.Add(new byte[270]);//231
        message.Add(new byte[270]);//232
        message.Add(new byte[270]);//233
        message.Add(new byte[270]);//234
        message.Add(new byte[270]);//235
        message.Add(new byte[270]);//236
        message.Add(new byte[270]);//237
        message.Add(new byte[270]);//238
        message.Add(new byte[270]);//239
        message.Add(new byte[270]);//240
        message.Add(vibration_t);// 241,
        message.Add(new byte[270]);//242
        message.Add(new byte[270]);//243
        message.Add(new byte[270]);//244
        message.Add(new byte[270]);//245
        message.Add(new byte[270]);//246
        message.Add(new byte[270]);//247
        message.Add(v2_extension_t);// 248,
        message.Add(memory_vect_t);// 249,
        message.Add(debug_vect_t);// 250,
        message.Add(named_value_float_t);// 251,
        message.Add(named_value_int_t);// 252,
        message.Add(statustext_t);// 253,
        message.Add(debug_t);// 254,


    }*/
    public void setValue(object packet)
    {
        //  Console.WriteLine("i");
        if (packet == null) return;
        if (packet.GetType() == typeof(byte[]))
        {
            if (((byte[])packet).Length <= 8)
                return;
            int x = ((byte[])packet)[1];
            if (message[x].GetType() != typeof(byte[]))
                return;
            message[x] = (byte[])packet;
        }
        Console.WriteLine("set:" + packet.GetType());
        int i = 0;
        while (i < message.Count)
        {
            if (message[i].GetType() == packet.GetType())
            {
                // object obj = message[i];
                //obj = packet;
                message[i] = packet;
                // string s = this.heartbeat_t.mavlink_version.ToString();// (mavlink_version.ToString();
                // string ss = ((MAVLink.mavlink_heartbeat_t)message[i]).mavlink_version.ToString();
                // Console.WriteLine("true:"+s+","+ss);
                // Console.WriteLine("true:"+i);
                break;
            }
            i++;
        }

        switch (packet.GetType().ToString())
        {

            case "MAVLink+mavlink_heartbeat_t": this.heartbeat_t = (MAVLink.mavlink_heartbeat_t)packet; break;//0
            case "MAVLink+mavlink_sys_status_t": this.sys_status_t = (MAVLink.mavlink_sys_status_t)packet; break;// 1,
            case "MAVLink+mavlink_system_time_t": this.system_time_t = (MAVLink.mavlink_system_time_t)packet; break;// 2,
            case "MAVLink+mavlink_ping_t": break;// 4,
            case "MAVLink+mavlink_change_operator_control_t": break;// 5,
            case "MAVLink+mavlink_change_operator_control_ack_t": break;// 6,
            case "MAVLink+mavlink_auth_key_t": break;// 7,
            case "MAVLink+mavlink_set_mode_t": break;// 11,
            case "MAVLink+mavlink_param_request_read_t": break;// 20,
            case "MAVLink+mavlink_param_request_list_t": break;// 21,
            case "MAVLink+mavlink_param_value_t": break;// 22,
            case "MAVLink+mavlink_param_set_t": break;// 23,
            case "MAVLink+mavlink_gps_raw_int_t": break;// 24,
            case "MAVLink+mavlink_gps_status_t": break;// 25,
            case "MAVLink+mavlink_scaled_imu_t": break;// 26,
            case "MAVLink+mavlink_raw_imu_t": break;// 27,
            case "MAVLink+mavlink_raw_pressure_t": break;// 28,
            case "MAVLink+mavlink_scaled_pressure_t": break;// 29,
            case "MAVLink+mavlink_attitude_t": break;// 30,
            case "MAVLink+mavlink_attitude_quaternion_t": break;// 31,
            case "MAVLink+mavlink_local_position_ned_t": break;// 32,
            case "MAVLink+mavlink_global_position_int_t": break;// 33,
            case "MAVLink+mavlink_rc_channels_scaled_t": break;// 34,
            case "MAVLink+mavlink_rc_channels_raw_t": break;// 35,
            case "MAVLink+mavlink_servo_output_raw_t": break;// 36,
            case "MAVLink+mavlink_mission_request_partial_list_t": break;// 37,
            case "MAVLink+mavlink_mission_write_partial_list_t": break;// 38,
            case "MAVLink+mavlink_mission_item_t": break;// 39,
            case "MAVLink+mavlink_mission_request_t": break;// 40,
            case "MAVLink+mavlink_mission_set_current_t": break;// 41,
            case "MAVLink+mavlink_mission_current_t": break;// 42,
            case "MAVLink+mavlink_mission_request_list_t": break;// 43,

            case "MAVLink+mavlink_mission_count_t": break;// 44,
            case "MAVLink+mavlink_mission_clear_all_t": break;// 45,
            case "MAVLink+mavlink_mission_item_reached_t": break;// 46,
            case "MAVLink+mavlink_mission_ack_t": break;// 47,
            case "MAVLink+mavlink_set_gps_global_origin_t": break;// 48,
            case "MAVLink+mavlink_gps_global_origin_t": break;// 49,
            case "MAVLink+mavlink_param_map_rc_t": break;// 50,
            case "MAVLink+mavlink_safety_set_allowed_area_t": break;// 54,
            case "MAVLink+mavlink_safety_allowed_area_t": break;// 55,
            case "MAVLink+mavlink_attitude_quaternion_cov_t": break;// 61,
            case "MAVLink+mavlink_nav_controller_output_t": break;// 62,
            case "MAVLink+mavlink_global_position_int_cov_t": break;// 63,
            case "MAVLink+mavlink_local_position_ned_cov_t": break;// 64,
            case "MAVLink+mavlink_rc_channels_t": break;// 65,
            case "MAVLink+mavlink_request_data_stream_t": break;// 66,
            case "MAVLink+mavlink_data_stream_t": break;// 67,
            case "MAVLink+mavlink_manual_control_t": break;// 69,
            case "MAVLink+mavlink_rc_channels_override_t": break;// 70,
            case "MAVLink+mavlink_mission_item_int_t": break;// 73,
            case "MAVLink+mavlink_vfr_hud_t": break;// 74,
            case "MAVLink+mavlink_command_int_t": break;// 75,
            case "MAVLink+mavlink_command_long_t": break;// 76,
            case "MAVLink+mavlink_command_ack_t": break;// 77,
            case "MAVLink+mavlink_manual_setpoint_t": break;// 81,
            case "MAVLink+mavlink_set_attitude_target_t": break;// 82,
            case "MAVLink+mavlink_attitude_target_t": break;// 83,
            case "MAVLink+mavlink_set_position_target_local_ned_t": break;// 84,
            case "MAVLink+mavlink_position_target_local_ned_t": break;// 85,
            case "MAVLink+mavlink_set_position_target_global_int_t": break;// 86,
            case "MAVLink+mavlink_position_target_global_int_t": break;// 87,
            case "MAVLink+mavlink_local_position_ned_system_global_offset_t": break;// 89,
            case "MAVLink+mavlink_hil_state_t": break;// 90,
            case "MAVLink+mavlink_hil_controls_t": break;// 91,
            case "MAVLink+mavlink_hil_rc_inputs_raw_t": break;// 92,
            case "MAVLink+mavlink_optical_flow_t": break;// 100,
            case "MAVLink+mavlink_global_vision_position_estimate_t": break;// 101,
            case "MAVLink+mavlink_vision_position_estimate_t": break;// 102,
            case "MAVLink+mavlink_vision_speed_estimate_t": break;// 103,
            case "MAVLink+mavlink_vicon_position_estimate_t": break;// 104,
            case "MAVLink+mavlink_highres_imu_t": break;// 105,
            case "MAVLink+mavlink_optical_flow_rad_t": break;// 106,
            case "MAVLink+mavlink_hil_sensor_t": break;// 107,
            case "MAVLink+mavlink_sim_state_t": break;// 108,
            case "MAVLink+mavlink_radio_status_t": break;// 109,
            case "MAVLink+mavlink_file_transfer_protocol_t": break;// 110,
            case "MAVLink+mavlink_timesync_t": break;// 111,
            case "MAVLink+mavlink_hil_gps_t": break;// 113,
            case "MAVLink+mavlink_hil_optical_flow_t": break;// 114,
            case "MAVLink+mavlink_hil_state_quaternion_t": break;// 115,
            case "MAVLink+mavlink_scaled_imu2_t": break;// 116,
            case "MAVLink+mavlink_log_request_list_t": break;// 117,
            case "MAVLink+mavlink_log_entry_t": break;// 118,
            case "MAVLink+mavlink_log_request_data_t": break;// 119,
            case "MAVLink+mavlink_log_data_t": break;// 120,
            case "MAVLink+mavlink_log_erase_t": break;// 121,
            case "MAVLink+mavlink_log_request_end_t": break;// 122,
            case "MAVLink+mavlink_gps_inject_data_t": break;// 123,
            case "MAVLink+mavlink_gps2_raw_t": break;// 124,
            case "MAVLink+mavlink_power_status_t": break;// 125,
            case "MAVLink+mavlink_serial_control_t": break;// 126,
            case "MAVLink+mavlink_gps_rtk_t": break;// 127,
            case "MAVLink+mavlink_gps2_rtk_t": break;// 128,
            case "MAVLink+mavlink_scaled_imu3_t": break;// 129,
            case "MAVLink+mavlink_data_transmission_handshake_t": break;// 130,
            case "MAVLink+mavlink_encapsulated_data_t": break;// 131,
            case "MAVLink+mavlink_distance_sensor_t": break;// 132,
            case "MAVLink+mavlink_terrain_request_t": break;// 133,
            case "MAVLink+mavlink_terrain_data_t": break;// 134,
            case "MAVLink+mavlink_terrain_check_t": break;// 135,
            case "MAVLink+mavlink_terrain_report_t": break;// 136,
            case "MAVLink+mavlink_scaled_pressure2_t": break;// 137,
            case "MAVLink+mavlink_att_pos_mocap_t": break;// 138,
            case "MAVLink+mavlink_set_actuator_control_target_t": break;// 139,
            case "MAVLink+mavlink_actuator_control_target_t": break;// 140,
            case "MAVLink+mavlink_scaled_pressure3_t": break;// 143,
            case "MAVLink+mavlink_battery_status_t": break;// 147,
            case "MAVLink+mavlink_autopilot_version_t": break;// 148,
            case "MAVLink+mavlink_landing_target_t": break;// 149,
            case "MAVLink+mavlink_sensor_offsets_t": break;// 150,
            case "MAVLink+mavlink_set_mag_offsets_t": break;// 151,
            case "MAVLink+mavlink_meminfo_t": break;// 152,
            case "MAVLink+mavlink_ap_adc_t": break;// 153,
            case "MAVLink+mavlink_digicam_configure_t": break;// 154,
            case "MAVLink+mavlink_digicam_control_t": break;// 155,
            case "MAVLink+mavlink_mount_configure_t": break;// 156,
            case "MAVLink+mavlink_mount_control_t": break;// 157,
            case "MAVLink+mavlink_mount_status_t": break;// 158,
            case "MAVLink+mavlink_fence_point_t": break;// 160,
            case "MAVLink+mavlink_fence_fetch_point_t": break;// 161,
            case "MAVLink+mavlink_fence_status_t": break;// 162,
            case "MAVLink+mavlink_ahrs_t": break;// 163,
            case "MAVLink+mavlink_simstate_t": break;// 164,
            case "MAVLink+mavlink_hwstatus_t": break;// 165,
            case "MAVLink+mavlink_radio_t": break;// 166,
            case "MAVLink+mavlink_limits_status_t": break;// 167,
            case "MAVLink+mavlink_wind_t": break;// 168,
            case "MAVLink+mavlink_data16_t": break;// 169,
            case "MAVLink+mavlink_data32_t": break;// 170,
            case "MAVLink+mavlink_data64_t": break;// 171,
            case "MAVLink+mavlink_data96_t": break;// 172,
            case "MAVLink+mavlink_rangefinder_t": break;// 173,
            case "MAVLink+mavlink_airspeed_autocal_t": break;// 174,
            case "MAVLink+mavlink_rally_point_t": break;// 175,
            case "MAVLink+mavlink_rally_fetch_point_t": break;// 176,
            case "MAVLink+mavlink_compassmot_status_t": break;// 177,
            case "MAVLink+mavlink_ahrs2_t": break;// 178,
            case "MAVLink+mavlink_camera_status_t": break;// 179,
            case "MAVLink+mavlink_camera_feedback_t": break;// 180,
            case "MAVLink+mavlink_battery2_t": break;// 181,
            case "MAVLink+mavlink_ahrs3_t": break;// 182,
            case "MAVLink+mavlink_autopilot_version_request_t": break;// 183,
            case "MAVLink+mavlink_led_control_t": break;// 186,
            case "MAVLink+mavlink_mag_cal_progress_t": break;// 191,
            case "MAVLink+mavlink_mag_cal_report_t": break;// 192,
            case "MAVLink+mavlink_ekf_status_report_t": break;// 193,
            case "MAVLink+mavlink_pid_tuning_t": break;// 194,
            case "MAVLink+mavlink_gimbal_report_t": break;// 200,
            case "MAVLink+mavlink_gimbal_control_t": break;// 201,
            case "MAVLink+mavlink_gimbal_reset_t": break;// 202,
            case "MAVLink+mavlink_gimbal_axis_calibration_progress_t": break;// 203,
            case "MAVLink+mavlink_gimbal_set_home_offsets_t": break;// 204,
            case "MAVLink+mavlink_gimbal_home_offset_calibration_result_t": break;// 205,
            case "MAVLink+mavlink_gimbal_set_factory_parameters_t": break;// 206,
            case "MAVLink+mavlink_gimbal_factory_parameters_loaded_t": break;// 207,
            case "MAVLink+mavlink_gimbal_erase_firmware_and_config_t": break;// 208,
            case "MAVLink+mavlink_gimbal_perform_factory_tests_t": break;// 209,
            case "MAVLink+mavlink_gimbal_report_factory_tests_progress_t": break;// 210,
            case "MAVLink+mavlink_gimbal_request_axis_calibration_status_t": break;// 211,
            case "MAVLink+mavlink_gimbal_report_axis_calibration_status_t": break;// 212,
            case "MAVLink+mavlink_gimbal_request_axis_calibration_t": break;// 213,
            case "MAVLink+mavlink_gopro_heartbeat_t": break;// 215,
            case "MAVLink+mavlink_gopro_get_request_t": break;// 216,
            case "MAVLink+mavlink_gopro_get_response_t": break;// 217,
            case "MAVLink+mavlink_gopro_set_request_t": break;// 218,
            case "MAVLink+mavlink_gopro_set_response_t": break;// 219,
            case "MAVLink+mavlink_rpm_t": break;// 226,
            case "MAVLink+mavlink_vibration_t": break;// 241,
            case "MAVLink+mavlink_v2_extension_t": break;// 248,
            case "MAVLink+mavlink_memory_vect_t": break;// 249,
            case "MAVLink+mavlink_debug_vect_t": break;// 250,
            case "MAVLink+mavlink_named_value_float_t": break;// 251,
            case "MAVLink+mavlink_named_value_int_t": break;// 252,
            case "MAVLink+mavlink_statustext_t": break;// 253,
            case "MAVLink+mavlink_debug_t": break;// 254,


            default: break;
        }
    }
    /* public void setValue(object packet)
     {
         switch (packet.GetType().ToString())
         {
             case "MAVLink+mavlink_attitude_t": this.attitude_t = (MAVLink.mavlink_attitude_t)packet; break;
             case "MAVLink+mavlink_heartbeat_t": this.heartbeat_t = (MAVLink.mavlink_heartbeat_t)packet; break;
             case "MAVLink+mavlink_statustext_t": this.statustext_t = (MAVLink.mavlink_statustext_t)packet; break;


             case "MAVLink+mavlink_param_request_read_t": this.param_request_read_t = (MAVLink.mavlink_param_request_read_t)packet; break;
             case "MAVLink+mavlink_command_ack_t": this.command_ack_t = (MAVLink.mavlink_command_ack_t)packet; break;
             case " MAVLink+mavlink_request_data_stream_t": this.request_data_stream_t = (MAVLink.mavlink_request_data_stream_t)packet; break;
             default: break;
         }
     }*/
    //VAR

}

      


/* public MAVLink.mavlink_heartbeat_t heartbeat_t {  get { return (     )     ; (MAVLink.mavlink_heartbeat_t)message[0]; }set { message[0] = value; } }//0
        public MAVLink.mavlink_sys_status_t sys_status_t;//1
        public MAVLink.mavlink_system_time_t system_time_t; //2
                                                                                //3
        public MAVLink.mavlink_ping_t ping_t;//4
        public MAVLink.mavlink_change_operator_control_t change_operator_control_t;//5
        public MAVLink.mavlink_change_operator_control_ack_t change_operator_control_ack_t;//6
        public MAVLink.mavlink_auth_key_t auth_key_t;//7
                                                     //8
                                                     //9
                                                     //10
        public MAVLink.mavlink_set_mode_t set_mode_t;//11
                                                     //12
                                                     //13
                                                     //14
                                                     //15
                                                     //16
                                                     //17
                                                     //18
                                                     //19
        public MAVLink.mavlink_param_request_read_t param_request_read_t;//20
        public MAVLink.mavlink_param_request_list_t param_request_list_t;//21
        public MAVLink.mavlink_param_value_t param_value_t;//22
        public MAVLink.mavlink_param_set_t param_set_t;//23
        public MAVLink.mavlink_gps_raw_int_t gps_raw_int_t;//24
        public MAVLink.mavlink_gps_status_t gps_status_t;//25
        public MAVLink.mavlink_scaled_imu_t scaled_imu_t;//26
        public MAVLink.mavlink_raw_imu_t raw_imu_t;//27
        public MAVLink.mavlink_raw_pressure_t raw_pressure_t;//28
        public MAVLink.mavlink_scaled_pressure_t scaled_pressure_t;//29
        public MAVLink.mavlink_attitude_t attitude_t;//30
        public MAVLink.mavlink_attitude_quaternion_t attitude_quaternion_t;//31
        public MAVLink.mavlink_local_position_ned_t local_position_ned_t;//32
        public MAVLink.mavlink_global_position_int_t global_position_int_t;//33
        public MAVLink.mavlink_rc_channels_scaled_t rc_channels_scaled_t;//34
        public MAVLink.mavlink_rc_channels_raw_t rc_channels_raw_t;//35
        public MAVLink.mavlink_servo_output_raw_t servo_output_raw_t;//36
        public MAVLink.mavlink_mission_request_partial_list_t mission_request_partial_list_t;//37
        public MAVLink.mavlink_mission_write_partial_list_t mission_write_partial_list_t;//38
        public MAVLink.mavlink_mission_item_t mission_item_t;//39
        public MAVLink.mavlink_mission_request_t mission_request_t;//40
        public MAVLink.mavlink_mission_set_current_t mission_set_current_t;//41
        public MAVLink.mavlink_mission_current_t mission_current_t;//42
        public MAVLink.mavlink_mission_request_list_t mission_request_list_t;//43
        public MAVLink.mavlink_mission_count_t mission_count_t;// 44,
        public MAVLink.mavlink_mission_clear_all_t mission_clear_all_t;// 45,
        public MAVLink.mavlink_mission_item_reached_t mission_item_reached_t;// 46,
        public MAVLink.mavlink_mission_ack_t mission_ack_t;// 47,
        public MAVLink.mavlink_set_gps_global_origin_t set_gps_global_origin_t;// 48,
        public MAVLink.mavlink_gps_global_origin_t gps_global_origin_t;// 49,
        public MAVLink.mavlink_param_map_rc_t param_map_rc_t;// 50,
        public MAVLink.mavlink_safety_set_allowed_area_t safety_set_allowed_area_t;// 54,
        public MAVLink.mavlink_safety_allowed_area_t safety_allowed_area_t;// 55,
        public MAVLink.mavlink_attitude_quaternion_cov_t attitude_quaternion_cov_t;// 61,
        public MAVLink.mavlink_nav_controller_output_t nav_controller_output_t;// 62,
        public MAVLink.mavlink_global_position_int_cov_t global_position_int_cov_t;// 63,
        public MAVLink.mavlink_local_position_ned_cov_t local_position_ned_cov_t;// 64,
        public MAVLink.mavlink_rc_channels_t rc_channels_t;// 65,
        public MAVLink.mavlink_request_data_stream_t request_data_stream_t;// 66,
        public MAVLink.mavlink_data_stream_t data_stream_t;// 67,
        public MAVLink.mavlink_manual_control_t manual_control_t;// 69,
        public MAVLink.mavlink_rc_channels_override_t rc_channels_override_t;// 70,
        //71
        //72
        public MAVLink.mavlink_mission_item_int_t mission_item_int_t;// 73,
        public MAVLink.mavlink_vfr_hud_t vfr_hud_t;// 74,
        public MAVLink.mavlink_command_int_t command_int_t;// 75,
        public MAVLink.mavlink_command_long_t command_long_t;// 76,
        public MAVLink.mavlink_command_ack_t command_ack_t;// 77,
        //78
        //79
        //80
        public MAVLink.mavlink_manual_setpoint_t manual_setpoint_t;// 81,
        public MAVLink.mavlink_set_attitude_target_t set_attitude_target_t;// 82,
        public MAVLink.mavlink_attitude_target_t attitude_target_t;// 83,
        public MAVLink.mavlink_set_position_target_local_ned_t set_position_target_local_ned_t;// 84,
        public MAVLink.mavlink_position_target_local_ned_t position_target_local_ned_t;// 85,
        public MAVLink.mavlink_set_position_target_global_int_t set_position_target_global_int_t;// 86,
        public MAVLink.mavlink_position_target_global_int_t position_target_global_int_t;// 87,
        //88
        public MAVLink.mavlink_local_position_ned_system_global_offset_t local_position_ned_system_global_offset_t;// 89,
        public MAVLink.mavlink_hil_state_t hil_state_t;// 90,
        public MAVLink.mavlink_hil_controls_t hil_controls_t;// 91,
        public MAVLink.mavlink_hil_rc_inputs_raw_t hil_rc_inputs_raw_t;// 92,
                                                                       //93
                                                                       //94
                                                                       //95
                                                                       //96
                                                                       //97
                                                                       //98
                                                                       //99
        public MAVLink.mavlink_optical_flow_t optical_flow_t;// 100,
        public MAVLink.mavlink_global_vision_position_estimate_t global_vision_position_estimate_t;// 101,
        public MAVLink.mavlink_vision_position_estimate_t vision_position_estimate_t;// 102,
        public MAVLink.mavlink_vision_speed_estimate_t vision_speed_estimate_t;// 103,
        public MAVLink.mavlink_vicon_position_estimate_t vicon_position_estimate_t;// 104,
        public MAVLink.mavlink_highres_imu_t highres_imu_t;// 105,
        public MAVLink.mavlink_optical_flow_rad_t optical_flow_rad_t;// 106,
        public MAVLink.mavlink_hil_sensor_t hil_sensor_t;// 107,
        public MAVLink.mavlink_sim_state_t sim_state_t;// 108,
        public MAVLink.mavlink_radio_status_t radio_status_t;// 109,
        public MAVLink.mavlink_file_transfer_protocol_t file_transfer_protocol_t;// 110,
        public MAVLink.mavlink_timesync_t timesync_t;//= 111,
                                                     //112
        public MAVLink.mavlink_hil_gps_t hil_gps_t;// 113,
        public MAVLink.mavlink_hil_optical_flow_t hil_optical_flow_t;// 114,
        public MAVLink.mavlink_hil_state_quaternion_t hil_state_quaternion_t;// 115,
        public MAVLink.mavlink_scaled_imu2_t scaled_imu2_t;// 116,
        public MAVLink.mavlink_log_request_list_t log_request_list_t;// 117,
        public MAVLink.mavlink_log_entry_t log_entry_t;// 118,
        public MAVLink.mavlink_log_request_data_t log_request_data_t;// 119,
        public MAVLink.mavlink_log_data_t log_data_t;// 120,
        public MAVLink.mavlink_log_erase_t log_erase_t;// 121,
        public MAVLink.mavlink_log_request_end_t log_request_end_t;// 122,
        public MAVLink.mavlink_gps_inject_data_t gps_inject_data_t;// 123,
        public MAVLink.mavlink_gps2_raw_t gps2_raw_t;// 124,
        public MAVLink.mavlink_power_status_t power_status_t;// 125,
        public MAVLink.mavlink_serial_control_t serial_control_t;// 126,
        public MAVLink.mavlink_gps_rtk_t gps_rtk_t;// 127,
        public MAVLink.mavlink_gps2_rtk_t gps2_rtk_t;// 128,
        public MAVLink.mavlink_scaled_imu3_t scaled_imu3_t;// 129,
        public MAVLink.mavlink_data_transmission_handshake_t data_transmission_handshake_t;// 130,
        public MAVLink.mavlink_encapsulated_data_t encapsulated_data_t;// 131,
        public MAVLink.mavlink_distance_sensor_t distance_sensor_t;// 132,
        public MAVLink.mavlink_terrain_request_t terrain_request_t;// 133,
        public MAVLink.mavlink_terrain_data_t terrain_data_t;//134,
        public MAVLink.mavlink_terrain_check_t terrain_check_t;// 135,
        public MAVLink.mavlink_terrain_report_t terrain_report_t;// 136,
        public MAVLink.mavlink_scaled_pressure2_t scaled_pressure2_t;// 137,
        public MAVLink.mavlink_att_pos_mocap_t att_pos_mocap_t;// 138,
        public MAVLink.mavlink_set_actuator_control_target_t set_actuator_control_target_t;// 139,
        public MAVLink.mavlink_actuator_control_target_t actuator_control_target_t;// 140,
                                                                                   //141
                                                                                   //142
        public MAVLink.mavlink_scaled_pressure3_t scaled_pressure3_t;// 143,
                                                                     //144
                                                                     //145
                                                                     //146
        public MAVLink.mavlink_battery_status_t battery_status_t;// 147,
        public MAVLink.mavlink_autopilot_version_t autopilot_version_t;// 148,
        public MAVLink.mavlink_landing_target_t landing_target_t;// 149,
        public MAVLink.mavlink_sensor_offsets_t sensor_offsets_t;// 150,
        public MAVLink.mavlink_set_mag_offsets_t set_mag_offsets_t;// 151,
        public MAVLink.mavlink_meminfo_t meminfo_t;// 152,
        public MAVLink.mavlink_ap_adc_t ap_adc_t;// 153,
        public MAVLink.mavlink_digicam_configure_t digicam_configure_t;// 154,
        public MAVLink.mavlink_digicam_control_t digicam_control_t;// 155,
        public MAVLink.mavlink_mount_configure_t mount_configure_t;// 156,
        public MAVLink.mavlink_mount_control_t mount_control_t;// 157,
        public MAVLink.mavlink_mount_status_t mount_status_t;// 158,
                                                             //159
        public MAVLink.mavlink_fence_point_t fence_point_t;// 160,
        public MAVLink.mavlink_fence_fetch_point_t fence_fetch_point_t;// 161,
        public MAVLink.mavlink_fence_status_t fence_status_t;// 162,
        public MAVLink.mavlink_ahrs_t ahrs_t;// 163,
        public MAVLink.mavlink_simstate_t simstate_t=new MAVLink.mavlink_simstate_t();// 164,
        public MAVLink.mavlink_hwstatus_t hwstatus_t;//  165,
        public MAVLink.mavlink_radio_t radio_t;// 166,
        public MAVLink.mavlink_limits_status_t limits_status_t;// 167,
        public MAVLink.mavlink_wind_t wind_t;// 168,
        public MAVLink.mavlink_data16_t data16_t;// 169,
        public MAVLink.mavlink_data32_t data32_t;// 170,
        public MAVLink.mavlink_data64_t data64_t;// 171,
        public MAVLink.mavlink_data96_t data96_t;// 172,
        public MAVLink.mavlink_rangefinder_t rangefinder_t;// 173,
        public MAVLink.mavlink_airspeed_autocal_t airspeed_autocal_t;// 174,
        public MAVLink.mavlink_rally_point_t rally_point_t;// 175,
        public MAVLink.mavlink_rally_fetch_point_t rally_fetch_point_t;// 176,
        public MAVLink.mavlink_compassmot_status_t compassmot_status_t;// 177,
        public MAVLink.mavlink_ahrs2_t ahrs2_t;// 178,
        public MAVLink.mavlink_camera_status_t camera_status_t; // 179,
        public MAVLink.mavlink_camera_feedback_t camera_feedback_t;// 180,
        public MAVLink.mavlink_battery2_t battery2_t;// 181,
        public MAVLink.mavlink_ahrs3_t ahrs3_t;// 182,
        public MAVLink.mavlink_autopilot_version_request_t autopilot_version_request_t;// 183,
                                                                                       //184
                                                                                       //185
        public MAVLink.mavlink_led_control_t led_control_t;// 186,
                                                           //187
                                                           //188
                                                           //189
                                                           //190
        public MAVLink.mavlink_mag_cal_progress_t mag_cal_progress_t;// 191,
        public MAVLink.mavlink_mag_cal_report_t mag_cal_report_t;// 192,
        public MAVLink.mavlink_ekf_status_report_t ekf_status_report_t;// 193,
        public MAVLink.mavlink_pid_tuning_t pid_tuning_t;// 194,
                                                         //195
                                                         //196
                                                         //197
                                                         //198
                                                         //199
        public MAVLink.mavlink_gimbal_report_t gimbal_report_t;// 200,
        public MAVLink.mavlink_gimbal_control_t gimbal_control_t;// 201,
        public MAVLink.mavlink_gimbal_reset_t gimbal_reset_t;// 202,
        public MAVLink.mavlink_gimbal_axis_calibration_progress_t gimbal_axis_calibration_progress_t;// 203,
        public MAVLink.mavlink_gimbal_set_home_offsets_t gimbal_set_home_offsets_t;// 204,
        public MAVLink.mavlink_gimbal_home_offset_calibration_result_t gimbal_home_offset_calibration_result_t;// 205,
        public MAVLink.mavlink_gimbal_set_factory_parameters_t gimbal_set_factory_parameters_t;// 206,
        public MAVLink.mavlink_gimbal_factory_parameters_loaded_t gimbal_factory_parameters_loaded_t;// 207,
        public MAVLink.mavlink_gimbal_erase_firmware_and_config_t gimbal_erase_firmware_and_config_t;// 208,
        public MAVLink.mavlink_gimbal_perform_factory_tests_t gimbal_perform_factory_tests_t;// 209,
        public MAVLink.mavlink_gimbal_report_factory_tests_progress_t gimbal_report_factory_tests_progress_t;// 210,
        public MAVLink.mavlink_gimbal_request_axis_calibration_status_t gimbal_request_axis_calibration_status_t;// 211,
        public MAVLink.mavlink_gimbal_report_axis_calibration_status_t gimbal_report_axis_calibration_status_t;// 212,
        public MAVLink.mavlink_gimbal_request_axis_calibration_t gimbal_request_axis_calibration_t;// 213,
                                                                                                   //214
        public MAVLink.mavlink_gopro_heartbeat_t gopro_heartbeat_t;// 215,
        public MAVLink.mavlink_gopro_get_request_t gopro_get_request_t;//216,
        public MAVLink.mavlink_gopro_get_response_t gopro_get_response_t;//217,
        public MAVLink.mavlink_gopro_set_request_t gopro_set_request_t;//218,
        public MAVLink.mavlink_gopro_set_response_t gopro_set_response_t;// 219,
                                                                         //220
                                                                         //221
                                                                         //222
                                                                         //223
                                                                         //224
                                                                         //225
        public MAVLink.mavlink_rpm_t rpm_t;// 226,
                                           //227
                                           //228
                                           //229
                                           //230
                                           //231
                                           //232
                                           //233
                                           //234
                                           //235
                                           //236
                                           //237
                                           //238
                                           //239
                                           //240
        public MAVLink.mavlink_vibration_t vibration_t;// 241,
                                                       //242
                                                       //243
                                                       //244
                                                       //245
                                                       //246
                                                       //247
        public MAVLink.mavlink_v2_extension_t v2_extension_t;// 248,
        public MAVLink.mavlink_memory_vect_t memory_vect_t;// 249,
        public MAVLink.mavlink_debug_vect_t debug_vect_t;// 250,
        public MAVLink.mavlink_named_value_float_t named_value_float_t;// 251,
        public MAVLink.mavlink_named_value_int_t named_value_int_t;// 252,
        public MAVLink.mavlink_statustext_t statustext_t;// 253,
        public MAVLink.mavlink_debug_t debug_t;// 254,*/
