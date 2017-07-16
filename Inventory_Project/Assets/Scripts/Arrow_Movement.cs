using UnityEngine;
using System.Collections;

public class Arrow_Movement : MonoBehaviour {
    public float speed = 1;

    public float jump_height = 8;

    bool is_falling = false;

    Rigidbody this_rb;


    // Use this for initialization
    void Start () {
        this_rb = this.gameObject.GetComponent<Rigidbody>();
    }

    void Jump()
    {
		if (is_falling == false) {
			this_rb.velocity = new Vector3 (0, jump_height, 0);
			is_falling = true;
		}
    }

    void OnCollisionStay()
    {
        is_falling = false;
    }

    // Update is called once per frame
    void Update () {
		if(Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.D))
            transform.Translate(Vector3.right * 0.1f * speed);
		if (Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.A))
            transform.Translate(Vector3.left * 0.1f * speed);
		if (Input.GetKey(KeyCode.UpArrow) || Input.GetKey(KeyCode.W))
            transform.Translate(Vector3.forward * 0.1f * speed);
		if (Input.GetKey(KeyCode.DownArrow) || Input.GetKey(KeyCode.S))
            transform.Translate(Vector3.back * 0.1f * speed);

        if (Input.GetKey(KeyCode.Space))
            Jump();
    }
}
