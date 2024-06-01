using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletScript : MonoBehaviour
{
    public Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        Destroy(gameObject, 3);
        float moveSpeed = 5;
        rb.velocity = new Vector3(0, 0, moveSpeed);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "Enemy")
        {
            Destroy(this.gameObject);
            Destroy(other.gameObject);
        }
    }

}
