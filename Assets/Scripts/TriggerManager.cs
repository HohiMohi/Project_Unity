using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneTrigger : MonoBehaviour
{
    public string sceneToLoad;
    public int triggerID;
    public int spawnID;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            PlayerPrefs.SetInt("TriggerID", triggerID);
            PlayerPrefs.SetInt("SpawnID", spawnID);
            SceneManager.LoadScene(sceneToLoad);
        }
    }
}