using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour
{
    public float moveSpeed = 1000f;

    private Rigidbody body;

    // Start is called before the first frame update
    void Start()
    {
        body = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        float xValue = Input.GetAxis("Horizontal");
        float zValue = Input.GetAxis("Vertical");

        body.AddTorque(new Vector3(xValue, 0f, zValue) * moveSpeed * Time.deltaTime);

        if(Input.GetButtonDown("Jump"))
         {
             body.velocity = new Vector3(0f, 10f, 0f);
         }
    }

    void OnCollisionEnter(Collision collision)
    {
        collision.gameObject.CompareTag("Environment");
    }
}