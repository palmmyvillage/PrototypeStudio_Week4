using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClapSound : MonoBehaviour
{

    private AudioSource self;
    
    // Start is called before the first frame update
    void Start()
    {
        self = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (self.isPlaying == false)
            Destroy(gameObject);
    }
}
