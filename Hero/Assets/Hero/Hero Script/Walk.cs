using UnityEngine;
using System.Collections;

public class Walk : MonoBehaviour {

    Animator anim;
    private Rigidbody2D heroBody;

    public float speedMoove;
    private bool isJumping;

	// Use this for initialization
	void Start () {
        anim = GetComponent<Animator>();
        heroBody = GetComponent<Rigidbody2D>();
        isJumping = false;
	}
	
	// Update is called once per frame
	void Update () {
        
        Movement();
        {
            float move = Input.GetAxis("Horizontal");
            anim.SetFloat("Speed", move);
        }

        if (Input.GetKeyDown(KeyCode.Space) && isJumping == false)
        {
            isJumping = true;
            StartCoroutine(StartJump());

        }

    }

    void Movement()
    {
        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(Vector2.right * speedMoove * Time.deltaTime);
            transform.eulerAngles = new Vector2(0, 0);
        }

        if (Input.GetKey(KeyCode.Q))
        {
            transform.Translate(Vector2.right * speedMoove * Time.deltaTime);
            transform.eulerAngles = new Vector2(0, 180);
        }
    }
    
    IEnumerator StartJump()
    {
        heroBody.AddForce(new Vector2(0, 350f));
        heroBody.mass = 1.5f;
        //heroBody.AddForce(new Vector2(0, -100f));
        yield return new WaitForSeconds(1);
        isJumping = false;
        heroBody.mass = 1f;
    }
}
