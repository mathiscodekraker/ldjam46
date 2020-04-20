using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move : MonoBehaviour
{
    public float gamespeed;
    public float gamespeedtrap;
    public float gameSpeedjump;

    bool doubleJumpAllowed = false;
    bool onTheGround = false;

    void Start()
    {
        gamespeedtrap = 500;
        gamespeed = 10;
        gameSpeedjump = 8;

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(Vector2.right * gamespeed * Time.deltaTime);

        }
        else if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(Vector2.left * gamespeed * Time.deltaTime);

        }

        //_________________________________________________________________________________
        //jump
        if (onTheGround)
        {
            doubleJumpAllowed = true;
        }


        if (Input.GetKey(KeyCode.W) && onTheGround)
        {
            jump();
        }
        else if (doubleJumpAllowed && Input.GetKey(KeyCode.W))
        {
            jump();
            doubleJumpAllowed = false;
        }
    }

    public void jump()
    {
        transform.Translate(Vector2.up * gameSpeedjump * Time.deltaTime);
    }

    public void triggerfunctie()
    {
        onTheGround = true;
    }



    //_______________________________________________
    //lader en wall

    public void ladderup()
    {
        transform.Translate(Vector2.up * gamespeedtrap * Time.deltaTime);
    }
    public void ladderdown()
    {
        transform.Translate(Vector2.down * gamespeedtrap * Time.deltaTime);
    }
    
}
