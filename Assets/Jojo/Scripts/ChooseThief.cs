using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace Jojo
{


public class ChooseThief : MonoBehaviour
{
    //********* Init des variables *****************
    public List<ThiefMovement> ListThief1;
    int randomThief;
    int randomMove;
    private float compteur;
    public int cooldown;
    //*********************************************
    void Start()
    {
        //************ Au lancement **************************
        compteur = cooldown;
        randomThief = Random.Range(0,ListThief1.Count);     // Init du random en fonction de la taille de la liste
        randomMove = Random.Range(0,1);
        //****************************************************
    }

    //*************** Pour chaque frame *******************************
    void Update()
    {
        Debug.Log(randomMove);
        if (compteur > 0)           // choisis un mouvement tout les X temps
            {
                compteur -= Time.deltaTime;     
        }else
            {
            if(randomMove==0){
                ListThief1[randomThief].BigMove=true;           // Si le nombre choisis est egal a zero alors faire le grand mouvement
            }

            if(randomMove==1 || randomMove==2 ){
                ListThief1[randomThief].SmallMove=true;         // Si le nombre choisis est egal a un ou deux alors faire le petit mouvement
            }
            randomThief = Random.Range(0,ListThief1.Count);
            randomMove = Random.Range(0,2);                             
            compteur = cooldown;
            }
    }
    //****************************************************
}

}
