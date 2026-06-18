using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move_Sample : MonoBehaviour
{
    public float ySpeed;
    public float xSpeed;

    void Start()
    {
        
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            transform.position = transform.position + Vector3.up * ySpeed;
        }

        if (Input.GetKey(KeyCode.S))
        {
            transform.position = transform.position + Vector3.down * ySpeed;
        }

        if (Input.GetKey(KeyCode.D))
        {
            transform.position = transform.position + Vector3.right * xSpeed;
        }

        if (Input.GetKey(KeyCode.A))
        {
            transform.position = transform.position + Vector3.left * xSpeed;
        }
    }
}
