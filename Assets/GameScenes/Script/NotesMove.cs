using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NotesMove : MonoBehaviour
{
    // Update is called once per frame
    int NoteSpeed = 5;
    void Update()
    {
      //NoteSpeed.
	    transform.position -= transform.forward * Time.deltaTime * NoteSpeed;
    }
}
