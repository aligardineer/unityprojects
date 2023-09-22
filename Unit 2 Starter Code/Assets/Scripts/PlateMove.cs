using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlateMove : MonoBehaviour
{
    private float speed = 10f;
    public GameObject platePrefab;
    private int boundary = 22;

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward * Time.deltaTime * speed);


        if (transform.position.x < -boundary)
        {
            Destroy(gameObject);
        }

    }

    private void OnTriggerEnter(Collider other)
    {
        Destroy(gameObject);
        Destroy(other.gameObject);

        //Helps keep track of the score
        Debug.Log("You earned a point!");
    }
}
