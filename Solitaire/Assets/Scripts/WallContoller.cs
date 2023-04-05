using UnityEngine;

public class WallContoller : MonoBehaviour
{
    [SerializeField] private float speedForMovingWall;
    private BoundsCheck _boundsCheck;


    private void Awake()
    {
        _boundsCheck = GetComponent<BoundsCheck>();
    }

    private void FixedUpdate()
    {
        MoveWall();
        BoundsCheck();
    }

    private void BoundsCheck()
    {
        if (_boundsCheck.offLeft)
        {
            this.gameObject.SetActive(false);
        }
    }

    private void MoveWall()
    {
        this.gameObject.transform.position -= new Vector3(speedForMovingWall, 0, 0) * Time.deltaTime;
    }
}
