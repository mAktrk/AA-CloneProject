using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainCricleScript : MonoBehaviour
{

    [SerializeField] private int speed; 
    
    void Start()
    {
        
    }

    
    void Update()
    {
        transform.Rotate(0, 0, speed * Time.deltaTime);
    }
}
