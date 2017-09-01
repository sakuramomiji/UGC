using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using MaterialUI;
public class InputDevice : MonoBehaviour {
    //该脚本用以获取键盘与手柄事件
    // Use this for initialization
   public  enum Direction {Forward,Right ,Back,Left};

    public Direction direction = Direction.Forward;

    public  List<Anxis> anxises=new List<Anxis>();
    public Anxis anxisThrottle = new Anxis();
    public Anxis anxisYaw=new Anxis();
    public Anxis anxisRoll = new Anxis();
    public Anxis anxisPitch = new Anxis();
    public Anxis anxisTrimRoll = new Anxis();
    public Anxis anxisTrimPitch = new Anxis();
    public Anxis anxisGain = new Anxis();

    public List<KeyButton> keyButtons=new List<KeyButton>();
    public KeyButton buttonArm = new KeyButton();
    public KeyButton buttonDisArm=new KeyButton();
    public KeyButton buttonLightBrighter=new KeyButton();
    public KeyButton buttonLightDimmer=new KeyButton();
    public KeyButton buttonModel1Manual = new KeyButton();
    public KeyButton buttonModel2Stablize = new KeyButton();
    public KeyButton buttonModel3DepthHold=new KeyButton();

    Slider slider;
    void Awake () {
        keyButtons.Add(null);
        keyButtons.Add(buttonArm);
        keyButtons.Add(buttonDisArm);
        keyButtons.Add(buttonModel1Manual);
        keyButtons.Add(buttonModel2Stablize);
        keyButtons.Add(buttonModel3DepthHold);
        keyButtons.Add(buttonLightDimmer);
        keyButtons.Add(buttonLightBrighter);
       
      

        anxises.Add(null);
        anxises.Add(anxisRoll);
        anxises.Add(anxisPitch);
        anxises.Add(anxisYaw);
        anxises.Add(anxisThrottle);
        anxises.Add(anxisTrimRoll);
        anxises.Add(anxisTrimPitch);
        anxises.Add(anxisGain);




    }
    void G<T>(object sender)
    {
        T obj= (T)sender;
    }
    void Start()
    {

    }
   
   

    void OnGUI()
    {
     
    }

	// Update is called once per frame
	void Update () {

        int i = 1;
        while(i< anxises.Count)
        {
            anxises[i].Update();
            i++;
        }
        i = 1;
        while (i < keyButtons.Count)
        {
            keyButtons[i].Update();
            i++;
        }
    }
}

public class Anxis
{
    private float _Value;
    public float Value
    {
        get { return _Value; }
        set
        {
            if (_Value != value)
            {
                _Value = value;
                if (ValueChanged != null)
                     ValueChanged(this);
                if (MSlider != null)
                    MSlider.value = value;
                
            }
        }
    }
    public float ValueA;
    float AnxisDelta=0;
    float AnxisValue = 0;
    float AnxisLastValue = 0;
   KeyCode AnxisUp;
    KeyCode AnxisDown;

    public bool flag = false;

    bool isInitialization = false;
    public string AnxisName;
    public float Max,KeyMax,Limit,Middle;
   
    public Slider MSlider;
    public delegate void VALUECHANGED(object sender);
    public event VALUECHANGED ValueChanged;

    public InputField Ipt_Max;
    public InputField Ipt_KeyMax;
    public InputField Ipt_Mid;
    public void Initialization(string anxisName, KeyCode anxisUp, KeyCode anxisDown, float max, float keyMax, float limit,float middle, Slider mSlider)
    {
        MSlider = mSlider;
        Value = middle;
        AnxisName = anxisName;
        AnxisUp = anxisUp;
        AnxisDown = anxisDown;
        Max = max;
        KeyMax = keyMax;
       
        Limit = limit;
        Middle = middle;
        ResetAnxisValue();
        isInitialization = true;
    }
    public void Initialization(string anxisName, KeyCode anxisUp, KeyCode anxisDown, InputField ipt_Max, InputField ipt_KeyMax,InputField ipt_Mid,float limit, Slider mSlider)
    {
        if (ipt_Max == null || ipt_Mid == null || ipt_KeyMax == null) return;
        Ipt_Max = ipt_Max;
        Ipt_Mid = ipt_Mid;
        Ipt_KeyMax = ipt_KeyMax;

        MSlider = mSlider;
        Value = float.Parse(ipt_Mid.text);
        AnxisName = anxisName;
        AnxisUp = anxisUp;
        AnxisDown = anxisDown;
        Max = float.Parse(ipt_Max .text);
        KeyMax = float.Parse(ipt_KeyMax.text);

        Limit = limit;
        Middle = float.Parse(ipt_Mid.text);
        isInitialization = true;

        ResetAnxisValue();
    }
    public Anxis()
    { }
    public Anxis(string anxisName, KeyCode anxisUp, KeyCode anxisDown, float max, float keyMax, float limit, float middle, Slider mSlider)
    {
        Initialization(anxisName, anxisUp, anxisDown, max, keyMax, limit, middle, mSlider);
    }

