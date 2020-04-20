using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class balmove : MonoBehaviour
{
    public float gamespeed;

    public bool hitplayer;
    public bool htp;
    public float draai;

    void Start()
    {
        
        gamespeed = 100;
        draai = -1000;
        hitplayer = false;
        htp = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.D) && hitplayer)
        {

            transform.Translate(Vector2.right * gamespeed * Time.deltaTime);
            hitplayer = false;

        }
        else if (Input.GetKey(KeyCode.A) && hitplayer)
        {
            transform.Translate(Vector2.left * gamespeed * Time.deltaTime);
            hitplayer = false;

        }
        if (Input.GetKey(KeyCode.E) && htp)
        {
            transform.Rotate(0, 0, Time.deltaTime * draai, Space.Self);
            transform.Translate(Vector2.up * gamespeed * Time.deltaTime);
            htp = false;
        }

    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag == "player")
        {
            
            hitplayer = true;
        }
        if(other.tag == "triggerplayer")
        {
            htp = true;
        }
    }

}

