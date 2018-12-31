
using UnityEngine;

public class endtrigger : MonoBehaviour {

    // Use this for initialization

    public gamemanager Gamemanager;

    public void OnTriggerEnter(Collider other)
    {
        FindObjectOfType<gamemanager>().completelevel();
    }
}
