using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class GameManagerController : MonoBehaviour
{
    public int points;
    public Text textPoints;
    void Start()
    {
        UpdatePoints(0);
    }
    public void UpdatePoints(int score)
    {
        points = points + score;
        textPoints.text = "Puntos: " + points;
    }
}
