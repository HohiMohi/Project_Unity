using UnityEngine;
using UnityEngine.SceneManagement;

public class CustomSceneManager : MonoBehaviour
{
    [SerializeField] private string sceneNameToLoad;
    [SerializeField] private int spawnPointIDToUse;

    
    public void TransitionToScene()
    {
        
        PlayerPrefs.SetInt("SpawnPointID", spawnPointIDToUse);
        PlayerPrefs.Save(); // Ensure the change is saved immediately

        
        SceneManager.LoadScene(sceneNameToLoad);
    }
}