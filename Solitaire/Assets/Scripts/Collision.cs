using UnityEngine;

public class Collision : MonoBehaviour
{
    [SerializeField] private float _delayBetweenRestartScene;
    [SerializeField] private GameObject _gameManagerGO;
    private GameManager _gameManager;
    private Score _score;

    private void Awake()
    {
        _score = GetComponent<Score>();
        _gameManager = _gameManagerGO.GetComponent<GameManager>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        GameObject other = collision.gameObject;
        if (other.tag == "Wall")
        {
            gameObject.SetActive(false);
            _gameManager.RestartGame(_delayBetweenRestartScene);
        }
        if (other.tag == "Point")
        {
            _score.AddScore();
        }
    }
}
