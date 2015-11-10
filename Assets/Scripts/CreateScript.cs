using UnityEngine;
using System.Collections;

public class CreateScript : MonoBehaviour {

    //public GameObject block;
    float x, pos, y = 0f , z = 0f;
    public GameObject prefab;
	// Use this for initialization
    void Start()
    {
        for (int i = 0; i < 100; i++)
        {
            Vector3 position = new Vector3(Random.Range(2, 7),
                Random.Range(10, 150),
                0f);
            Instantiate(prefab, position, Quaternion.identity);
        }
    }
	
	// Update is called once per frame
	void Update () {
	
	}
}
