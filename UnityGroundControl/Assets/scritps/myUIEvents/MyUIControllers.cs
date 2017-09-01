using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using MaterialUI;
public class MyUIControllers : MonoBehaviour {

    // Use this for initialization
    public Ardusub ardusub;
    public AppBar_title appBar_title;
    public FlyScreem flyScreem;
    public HUD hud;

    public Page_status page_status;
    public Page_communication page_commucation;
    public Page_input page_input;
    public Page_camera page_camera;
    public Page_mavlink page_mavlink;
    public Page_setting page_setting;
    void Start ()
    {
        //获取全部 控件 地址
        Debug.Log("public class MyUIControllers Start");

        ardusub = GameObject.Find("ardusub").GetComponent<Ardusub>(); Debug.Log("Find:ardusub");

        appBar_title = new AppBar_title(); Debug.Log("Find:appBar_title");
        flyScreem = new FlyScreem(); Debug.Log("Find:flyScreem");
        hud = new HUD(); Debug.Log("Find:hud");

        page_status = new Page_status(); Debug.Log("Find:page_status");
        page_commucation = new Page_communication(); Debug.Log("Find:page_commucation");
        page_input = new Page_input(); Debug.Log("Find:page_input");
        page_camera = new Page_camera(); Debug.Log("Find:page_camera");
        page_mavlink = new Page_mavlink(); Debug.Log("Find:page_mavlink");
        page_setting = new Page_setting(); Debug.Log("Find:page_setting");

        Debug.Log("public class MyUIControllers EndStart");

        //flyScreem.ist_Yaw.value = 90;
    }
   
    // Update is called once per frame
    void Update () {
		
	}
   
}
public class AppBar_title
{
   public LinearProgressIndicator lpi_ProgressBar;
    public Button btn_OutWin;
    public Button btn_MinWin;
    public Text txt_Title;
    public Text txt_Model;
    public Text txt_Power;
    public MaterialDropdown dpd_Menue;
    public AppBar_title()
    {
        lpi_ProgressBar = GameObject.Find("lpi_ProgressBar").GetComponent<LinearProgressIndicator>();
        btn_OutWin = GameObject.Find("btn_OutWin").GetComponent<Button>();
        btn_MinWin = GameObject.Find("btn_MinWin").GetComponent<Button>();
        txt_Title = GameObject.Find("txt_Title").GetComponent<Text>();
        txt_Model = GameObject.Find("txt_Model").GetComponent<Text>();
        txt_Power = GameObject.Find("txt_Power").GetComponent<Text>();
        dpd_Menue = GameObject.Find("dpd_Menue").GetComponent<MaterialDropdown>();
    }
}
public class FlyScreem
{
    public YawInstrument fist_Yaw;
    public RollInstrument fist_Roll;
    public PitchInstrument fist_Pitch;
    public FlyScreem()
    {
        fist_Yaw = GameObject.Find("fist_Yaw").GetComponent<YawInstrument>();
        //if (fist_Yaw == null) Debug.Log("**ist_Yaw null");

        fist_Roll = GameObject.Find("fist_Roll").GetComponent<RollInstrument>();
       // if (fist_Roll == null) Debug.Log("**ist_Roll null");

        fist_Pitch = GameObject.Find("fist_Pitch").GetComponent<PitchInstrument>();
       // if (fist_Pitch == null) Debug.Log("**ist_Pitch null");
    }
}
public class HUD
{
    public Text txt_HUDStatus;
    public Instrument ist_Yaw;
    public Instrument ist_Roll;
    public Instrument ist_Pitch;
    public Instrument2 ist2_Alt;
    public HUD()
    {
        txt_HUDStatus = GameObject.Find("txt_HUDStatus").GetComponent<Text>();
        ist_Yaw = GameObject.Find("ist_Yaw").GetComponent<Instrument>();
        ist_Roll = GameObject.Find("ist_Roll").GetComponent<Instrument>();
        ist_Pitch = GameObject.Find("ist_Pitch").GetComponent<Instrument>();
        ist2_Alt = GameObject.Find("ist2_Alt").GetComponent<Instrument2>();
    }
}
public class Page_status
{
    public Text txt_statues1;
    public Text txt_statues2;
    public Page_status()
    {
        txt_statues1=GameObject.Find("txt_statues1").GetComponent<Text>();
        txt_statues2 = GameObject.Find("txt_statues2").GetComponent<Text>();
    }
}
public class Page_communication
{
    public InputField itf_IPAddress;
    public InputField itf_IPPort;
    public Button btn_Connect;
    public Button btn_DisConnect;
    public InputField itf_Send;
    public udpPort udp_px4;
    public Button btn_Send;
    public InputField ipt_TextBox;
    public Page_communication()
    {
        itf_IPAddress = GameObject.Find("itf_IPAddress").GetComponent<InputField>();
        itf_IPPort=GameObject.Find("itf_IPPort").GetComponent<InputField>();
        btn_Connect=GameObject.Find("btn_Connect").GetComponent<Button>();
        btn_DisConnect=GameObject.Find("btn_DisConnect").GetComponent<Button>();
        itf_Send=GameObject.Find("itf_Send").GetComponent<InputField>();
        udp_px4=GameObject.Find("udp_px4").GetComponent<udpPort>();
        btn_Send=GameObject.Find("btn_Send").GetComponent<Button>();
        ipt_TextBox=GameObject.Find("ipt_TextBox").GetComponent<InputField>();
    }
}

