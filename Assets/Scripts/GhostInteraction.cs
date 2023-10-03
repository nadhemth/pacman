using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GhostInteraction : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        { RespawnPacMan(); }


    }

    private void RespawnPacMan()
    {
        
    }
}
