using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gyroscope : MonoBehaviour
{
    
    void Start()
    {
        SuportGyroscope();
    }

    private void SuportGyroscope()
    {
       
        if (SystemInfo.supportsGyroscope)
        {
            Input.gyro.enabled = true;
        }
    }

    void Update()
    {
        if(StatesGame.GetIsGyroscope())
        RotationWithGyroscope();
    }

    private void RotationWithGyroscope()
    {
        transform.rotation = Input.gyro.attitude;
    }

    private Quaternion GyroControll(Quaternion quaternion)
    {
        return new Quaternion(quaternion.x, quaternion.y, -quaternion.z, -quaternion.w);
    }
}
