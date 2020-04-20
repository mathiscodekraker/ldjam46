using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class valplatform : MonoBehaviour
{
    // Reference to Sprite Renderer component
    private Renderer rend;
    private Renderer rend2;

    public float gamespeed;
    

    public float tijd;

    public bool tijdb;
    
    // Color value that we can set in Inspector
    // It's White by default
    [SerializeField]
    private Color colorToTurnTo = Color.white;
    public Color colorToTurnTo2 = Color.white;

    // Use this for initialization
    void Start () {
        // Assign Renderer component to rend variable
        rend = GetComponent<Renderer>();
        rend2 = GetComponent<Renderer>();

        // Change sprite color to selected color
        rend.material.color = colorToTurnTo;
        tijdb = false;
    }

    void Update()
    {
        if(tijd >= 1)
        {
            
            rend2.material.color = colorToTurnTo;
            tijd = 0;
        }
        if (tijdb)
        {
            tijd += Time.deltaTime;
            transform.Translate(Vector2.up * gamespeed * Time.deltaTime);
        }
        
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag == "player")
        {
            
            rend2.material.color = colorToTurnTo2;
            
            tijdb = true;
        }
    }
}
