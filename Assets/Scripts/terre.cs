using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class terre : MonoBehaviour
{
    public float vitesseRotation = 10f; // Vitesse de rotation de la Terre sur elle-même
    public Transform Soleil;  // Référence au Soleil
    public float vitesseOrbite = 30f;   // Vitesse de rotation de la Terre autour du Soleil

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
//transform rotate pour tourner un obj 
//vector3.up selon quel vecteur elle tourne sur l'axe des y ou x .up pour y c 'est verticalement
        transform.Rotate(Vector3.up * vitesseRotation * Time.deltaTime);
        transform.RotateAround(Soleil.position, Vector3.up, vitesseOrbite * Time.deltaTime);
    }
}
