using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {

    public Rigidbody Player;
    
    // Use this for initialization
    void Start () {
        

    }
	
	// Update is called once per frame
	void FixedUpdate () {

        if (Player.transform.position.y < 10 && Player.transform.position.z < 15)
        {
            if (Input.GetKey(KeyCode.W))
            {
                Player.AddForce(0, 0, 50 * Time.deltaTime, ForceMode.VelocityChange);
            }

            if (Input.GetKey(KeyCode.S))
            {
                Player.AddForce(0, 0, -50 * Time.deltaTime, ForceMode.VelocityChange);
            }

            if (Input.GetKey(KeyCode.A))
            {
                Player.AddForce(-50 * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
            }

            if (Input.GetKey(KeyCode.D))
            {
                Player.AddForce(50 * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
            }

            if (Input.GetKeyDown(KeyCode.Space))
            {
                Player.AddForce(0, 20, 0, ForceMode.VelocityChange);
            }
        }
    }
}
