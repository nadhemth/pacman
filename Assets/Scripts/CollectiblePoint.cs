using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectiblePoint : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player")) // Assuming "Player" is the tag for Pac-Man.
        {
            // Add your logic here for what happens when Pac-Man collects the point.
            // For example, you can play a sound, increase the score, and destroy the point GameObject.
            // You can also implement additional effects or power-ups.
            Destroy(gameObject); // Remove the collectible point.
        }
    }
}
