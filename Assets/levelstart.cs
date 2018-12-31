using UnityEngine.SceneManagement;
using UnityEngine;

public class levelstart : MonoBehaviour {

    public void LoadNextLeve()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
