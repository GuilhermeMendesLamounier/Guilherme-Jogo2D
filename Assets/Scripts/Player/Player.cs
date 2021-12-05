using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;


public class Player : MonoBehaviour
{
    public Rigidbody2D myRigidbody;

    [Header("Speed setup")]
    public Vector2 friction = new Vector2(.1f, 0);
    public float speed;
    public float speedRun;
    public float forceJump = 2;
    public float forcedown = 2;
    


    [Header("Animation setup pulo")]
    public float jumpScaleY = 1.5f;
    public float jumpScaleX = 0.7f;
    public float animationDuration = .3f;
    public Ease ease = Ease.OutBack;

    [Header("Animation setup impacy")]
    public float impactScaleY = 0.7f;
    public float impactScaleX = 1.5f;
    public float durationanimaation = 3f;
    public Ease easa = Ease.OutBack;

    private float _currentSpeed;

    public void Update()
    {
        handleJump();
        HandleMoviniment();
    }

    private void HandleMoviniment()
    {
        if (Input.GetKey(KeyCode.LeftShift))
            _currentSpeed = speedRun;
        else
            _currentSpeed = speed;


        if (Input.GetKey(KeyCode.LeftArrow))
        {
            myRigidbody.velocity = new Vector2(-_currentSpeed, myRigidbody.velocity.y);
        }
        else if (Input.GetKey(KeyCode.RightArrow))
        {
            myRigidbody.velocity = new Vector2(_currentSpeed, myRigidbody.velocity.y);
        }

        if(myRigidbody.velocity.x > 0)
        {
            myRigidbody.velocity += friction;
        }

        else if (myRigidbody.velocity.x < 0)
        {
            myRigidbody.velocity -= friction;
        }

    }

    private void handleJump()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            myRigidbody.velocity = Vector2.up * forceJump;
            myRigidbody.transform.localScale = Vector2.one;

            DOTween.Kill(myRigidbody.transform);

            HandleScaleJump();
            
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
       // if (collision.transform)
        {
         // myRigidbody.velocity = Vector2.down * forcedown;
          //myRigidbody.transform.localScale = Vector2.one;

          //HandleScaleDown();
        }

    }

    private void HandleScaleJump()
    {
        myRigidbody.transform.DOScaleY(jumpScaleY, animationDuration).SetLoops(2, LoopType.Yoyo).SetEase(ease);
        myRigidbody.transform.DOScaleX(jumpScaleX, animationDuration).SetLoops(2, LoopType.Yoyo).SetEase(ease);

    }

    private void HandleScaleDown()
    {
        myRigidbody.transform.DOScaleY(impactScaleY, animationDuration).SetLoops(2, LoopType.Yoyo);
        myRigidbody.transform.DOScaleX(impactScaleX, animationDuration).SetLoops(2, LoopType.Yoyo);

    }

}
