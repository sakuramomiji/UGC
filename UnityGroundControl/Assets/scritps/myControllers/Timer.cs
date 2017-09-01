using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Threading;
using MaterialUI;
public class Timer : MonoBehaviour
{
    Thread tick;
    bool flag = false;
    bool threadFlag = false;
    public delegate void TICK(object Sender);
    public delegate void TICKCALLBACK(object Sender);
    public delegate void FLUSH(object Sender);

    public event TICK Tick;
    public event TICKCALLBACK TickCallBack;
    public event FLUSH Flush;
    public int Interval = 0;

    public void TimmerStart(int interval)
    {
        Interval = interval;
        tick = new Thread(TimmerFlush);
        tick.IsBackground = true;
        threadFlag = true;
    }
    public void TimmerStop()
    {
        threadFlag = false;
    }
    void TimmerFlush()
    {
        while (threadFlag)
        {
            Thread.Sleep(Interval);
            flag = true;
            try
            {
                if (TickCallBack != null)
                    TickCallBack(this);
            }
            catch { }
        }
    }
    // Use this for initialization
    void Start()
    {

    }



    // Update is called once per frame
    void Update()
    {
        if (Flush != null)
            Flush(this);
        if (tick == null) return;


        if (flag)
        {
            if (Tick != null)
                Tick(this);
            flag = false;
            
        }


        if (threadFlag && !tick.IsAlive)
            tick.Start();
        if (!threadFlag && tick.IsAlive)
        {
            tick.Interrupt();
            tick = null;
        }
        

    }
    void OnApplicationQuit()
    {
        TimmerStop();
    }
}
