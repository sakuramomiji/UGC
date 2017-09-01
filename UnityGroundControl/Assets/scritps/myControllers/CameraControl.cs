using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControl : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
    int flag = 0;
	// Update is called once per frame
	void Update () {
      
        if (Input.GetKeyDown(KeyCode.R))
        {
            flag++;
            if (flag == 4)
                flag = 0;
            switch (flag)
            {
                case 0:
                    this.transform.localPosition = new Vector3(0, 0, 0.22f);
                    this.transform.localEulerAngles = new Vector3(0f, 0f, 0f); break;
                case 1:
                    this.transform.localPosition = new Vector3(0, 1, -2.5f);
                    this.transform.localEulerAngles = new Vector3(0f, 0f, 0f); break;
                case 2:
                    this.transform.localPosition = new Vector3(0, 8, 0);
                    this.transform.localEulerAngles = new Vector3(90f, 0f, 0f);break;
                case 3:
                    this.transform.localPosition = new Vector3(0, 0, 0);
                    this.transform.localEulerAngles = new Vector3(90f, 0f, 0f); break;

            }
        }
        


	}
}
