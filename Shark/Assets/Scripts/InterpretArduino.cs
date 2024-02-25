using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO.Ports;

public class InterpretArduino : MonoBehaviour
{
    public string[] values;

    float horizontalInput = 0f;
    float verticalInput = 0f;


    // Invoked when a line of data is received from the serial device.
    void OnMessageArrived(string msg)
    {
        values = msg.Split(',');

        float xAxis = float.Parse(values[0]);
        float yAxis = float.Parse(values[1]);

        // Map accelerometer data to Unity input axes
        horizontalInput = xAxis; // Map to left/right steering
        verticalInput = yAxis;   // Map to acceleration/braking

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