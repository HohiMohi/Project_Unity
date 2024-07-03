using UnityEngine;
using UnityEngine.SceneManagement;

public class CustomSceneManager : MonoBehaviour
{
    [SerializeField] private string sceneNameToLoad;
    [SerializeField] private int spawnPointIDToUse;

    // This method can now be called by a UI button or other event triggers in the scene
    public void TransitionToScene()
    {
        // Set the SpawnPointID in PlayerPrefs
        PlayerPrefs.SetInt("SpawnPointID", spawnPointIDToUse);
        PlayerPrefs.Save(); // Ensure the change is saved immediately

        // Load the new scene
        SceneManager.LoadScene(sceneNameToLoad);
    }
}