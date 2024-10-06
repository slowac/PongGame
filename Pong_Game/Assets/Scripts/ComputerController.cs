using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ComputerController : Paddle
{
    public Rigidbody2D ball;

    private void FixedUpdate()
    {
        if (this.ball.velocity.x > 0f)
        {
            if(this.ball.position.y > this.transform.position.y)
            {
                rb.AddForce(Vector2.up * this.speed);
            }
            else if(this.ball.position.y < this.transform.position.y)
            {
                rb.AddForce(Vector2.down * this.speed);
            }

            else
            {
                if(this.transform.position.y > 0f)
                {
                    rb.AddForce(Vector2.down * this.speed);
                }
                else if (this.transform.position.y < 0f)
                {
                    rb.AddForce(Vector2.up * this.speed);
                }
            }
        }
    }
}
