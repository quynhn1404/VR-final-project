using System.Collections;

using UnityEngine;

public class playDropSound : MonoBehaviour
{
    private AudioSource aud;
    // Start is called before the first frame update
    void Start()
    {
        aud =  GetComponent<AudioSource>();
    }

    void OnCollisionEnter(Collision col)  //Plays Sound Whenever collision detected
     {
        if(col.gameObject)
            aud.Play ();
     }
}
