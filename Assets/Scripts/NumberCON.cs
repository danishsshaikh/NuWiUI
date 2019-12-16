using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class NumberCON : MonoBehaviour
{
    [SerializeField] int min;
    [SerializeField] int max;
    [SerializeField] TextMeshProUGUI ehGuess;
    int guess;
    void Start()
    {
        StartGame();       
    }

    void StartGame()
    {
        max = max + 1;
        guess = (max + min) / 2;
        ehGuess.text = guess.ToString();
    }

    void NextGuess()
    {
        guess = (max + min) / 2;
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

}
