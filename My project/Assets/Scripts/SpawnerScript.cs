using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerScript : MonoBehaviour
{
    public GameObject[] objectPrefabs;
    private float spawnDelay = 2;
    private float spawnInterval = 1.5f;

    private FPSController FPSController;
    public bool gameOver;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("enemy", spawnDelay, spawnInterval);
        FPSController = GameObject.Find("Player").GetComponent<FPSController>();
    }

    // Spawn obstacles
    void SpawnObjects ()
    {
        // Set random spawn location and random object index
        Vector3 spawnLocation = new Vector3(30, Random.Range(5, 15), 0);
        int index = Random.Range(0, objectPrefabs.Length);

        // If game is still active, spawn new object
        if (!FPSController.gameOver)
        {
            Instantiate(objectPrefabs[index], spawnLocation, objectPrefabs[index].transform.rotation);
        }

            /*  void OnCollisionEnter(Collision other)
                {
                    // if player collides with enemy, set gameOver to true
                    if (other.gameObject.CompareTag("enemy"))
                    {
                        
                        gameOver = true;
                        Debug.Log("Game Over!");
                        Destroy(other.gameObject);
                    } 
                }
        */

    }
}

