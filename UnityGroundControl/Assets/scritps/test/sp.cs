using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO.Ports;
using System.Threading;
public class sp : MonoBehaviour {
    SerialPort SP;
    public string portName = "COM1";
	// Use this for initialization
	void Start () {
        SP = new SerialPort();
        SP.PortName = portName;
        SP.BaudRate = 57600;
        try
        {
            SP.Open();
            while (true)
            {
                if (SP.IsOpen)
                {
                    th_received = new Thread(Receiveing);
                    th_received.IsBackground = true;
                    th_received.Start();
                    break;
                }
            }
        }
        catch { }
	}
    Thread th_received;
    void Receiveing()
    {
        while (true)
        {
            try
            {
                int lenth = 0,i=0;
                lenth = SP.BytesToRead;
                if (lenth > 0)
                {
                    byte[] data = new byte[lenth];
                    while (i < lenth)
                    {
                        data[i] = (byte)SP.ReadByte();
                        i++;
                    }
                    Received(data);
                }
            }
            catch { }
        }
    }
	// Update is called once per frame
	void Update () {
		
	}

    void Received(byte[] data)
    { }
}
