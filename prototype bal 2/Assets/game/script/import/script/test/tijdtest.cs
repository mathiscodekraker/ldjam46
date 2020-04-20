using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tijdtest : MonoBehaviour
{
    public float tijd;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        tijd += Time.deltaTime;
        
    }
}
