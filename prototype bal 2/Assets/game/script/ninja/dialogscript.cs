using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class dialogscript : MonoBehaviour
{
    public Text dialogtext;

    public float pagina;

    // Start is called before the first frame update
    void Start()
    {
        pagina = 0;
        dialogtext.text = "feed the baby before it dies";
    }

    // Update is called once per frame
    void Update()
    {
        if(pagina >= 1 && pagina <= 1)
        {
            dialogtext.text = "with the food under the red arrow";
        }
        else if (pagina >= 2 && pagina <= 2)
        {
            dialogtext.text = "go to the baby";
        }
    }

    public void gadoor()
    {
        pagina++;
    }
}
