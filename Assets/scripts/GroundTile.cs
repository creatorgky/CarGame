using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundTile : MonoBehaviour
{
    GroundSpawner groundSpawner;
    public GameObject obstaclePrefab;
    public GameObject coinPrefab;
    

    // Start is called before the first frame update
    private void Start()
    {
        groundSpawner = GameObject.FindObjectOfType<GroundSpawner>();

        SpawnObstacle();
        SpawnCoins();
    }

    private void OnTriggerExit(Collider other)
    {
        groundSpawner.SpawnTile();
        Destroy(gameObject, 2);
        
    }
   
    void SpawnObstacle ()
    {
        //random
        int obstacleSpawnIndex = Random.Range(2, 4);
        Transform spawnPoint = transform.GetChild(obstacleSpawnIndex).transform;


        //position
         GameObject spawned = Instantiate(obstaclePrefab, spawnPoint.position, Quaternion.Euler(0, 270, 0), transform);
        //spawned.transform.Rotate(0, 270, 0);

    }

    void SpawnCoins()
    {
        int coinsToSpawn = 2;
        for (int i = 0; i < coinsToSpawn; i++)
        {
            GameObject temp = Instantiate(coinPrefab, transform);
            temp.transform.position = GetRandomPointInCollider(GetComponent<Collider>());   
        }
    }

    Vector3 GetRandomPointInCollider (Collider Collider)
    {
        Vector3 point = new Vector3(
            Random.Range(Collider.bounds.min.x, Collider.bounds.max.x),
            Random.Range(Collider.bounds.min.y, Collider.bounds.max.y),
            Random.Range(Collider.bounds.min.z, Collider.bounds.max.z)
            );
        if ( point != Collider.ClosestPoint(point) )
        {
            point = GetRandomPointInCollider(Collider);
        }

        point.y = 1;
        return point;
    }
}
