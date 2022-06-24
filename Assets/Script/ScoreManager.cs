using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    public int P1Score;
    public int P2Score;
    public int P3Score;
    public int P4Score;
    public PaddleController P1;
    public PaddleController P2;
    public PaddleController P3;
    public PaddleController P4;

    public int maxScore = 15;

    public BallController ball;
    public GawangController gawangController;

    public void AddP1Score(int increment)
    {
        P1Score += increment;
        if (P1Score == maxScore)
        {
            gawangController.gawangActive1();
            P1.destroyPlayer();
        }
    }

    public void AddP2Score(int increment)
    {
        P2Score += increment;
        if (P2Score == maxScore)
        {
            gawangController.gawangActive2();
            P2.destroyPlayer();
        }
    }

    public void AddP3Score(int increment)
    {
        P3Score += increment;
        Debug.Log(P3Score);
        if (P3Score == maxScore)
        {
            gawangController.gawangActive3();
            P3.destroyPlayer();
        }
    }

    public void AddP4Score(int increment)
    {
        P4Score += increment;
        if (P4Score == maxScore)
        {
            gawangController.gawangActive4();
            P4.destroyPlayer();
        }
    }
}
