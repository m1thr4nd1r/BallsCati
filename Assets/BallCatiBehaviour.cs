using UnityEngine;
using System.Collections;

public class BallCatiBehaviour : MonoBehaviour {

    private Vector2 force;
    private float startTime;
    private int collisions;
    private double f;
    private AudioSource audio;
    private AudioClip[] clips;
    private AudioClip hit;
    public float delay;

	// Use this for initialization
	void Start () {
        startTime = Time.time;
        collisions = 0;
        //clips = new AudioClip[] { (AudioClip) Resources.Load("Ball's Cat 1"),
          //                        (AudioClip) Resources.Load("Ball's Cat 2"),
            //                      (AudioClip) Resources.Load("Ball's Cat 3"),
              //                    (AudioClip) Resources.Load("Ball's Cat 4")};

        //clips = new AudioClip[] { (AudioClip) Resources.Load("41"), 
          //                        (AudioClip) Resources.Load("42")};
  
        AudioClip hit = (AudioClip)Resources.Load("Ball's Cat Trilha");

        audio = this.gameObject.audio;

        audio.clip = hit;
        //this.force = new Vector2(0.1737f, 0.1737f); // 0.52
        // this.force = new Vector2(0.1738f, 0.1738f); // 0.52
        // this.force = new Vector2(0.17378f, 0.17378f); // 0.52
        //this.force = new Vector2(0.1799999999999999999999999999999f, 0.179999999999999999999999999999999999f);
		//this.force = new Vector2 (0.09f, 0.09f);
        this.force = new Vector2(0.15f, 0.15f);
         //this.force = new Vector2(100f, -100f);
        //this.rigidbody2D.AddForce (force);
        //this.rigidbody2D.fixedAngle = true;
		//this.force = new Vector2(0f, 23f);
	}
	
    void Update()
    {
        this.transform.Translate(new Vector3(force.x, force.y, 0));
    }

	// Update is called once per frame
	void FixedUpdate() {
        //this.transform.Translate(new Vector3(force.x, force.y, 0));
		//this.rigidbody2D.AddForce (force);
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
		if (collision.gameObject.name == "BoundX")
        {
//			this.force = new Vector2(400f, 400f);

            float endTime = Time.time;

            force.x *= -1;
            print(endTime - startTime);

            startTime = Time.time;

            collisions++;

            //this.rigidbody2D.AddForce(force);

       //     this.audio.Play();

            //if (collisions % 16 == 0)
            //{
            //    this.audio.Stop();
            //    this.audio.clip = clips[(collisions / 16) % 2];
            //    print(audio.clip);
            //    this.audio.PlayDelayed(delay);
            //    this.audio.Play();
            //}
        }
        else if (collision.gameObject.name == "BoundY")
        {
            float endTime = Time.time;

            force.y *= -1;
            print(endTime - startTime);

            startTime = Time.time;

           // this.audio.Play();

            //this.rigidbody2D.AddForce(force);

            collisions++;

            //if (collisions % 16 == 0)
            //{
            //    this.audio.Stop();
            //    this.audio.clip = clips[(collisions / 16) % 2];
            //    print(audio.clip);
            //    this.audio.PlayDelayed(delay);
            //    this.audio.Play();
            //}
        }        
    }
}
