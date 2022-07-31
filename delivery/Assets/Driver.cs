using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Driver : MonoBehaviour
{
    [SerializeField] float steeringSpeed = 1f;
    [SerializeField] float movingSpeed = 0.01f;
    
    void Start()
    {
        
    }

    
    void Update()
    {
        float steeringPower = Input.GetAxis("Horizontal") * steeringSpeed * Time.deltaTime;
        float movingPower = Input.GetAxis("Vertical") * movingSpeed * Time.deltaTime;
        transform.Translate(0, movingPower, 0);
        transform.Rotate(0, 0, -steeringPower);
    }
}
