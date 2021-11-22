using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{

    [SerializeField] float yValue = 0;
    [SerializeField] float speed = 10.5f;
    // Start is called before the first frame update
    void Start()
    {
        PrintInstruction();
    }

    // Update is called once per frame
    void Update()
    {
        Control();
    }

    void PrintInstruction() 
    {
        Debug.Log("Welcome to the game");
        Debug.Log("Use arrow key to move");
        Debug.Log("Try not to push to the wall");
    }

    void Control()
    {
        float xValue = Input.GetAxis("Horizontal") * Time.deltaTime * speed;
        float zValue = Input.GetAxis("Vertical") * Time.deltaTime * speed;
        transform.Translate(xValue,yValue,zValue);
    }
}
