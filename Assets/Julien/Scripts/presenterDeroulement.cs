using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Cunegonde
{
    public class presenterDeroulement : MonoBehaviour
    {
        public int choixDemande;
        public int avantFin = 0;



        // Start is called before the first frame update
        void Start()
        {




            GameObject.Find("FlecheHaut").transform.position = new Vector3(0, 0, 0);
            GameObject.Find("FlecheBas").transform.position = new Vector3(0, 0, 0);
            GameObject.Find("FlecheDroite").transform.position = new Vector3(0, 0, 0);
            GameObject.Find("FlecheGauche").transform.position = new Vector3(0, 0, 0);
            GameObject.Find("Bouton").transform.position = new Vector3(0, 0, 0);

            GameObject.Find("BatonUn").transform.position = new Vector3(0, 0, 0);
            GameObject.Find("BatonDeux").transform.position = new Vector3(0, 0, 0);
            GameObject.Find("BatonTrois").transform.position = new Vector3(0, 0, 0);

            GameObject.Find("ecritureTableau").transform.position = new Vector3(0, 0, 0);



            FonctionChoix();



        }

        // Update is called once per frame
        void Update()
        {

        }
        public void FonctionChoix()
        {
            choixDemande = Random.Range(1, 6);
            Debug.Log(choixDemande);

            if (choixDemande == 1)
            {
                Debug.Log("Appuyer sur le bouton.png");
                GameObject.Find("Bouton").transform.position = new Vector3(-0.8423f, 1.523f, 4.146f);
                GameObject.Find("BatonUn").transform.position = new Vector3(-0.8451f, 1.686f, 4.1381f);
                GameObject.Find("BatonDeux").transform.position = new Vector3(-0.7448f, 1.686f, 4.1381f);
                GameObject.Find("BatonTrois").transform.position = new Vector3(-0.9372f, 1.6894f, 4.1381f);
            }
            else if (choixDemande == 2)
            {
                Debug.Log("Appuyer sur la flèche haut.png");
                GameObject.Find("FlecheHaut").transform.position = new Vector3(-0.836f, 1.48f, 4.129f);
            }
            else if (choixDemande == 3)
            {
                Debug.Log("Appuyer sur la flèche bas.png");
                GameObject.Find("FlecheBas").transform.position = new Vector3(-0.84f, 1.685f, 4.129f);
            }
            else if (choixDemande == 4)
            {
                Debug.Log("Appuyer sur la flèche droite.png");
                GameObject.Find("FlecheDroite").transform.position = new Vector3(-0.94f, 1.587f, 4.129f);
            }
            else if (choixDemande == 5)
            {
                Debug.Log("Appuyer sur la flèche gauche.png");
                GameObject.Find("FlecheGauche").transform.position = new Vector3(-0.739f, 1.587f, 4.129f);
            }
        }
        public void FonctionExecution(int choixEntre)
        {
            if (choixDemande == choixEntre)
            {
                Debug.Log("QTE réussi.png");
                avantFin += 1;

                GameObject.Find("FlecheHaut").transform.position = new Vector3(0, 0, 0);
                GameObject.Find("FlecheBas").transform.position = new Vector3(0, 0, 0);
                GameObject.Find("FlecheDroite").transform.position = new Vector3(0, 0, 0);
                GameObject.Find("FlecheGauche").transform.position = new Vector3(0, 0, 0);
                GameObject.Find("Bouton").transform.position = new Vector3(0, 0, 0);

                GameObject.Find("BatonUn").transform.position = new Vector3(0, 0, 0);
                GameObject.Find("BatonDeux").transform.position = new Vector3(0, 0, 0);
                GameObject.Find("BatonTrois").transform.position = new Vector3(0, 0, 0);

                if (avantFin < 4)
                {
                    StartCoroutine(Attente());
                }
                else
                {
                    Debug.Log("Victoire !");
                }
            }
            else if (choixDemande != choixEntre)
            {
                Debug.Log("-1 vie");

                GameObject.Find("FlecheHaut").transform.position = new Vector3(0, 0, 0);
                GameObject.Find("FlecheBas").transform.position = new Vector3(0, 0, 0);
                GameObject.Find("FlecheDroite").transform.position = new Vector3(0, 0, 0);
                GameObject.Find("FlecheGauche").transform.position = new Vector3(0, 0, 0);
                GameObject.Find("Bouton").transform.position = new Vector3(0, 0, 0);

                GameObject.Find("BatonUn").transform.position = new Vector3(0, 0, 0);
                GameObject.Find("BatonDeux").transform.position = new Vector3(0, 0, 0);
                GameObject.Find("BatonTrois").transform.position = new Vector3(0, 0, 0);

                if (avantFin < 4)
                {
                    StartCoroutine(Attente()); ;
                }
            }
        }

        public IEnumerator Attente()
        {
            //Wait for 1 seconds
            yield return new WaitForSeconds(1);

            GameObject.Find("ecritureTableau").transform.position = new Vector3(-0.152f, 2.095f, 4.877f);

            int tempsAttente = Random.Range(1, 3);

            yield return new WaitForSeconds(tempsAttente);

            GameObject.Find("ecritureTableau").transform.position = new Vector3(0, 0, 0);

            FonctionChoix();


        }

    }
}

