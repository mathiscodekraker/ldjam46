using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class raakladder : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    public void rld()
    {
        GetComponent<BoxCollider2D>().isTrigger = true;
    }

    public void rlu()
    {
        GetComponent<BoxCollider2D>().isTrigger = false;
    }
}
