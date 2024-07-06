using UnityEngine;

public class GameManager : MonoBehaviour
{
    private Vector3 obstacleInitPos = new Vector3(13, -3, 0);
    [SerializeField]
    GameObject obstaclePrefab;
    private float time = 0;// テスト用
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // obstaclePrefab = (GameObject)Resources.Load("obstacle");
    }

    // Update is called once per frame
    void Update()
    {

    }

    /// <summary>
    /// This function is called every fixed framerate frame, if the MonoBehaviour is enabled.
    /// </summary>
    void FixedUpdate()
    {
        time += Time.deltaTime;
        if (time > 2)
        {
            CreateObstacle();
            time = 0;
        }
    }

    void CreateObstacle()
    {
        GameObject obstacleInstance = Instantiate(obstaclePrefab, obstacleInitPos, Quaternion.identity);
    }
}
