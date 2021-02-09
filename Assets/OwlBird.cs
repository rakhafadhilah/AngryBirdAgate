using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OwlBird : Bird
{
    public bool _hasExplode = false;

    public void Explode()
    {
        if (State == BirdState.HitSomething && !_hasExplode)
        {
            transform.localScale = new Vector2(2.2f, 2.2f);
            _hasExplode = true;
        }
    }

    public override void OnCollisionEnter2D(Collision2D col)
    {
        State = BirdState.HitSomething;
        Explode();
    }
}
