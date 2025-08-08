using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GuessGame : MonoBehaviour
{
    public int min = 0, max = 1000;
    int guess;

    void Start()
    {
        guess = (max + min) / 2;
        Debug.Log("Welcome to the Guess Game, Think of a number between 1 and 1000 and dont tell me");
        Debug.Log("My guess is:" + guess);
        
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            min = guess;
            guess = (min + max) / 2;
            Debug.Log("So your number is higher, i guess to be :" + guess);
        }
        else if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            max = guess;
            guess = (min + max) / 2;
            Debug.Log("So your number is lower, i guess to be :" + guess);
        }
        else if (Input.GetKeyDown(KeyCode.Equals))
        {
            Debug.Log("Gotcha!!");
        }
        
    }
}