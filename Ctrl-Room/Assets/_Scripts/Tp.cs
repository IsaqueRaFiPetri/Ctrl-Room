using UnityEngine;
using UnityEngine.SceneManagement;

public class Tp : MonoBehaviour
{
    public void Teleport(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }
}
