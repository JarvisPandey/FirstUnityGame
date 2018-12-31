using UnityEngine.SceneManagement;
using UnityEngine;

public class gamemanager : MonoBehaviour {


    bool gamehasended = false;

    public GameObject completelevelUI;

    public void Endgame()
    {
        if(gamehasended==false)
        {
            gamehasended = true;
            Invoke("restart", 1f);
        }
    }

    void restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void completelevel()
    {
        completelevelUI.SetActive(true);
    }
	
}
