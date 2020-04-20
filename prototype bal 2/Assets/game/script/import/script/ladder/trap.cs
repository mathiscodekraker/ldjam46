using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class trap : MonoBehaviour
{
    public bool aan;
    public move m;
    public trap2 t2;

    // Start is called before the first frame update
    void Start()
    {
        aan = false;

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag == "player")
        {
            aan = true;

        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        aan = false;

    }
    public void trapf()
    {
        if (aan)
        {
            t2.luf();
            m.ladderup();
        }
    }

    public void trapfdown()
    {
        if (aan)
        {
            t2.ldf();
            m.ladderdown();
        }
    }
}
