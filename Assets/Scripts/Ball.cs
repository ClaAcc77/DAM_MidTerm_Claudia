using JetBrains.Annotations;
using Unity.VisualScripting;
using UnityEngine;

public class Ball : MonoBehaviour
{
    public float horizontalMovemnt = 8;
    public float Delay = 0.1f;

    public Rigidbody2D body;
    public Transform ball;
    private Transform position;
    public Vector2 CheckpositionOver = new Vector2(0f, 1f);
    public Vector2 Postion0 = new Vector2(0, 0);

    bool IsHight;

    private void Awake()
    {
        //body.linearVelocityY = 7;
        body.linearVelocityX = -7;
    }

    public void Ishigh()
    {
        if(IsHight == true)
        {
            body.position = CheckpositionOver;
        }
    }

    public void ResetPostion()
    {
        body.position = new Vector2(0, 0);
    }


    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Out"))
        {

            PlayerPoints points = collision.gameObject.GetComponent<PlayerPoints>();
            points.AddPoints(1);
            GetComponent<Collider2D>().enabled = false;

            Invoke("ResetPosition", Delay);

            
        }

        
    }

    


}
