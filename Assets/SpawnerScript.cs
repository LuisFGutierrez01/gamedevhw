using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerScript : MonoBehaviour {

    //public GameObject spawner;
    public GameObject badCube;
    public bool onoff = true;
    public float spawnrate;
    public float spawnrateLower;
    public float spawnrateUpper;
    public Vector3 addRandom;
    public int wait;

	// Use this for initialization
	void Start () {
        
        StartCoroutine(waitSpawner());
        
	}
	
	// Update is called once per frame
	void Update () {

        spawnrate = Random.Range(spawnrateLower, spawnrateUpper);


	}

    IEnumerator waitSpawner()
    {
        yield return new WaitForSeconds(wait);

        while(onoff)
        {

            Vector3 spawnPosition = new Vector3(Random.Range(-addRandom.x, addRandom.x), Random.Range(0,addRandom.y), Random.Range(- addRandom.z, addRandom.z));
            Instantiate(badCube, spawnPosition + transform.position, Random.rotation);
            yield return new WaitForSeconds(spawnrate);
        }

    }

}
