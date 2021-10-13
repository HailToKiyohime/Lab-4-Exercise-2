using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
public class Move : MonoBehaviour
{
    public static event Action CoinCollectedNotification ;

    private Rigidbody rb;
    private float movespeed;
    private float dirX, dirZ;
    float jump = 5f;

    // Start is called before the first frame update
    void Start()
    {
        movespeed = 3f;
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        dirX = Input.GetAxis("Horizontal") * movespeed;
        dirZ = Input.GetAxis("Vertical") * movespeed;



        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (rb.velocity.y < 0.05 && rb.velocity.y > -0.05)
                rb.velocity = new Vector3(rb.velocity.x, jump, rb.velocity.z);
        }

    }
    private void FixedUpdate()
    {
        rb.velocity = new Vector3(dirX, rb.velocity.y, dirZ);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Sphere"))
        {
            PersistentManagerScript.Instance.AddScore(1);
            CoinCollectedNotification?.Invoke();
        }
    }
}
