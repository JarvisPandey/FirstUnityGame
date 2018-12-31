using UnityEngine.SceneManagement;
using UnityEngine;

public class start : MonoBehaviour {

    public void startgame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

}
