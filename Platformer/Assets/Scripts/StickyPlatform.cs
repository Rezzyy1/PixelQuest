using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StickyPlatform : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        // ���������, ��� ��� ����� � ��� �� ���
        if (collision.gameObject.name == "Player" && IsPlayerAlive(collision))
        {
            collision.gameObject.transform.SetParent(transform);
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        // ���������, ��� ��� ����� � ��� �� ���
        if (collision.gameObject.name == "Player" && IsPlayerAlive(collision))
        {
            collision.gameObject.transform.SetParent(null);
        }
    }

    // ����� ��� ��������, ��� �� �����
    private bool IsPlayerAlive(Collider2D collision)
    {
        PlayerLife playerLife = collision.gameObject.GetComponent<PlayerLife>();
        if (playerLife != null)
        {
            return playerLife.IsAlive();
        }
        return false;
    }
}