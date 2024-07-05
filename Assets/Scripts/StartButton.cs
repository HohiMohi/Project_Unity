using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuButton : MonoBehaviour
{
    public void OnClick()
    {
        SceneManager.LoadScene("Scene");
    }
}
