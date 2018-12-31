
using UnityEngine;

public class player1 : MonoBehaviour {

    public Rigidbody rb;
    public Transform plane;
    // Use this for initializatio

    public float forwardforce = 2000f;
	// Update is called once per frame
	void FixedUpdate () {
        rb.AddForce(0, 0, forwardforce*Time.deltaTime);

        if (Input.GetKey("d"))
        {
            rb.AddForce(100* Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        if (Input.GetKey("a"))
        {
            rb.AddForce(-100* Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        if(rb.position.x >=11 ||rb.position.x<=-95)
        {
            FindObjectOfType<gamemanager>().Endgame();
        }
	}
}
