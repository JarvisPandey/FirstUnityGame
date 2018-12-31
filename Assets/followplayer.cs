
using UnityEngine;

public class followplayer : MonoBehaviour {

    public Transform player1;
    public Vector3 offset;
	
	// Update is called once per frame
	void Update () {
        transform.position = player1.position + offset;
	}
}
