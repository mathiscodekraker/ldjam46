using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class puntenp : MonoBehaviour
{
    public static float healthAmount;
    public bool nietvol;
    public portaalscript ps;
    public float getal = 1;

    // Start is called before the first frame update
    void Start()
    {
        nietvol = true;
        healthAmount = getal;
        
    }

    // Update is called once per frame
    void Update()
    {
        if (healthAmount >= 11)
        {
            nietvol = false;
            ps.functiep();
        }
                
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        
        if(other.tag == "vlok")
        {
            
            if (nietvol)
            {
                healthAmount = healthAmount + 2f;
                
                
            }
        }
    }
    
}
