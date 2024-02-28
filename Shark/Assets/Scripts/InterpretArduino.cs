using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO.Ports;

public class InterpretArduino : MonoBehaviour
{
    public string[] values;

    public float horizontalInput = 0f;
    public float verticalInput = 0f;
    public float hDiv = 0f;
    public float vDiv = 0f;

    // Invoked when a line of data is received from the serial device.
    void OnMessageArrived(string msg)
    {
        values = msg.Split(',');

        float xAxis = float.Parse(values[0]);
        float yAxis = float.Parse(values[1]);


        if (xAxis>540 || xAxis<500)
        {  
            horizontalInput = (xAxis-540)/hDiv;
        }

        if (yAxis>540 || yAxis<500)
        {   
            verticalInput = (yAxis-540)/vDiv;
        }

        Debug.Log(xAxis);
        Debug.Log(yAxis);
    }
    

    // Invoked when a connect/disconnect event occurs. The parameter 'success'
    // will be 'true' upon connection, and 'false' upon disconnection or
    // failure to connect.
    void OnConnectionEvent(bool success)
    {
        Debug.Log(success ? "Device connected" : "Device disconnected");
    }
}