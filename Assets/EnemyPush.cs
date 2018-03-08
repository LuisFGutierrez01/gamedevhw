using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyPush : MonoBehaviour {

    public GameObject EnemyObject;
    public Rigidbody Enemy;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        Enemy.AddForce(0, 0, -50 * Time.deltaTime, ForceMode.VelocityChange);

	}


    void OnBecameInvisible()
    {
        Destroy(EnemyObject);
    }

}
