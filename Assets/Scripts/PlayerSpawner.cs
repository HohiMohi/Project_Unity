using UnityEngine;

[System.Serializable] 
public class SpawnPoint
{
    public int ID;
    public Transform location;
}

public class PlayerSpawner : MonoBehaviour
{
    public GameObject playerPrefab;
    public SpawnPoint[] spawnPoints;

    void Start()
    {
        int spawnPointID = PlayerPrefs.GetInt("SpawnPointID", 0); 
        SpawnPlayer(spawnPointID);
    }

    void SpawnPlayer(int spawnPointID)
    {
        foreach (var spawnPoint in spawnPoints)
        {
            if (spawnPoint.ID == spawnPointID)
            {
                Instantiate(playerPrefab, spawnPoint.location.position, Quaternion.identity);
                break; 
            }
        }
    }
}