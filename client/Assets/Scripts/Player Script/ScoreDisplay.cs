using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreDisplay : MonoBehaviour {
    public TextMeshProUGUI scoreText;

    private void Start() {
        PlayerScript.OnScoreChanged += UpdateScoreText;
        UpdateScoreText(PlayerScript.GetScore());
    }

    private void OnDestroy() {
        PlayerScript.OnScoreChanged -= UpdateScoreText;
    }

    private void UpdateScoreText(int newScore) {
        scoreText.text = "Score: " + newScore.ToString();
    }
}