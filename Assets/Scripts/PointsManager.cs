using UnityEngine;

public class PointsManager : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Ball"))
        {

            PlayerPoints Points = collision.gameObject.GetComponent<PlayerPoints>();
            Points.AddPoints(1);

        }
    }
}
