using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ChestScoreManager : MonoBehaviour
{
    public static ChestScoreManager cinstance;
    public TextMeshProUGUI text;
    int score;

    // Start is called before the first frame update
    void Start()
    {
        if (cinstance == null)
        {
            cinstance = this;

        }

    }
    public void ChangeScore(int chestValue)
    {
        score = score + chestValue;
        text.text = "X" + score.ToString();
    }
}
