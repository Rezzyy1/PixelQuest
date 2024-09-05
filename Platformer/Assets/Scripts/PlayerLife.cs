using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerLife : MonoBehaviour
{
    private Rigidbody2D rb;
    private Animator anim;
    private PlayerMovement playerMovement;

    private bool isAlive = true;

    [SerializeField] private AudioSource deathSoundEffect;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
        playerMovement = GetComponent<PlayerMovement>();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Trap"))
        {
            Die();
        }
    }

    public bool IsAlive()
    {
        return isAlive;
    }

    private void Die()
    {
        isAlive = false;

        deathSoundEffect.Play();
        rb.velocity = Vector2.zero;
        rb.isKinematic = true;
        anim.SetTrigger("death");
    }

    private void RestartLevel()
    {
        transform.SetParent(null);

        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}