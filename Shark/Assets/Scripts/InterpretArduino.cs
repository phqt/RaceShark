using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO.Ports;

public class InterpretArduino : MonoBehaviour
{

    public SerialController serialController;

    public int xTilt;
    public int yTilt;
    public int zTilt;

    SerialPort stream = new SerialPOrt("COM3", 9600);
    void Start()
    {
        stream.Open();
    }

    void Update()
    {
        string[] newStrings = msg.Split(',');

        xTilt = int.Parse(newStrings[0]);
        yTilt = int.Parse(newStrings[1]);
        zTilt = int.Parse(newStrings[2]);
    }

//in some other script
    void OnTilt()
    {
        if(xTilt>200)
        {
            //tilt right
        }
        else if
        {
            //tilt left
        }

        if(yTilt>200)
        {
            //accel
        }
        else if (yTilt<100)
        {
            //brake
        }
    }
}




