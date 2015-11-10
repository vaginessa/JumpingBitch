using UnityEngine;
using System.Collections;

public class DestroyScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

	}
    
    void OnTriggerEnter2D()
    {
        if (this.CompareTag("Player"))
        {
            Destroy(this.gameObject);
        }
    }
}
