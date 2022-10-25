using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    private Animation thisAnimation;
    public float velocity = 1;
    private Rigidbody rb;

    void Start()
    {
        thisAnimation = GetComponent<Animation>();
        thisAnimation["Flap_Legacy"].speed = 3;

        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
            rb.velocity = Vector2.up * velocity;
        thisAnimation.Play();

    }

    private void OnCollisionEnter(Collision collision)
    {
        SceneManager.LoadScene("RestartScene");
    }
}
