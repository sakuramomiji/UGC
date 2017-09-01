using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Speaker : MonoBehaviour {
   public bool Enabled;
    //SpVoice speaker = new SpVoice();
    public int LanguageCount;
    public int Rate
    {
        get
        {
          //  if (speaker != null)
           //     return speaker.Rate;
           // else
                return 0;
        }
        set
        {
           // if (speaker != null)
              //  speaker.Rate=value;
        }
    }
    public int Volume
    {
        get
        {//
         //if (speaker != null) return speaker.Volume;
         // else 
            return 0;
        }
        set
        {
            //if (speaker != null)
             //   speaker.Volume = value;
        }
    }
    private int _Language = 0;
    public int Language
    {
        get { return _Language; }
        set
        {
            if (value < 0)
            {
              //  _Language = 0;
              //  speaker.Voice = speaker.GetVoices().Item(_Language);
            }
            else if (value >= LanguageCount)
            {
                //_Language = LanguageCount-1;
               // speaker.Voice = speaker.GetVoices().Item(_Language);
            }
            else
               
            {
               // _Language = value;
               // speaker.Voice = speaker.GetVoices().Item(value);
            }
        }
    }
    public void Speak(string str)
    {
        //if(Enabled)
         //   speaker.Speak(str, SpeechVoiceSpeakFlags.SVSFlagsAsync);
    }
    // Use this for initialization
    void Awake()
    {
        //LanguageCount = speaker.GetVoices().Count;
    }
    void Start () {
       Rate = 0;
        Volume = 50;
        Language = 1;
        Enabled = true;
        Speak("1 2 3");
        

    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
