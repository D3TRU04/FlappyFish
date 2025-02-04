using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;
using TMPro;

public class Player : MonoBehaviour
{
    [SerializeField] private float force;
    [SerializeField] private AudioClip pointSFX;
    [SerializeField] private AudioClip forceSFX;
    [SerializeField] private AudioClip deadSFX;
    public TextMeshProUGUI scoreText;
    public GameObject ReplayButton;
    private int scoreCnt;
    private bool canReset;

    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 1;
    }

    // Update is called once per frame
    void Update()
    {
        scoreText.text = scoreCnt.ToString();
        if(Input.GetKeyDown(KeyCode.Space)) {
            GetComponent<Rigidbody2D>().velocity = new Vector2(0f, force);
//            GetComponent<AudioSource>().clip = forceSFX;
//            GetComponent<AudioSource>().Play();
        }
    }

    private void OnTriggerEnter2D(Collider2D collision) {
        if(collision.gameObject.CompareTag("Scoring")) {
            GetComponent<AudioSource>().clip = pointSFX;
            GetComponent<AudioSource>().Play();
            scoreCnt += 1;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision) {
        if(collision.gameObject.CompareTag("Ground") || collision.gameObject.CompareTag("Pipe")) {
            GetComponent<AudioSource>().clip = deadSFX;
            GetComponent<AudioSource>().Play();
            Time.timeScale = 0;
            ReplayButton.SetActive(true);
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }

    public void ReplayGame() {
//        if(Input.GetKeyDown(KeyCode.Space)) {
//        }
    }
}
