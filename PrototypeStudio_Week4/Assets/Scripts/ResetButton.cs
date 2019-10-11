using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ResetButton : MonoBehaviour
{
    public KeyCode resetGameButton;
    public KeyCode resetSceneButton;
    public KeyCode quitGameButton;

    public static ResetButton instance;

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
        
    }

    // Update is called once per frame
    void Update()
    {
        ResetGame();
        ResetScene();
        QuitGame();
        
        //if (Input.GetKey(KeyCode.K))
        //    ToNextScene();
    }

    void ResetGame()
    {
        if (Input.GetKeyDown(resetGameButton))
            SceneManager.LoadScene(0);
    }

    void ResetScene()
    {
        if (Input.GetKeyDown(resetSceneButton))
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    void QuitGame()
    {
        if (Input.GetKeyDown(quitGameButton))
            Application.Quit();
    }

    public void ToNextScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex+1);
    }
}
