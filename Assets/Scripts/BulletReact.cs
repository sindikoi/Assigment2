using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletReact : MonoBehaviour
{

    public void OnCollisionEnter2D(Collision2D other)
    {
        if(other.gameObject.CompareTag("Enemy"))
        {
            GetComponent<SpriteRenderer>().color = Color.red;
            StartCoroutine(WaitToDestory());

        }
        else
        {
            StartCoroutine(WaitToDestory());
        }
    }


    IEnumerator WaitToDestory()
    {
        yield return new WaitForSeconds(0.5f);
        Destroy(gameObject);
    }



}
