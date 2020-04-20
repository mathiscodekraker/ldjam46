using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class valplatformcollider : MonoBehaviour
{
    public void colp()
    {
        GetComponent<BoxCollider2D>().isTrigger = true;

    }
}
