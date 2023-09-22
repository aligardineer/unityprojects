using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerThrow : MonoBehaviour
{
    public GameObject platePrefab;
    private int boundary = 10;


    // Update is called once per frame
    void Update()
    {
            if (Input.GetKeyDown(KeyCode.Space))
        {
            Vector3 offset = new Vector3(transform.position.x, transform.position.y + 4, transform.position.z);
            Instantiate(platePrefab, offset, transform.rotation);
        }
        
    }
}
