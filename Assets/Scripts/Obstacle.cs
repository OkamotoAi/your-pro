using UnityEngine;

public class Obstacle : MonoBehaviour
{
    [SerializeField]
    private float _obstacleSpeed = 100;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        this.transform.position = new Vector2(13, -3);
    }

    // Update is called once per frame
    void Update()
    {
        this.transform.position += (Vector3.left * _obstacleSpeed);
        //TODO：画面サイズに合わせた座標にする
        if (this.transform.position.x < -15)
        {
            Destroy(this.gameObject);
        }
    }
}
