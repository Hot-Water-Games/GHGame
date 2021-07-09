using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shipGame : MonoBehaviour
{

    bool isRunnning = true;
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
        isRunnning = false;
    }

    private void OnGUI()
    {
        if(isRunnning == true)
        {
            GUI.Label(new Rect(5, 5, 100, 30), "Punkty: " + playerScore);
        }
        else
        {
            GUI.Label(new Rect(Screen.width / 2 - 100, Screen.height / 2 - 50, 200, 100), "Koniec gry. Liczba zdobytych punktów: " + playerScore);
        }
    }
}
