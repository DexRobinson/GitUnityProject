using UnityEngine;
using System.Collections;

public class Player : Character 
{
    public float RechargeRate;

    private Rigidbody myRigidbody;
    void Start()
    {
        myRigidbody = rigidbody;
    }

    void Update()
    {
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");
    }

    private void Move(float h, float v)
    {
        if (h != 0f || v != 0f)
        {
        }
    }
}
