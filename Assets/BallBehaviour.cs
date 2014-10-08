using UnityEngine;
using System.Collections;

public class BallBehaviour : MonoBehaviour {

    private Vector2 force;
    private float duration;

	// Use this for initialization
	void Start () {
        this.force = new Vector2(0.1f, 0.1f);
        duration = 1;
	}
	
	// Update is called once per frame
	void Update () {

        // this.force *= duration;
        if (duration > 0)
            this.transform.Translate(force.x, force.y, 0);

        //duration -= 0.01f;

        //print(force);
        
	}

    void OnCollisionEnter2D(Collision2D collision)
    {
        force *= -1;
        duration = 100;
    }

    void OnMouseDown()
    {
        force = new Vector2(-this.gameObject.transform.position.x % 0.3f,
                             -this.gameObject.transform.position.y % 0.3f);
        duration = 50;
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.name == "Goal")
        {
         //   Debug.Log("Voce Ganhou");
        }
    }
}
