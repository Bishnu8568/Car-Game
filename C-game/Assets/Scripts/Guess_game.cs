using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public int min = 0, max = 1000;
    int guess;
    void Start()
    {
        guess = (max+min) / 2;
        debug.Log("Welcome to the Guessing Game! think a num b/w 1 to 1000");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
