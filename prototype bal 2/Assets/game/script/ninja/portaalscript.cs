using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class portaalscript : MonoBehaviour
{
    public bool aan;

    // Start is called before the first frame update
    void Start()
    {
        aan = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    public void functiep()
    {
        aan = true;
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag == "player")
        {
            if (aan)
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
            }
        }
    }
}
