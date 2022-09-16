using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Control : MonoBehaviour
{
    public float sensetivity;
    public Transform SnakeHead;

    private Vector3 _previousMousePosition;
    void Update()
    {
        if (Input.GetKey(KeyCode.D))
        {
            SnakeHead.position += SnakeHead.right * Time.deltaTime * sensetivity; 
        }
        if (Input.GetKey(KeyCode.A))
        {
            SnakeHead.position += SnakeHead.right * -1 * Time.deltaTime * sensetivity;
        }
    }
}
