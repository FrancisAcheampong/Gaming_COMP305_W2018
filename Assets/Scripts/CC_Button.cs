using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CC_Button : MonoBehaviour {

    public GameObject capPolution;


    public Sprite first_Sprite;
    public Sprite second_Sprite;
    public Sprite third_Sprite;
    public Sprite btn_color_purple;
    public Sprite btn_color_green1;
    public Sprite btn_color_yellow;

    private SpriteRenderer srend;

    // Use this for initialization
    void Start () {
        srend = gameObject.GetComponent<SpriteRenderer>();

    }
    void OnMouseDown()
    {
        if (srend.sprite ==btn_color_purple)
        {
            srend.sprite = first_Sprite;
        }
        else if (srend.sprite == btn_color_green1)
        {
            srend.sprite = second_Sprite;

        }else
        {
            srend.sprite = third_Sprite;
        }
    }


    }
