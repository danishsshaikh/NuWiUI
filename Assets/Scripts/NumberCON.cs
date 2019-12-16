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