public class Page_input
{

    public InputDevice itd_InputDevice;
    public Button btn_Info;
    public Image img_Joystick;

    public MaterialDropdown dpd_XAnxis;
    public MaterialDropdown dpd_YAnxis;
    public MaterialDropdown dpd_3thAnxis;
    public MaterialDropdown dpd_4thAnxis;
    public MaterialDropdown dpd_5thAnxis;
    public MaterialDropdown dpd_6thAnxis;
    public MaterialDropdown dpd_7thAnxis;
    public MaterialDropdown dpd_Button0;
    public MaterialDropdown dpd_Button1;
    public MaterialDropdown dpd_Button2;
    public MaterialDropdown dpd_Button3;
    public MaterialDropdown dpd_Button4;
    public MaterialDropdown dpd_Button5;
    public MaterialDropdown dpd_Button6;
    public MaterialDropdown dpd_Button7;

    public Button btn_ThrottleValueClear;
    public Button btn_YawValueClear;
    public Button btn_RollValueClear;
    public Button btn_PitchValueClear;
    public Button btn_TrimRollValueClear;
    public Button btn_TrimPitchValueClear;

    public Slider sld_Throttle;
    public Slider sld_Yaw;
    public Slider sld_Roll;
    public Slider sld_Pitch;
    public Slider sld_TrimRoll;
    public Slider sld_TrimPitch;

    public Button btn_Arm; public MaterialButton mbtn_Arm;
     public Button btn_DisArm; public MaterialButton mbtn_DisArm;
    public Button btn_LightBrighter; public MaterialButton mbtn_LightBrighter;
    public Button btn_LightDimmer; public MaterialButton mbtn_LightDimmer;
    public Button btn_Model1; public MaterialButton mbtn_Model1;
    public Button btn_Model2; public MaterialButton mbtn_Model2;
    public Button btn_Model3; public MaterialButton mbtn_Model3;

    public InputField ipt_ThrottleMax;
    public InputField ipt_YawMax;
    public InputField ipt_RollMax;
    public InputField ipt_PitchMax;
    public InputField ipt_TrimRollMax;
    public InputField ipt_TrimPitchMax;
    public InputField ipt_ThrottleKeyMax;
    public InputField ipt_RollKeyMax;
    public InputField ipt_PitchKeyMax;
    public InputField ipt_TrimPitchKeyMax;
    public InputField ipt_TrimRollKeyMax;
    public InputField ipt_YawKeyMax;
    public InputField ipt_ThrottleMid;
    public InputField ipt_YawMid;
    public InputField ipt_TrimRollMid;
    public InputField ipt_PitchMid;
    public InputField ipt_RollMid;
    public InputField ipt_TrimPitchMid;

    public Button btn_anxisValueFlush;

