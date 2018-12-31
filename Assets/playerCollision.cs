
using UnityEngine;

public class playerCollision : MonoBehaviour {

    public player1 movement;

    public void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag == "object")
        {
            movement.enabled = false;
            FindObjectOfType<gamemanager>().Endgame();
               }   
    }

    // Update is called once per frame
    void Update () {
		
	}
}
