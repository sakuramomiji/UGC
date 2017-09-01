using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ardusub : MonoBehaviour {

    public Rigidbody rigidbody;
    public ConstantForce constantForce;
   public  Transform ROV;
    // Use this for initialization
    //x俯仰pitch y偏航yaw z翻滚roll
    public bool isControl = false;

    private float _Roll;
    private float _Yaw;
    private float _Pitch;

    public bool RollIsClockWise = true;
    public bool YawIsClockWise=true;
    public bool PitchIsClockWise = true;

    public float RollOffset;
    public float YawOffset;
    public float PitchOffset;

   public  Vector3 eulerAngles;

    public float Roll
    {
        get { return _Roll; }
        set
        {
            float v = value;
            v = v % 360;
            if (RollIsClockWise) { }
            else v = -v;
          //  v = v + RollOffset;
           
            if (v == _Roll) return;
            else _Roll = v;
        }
    }
    public float Pitch
    {
        get { return _Pitch; }
        set
        {
            float v = value;
            v = v % 360;
            if (PitchIsClockWise) { }
            else v = -v;
          //  v = v + PitchOffset;
          
            if (v == _Pitch) return;
            else _Pitch = v;
        }
    }

    public float Yaw
    {
        get { return _Yaw; }
        set
        {
            float v = value;
            v = v % 360;
            if (YawIsClockWise) { }
            else v = -v;
           // v = v + YawOffset;
            
            if (v == _Yaw) return;
            else _Yaw = v;
        }
    }
    void Awake()
    {
        rigidbody = this.GetComponent<Rigidbody>();
        constantForce = this.GetComponent<ConstantForce>();
        ROV = this.transform.FindChild("ROV");
        eulerAngles = this.transform. eulerAngles;
    }
    void Start () {
		 
	}
	
	// Update is called once per frame
	void Update () {

        eulerAngles = this.transform.eulerAngles;
        if (rigidbody != null)
        {
            rigidbody.isKinematic = !isControl;
        }
        if (!isControl)
        {
            this.transform.eulerAngles = new Vector3(_Pitch + PitchOffset, _Yaw + YawOffset, _Roll + RollOffset);
        }
        else
        {
           // ROV.eulerAngles = new Vector3(_Pitch + PitchOffset, _Yaw + YawOffset, _Roll + RollOffset);
            if (ROV != null)
            {
               /* if (constantForce == null) return;
                Vector3 v = ROV.eulerAngles;

                Vector3 F = constantForce.relativeForce;
                if (F.x > 0) v.x += 1;
                else if (F.x == 0) v.x = 0;
                ROV.eulerAngles = v;
                */

            }
        }
    }
}
