using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoodSpawnManager : MonoBehaviour
{

    public GameObject[] foodPrefab;

    // Start is called before the first frame update
    void Start()
    {
        // Call the SpawnMeteors function every so often
        InvokeRepeating("SpawnFood", 0.5f, 1.5f);
    }

    // Update is called once per frame
    private void SpawnFood()
    {
        // Gemerate a random value from -22 to 22
        float randomX = Random.Range(-22f, 13f);

        //Generate a random food
        GameObject food = foodPrefab[Random.Range(0, foodPrefab.Length)];

        //Spawn a food at a specific position
        Instantiate(food, new Vector3(randomX, 4f, -10.5f), food.transform.rotation);

    }
}
