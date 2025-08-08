using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boost : MonoBehaviour
{
    public float boostMultiplier = 2f;
    public float boostDuration = 5f;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("boost")) // Make sure your car has this tag
        {
            StartCoroutine(ApplyBoost(other));
            Destroy(gameObject); // Destroy the boost box
        }
    }

    private IEnumerator ApplyBoost(Collider2D car)
    {
        Rigidbody2D rb = car.GetComponent<Rigidbody2D>();
        if (rb != null)
        {
            float originalSpeed = rb.velocity.magnitude;
            Vector2 boostDirection = rb.velocity.normalized;

            // Apply boost
            rb.velocity = boostDirection * originalSpeed * boostMultiplier;

            yield return new WaitForSeconds(boostDuration);

            // Revert speed to original (or lower it safely)
            rb.velocity = boostDirection * originalSpeed;
        }
    }
}
