using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DiagramaController : MonoBehaviour
{
    public GameObject[] card;

    public int actualCard;
    private void Start ()
    {
        actualCard = 0;
    }

    private void Update ()
    {
        if ( Input.GetKeyDown ( KeyCode.UpArrow ) )
        {
          
            actualCard = ( actualCard + 1 ) % card.Length;
            card [actualCard].SetActive ( true );
        }
        else if ( Input.GetKeyDown ( KeyCode.DownArrow ) )
        {
            card [actualCard].SetActive ( false );
            if ( actualCard - 1 < 0 )
            {
                actualCard = card.Length - 1;
            }
            else
                actualCard = ( actualCard - 1 );

            card [actualCard].SetActive ( true );
        }
    }
}
