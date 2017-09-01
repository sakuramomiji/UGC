using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using MaterialUI;
using UnityEngine.UI;

public class input : MonoBehaviour {
    MaterialInputField ipf;
    public GameObject  TT;
    // Use this for initialization
    void Start () {
        ipf = this.GetComponent<MaterialInputField>();
        ipf.inputField.onEndEdit.AddListener(onEndEdit);
        
    }
    void onEndEdit(string str)
    {
        TT.GetComponent<Text>().text += str + "\r\n";
        ipf.ClearText();
         Debug.Log(str);
    }
	// Update is called once per frame
	void Update () {
		
	}
}
