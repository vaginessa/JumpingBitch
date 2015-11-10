using UnityEngine;
using System.Collections;

public class WallScript : MonoBehaviour {

    public GameObject player;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Wall"))
        {
            //player.transform.position.x = GetComponent<Rigidbody2D>().velocity.x;
        }
    }
}
