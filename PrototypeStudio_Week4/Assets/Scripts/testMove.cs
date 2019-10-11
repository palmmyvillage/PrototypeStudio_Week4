using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class testMove : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.W))
        {
            transform.position += gameObject.transform.up;
        }

        if (Input.GetKeyDown(KeyCode.E))
        {
            transform.eulerAngles += new Vector3(0,0,90);
        }

        Vector2 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);

        Vector2 diff = (mousePos - new Vector2(transform.position.x, transform.position.y)).normalized;
        transform.position += new Vector3(diff.x, diff.y, 0) * 5 * Time.deltaTime;
    }
}
