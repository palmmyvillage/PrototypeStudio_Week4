using System;
using System.Collections;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using UnityEngine;

public class PullForce : MonoBehaviour
{
    public int player;
    public float speed;
    
    private Rigidbody2D rb;
    private SpringJoint2D spring;
    private CapsuleCollider2D col;

    private Transform self;
    private float originPosX;
    private float originPosY;
    private float newPosX;
    private float newPosY;

    public float maxX;
    public float maxY;
    
    // Start is called before the first frame update
    void Start()
    {
        self = transform;
        originPosX = self.position.x;
        originPosY = self.position.y;
        newPosX = self.position.x;
        newPosY = self.position.y;
        
        rb = GetComponent<Rigidbody2D>();
        spring = GetComponent<SpringJoint2D>();
        col = GetComponent<CapsuleCollider2D>();
    }

    // Update is called once per frame
    void Update()
    {
        chargeForce();
        
    }

    void chargeForce()
    {
        if (Input.GetAxis("Horizontal" + player) != 0 || Input.GetAxis("Vertical" + player) != 0)
        {
            col.enabled = false;
            spring.enabled = false;
            rb.velocity = new Vector2(0,0);
            
            float xSpeed;
            float ySpeed;

            xSpeed = Input.GetAxis("Horizontal" + player) * speed;
            ySpeed = Input.GetAxis("Vertical" + player) * speed;

            if (Mathf.Abs(newPosX - originPosX) < maxX)
                newPosX += xSpeed;
            else
            {
                newPosX = originPosX + (maxX * ((newPosX - originPosX) / Mathf.Abs(newPosX - originPosX)));
            }
            if (Mathf.Abs(newPosY - originPosY) < maxY)
                newPosY += ySpeed;
            else
            {
                newPosY = originPosY + (maxY * ((newPosY - originPosY) / Mathf.Abs(newPosY - originPosY)));
            }

            rb.position = new Vector3(newPosX, newPosY, 0);
        }
            
        else
        {
            col.enabled = true;
            spring.enabled = true;
            originPosX = self.position.x;
            originPosY = self.position.y;
            newPosX = self.position.x;
            newPosY = self.position.y;
        }

    }
}
