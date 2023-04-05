using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    [SerializeField] private Text scoreText;
    private int _score;
    [SerializeField] private Text hightScoreText;
    private int _hightScore;


    public int ScoreGS
    {
        get { return _score; }
        set { _score = value; }
    }

    public int HightScore
    {
        get { return _hightScore; }
        set { _hightScore = value; }
    }

    private void Awake()
    {
        scoreText.text = ScoreGS.ToString();
        if (PlayerPrefs.HasKey("hightScore"))
        {
            HightScore = PlayerPrefs.GetInt("hightScore", HightScore);
            hightScoreText.text = HightScore.ToString();
        }
    }

    public void Update()
    {
        UpdateScors();
        UpdateHightScore();
    }

    public void AddScore()
    {
        ScoreGS++;        
    }

    public void UpdateScors()
    {
        scoreText.text = ScoreGS.ToString();
        hightScoreText.text = HightScore.ToString();
    }


    public void UpdateHightScore()
    {
        if (HightScore < ScoreGS)
        {            
            HightScore = ScoreGS;
            PlayerPrefs.SetInt("hightScore", HightScore);
            PlayerPrefs.Save();
        }

    }

}
