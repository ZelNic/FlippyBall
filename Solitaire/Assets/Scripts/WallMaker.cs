using UnityEngine;

public class WallMaker : MonoBehaviour
{
    [SerializeField] private GameObject[] _arrayWall;
    [SerializeField] private GameObject _pointActiveWall;
    private float _timeActiveWall;

    private void FixedUpdate()
    {
        if (_timeActiveWall < Time.timeSinceLevelLoad)
        {
            ActiveWall();
        }

    }

    private void ActiveWall()
    {
        if (_timeActiveWall < Time.timeSinceLevelLoad)
        {
            for (int i = 0; i < _arrayWall.Length; i++)
            {
                if (_arrayWall[i].activeInHierarchy == false)
                {
                    _arrayWall[i].SetActive(true);
                    _arrayWall[i].transform.position = new Vector3(8, Random.Range(6, 10), 0);
                    _timeActiveWall = Time.timeSinceLevelLoad + 2.5f;
                    break;
                }
            }
        }            
    }
}
