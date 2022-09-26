using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    [SerializeField]
    private Text scoreText;
    
   
   

    private Scorekeeper scorekeeper;

    void Start()
    {
        scorekeeper = FindObjectOfType<Scorekeeper>();
    }


    void Update()
    {
        string score = "Score: " + scorekeeper.Score;
        scoreText.text = score;
    }
}
