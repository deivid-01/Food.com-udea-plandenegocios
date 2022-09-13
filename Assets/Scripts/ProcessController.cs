using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProcessController : MonoBehaviour
{
    public GameObject []chracter;
    public GameObject box;
    public int actual;
    public Animator animControl;
    private void Start ()
    {
        actual = 0;
    }
    private void Update ()
    {
        if ( Input.GetKeyDown ( KeyCode.UpArrow ) )
        {
            if ( actual == 0 || actual == 1 )
            {
                chracter [actual].SetActive ( false );
                ++actual;
                chracter [actual].SetActive ( true );
            }
            else if ( actual == 2 )
            {
                animControl.SetBool ( "change" , true );
                StartCoroutine ( EnableBox () );
            }

        }
    }
    IEnumerator EnableBox () {
        yield return new WaitForSeconds ( 0.6f );
        box.SetActive ( true );

    }
}