    public Button btn_northMain;
    public Button btn_southMain;
    public Button btn_eastMain;
    public Button btn_westMain;
    public Page_input()
    {
        itd_InputDevice = GameObject.Find("itd_InputDevice").GetComponent<InputDevice>();
        btn_Info = GameObject.Find("btn_Info").GetComponent<Button>();
        img_Joystick = GameObject.Find("img_Joystick").GetComponent<Image>();

        dpd_XAnxis = GameObject.Find("dpd_XAnxis").GetComponent<MaterialDropdown>();
        dpd_YAnxis = GameObject.Find("dpd_YAnxis").GetComponent<MaterialDropdown>();
        dpd_3thAnxis = GameObject.Find("dpd_3thAnxis").GetComponent<MaterialDropdown>();
        dpd_4thAnxis = GameObject.Find("dpd_4thAnxis").GetComponent<MaterialDropdown>();
        dpd_5thAnxis = GameObject.Find("dpd_5thAnxis").GetComponent<MaterialDropdown>();
        dpd_6thAnxis = GameObject.Find("dpd_6thAnxis").GetComponent<MaterialDropdown>();
        dpd_7thAnxis = GameObject.Find("dpd_7thAnxis").GetComponent<MaterialDropdown>();
        dpd_Button0 = GameObject.Find("dpd_Button0").GetComponent<MaterialDropdown>();
        dpd_Button1 = GameObject.Find("dpd_Button1").GetComponent<MaterialDropdown>();
        dpd_Button2 = GameObject.Find("dpd_Button2").GetComponent<MaterialDropdown>();
        dpd_Button3 = GameObject.Find("dpd_Button3").GetComponent<MaterialDropdown>();
        dpd_Button4 = GameObject.Find("dpd_Button4").GetComponent<MaterialDropdown>();
        dpd_Button5 = GameObject.Find("dpd_Button5").GetComponent<MaterialDropdown>();
        dpd_Button6 = GameObject.Find("dpd_Button6").GetComponent<MaterialDropdown>();
        dpd_Button7 = GameObject.Find("dpd_Button7").GetComponent<MaterialDropdown>();

        btn_ThrottleValueClear = GameObject.Find("btn_ThrottleValueClear").GetComponent<Button>();
        btn_YawValueClear = GameObject.Find("btn_YawValueClear").GetComponent<Button>();
        btn_RollValueClear = GameObject.Find("btn_RollValueClear").GetComponent<Button>();
        btn_PitchValueClear = GameObject.Find("btn_PitchValueClear").GetComponent<Button>();
        btn_TrimRollValueClear = GameObject.Find("btn_TrimRollValueClear").GetComponent<Button>();
        btn_TrimPitchValueClear = GameObject.Find("btn_TrimPitchValueClear").GetComponent<Button>();

        sld_Throttle = GameObject.Find("sld_Throttle").GetComponent<Slider>();
        sld_Yaw = GameObject.Find("sld_Yaw").GetComponent<Slider>();
        sld_Roll = GameObject.Find("sld_Roll").GetComponent<Slider>();
        sld_Pitch = GameObject.Find("sld_Pitch").GetComponent<Slider>();
        sld_TrimRoll = GameObject.Find("sld_TrimRoll").GetComponent<Slider>();
        sld_TrimPitch = GameObject.Find("sld_TrimPitch").GetComponent<Slider>();

        btn_Arm = GameObject.Find("btn_Arm").GetComponent<Button>();
        btn_DisArm = GameObject.Find("btn_DisArm").GetComponent<Button>();
        btn_LightBrighter = GameObject.Find("btn_LightBrighter").GetComponent<Button>();
        btn_LightDimmer = GameObject.Find("btn_LightDimmer").GetComponent<Button>();
        btn_Model1 = GameObject.Find("btn_Model1").GetComponent<Button>();
        btn_Model2 = GameObject.Find("btn_Model2").GetComponent<Button>();
        btn_Model3 = GameObject.Find("btn_Model3").GetComponent<Button>();

        ipt_ThrottleMax= GameObject.Find("ipt_ThrottleMax").GetComponent<InputField>();
        ipt_YawMax = GameObject.Find("ipt_YawMax").GetComponent<InputField>();
        ipt_RollMax = GameObject.Find("ipt_RollMax").GetComponent<InputField>();
        ipt_PitchMax = GameObject.Find("ipt_PitchMax").GetComponent<InputField>();
        ipt_TrimRollMax = GameObject.Find("ipt_TrimRollMax").GetComponent<InputField>();
        ipt_TrimPitchMax = GameObject.Find("ipt_TrimPitchMax").GetComponent<InputField>();
        ipt_ThrottleKeyMax = GameObject.Find("ipt_ThrottleKeyMax").GetComponent<InputField>();
        ipt_RollKeyMax = GameObject.Find("ipt_RollKeyMax").GetComponent<InputField>();
        ipt_PitchKeyMax = GameObject.Find("ipt_PitchKeyMax").GetComponent<InputField>();
        ipt_TrimPitchKeyMax = GameObject.Find("ipt_TrimPitchKeyMax").GetComponent<InputField>();
        ipt_TrimRollKeyMax = GameObject.Find("ipt_TrimRollKeyMax").GetComponent<InputField>();
        ipt_YawKeyMax = GameObject.Find("ipt_YawKeyMax").GetComponent<InputField>();
        ipt_ThrottleMid = GameObject.Find("ipt_ThrottleMid").GetComponent<InputField>();
        ipt_YawMid = GameObject.Find("ipt_YawMid").GetComponent<InputField>();
        ipt_TrimRollMid = GameObject.Find("ipt_TrimRollMid").GetComponent<InputField>();
        ipt_PitchMid = GameObject.Find("ipt_PitchMid").GetComponent<InputField>();
        ipt_RollMid = GameObject.Find("ipt_RollMid").GetComponent<InputField>();
        ipt_TrimPitchMid = GameObject.Find("ipt_TrimPitchMid").GetComponent<InputField>();

      mbtn_Arm = GameObject.Find("btn_Arm").GetComponent<MaterialButton>();
        mbtn_DisArm =GameObject.Find("btn_DisArm").GetComponent<MaterialButton>();
        mbtn_LightBrighter = GameObject.Find("btn_LightBrighter").GetComponent<MaterialButton>();
        mbtn_LightDimmer = GameObject.Find("btn_LightDimmer").GetComponent<MaterialButton>();
        mbtn_Model1 = GameObject.Find("btn_Model1").GetComponent<MaterialButton>();
        mbtn_Model2 = GameObject.Find("btn_Model2").GetComponent<MaterialButton>();
        mbtn_Model3 = GameObject.Find("btn_Model3").GetComponent<MaterialButton>();

        btn_anxisValueFlush= GameObject.Find("btn_anxisValueFlush").GetComponent<Button>();

        btn_northMain = GameObject.Find("btn_northMain").GetComponent<Button>();
        btn_southMain = GameObject.Find("btn_southMain").GetComponent<Button>();
        btn_eastMain = GameObject.Find("btn_eastMain").GetComponent<Button>();
        btn_westMain = GameObject.Find("btn_westMain").GetComponent<Button>();
    }

}
public class Page_camera
{
    public MaterialDropdown dd_CameraType;
    public Button btn_CatchCapture;

