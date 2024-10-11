using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class turn : MonoBehaviour
{

    public Transform SecondHand;//��
    public Transform HourHand;//ʱ
    public Transform MinHand;//��

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

        //������ת�Ƕ�
        float secondAngle = -360 * (second/60);
        float minAngle = -360 * (minute/60);
        float hourAngle = -360 * (hour/12);

        SecondHand.localRotation= Quaternion.Euler(0,secondAngle,0);
        MinHand.localRotation = Quaternion.Euler(0,minAngle,0);
        HourHand.localRotation=Quaternion.Euler(0,hourAngle,0);
    }
}
