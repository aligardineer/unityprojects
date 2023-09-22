using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileMove : MonoBehaviour
{
    private float speed = 30f;
    private int outOfBounds = 50;

    // Update is called once per frame
    void Update()
    {
        // This moved my projectile foward
        transform.Translate(Vector3.forward * Time.deltaTime * speed);

        // Destory objects once they have flown off screen
        if (transform.position.z > outOfBounds)
        {
            Destroy(gameObject);
        }
    }

    // This function will destory the meteor and projectile when they hit
    private void OnTriggerEnter(Collider other)
    {
        Destroy(gameObject);
        Destroy(other.gameObject);

        //Helps keep track of the score
        Debug.Log("You earned a point.");
    }
}
