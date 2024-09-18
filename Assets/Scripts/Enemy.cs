using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] GameObject bullet;
    [SerializeField] float time = 0.05f;
    public static event Action<int> UpdateScore;
    private bool isActive = true;


    public void OnCollisionEnter2D(Collision2D other)
    {
        if(other.gameObject.CompareTag("Bullet") && isActive)
        {
            isActive = false;
            UpdateScore?.Invoke(1);
            StartCoroutine(WaitToDestroy());
        }
        
    }

    IEnumerator WaitToDestroy()
    {
        yield return new WaitForSeconds(time);
        Destroy(gameObject);
    }
}
