using UnityEngine;

public class ObstacleOutBal : MonoBehaviour
{
    public Rigidbody2D ball;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Ball"))
        {
            Invoke("DoIt", 0);

        }
    }

    private void DoIt()
    {

        ball.position = new Vector3(0, 0);



    }







}
