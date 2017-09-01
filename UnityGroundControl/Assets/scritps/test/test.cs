using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Reflection;
//using SpeechLib;
using System.Threading;

public class test
{
   
    public test()
    {
        t = new Thread(tt);
        t.Start();
        
    }
    void Start()
    { }
    Thread t;
    void tt()
    {
      
    }
   
}
