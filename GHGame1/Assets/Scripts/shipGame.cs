using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shipGame : MonoBehaviour
{

    bool isRunning = true;
    int playerScore = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void AddScore()
    {
        playerScore++;
    }

    public void PlayerDied()
    {
        isRunning = false;
    }

    
}
