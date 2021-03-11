using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SmallCircleScirpt : MonoBehaviour
{

    private Rigidbody2D Rigidbody2D;
    [SerializeField] private int speed = 5;
    private bool controll = false;
    [SerializeField] private int gameLevel;


    void Start()
    {
        Rigidbody2D = GetComponent<Rigidbody2D>();
    }

    
    void Update()
    {
        if (!controll)
        {
            Rigidbody2D.MovePosition(Rigidbody2D.position + Vector2.up * speed * Time.deltaTime);
        }
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "MainCircleTag")
        {
            transform.SetParent(collision.transform);
            controll = true;
        }

        if (collision.gameObject.tag == "SmallCircleTag")
        {
            SceneManager.LoadScene(gameLevel);
        }
    }
}
