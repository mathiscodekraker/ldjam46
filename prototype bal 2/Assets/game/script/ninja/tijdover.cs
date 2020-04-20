using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class tijdover : MonoBehaviour
{
    public float tijd;
    
    public float tijdminlijn;
    public float tijdbeginlijn = 60;
    public float tijdminlijnschaal;

    Vector3 lijn;

    public Text go;

    // Start is called before the first frame update
    void Start()
    {
        lijn = transform.localScale;
    }

    // Update is called once per frame
    void Update()
    {
        tijd += Time.deltaTime;
        tijdminlijn = tijdbeginlijn - tijd;
        tijdminlijnschaal = tijdminlijn / 5;
        if (tijd <= 60)
        {
            
            lijn.x = tijdminlijnschaal;
            transform.localScale = lijn;
        }
        else if (tijd >= 60)
        {
            doodf();
        }
    }

    public void doodf()
    {
        go.text = "game over";
        Time.timeScale = 0f;
    }
}
