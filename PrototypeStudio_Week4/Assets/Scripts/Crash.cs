using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Crash : MonoBehaviour
{
    public GameObject canvas;
    private int level = 0;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Ass"))
        {
            if (level <= 4)
            {
                Instantiate(Resources.Load("Prefabs/BubblesTexts1"), canvas.transform);
                level++;
            }
            else
            {
                Instantiate(Resources.Load("Prefabs/BubblesTexts2"), canvas.transform);
            }
            
            Instantiate(Resources.Load("Prefabs/ClapSound"), transform);
        }
    }
}
