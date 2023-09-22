using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeteorMove : MonoBehaviour
{
    private float speed = 10f;
    private int outOfBounds = -50;

    // Update is called once per frame
    void Update()
    {
        // Move the meteor towards the ship
        transform.Translate(Vector3.back * Time.deltaTime * speed);

        // Destory objects once they have flown off screen
        if (transform.position.z < outOfBounds)
        {
            Destroy(gameObject);
        }
    }
}
