using UnityEngine;
using UnityEngine.SceneManagement;

public class Losing : MonoBehaviour
{
    public string sceneToLoad = "Won"; // name of the scene to load

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            SceneManager.LoadScene(sceneToLoad);
        }
    }
}