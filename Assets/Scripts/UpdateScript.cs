using UnityEngine;
using System.Collections;

public class UpdateScript : MonoBehaviour {

    public Camera camera;
    public GameObject[] block;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void FixedUpdate () {
	    if (camera.transform.position.y > camera.velocity.y)
        {
            Instantiate(block[Random.Range(0, block.Length)],
            new Vector3(Random.Range(2, 8),
                this.transform.position.y+20),
                Quaternion.identity
                );
            Debug.Log("LEL");
        }
	}
}
