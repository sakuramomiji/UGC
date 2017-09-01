using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using MaterialUI;
public class t_sendmessage : MonoBehaviour {

	// Use this for initialization
	void Start () {
        this.SendMessageUpwards("display", "**");
       // Transform tr_inputfield=this.transform.FindChild("Input Field");
        //if(tr_inputfield!=null)
           // tr_inputfield.gameObject.GetComponent<MaterialUI.MaterialInputField>().inputField.onEndEdit.AddListener(onEndEdit);
    }
    void display2(string str)
    {
        Debug.Log(str);
    }
    void onEndEdit(string str)
    {
       this.SendMessageUpwards("display", str);
    }
    // Update is called once per frame
    void Update () {
		
	}
}
