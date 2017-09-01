
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using System.Runtime;
public class EventHeader : MonoBehaviour {
    MyUIHeader myUIHeader;
    
    CommunicationEvent communicationEvent;
    AppBar_titleEvent appBar_titleEvent;
    DisplayEvent displayEvent;
    ControlEvent controlEvent;
    SettingEvents settingEvents;
    Simulation simulation;


   
    // Use this for initialization
    void Start () {
        Debug.Log("public class EventHeader Start");
        myUIHeader = this.transform.GetComponent<MyUIHeader>();
        
        appBar_titleEvent = new AppBar_titleEvent(myUIHeader);
        communicationEvent = new CommunicationEvent(myUIHeader);
        displayEvent = new DisplayEvent(myUIHeader);
        controlEvent = new ControlEvent(myUIHeader);
        settingEvents = new SettingEvents(myUIHeader);
        simulation = new Simulation(myUIHeader);
        Debug.Log("public class EventHeader EndStart");

        test t = new test();
       




    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
