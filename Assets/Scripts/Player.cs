using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    Rigidbody2D rb;

    // for debug
    [SerializeField]
    private int _jumpPower = 100;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
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
        if (Input.GetMouseButtonDown(0))
        {
            Jump();
        }
    }
    void Jump()
    {
        // 上方向に力を加える事でジャンプする
        rb.AddForce(Vector2.up * _jumpPower);
    }

    /// <summary>
    /// Sent when another object enters a trigger collider attached to this
    /// object (2D physics only).
    /// </summary>
    /// <param name="other">The other Collider2D involved in this collision.</param>
    void OnTriggerEnter2D(Collider2D collider)
    {
        Debug.Log(collider.gameObject.tag);
        if (collider.gameObject.tag == "Obstacle")
        {

            Debug.Log("ぶつかった");
            SceneManager.LoadScene("GameOverScene");

        }
    }
}
