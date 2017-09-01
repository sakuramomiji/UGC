using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Threading;

public class FlushText : MonoBehaviour {
    Text text;


    public float FR, FG,FB,FA;//255
    public float ER, EG,EB,EA;//255
    public float R, G,B,A;//255
    public float DR, DG,DB,DA;//255

    public float delaytime =1000;
    public float deltaTime=1;
    private string _TestStr="";
    Thread TDelayTime;
  public  bool flag;
    public string TestStr
    {
        get { return _TestStr; }
        set
        {
            if (_TestStr == value)
                return;

            _TestStr = value;
            if (text != null) text.text = value;
        }
    }
  void DelayTime()
    {
        flag = false;
        Thread.Sleep((int)delaytime);
            flag = true;
    }
    // Use this for initialization
    void Awake()
    {
        text = this.GetComponent<Text>();
        TDelayTime = new Thread(DelayTime);
        TDelayTime.IsBackground = true;
        //text.text
    }

    void Start () {
        text.color = new Color(FR / 255f, FG / 255f, FB / 255f, FA / 255f);
        R = FR; G = FG; B = FB; A = FA;
    }
    public void Bilibili()
    {
        TDelayTime.Start();
        R = FR;G = FG;B = FB;A = FA;
        text.color = new Color(FR / 255f, FG / 255f, FB / 255f, FA / 255f);

    }
    void judge(ref float value)
    {
        if (value > 255) value = 255;
        if (value < 0) value = 0;
      // Skybox.
    }
	// Update is called once per frame
	void Update () {
        judge(ref ER); judge(ref FR);
        judge(ref EG); judge(ref FG);
        judge(ref EB); judge(ref FB);
        judge(ref EA); judge(ref FA);

        if (!flag) return;
        DR = (ER - FR)*20 / deltaTime;
        DG = (EG - FG)*20 / deltaTime;
        DB = (EB - FB)*20 / deltaTime;
        DA = (EA - FA)*20 / deltaTime;

        if ((ER - R) * DR > 0)
            R += DR;

        if ((EG - G) * DG > 0)
           G += DG;

        if ((EB - B) * DB > 0)
            B+= DB;

        if ((EA - A) * DA > 0)
            A += DA;

        text.color = new Color(R / 255f, G / 255f, B / 255f, A / 255f);
       



    }
}
