using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cartes : MonoBehaviour
{
    public MeshRenderer mr;
    public void ChangeColor(Color color)
    {
        mr.material.color = color;
    }
    
    // Start is called before the first frame update
   
}
