using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarController : MonoBehaviour
{
   
    public float rotationSpeed, moveSpeed, boostMultiplier;
    public Transform cartransform;


    void Update()
    {
        float horizontalMovement = Input.GetAxis("Horizontal");
        float verticalMovement = Input.GetAxis("Vertical");

        if (Math.Abs(horizontalMovement) > 0.01f)
        {
            cartransform.Rotate(0f, 0f, -1 * rotationSpeed * horizontalMovement * Time.deltaTime);
        }
        if (Math.Abs(verticalMovement) > 0.01f)
        {
            cartransform.Translate(0f, moveSpeed * verticalMovement * Time.deltaTime, 0f);
        }
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "RedHouse")
        {
            Debug.Log("I've hit a Red House");
        }
        if (collision.gameObject.tag == "BlueHouse")
        {
            Debug.Log("I've hit a Blue House");
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "boost")
        {
            moveSpeed = moveSpeed * boostMultiplier;
            Destroy(other.gameObject);
        }
    }
}