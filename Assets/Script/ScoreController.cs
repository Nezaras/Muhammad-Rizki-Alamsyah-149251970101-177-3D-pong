using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreController : MonoBehaviour
{
    public TextMeshProUGUI scoreP1;
    public TextMeshProUGUI scoreP2;
    public TextMeshProUGUI scoreP3;
    public TextMeshProUGUI scoreP4;
    public ScoreManager manager;

    // Update is called once per frame
    void Update()
    {
        scoreP1.text = manager.P1Score.ToString();
        scoreP2.text = manager.P2Score.ToString();
        scoreP3.text = manager.P3Score.ToString();
        scoreP4.text = manager.P4Score.ToString();
    }
}
