using UnityEngine;

public class PlayerSpawner : MonoBehaviour
{
    public int spawnID;
    public GameObject playerPrefab;

    // Start is called before the first frame update
    void Start()
    {
        int savedSpawnID = PlayerPrefs.GetInt("SpawnID", -1);
        if (savedSpawnID == spawnID)
        {
            Instantiate(playerPrefab, transform.position, Quaternion.identity);
        }
    }
}