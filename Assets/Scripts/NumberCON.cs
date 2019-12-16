using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumberCON : MonoBehaviour
{
    int min;
    int max;
    int guess;
    void Start()
    {
        StartGame();       
    }

    void StartGame()
    {
        max = 1000;
        min = 1;
        guess = 500;

        Debug.Log("Welcome, to our Number Game");
        Debug.Log("Hosted by Danish Shaikh, @danishsshaikh");
        Debug.Log("Now just think of an number between 1 to 1000");

        Debug.Log("May the Lowest Number to Pick be:" + min);
        Debug.Log("May the Highest Number to Pick be:" + max);

        Debug.Log("Tell me if your number is higher or lower than:" + guess);
        Debug.Log("Arrow Up = Higher, Arrow Down = Lower, Enter = Correct");

        max = max + 1;
    }

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.UpArrow))
        {
            //Debug.Log("Up Arrow");
            min = guess;
            NextGuess();
            //guess = (max + min) / 2;
            //Debug.Log("Is it higher or lower than:" + guess);
        }
        else if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            //Debug.Log("Down Arrow");
            max = guess;
            NextGuess();
            //guess = (max + min) / 2;
            //Debug.Log("Is it higher or lower than:" + guess);
        }
        else if (Input.GetKeyDown(KeyCode.Return))
        {
            Debug.Log("Enter");
            Debug.Log("YES, I did it");
            StartGame();
        }
    }
    void NextGuess()
    {
        guess = (max + min) / 2;
        Debug.Log("Is it higher or lower than:" + guess);
    }
}
