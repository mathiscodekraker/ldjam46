using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class jumptrigger : MonoBehaviour
{
    public move m;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "grond")
        {
            m.triggerfunctie();
        }
    }
}
