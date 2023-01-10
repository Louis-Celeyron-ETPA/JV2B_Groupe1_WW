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
        randomThief = Random.Range(0,ListThief1.Count);
        randomMove = Random.Range(0,1);
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(randomMove);
        if (compteur > 0)
            {
                compteur -= Time.deltaTime;
        }else
            {
            if(randomMove==0){
                ListThief1[randomThief].BigMove=true;
            }

            if(randomMove==1 || randomMove==2 ){
                ListThief1[randomThief].SmallMove=true;
            }
            randomThief = Random.Range(0,ListThief1.Count);
            randomMove = Random.Range(0,2);
            compteur = cooldown;
            }
    }
}

}
