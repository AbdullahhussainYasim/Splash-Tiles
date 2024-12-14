using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class tilescript : MonoBehaviour
{
    public SpriteRenderer color;
    public int scorevalue = 1;
    private bool isTouched = false;
    public Rigidbody2D rb;
    public float speed = 500f;
    public AudioClip gameovers;
    private int i1 = 1;

    private AudioSource audioSource; 

    void Start()
    {
       
        audioSource = GetComponent<AudioSource>();
        audioSource.clip = gameovers;
    }

    void OnMouseOver()
    {
        if (Input.GetMouseButtonDown(0) && color.color != Color.blue)
        {
            color.color = Color.blue;
            FindObjectOfType<ScoreScript>().updateScore(scorevalue);
            isTouched = true;


            if (audioSource != null)
            {
                audioSource.Play();
            }
        }
    }

    void HandleTouchInput()
    {
        if (Input.touchCount > 0 && color.color != Color.blue) 
        {
            foreach (Touch touch in Input.touches) 
            {
                if (touch.phase == TouchPhase.Began) 
                {
                    Vector3 touchPosition = Camera.main.ScreenToWorldPoint(touch.position);
                    RaycastHit2D hit = Physics2D.Raycast(touchPosition, Vector2.zero);

                    if (hit.collider != null && hit.collider.gameObject == this.gameObject && !isTouched)
                    {
                        isTouched = true;
                        color.color = Color.blue;
                        FindObjectOfType<ScoreScript>().updateScore(scorevalue);


                        if (audioSource != null)
                        {
                            audioSource.Play();
                        }
                    }
                }
            }
        }
        else
        {
            isTouched = false; 
        }
    }

    void Update()
    {
        rb.velocity = new Vector3(0, -speed * Time.deltaTime, 0);

        if (FindObjectOfType<ScoreScript>().score >= 5 * i1)
        {
            i1++;
            speed += 10f;
        }

        HandleTouchInput();


        if (Input.GetMouseButtonDown(0))
        {
            Vector3 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            RaycastHit2D hit = Physics2D.Raycast(mousePosition, Vector2.zero);


            if (hit.collider == null || hit.collider.tag != "piano")
            {
                EndGame(); 
            }
        }
    }

    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.collider.tag == "piano")
        {
            if (transform.position.y > col.transform.position.y)
            {
                Destroy(col.gameObject);
            }
            else
            {
                Destroy(gameObject);
            }
        }

        if (color.color != Color.blue && col.collider.tag == "border")
        {
            SceneManager.LoadScene("over");
        }
    }

    void EndGame()
    {

        SceneManager.LoadScene("over");
    }
}
