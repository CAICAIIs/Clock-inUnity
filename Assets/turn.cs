using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class turn : MonoBehaviour
{

    public Transform SecondHand;//秒
    public Transform HourHand;//时
    public Transform MinHand;//分

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        DateTime currentTime = DateTime.Now;
        float second = (float)currentTime.Second;
        float hour= (float)currentTime.Hour;
        float minute = (float)currentTime.Minute % 12;

        //计算旋转角度
        float secondAngle = -360 * (second/60);
        float minAngle = -360 * (minute/60);
        float hourAngle = -360 * (hour/12);

        SecondHand.localRotation= Quaternion.Euler(0,secondAngle,0);
        MinHand.localRotation = Quaternion.Euler(0,minAngle,0);
        HourHand.localRotation=Quaternion.Euler(0,hourAngle,0);
    }
}
