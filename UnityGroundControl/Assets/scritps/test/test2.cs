using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using
    MaterialUI;
public class test2 : MonoBehaviour {
    LinearProgressIndicator lpi;
	// Use this for initialization
	void Start () {
        lpi = this.GetComponent<LinearProgressIndicator>();
        lpi.SetProgress(1f, true);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
