using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_blue : MonoBehaviour
{
    public float speed = 5f;
    bool cangoup = true;
    bool cangodown = true;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKey(KeyCode.W) && (cangoup == true))
        {
            transform.Translate(Vector2.up * speed * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.S) && (cangodown == true))
        {
            transform.Translate(Vector2.down * speed * Time.deltaTime);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name == "Border_Top")
        {
            cangoup = false;
        }


        if (collision.gameObject.name == "Border_Bottom")
        {
            cangodown = false;
        }

    }
}
