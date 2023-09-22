using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoodMove : MonoBehaviour
{

    private float speed = 10f;
    private int outOfBounds = -10;

    // Update is called once per frame
    void Update()
    {
        // Move the meteor towards the ship
        transform.Translate(Vector3.down * Time.deltaTime * speed);

        // Destory objects once they have flown off screen
        if (transform.position.y < outOfBounds)
        {
            Destroy(gameObject);
            Debug.Log("Game Over!");
        }
    }
}
