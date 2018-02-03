using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickHandler : MonoBehaviour {
    public GameObject capPolution;

    public Sprite firstSprite;
    public Sprite secondSprite;


    private Rigidbody2D rBody;
    private SpriteRenderer srend;
	// Use this for initialization
	void Start () {
        //Debug.Log(someNumber);
        rBody = capPolution.GetComponent<Rigidbody2D>();
        rBody.velocity = new Vector2(2, 0);
        srend = capPolution.GetComponent<SpriteRenderer>();

        //capPolution.GetComponent<Rigidbody2D>().velocity = new Vector2(2, 0);
	}

    void OnMouseDown()
    {
        //rigidbody.AddForce(-transform.forward * 500f);
        // rigidbody.useGravity = true;
        //Debug.Log("clicked");
        //rBody = capPolution.GetComponent<Rigidbody2D>();
        rBody.velocity *= -1;
        if (srend.sprite ==firstSprite)
        {
            srend.sprite = secondSprite;
        }
        else
        {
            srend.sprite = firstSprite;
        }
       
    }


}
