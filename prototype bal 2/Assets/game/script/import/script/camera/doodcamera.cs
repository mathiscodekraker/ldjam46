using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class doodcamera : MonoBehaviour
{
    public Transform camv;
    public float power = 3.7f;
    public float duurt = 1.0f;
    public float wacht = 1.0f;
    Vector3 start;
    float eerstelengte;
    public bool check = false;

    // Start is called before the first frame update
    void Start()
    {
        camv = Camera.main.transform;
        start = camv.localPosition;
        eerstelengte = duurt;

    }

    void Update()
    {
        if (check)
        {
            if (duurt > 0)
            {
                camv.localPosition = start + Random.insideUnitSphere * power;
                duurt -= Time.deltaTime * wacht;
                check = false;
            }
        }
    }

    public void shakecamera()
    {
        check = true;
    }
}