    public void ResetAnxisValue()
    {
        float anxisValueNow = Input.GetAxis(AnxisName);
        AnxisValue = 0;
        AnxisDelta = anxisValueNow;
        AnxisLastValue = anxisValueNow;
    }
    public void Update()
    {
        float anxisValueNow = Input.GetAxis(AnxisName);
        AnxisDelta = anxisValueNow - AnxisLastValue;
        AnxisLastValue = anxisValueNow;
        AnxisValue += AnxisDelta;

        if (!isInitialization) return;
        //Debug.Log("updata!");
        if (!flag)
        {
            ValueA = AnxisValue * Max;// Input.GetAxis(AnxisName) * Max;
            Value = TrueValue(AnxisValue, Middle, Max, Limit);// TrueValue(Input.GetAxis(AnxisName), Middle, Max, Limit);
           
               
        }
        if (Input.GetKeyDown(AnxisUp))
        { Value = TrueValue(1, Middle, KeyMax, Limit); flag = true; ValueA = -KeyMax; }
        if (Input.GetKeyUp(AnxisUp))
        { Value = Middle; flag = false; ValueA = 0; }
        if (Input.GetKeyDown(AnxisDown))
        { Value = TrueValue(-1, Middle, KeyMax, Limit) ; flag = true; ValueA = KeyMax; }
        if (Input.GetKeyUp(AnxisDown))
        { Value = Middle; flag = false; ValueA = 0; }

        if (Ipt_Mid!=null)
            this.Middle= float.Parse(Ipt_Mid.text);
        if (Ipt_Max != null)
            this.Max = float.Parse(Ipt_Max.text);
        if (Ipt_KeyMax != null)
            this.KeyMax = float.Parse(Ipt_KeyMax.text);

    }
    float TrueValue(float value, float middleValue, float max, float limit)
    {
        float v = value * max + middleValue;
        if (v > Mathf.Abs(limit)) v = Mathf.Abs(limit);
        if (v < -Mathf.Abs(limit)) v = -Mathf.Abs(limit);
        return v;
    }
}
public class KeyButton
{
    public KeyCode First;
    public KeyCode Senond;
    public bool isClick = false;
    int u = 0;
    public MaterialButton mButton;
    
    private bool _flag;
    public bool flag
    {
        set
        {
            if (_flag != value)
            {
                _flag = value;
                if (ValueChanged != null)
                    ValueChanged(this);
            }
        }
        get { return _flag; }
    }
    public delegate void VALUECHANGED(object sender);
    public event VALUECHANGED ValueChanged;

    public delegate void CLICK(object sender);
    public event CLICK Click;

    bool isInitialization = false;
    public KeyButton()
    { }
   public void Initialization(KeyCode first, KeyCode second, MaterialButton MButton)
    {
        mButton = MButton;
        Senond = second;
        First = first;
        
        isInitialization = true;
    }
    public KeyButton(KeyCode first, KeyCode second, MaterialButton MButton)
    {
        Initialization(first, second, mButton);
    }
   
    public void Update()
    {
        if (!isInitialization) return;
        if (Input.GetKey(First) || Input.GetKey(Senond))
        {
            isClick = true;
            if (u == 0)
            {
                flag = !flag;
                if (Click != null)
                    Click(this);

            }
            u++;
            OnUsing();
        }
        else
        {
            isClick = false;
            u = 0;
            DisUsing();
        } 
    }
    void DisUsing()
    {

        if (mButton == null) return;
        Color c = mButton.textColor;
        c.r =0f;
        mButton.textColor = c;
    }
    void OnUsing()
    {

        if (mButton == null) return;

        Color c = mButton.textColor;
        c.r =1f;
        mButton.textColor = c;

    }
}
