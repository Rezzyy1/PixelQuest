using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class ItemCollector : MonoBehaviour
{
    private int strawberries = 0;

    [SerializeField] private Text strawberriesText;

    [SerializeField] private AudioSource itemCollectSoundEffect;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Strawberry"))
        {
            itemCollectSoundEffect.Play();
            Destroy(collision.gameObject);
            strawberries++;
            strawberriesText.text = "Strawberries: " +  strawberries;
        }
    }
}
