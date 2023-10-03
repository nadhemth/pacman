using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ghost : MonoBehaviour
{
    public Transform target; // The target to follow (Pac-Man).
    public float speed = 3.0f; // Adjust the speed as needed.
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (target != null)
        {
            // Calculate the direction towards the target.
            Vector3 direction = (target.position - transform.position).normalized;

            // Move the ghost towards the target.
            transform.Translate(direction * speed * Time.deltaTime);
        }
    }
    //detect when the ghost gets the player
    public void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
            SceneManager.LoadScene("menu");
        
    }

}
