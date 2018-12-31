using UnityEngine.UI;
using UnityEngine;

public class score : MonoBehaviour {

    public Transform player1;
    public Text scoretext;
    public Vector3 a;
	
	// Update is called once per frame
	void Update () {

        scoretext.text = (player1.position.z + a.z).ToString("0");
	}
}
