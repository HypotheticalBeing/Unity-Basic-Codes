using UnityEngine;

public class movement2d : MonoBehaviour // most important part is the behaviour not the mono part cause we aint monoman.
{
    [SerializeField]private float SPEED;
    private Rigidbody2D body;
    private void Awake()
    {
        body = GetComponent<Rigidbody2D>();
    }
    private void Update()
    {
        body.velocity = new Vector2(Input.GetAxis("Horizontal") * SPEED, body.velocity.y);
    }
}
