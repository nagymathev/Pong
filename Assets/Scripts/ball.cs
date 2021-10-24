using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ball : MonoBehaviour
{
    public float hvel = 5f;
    public float vvel = 5f;

    public Transform startinglocation;

    AudioSource ballsound;

    // Start is called before the first frame update
    void Start()
    {
        ballsound = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector2.right * hvel * Time.deltaTime);
        transform.Translate(Vector2.up * vvel * Time.deltaTime);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        ballsound.Play();

        if (collision.gameObject.name == "Border_Top")
        {
            vvel *= -1f;
        }

        if (collision.gameObject.name == "Border_Bottom")
        {
            vvel *= -1f;
        }

        if (collision.gameObject.name == "Border_Blue")
        {
            hvel = 4f;
            vvel = 2f;
            transform.position = startinglocation.position;
        }

        if (collision.gameObject.name == "Border_Red")
        {
            hvel = -4f;
            vvel = -2f;
            transform.position = startinglocation.position;
        }

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        ballsound.Play();

        if (collision.gameObject.name == "Player_Red")
        {
            hvel += 0.5f;
            hvel *= -1f;

            if (vvel > 0)
            {
                vvel += 0.2f;
            }
            else
            {
                vvel -= 0.2f;
            }
            
        }

        if (collision.gameObject.name == "Player_Blue")
        {
            hvel *= -1f;
            hvel += 0.5f;

            if (vvel > 0)
            {
                vvel += 0.2f;
            }
            else
            {
                vvel -= 0.2f;
            }

        }
    }
}
