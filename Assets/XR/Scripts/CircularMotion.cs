using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CircularMotion : MonoBehaviour
{
    //float timeCounter = 0;
    //float speed;
    //float width;
    //float hight;


    //void Start()
    //{
    //    speed = 1;
    //    width = 1;
    //    hight = 1;
    //}


    //void Update()
    //{
    //    timeCounter = + Time.deltaTime * speed;

    //    float x = Mathf.Cos(timeCounter) * width;
    //    float y = Mathf.Sin(timeCounter) * hight;
    //    float z = 0;
    //    transform.position = new Vector3(x, y, z);
    //}

    public float angularSpeed = 1f;
    public float circleRad = 1f;

    private Vector3 fixedPoint;
    private float currentAngle;

    void Start()
    {
        fixedPoint = transform.position;
    }

    void Update()
    {
        currentAngle += angularSpeed * Time.deltaTime;
        Vector3 offset = new Vector3(Mathf.Sin(currentAngle), 0, Mathf.Cos(currentAngle)) * circleRad;
        transform.position = fixedPoint + offset;
    }
}
