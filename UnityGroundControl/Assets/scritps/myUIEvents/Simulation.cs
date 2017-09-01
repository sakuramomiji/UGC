using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Simulation 
    {

    MyUIHeader myUIHeader;
    MyUIControllers myUIControllers; Random random = new Random();
    Ardusub ardusub;

    public bool pitchFlag = true, rollFlag= true, yawFlag=true , throttleFlag = true;
    public Simulation(MyUIHeader _myUIHeader)
    {
        myUIHeader = _myUIHeader;
        myUIControllers = myUIHeader.myUIControllers;
        ardusub = myUIControllers.ardusub;
        EventRegister();
    }
    void EventRegister()
    {
        myUIControllers.page_mavlink.tmr_MavlinkUpdata.Flush += simulation;
    }


    void simulation(object Sender)
    {


        float DIP = 0;// Random.Range(0.45f,0.55f);
        float D = 10, DR =0.05f ;

        if (!myUIControllers.page_setting.swt_ObjControlEn.isOn)
            return;
        Vector3 RF = ardusub.constantForce.relativeForce;

        float anxisPitchValueA = myUIControllers.page_input.itd_InputDevice.anxisPitch.ValueA;
        float anxisThrottleValueA = myUIControllers.page_input.itd_InputDevice.anxisThrottle.ValueA;
        float anxisRollValueA = myUIControllers.page_input.itd_InputDevice.anxisRoll.ValueA;
        float anxisYawValueA= myUIControllers.page_input.itd_InputDevice.anxisYaw.ValueA;

        if (!pitchFlag) anxisPitchValueA = -anxisPitchValueA;
        if (!throttleFlag) anxisThrottleValueA = -anxisThrottleValueA;
        if (!rollFlag) anxisRollValueA = -anxisRollValueA;
        if (!yawFlag) anxisYawValueA = -anxisYawValueA;


        if (Mathf.Abs(anxisPitchValueA) < 50)
            anxisPitchValueA = 0;
        if (Mathf.Abs(anxisThrottleValueA) < 50)
            anxisThrottleValueA = 0;
        if (Mathf.Abs(anxisRollValueA) < 50)
            anxisRollValueA = 0;
        if (Mathf.Abs(anxisYawValueA) < 50)
            anxisYawValueA = 0;
        //前后
        if (RF.z < anxisPitchValueA)
            RF.z += D;
        else if (RF.z > anxisPitchValueA)
            RF.z += -D;
        else
            RF.z = anxisPitchValueA;
        //升降
        if (RF.y < anxisThrottleValueA)
            RF.y += D;
        else if (RF.y > anxisThrottleValueA)
            RF.y += -D;
        else
            RF.y = anxisThrottleValueA;
        //左右
        if (RF.x < anxisRollValueA)
            RF.x += D;
        else if (RF.x > anxisRollValueA)
            RF.x += -D;
        else
            RF.x = anxisRollValueA;

        ardusub.constantForce.relativeForce = RF;
        //左右转
        Vector3 RT = ardusub.constantForce.relativeTorque;
       

        if (RT.y < anxisYawValueA)
            RT.y += D;
        else if (RT.y > anxisYawValueA)
            RT.y += -D;
        else
            RT.y = anxisYawValueA;
      
        ardusub.constantForce.relativeTorque = RT;
        Vector3 ve = ardusub.transform.localEulerAngles;
        ve.x = 0;
        ve.z = 0;
        ardusub.transform.localEulerAngles = ve;
        /*
        float RX,RZ;
        if (anxisPitchValueA > 50)
            RX = DIP;
        else if (anxisPitchValueA < -50)
            RX = -DIP;
        else
            RX = 0;

        if (anxisRollValueA > 50)
            RZ = DIP;
        else if (anxisRollValueA < -50)
            RZ = -DIP;
        else
            RZ = 0;

        Vector3 R = ardusub.ROV.localEulerAngles;
      
        if (R.x > 180) R.x = R.x - 360f;
        if (R.z > 180) R.z = R.z - 360f;
       
        if (RX == DIP)
        {
            if (R.x < DIP)
                R.x += DR;
            if (R.x > DIP)
                R.x = DIP;
        }
        if(RX == -DIP)
        {
            if (R.x > -DIP)
                R.x += -DR;
            if (R.x < -DIP)
                R.x = -DIP;
        }
        if (RX == 0)
        {
            if (R.x > 0)
                R.x += -DR;
            if (R.x < 0)
                R.x += DR;
            if (Mathf.Abs(R.x) < 2)
                R.x = 0;
        }

        if (RZ == DIP)
        {
            if (R.z < DIP)
                R.z += DR;
            if (R.z > DIP)
                R.z = DIP;
        }
        if (RZ == -DIP)
        {
            if (R.z > -DIP)
                R.z += -DR;
            if (R.z < -DIP)
                R.z = -DIP;
        }
        if (RZ == 0)
        {
            if (R.z> 0)
                R.z += -DR;
            if (R.z < 0)
                R.z += DR;
            if (Mathf.Abs(R.z) < 2)
                R.z = 0;
        }

      
        ardusub.ROV.localEulerAngles = R;
        */
    }
}
