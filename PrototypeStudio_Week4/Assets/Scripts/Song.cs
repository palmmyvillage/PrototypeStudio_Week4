using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Song : MonoBehaviour
{
    public static Song instance;
    private AudioSource audio;
    
    //set this as Singleton
    void Awake()
    {
        if (instance == null)
        {
            DontDestroyOnLoad(this);
            instance = this;
        }
        else if (instance != this)
            Destroy(gameObject);
    }

    
    // Start is called before the first frame update
    void Start()
    {
        audio = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (SceneManager.GetActiveScene().buildIndex == 0)
            audio.volume = 0.2f;
        
        if (SceneManager.GetActiveScene().buildIndex == 1)
            audio.volume = 0.03f;
    }
}
