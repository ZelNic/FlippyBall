using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private bool _isActiveInput;
    [SerializeField] private float _powerForce;    
    [SerializeField] private GameObject _gameManagerGO;
    private BoundsCheck _boundsCheck;
    private GameManager _gameManager;
    private Rigidbody2D _rb;
    private Quaternion _forwardPosition;


    private void Awake()
    {
        _rb = GetComponent<Rigidbody2D>();
        _forwardPosition = Quaternion.Euler(0, 0, 20);
        _gameManager = _gameManagerGO.GetComponent<GameManager>();
        _boundsCheck = GetComponent<BoundsCheck>();
    }

    private void Update()
    {
        Controller();
        BoundsCheck();
    }

    public void OnOffInput(bool value)
    {
        if(value == true)
        {
            _isActiveInput = true;
        }
        if(value == false)
        {
            _isActiveInput = false;
        }
    }

    private void BoundsCheck()
    {
        if (_boundsCheck.offUp || _boundsCheck.offDown)
        {
            gameObject.SetActive(false);
            _gameManager.RestartGame(2);
        }
    }

    private void Controller()
    {
        if ((Input.touchCount > 0) && _isActiveInput == true)
        {
            Touch touch = Input.GetTouch(0);
            if (touch.phase == TouchPhase.Began)
            {
                PushUpPlayer();
            }
        }

        if (Input.GetKeyDown(KeyCode.Space) && _isActiveInput == true)
        {
            {
                PushUpPlayer();
            }
        }
    }

    public void PushUpPlayer()
    {
        transform.rotation = Quaternion.Lerp(Quaternion.Euler(transform.rotation.eulerAngles), _forwardPosition, 7f);
        _rb.velocity = Vector3.zero;
        _rb.AddForce(Vector2.up * _powerForce, ForceMode2D.Force);
    }

}
