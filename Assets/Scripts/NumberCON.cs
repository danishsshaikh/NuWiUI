using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumberCON : MonoBehaviour
{
    [SerializeField] int min;
    [SerializeField] int max;
    [SerializeField] int guess;
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

    void NextGuess()
    {
        guess = (max + min) / 2;
        Debug.Log("Is it higher or lower than:" + guess);
    }

    public void OnPressHigher()
    {
        min = guess;
        NextGuess();
    }

    public void OnPressLower()
    {
        max = guess;
        NextGuess();
    }

    public void OnPressMiddle()
    {
        StartGame();
    }
}
