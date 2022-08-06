using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Driver : MonoBehaviour
{
    [SerializeField] float steeringSpeed = 1f;
    [SerializeField] float movingSpeed = 0.01f;
    [SerializeField] float boostSpeed = 25f;
    [SerializeField] float slowSpeed = 10f;
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

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Circle")
        {
            movingSpeed = boostSpeed;
        }

        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        movingSpeed = slowSpeed;
    }
}
