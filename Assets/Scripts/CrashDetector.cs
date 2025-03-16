using UnityEngine;
using UnityEngine.SceneManagement;

public class CrashDetector : MonoBehaviour
{
    CircleCollider2D head;
    void Start()
    {
        head = GetComponent<CircleCollider2D>();
    }
    void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Ground" && !head.IsTouching(collision.collider))
        {
            Debug.Log("Ouch! My head!");
            SceneManager.LoadScene(0);
        }
    }
}
