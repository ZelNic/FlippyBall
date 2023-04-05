using System.ComponentModel;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private bool isActiveInput;
    [SerializeField] private float _powerForce;    
    private Rigidbody2D _rb;
    private Quaternion forwardPosition;


    private void Awake()
    {
        _rb = GetComponent<Rigidbody2D>();
        forwardPosition = Quaternion.Euler(0, 0, 20);
    }

    private void Update()
    {
        PushUpPlayer();

    }

    private void PushUpPlayer()
    {
        if (Input.GetKeyDown(KeyCode.Space) && isActiveInput == true)
        {
            transform.rotation = Quaternion.Lerp(Quaternion.Euler(transform.rotation.eulerAngles), forwardPosition, 7f);
            _rb.velocity = Vector3.zero;
            _rb.AddForce(Vector2.up * _powerForce, ForceMode2D.Force);
        }
    }
}
