using UnityEngine;

[System.Serializable] // Make SpawnPoint visible in the inspector
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
        int spawnPointID = PlayerPrefs.GetInt("SpawnPointID", 0); // Default to 0 if not set
        SpawnPlayer(spawnPointID);
    }

    void SpawnPlayer(int spawnPointID)
    {
        foreach (var spawnPoint in spawnPoints)
        {
            if (spawnPoint.ID == spawnPointID)
            {
                Instantiate(playerPrefab, spawnPoint.location.position, Quaternion.identity);
                break; // Exit the loop once the correct spawn point is found
            }
        }
    }
}