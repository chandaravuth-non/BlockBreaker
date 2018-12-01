using UnityEngine;
using UnityEngine.SceneManagement;

public class Ball : MonoBehaviour {
   [SerializeField] Basket basket1;
    Rigidbody2D rigiBody2D;
    float randomN = 0.2f;
    bool launch = false;

    Vector2 BasketToBall;

    public void Start()
    {
     
        BasketToBall = transform.position - basket1.transform.position;
        rigiBody2D = GetComponent<Rigidbody2D>();

    }
     public void Update()
    {
        if (!launch)
        {
            LaunchBallClick();
            LockBallToBasket();
           
        }



    }

    public void LockBallToBasket()
    {
        Vector2 basketPos = new Vector2(basket1.transform.position.x, basket1.transform.position.y);
        transform.position = basketPos + BasketToBall;
    }
   public  void LaunchBallClick()
    {
        if(Input.GetMouseButton(0))
        {
            launch = true;
            rigiBody2D.velocity = new Vector2(2f, 15f);
        }
    }

    public void OnCollisionEnter2D(Collision2D collision)
    {
        Vector2 ballHitBlockBoxVelocity = new Vector2(Random.Range(0f,randomN), Random.Range(0f, randomN));
        if(launch)
        {
            rigiBody2D.velocity = rigiBody2D.velocity + ballHitBlockBoxVelocity;
        }
    }


}
