using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dead : MonoBehaviour
{

    public tijdover to;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "punt")
        {
            to.doodf();
        }
    }

}
