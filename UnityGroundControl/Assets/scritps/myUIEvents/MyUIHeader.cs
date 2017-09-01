using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyUIHeader : MonoBehaviour {
    public  MyUIControllers myUIControllers;
 
    public EventHeader eventHeader;
    // Use this for initialization

    void Start () {
        Debug.Log("public class MyUIHeader Start");
        //获取控件
        myUIControllers=   this.gameObject.AddComponent<MyUIControllers>();
        //注册事件
        eventHeader = this.gameObject.AddComponent<EventHeader>();
        Debug.Log("public class MyUIHeader EndStart");
        
    }
   
	// Update is called once per frame
	void Update () {
     
    }
}
