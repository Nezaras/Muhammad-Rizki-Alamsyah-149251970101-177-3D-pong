using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Winner : MonoBehaviour
{
    public Text winText;

    private void Start()
    {
        winText.text = StaticVarWinner.Winner;
    }
}
