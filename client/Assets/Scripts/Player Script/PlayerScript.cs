using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;


public class PlayerScript : MonoBehaviour
{
    private static int score = 0;

    public static event Action<int> OnScoreChanged = delegate { };

    public static void AddScore(int amount)
    {
        score += amount;
        Debug.Log("Score incremented. Current Score: " + score);
        OnScoreChanged(score);
    }
    
    public static int GetScore()
    {
        return score;
    }
}
