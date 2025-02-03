using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moon : MonoBehaviour
{
    // Start is called before the first frame update
    public Transform terre;  // Référence à la Terre
    public float vitesseRound = 2f;
    public float vitesseOrbiteLune = 50f;  // Vitesse de rotation de la Lune autour de la Terre

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(Vector3.up * vitesseRound * Time.deltaTime);
        transform.RotateAround(terre.position, Vector3.up, vitesseOrbiteLune * Time.deltaTime);
    }
}
