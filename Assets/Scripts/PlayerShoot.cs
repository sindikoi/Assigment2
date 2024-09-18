using System.Collections;
using System.Collections.Generic;
using UnityEditorInternal;
using UnityEngine;

public class PlayerShoot : MonoBehaviour
{
    [SerializeField] Transform bulletPosition;
    [SerializeField] GameObject bulletPrefab;
    [SerializeField] float bulletSpeed = 1f;
    private Vector3 directionPlayer;
    private float speed = 5f;
    private Vector3 directionSpeed;


    private void Start()
    {
        PlayerMovement.directionEvent += Direction;
        

    }
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            directionSpeed = directionPlayer * speed;
            var bullet = Instantiate(bulletPrefab, directionSpeed+bulletPosition.position, bulletPosition.rotation);
            bullet.GetComponent<Rigidbody2D>().velocity = directionPlayer * bulletSpeed;
        }
    }

    public void Direction(Vector2 direction)
    {
        directionPlayer = direction;
    }
}
