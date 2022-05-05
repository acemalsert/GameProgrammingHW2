using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameObjectMovement : MonoBehaviour
{

    public float speed = 5f;
    public float rotaionTreshold = 100f;
    private float x_axis;
    private float y_axis;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        fixedSpeedMove();
        horizontalRotataion();
        verticalRotation();
    }

    void fixedSpeedMove()
    {
        transform.Translate(0, 0, speed * Time.deltaTime);
    }

     void horizontalRotataion()
    {
        x_axis = Input.GetAxis("Horizontal");
        if (!(x_axis == 0))
        {
            transform.Rotate(0f, 0f, x_axis * rotaionTreshold * Time.deltaTime);
        }
    }
    void verticalRotation()
    {
        y_axis = Input.GetAxis("Vertical");
        if(!(y_axis == 0))
        {
            transform.Rotate(y_axis * rotaionTreshold * Time.deltaTime,0f,0f);
        }
    }
}
