using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scorekeeper : MonoBehaviour
{
    private static Scorekeeper instance;

    public static Scorekeeper Instance
    {
        get { return instance; }
    }

    [SerializeField]
    private int pointsPerCoin = 10;
    [SerializeField]
    

    private int score = 0;

    public int Score 
    {
        get { return score; }
    }


    public void Start()
    {
        instance = this;
    }

    public void AddPointsForCoin()
    {
        score += pointsPerCoin;
    }

}
