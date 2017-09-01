using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour {
    public GameObject ArduSub;
    Ardusub ardusub;
	// Use this for initialization
	void Start () {
        if(ArduSub!=null)
        ardusub = ArduSub.GetComponent<Ardusub>();
       

    }
	
	// Update is called once per frame
	void Update () {
        if (gameObject == null) return;
        if (ardusub == null) return;
        this.transform.position = ArduSub.transform.position;
        Vector3 v= ardusub.eulerAngles;
        /*Debug.Log("e:"+v);
        v = gameObject.transform.localEulerAngles;
        Debug.Log("le:" + v);
        Debug.Log("lr:" + gameObject.transform.rotation );
        Debug.Log("lr:" + gameObject.transform.localRotation);*/
        this.transform.eulerAngles  = v;

    }
}
