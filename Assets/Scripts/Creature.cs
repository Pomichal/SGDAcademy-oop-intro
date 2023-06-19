using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Creature : MonoBehaviour
{
    protected int health;
    protected float speed;
    protected int power;

    protected Rigidbody rb;


    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        Setup();
    }

    // Update is called once per frame
    void Update()
    {
        Move();
    }

    protected virtual void Setup()
    {
        health = Random.Range(10, 20);
        speed = Random.Range(5, 10);
        power = Random.Range(4, 8);
    }


    private void OnCollisionEnter(Collision other)
    {
        HandleCollision(other);
    }

    protected virtual void HandleCollision(Collision other)
    {
        if(other.gameObject.CompareTag("Creature"))
        {
            Creature enemy = other.gameObject.GetComponent<Creature>();
            if(enemy.power < power)
            {
                Destroy(enemy.gameObject);
            }
        }
    }

    protected virtual void Move()
    {
        Vector3 dir = GetRandomDir();
        rb.MovePosition(transform.position + dir * speed * Time.deltaTime);
    }

    protected Vector3 GetRandomDir()
    {
        return new Vector3(Random.Range(-1, 1f), 0, Random.Range(-1, 1f)).normalized;
    }
}
