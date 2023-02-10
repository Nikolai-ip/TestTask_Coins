using TMPro;
using UnityEngine;


public class CoinsScoreController : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI _scoreText;
    private SceneController _sceneController;
    private int _score = 0;
    [SerializeField] private int _coinsAmountForWin;
    private void Start()
    {
        UpdateScoreText();
        _sceneController = FindObjectOfType<SceneController>();
    }
    private void UpdateScoreText()
    {
        if (_scoreText != null)
            _scoreText.text = $"SCORE: {_score}";
    }
    public void IncrementCooinsScore()
    {
        _score++;
        UpdateScoreText();
        if (_score == _coinsAmountForWin) _sceneController.Win();
    }

}
