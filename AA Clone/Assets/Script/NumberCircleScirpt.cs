using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class NumberCircleScirpt : MonoBehaviour
{
    [SerializeField] private GameObject smallCircle;
    [SerializeField] private int howManyCircle;
    private bool CircleControll = false;
    [SerializeField] private int levelScene;
    [SerializeField] private Text howManyCircleText;


    void Start()
    {
        
    }

    
    void Update()
    {
       
        if (Input.GetButtonDown("Fire1"))
        {
            Instantiate(smallCircle, transform.position, transform.rotation);
            howManyCircle--;
            howManyCircleText.text = howManyCircle.ToString();
        }
        if (howManyCircle == 0)
        {
            CircleControll = true;
            SceneManager.LoadScene(levelScene+1);
        }

    }
}
