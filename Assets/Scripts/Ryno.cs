using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ryno : Creature
{

    private Vector3 direction;

    protected override void Setup()
    {
        base.Setup();
        direction = GetRandomDir();
    }

    protected override void Move()
    {
        rb.MovePosition(transform.position + direction * speed * Time.deltaTime);
    }


    protected override void HandleCollision(Collision other)
    {
        base.HandleCollision(other);
        direction *= -1;
    }
}
