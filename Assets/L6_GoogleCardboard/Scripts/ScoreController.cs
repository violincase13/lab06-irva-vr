using L6_GoogleCardboard.Scripts.Helpers;
using TMPro;
using UnityEngine;

namespace L6_GoogleCardboard.Scripts
{
    /// <summary>
    /// Used to keep track of game score & update world space UI canvas.
    /// </summary>
    public class ScoreController : Singleton<ScoreController>
    {
       [SerializeField] private TextMeshProUGUI scoreText;

       private int _score = 0;

       public void IncrementScore()
       {
           _score++;
           
           // TODO 5.1 : Set the score text.
           UpdateScoreText();
       }

       public void DecrementScore()
       {
           // TODO 5.2 : Implement score modification & set the score text.
            _score = Mathf.Max(0, _score - 1); // Decrement the score, but not below 0
            UpdateScoreText();
       }

        private void UpdateScoreText()
        {
            if (scoreText != null)
            {
                scoreText.text = "Score: " + _score;
            }
        }
    }
}