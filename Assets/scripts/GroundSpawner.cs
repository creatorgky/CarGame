
using UnityEngine;

public class GroundSpawner : MonoBehaviour
{

    public GameObject groundTile;
    public GameObject groundTile2;
    Vector3 nextSpawnPoint;

    public void SpawnTile()
    {
        GameObject temp = Instantiate(groundTile, nextSpawnPoint, Quaternion.identity);
        GameObject Query = Instantiate(groundTile2, nextSpawnPoint, Quaternion.identity);
        nextSpawnPoint = temp.transform.GetChild(1).transform.position;
    }

    private void Start()
    {
        for (int i = 0; i < 3; i++) 
        { 
            SpawnTile();
        }
    }
}
