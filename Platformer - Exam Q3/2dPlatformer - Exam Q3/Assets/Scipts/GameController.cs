using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour {
    [SerializeField] private Transform player1;
    [SerializeField] private Transform player2;
    private string text = "";

    private void Update()
    {
        if(player1.position.y > 25)
        {
            text = " PLAYER 1 WINS !!";
        }
        if(player2.position.y > 25)
        {
            text = " PLAYER 2 WINS !!";
        }
    }

    private void OnGUI()
    {
        GUI.Label(new Rect(Screen.width/2,50,150,20),text);
    }
}
