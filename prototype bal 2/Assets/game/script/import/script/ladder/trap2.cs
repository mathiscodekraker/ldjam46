using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class trap2 : MonoBehaviour
{
    public bool aan;
    public bool lu;
    public bool ld;

    public move m;

    // Start is called before the first frame update
    void Start()
    {
        aan = false;
        lu = false;
        ld = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (aan && lu)
        {
            
            m.ladderup();
            aan = false;
            lu = false;
        }
        if(aan && ld)
        {
            m.ladderdown();
            aan = false;
            ld = false;
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "player")
        {
            aan = true;

        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        aan = false;

    }

    public void luf()
    {
        lu = true;
    }

    public void ldf()
    {
        ld = true;
    }
}
