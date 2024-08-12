using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundTile2 : MonoBehaviour
{
    GroundSpawner groundSpawner;
    public GameObject obstaclePrefab;

    // Start is called before the first frame update
    private void Start()
    {
        groundSpawner = GameObject.FindObjectOfType<GroundSpawner>();

        SpawnObstacle();
    }

    private void OnTriggerExit(Collider other)
    {
        groundSpawner.SpawnTile();      
        Destroy(gameObject, 2);

        
    }

    void SpawnObstacle()
    {
        //random
        int obstacleSpawnIndex = Random.Range(2, 4);
        Transform spawnPoint = transform.GetChild(obstacleSpawnIndex).transform;


        //position
        GameObject spawned = Instantiate(obstaclePrefab, spawnPoint.position, Quaternion.Euler(0, 90, 0), transform);
        //spawned.transform.Rotate(0, 270, 0);


    }
}
