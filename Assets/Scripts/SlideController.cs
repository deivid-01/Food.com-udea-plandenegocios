using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlideController : MonoBehaviour
{
    public GameObject[] slides;

    public int actualSlide;
    private void Start ()
    {
        actualSlide = 0;
    }

    private void Update ()
    {
        if ( Input.GetKeyDown ( KeyCode.RightArrow ) )
        {
            slides [actualSlide].SetActive ( false );
            actualSlide = ( actualSlide + 1 ) % slides.Length;
            slides [actualSlide].SetActive ( true );
        }
        else if ( Input.GetKeyDown ( KeyCode.LeftArrow ) )
        {
            slides [actualSlide].SetActive ( false );
            if ( actualSlide - 1 < 0 )
            {
                actualSlide = slides.Length - 1;
            }
            else
                actualSlide = ( actualSlide - 1 );

            slides [actualSlide].SetActive ( true );
        }
    }
}
