using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class TestVelo : MonoBehaviour
{
    private Rigidbody2D rb;

    public float speed;
    
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        float xSpeed = 0;
        float ySpeed = 0;

        xSpeed = Input.GetAxis("Horizontal") * speed;
        ySpeed = Input.GetAxis("Vertical") * speed;
        
        rb.AddForce(new Vector2(xSpeed,ySpeed));
    }
}
