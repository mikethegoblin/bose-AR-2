using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveObject : MonoBehaviour
{

	public float speed;
	//private Rigidbody box;

    // Start is called before the first frame update
    void Start()
    {
        //box = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {

        transform.Translate(0, 0, -speed * Time.deltaTime);

        //box.velocity = new Vector3 (speed, 0, 0);
        //float moveHorizontal = Input.GetAxis("Horizontal");

        //Vector3 movement = new Vector3 (0.0f, 0.0f, moveHorizontal);
        //box.AddForce (movement * speed);
    }
}
