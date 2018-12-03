using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro; //<-- namespace 
//using unityengine.ui

public class ScoreTracker : MonoBehaviour
{
    public int TotalScore;
    public TextMeshProUGUI Scoretext;

    private void Update()
    {
        // Ändrar vad texten på Ui:n så att den visar vad din score är
        Scoretext.text = string.Format("Score: {0}/10", TotalScore);
    }
}
