using UnityEngine;
using UnityEngine.SceneManagement;

public class Bird : MonoBehaviour
{
    Vector3 _initpos;
    bool lauchedBird;
    float timeDelayed = 0;

    private void Awake()
    {
        _initpos = transform.position;
    }

    private void Update()
    {
        GetComponent<LineRenderer>().SetPosition(0, transform.position);
        GetComponent<LineRenderer>().SetPosition(1, _initpos);

        if (lauchedBird && GetComponent<Rigidbody2D>().velocity.magnitude < 0.1)
        {
            timeDelayed += Time.deltaTime;
        }
        if (transform.position.y > 15 || transform.position.x > 20 || transform.position.y < -10 || transform.position.x < -20 || timeDelayed > 3)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }

    private void OnMouseDown()
    {
        GetComponent<SpriteRenderer>().color = Color.red;
        GetComponent<LineRenderer>().enabled = true;
    }

    private void OnMouseUp()
    {
        GetComponent<SpriteRenderer>().color = Color.white;

        Vector2 directionInit = _initpos - transform.position;
        GetComponent<Rigidbody2D>().AddForce(directionInit * 200);
        GetComponent<Rigidbody2D>().gravityScale = 1;
        lauchedBird = true;
        GetComponent<LineRenderer>().enabled = false;
    }

    private void OnMouseDrag()
    {
        Vector3 newpos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        transform.position= new Vector3(newpos.x,newpos.y);
    }
}
