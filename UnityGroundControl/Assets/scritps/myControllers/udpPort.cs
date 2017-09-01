using UnityEngine;
using System.Net;
using System.Net.Sockets;
using System.Threading;

public class udpPort : MonoBehaviour {

    UdpClient udpclient;
    string localIPAddress = "192.168.2.2";
    string localIPPort = "14550";

    IPEndPoint localEndPoint;
    IPEndPoint receivedEndPoint = new IPEndPoint(IPAddress.Any, 0);
    IPEndPoint broadcastEndPoint = new IPEndPoint(IPAddress.Parse("255.255.255.255"),0);
    Thread ReceivedData;
    public bool isDatareceived=false;
    // Use this for initialization
    public delegate void _UDPPortDataReceived(byte[] data);
    public event _UDPPortDataReceived UDPPortDataReceived;

    public void SetLocalIPAddress(string LocalIPAddress)
    {
       
        try {IPAddress.Parse(LocalIPAddress); localIPAddress = LocalIPAddress; }
        catch { }
            
    }
    public void SetLocalIPPort(string LocalIPPort)
    {
        try
        {
            int.Parse(LocalIPPort);
            localIPPort = LocalIPPort;
        }
        catch { }
    }

    public void Connect()
    {
        //建立本地UDP
        if (udpclient != null)
            return;
        try
        {
            localEndPoint = new IPEndPoint(IPAddress.Parse(localIPAddress), int.Parse(localIPPort));
        }
        catch { return; }

        udpclient = new UdpClient(localEndPoint);
        udpclient.EnableBroadcast = true;
        isThreadReceivedData = true;
        ReceivedData = new Thread(receivedData);
        ReceivedData.IsBackground = true;
        ReceivedData.Start();

    }
    public void DisConnect()
    {
        //关闭本地UDP
        if (udpclient == null)
            return;

        //ReceivedData.Interrupt();
        isThreadReceivedData = false;
        // while (ReceivedData.IsAlive) { }
        isDatareceived = false;
        udpclient.Close();
        udpclient = null;
        
    }
    bool isThreadReceivedData;
    void receivedData()
    {
        try
        {
            while (true)
            {
                if (!isThreadReceivedData) return;
                byte[] data = udpclient.Receive(ref receivedEndPoint);
                if (data.Length > 0)
                {
                    isDatareceived = true;
                    if (UDPPortDataReceived != null)
                        UDPPortDataReceived(data);
                }
            }
        }
        catch { }
    }
    public void SendData(byte[] data)
    {
        if (udpclient == null) return;
        if(receivedEndPoint.Address==IPAddress.Any)
            udpclient.Send(data, data.Length, broadcastEndPoint);
        else
            udpclient.Send(data, data.Length, receivedEndPoint);
    }

    void Start () {
       
	}
	
	// Update is called once per frame
	void Update () {
        if (udpclient != null && !ReceivedData.IsAlive)
        {

            ReceivedData = new Thread(receivedData);
            ReceivedData.IsBackground = true;
            ReceivedData.Start();
        }
    }
    void OnApplicationQuit()
    {
        isThreadReceivedData = false;
        DisConnect();
    }
    public string getLocalIPAddress()
    {
        string AddressIP = "127.0.0.1";
        foreach (IPAddress _IPAddress in Dns.GetHostEntry(Dns.GetHostName()).AddressList)
        {
            if (_IPAddress.AddressFamily.ToString() == "InterNetwork")
            {
                AddressIP = _IPAddress.ToString();
            }
        }
        return AddressIP;
    }
}
