using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreScreen : MonoBehaviour
{
    int valueScroe;

    [SerializeField]
    float timeScore;

    [SerializeField]
    float velocity = 2;

    bool stopActive;

    [SerializeField]
    TextMeshProUGUI textScore;

    [SerializeField]
    AudioSource playScoreSound;

    private void Start()
    {
        playScoreSound.Play();
    }

    void Update()
    {
        if (!stopActive)
        {
            timeScore += velocity * Time.deltaTime;

            if (timeScore > 0.1)
            {
                timeScore = 0;
                valueScroe += 1;
                textScore.text = valueScroe.ToString();
                if (valueScroe >= StatesGame.GetScore())
                    stopActive = true;
            }
        }

    }
}
