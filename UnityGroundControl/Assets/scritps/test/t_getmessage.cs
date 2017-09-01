using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using MaterialUI;
public class t_getmessage : MonoBehaviour {

	// Use this for initialization
	void Start () {
        this.BroadcastMessage("display2", "###");
    }
    void display(string str)
    {
        Debug.Log(str);
    }
   
    // Update is called once per frame
    void Update () {
		
	}
}