    public Page_camera()
    {
        dd_CameraType = GameObject.Find("dd_CameraType").GetComponent<MaterialDropdown>();
        btn_CatchCapture = GameObject.Find("btn_CatchCapture").GetComponent<Button>();
    }
}
public class Page_mavlink
{
    public Text txt_Mavlink1;
    public Text txt_Mavlink2;
    public MavlinkData data_Mavlink;
    public Timer tmr_MavlinkUpdata;
    public Timer tmr_UGCHeartbeat;
    public Timer tmr_UGCManualControl;
    public Page_mavlink()
    {
        txt_Mavlink1 = GameObject.Find("txt_Mavlink1").GetComponent<Text>();
        txt_Mavlink2 = GameObject.Find("txt_Mavlink2").GetComponent<Text>();
        data_Mavlink = GameObject.Find("data_Mavlink").GetComponent<MavlinkData>();
        tmr_MavlinkUpdata = GameObject.Find("tmr_MavlinkUpdata").GetComponent<Timer>();
        tmr_UGCHeartbeat = GameObject.Find("tmr_UGCHeartbeat").GetComponent<Timer>();
        tmr_UGCManualControl = GameObject.Find("tmr_UGCManualControl").GetComponent<Timer>();
    }

}
public class Page_setting
{
    public MaterialDropdown dp_SpeakerLanguage;
    public Slider sld_SpeakerVoice;
    public Slider sld_SpeakerSpeed;
    public Button btn_SpeakerTest;
   // public Speaker spk_Speaker;
    public Button btn_OpenDiary;
    public Toggle swt_SpeakerEn;
    public Toggle swt_ObjControlEn;
    public Toggle swt_DiaryEn;
    public TxtWriter txtwt_DiaryWriter;
    public Page_setting()
    {
        dp_SpeakerLanguage = GameObject.Find("dp_SpeakerLanguage").GetComponent<MaterialDropdown>();
        sld_SpeakerVoice = GameObject.Find("sld_SpeakerVoice").GetComponent<Slider>();
        sld_SpeakerSpeed = GameObject.Find("sld_SpeakerSpeed").GetComponent<Slider>();
        btn_SpeakerTest = GameObject.Find("btn_SpeakerTest").GetComponent<Button>();
        //spk_Speaker = GameObject.Find("spk_Speaker").GetComponent<Speaker>();
        btn_OpenDiary = GameObject.Find("btn_OpenDiary").GetComponent<Button>();
        swt_SpeakerEn = GameObject.Find("swt_SpeakerEn").GetComponent<Toggle>();
        swt_ObjControlEn = GameObject.Find("swt_ObjControlEn").GetComponent<Toggle>();
        swt_DiaryEn = GameObject.Find("swt_DiaryEn").GetComponent<Toggle>();
        txtwt_DiaryWriter = GameObject.Find("txtwt_DiaryWriter").GetComponent<TxtWriter>();
    }
}





