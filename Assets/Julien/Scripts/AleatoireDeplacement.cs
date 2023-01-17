using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Cunegonde
{
public class AleatoireDeplacement : MonoBehaviour
{
    //************************************ INITIALISATION DES VARIABLES ************************************

        public int chrono = 760;
    public float speed = 0.02f;
    public KeyCode avance;
    public KeyCode recule;
    public bool JaiAttendu;
    public bool OnFaitUnChoix;
    public int VariableTemporaireDeplacement;
    Vector3 targetPosition;


        //************************************ ON LANCE LA FONCTION AU DEMARRAGE ************************************
        // Start is called before the first frame update
        void Start()
    {
            VerificationFin();
    }

        //************************************ MISE EN PLACE DU CHRONOMETRE ************************************
        // Update is called once per frame
        void Update()
    {

            if (chrono > 1)
            {
                chrono--;
            }

            Debug.Log(VariableTemporaireDeplacement);
        transform.position = Vector3.MoveTowards(transform.position, targetPosition, speed);

    }

        //************************************ VERIFICATION SI LE MINIGAME EST FINI, SINON, ON RELANCE ************************************
        public void VerificationFin()
        {
            if (chrono > 1 || OnFaitUnChoix == true)
            {
                chrono--;
                OnFaitUnChoix = false;
                AleatoireDeplacementCapsule();
                StartCoroutine(Attente());
            }
        }





        //************************************ DEPLACEMENT ALEATOIRE DE LA CAPSULE ************************************
        public void AleatoireDeplacementCapsule()
        {

            if (chrono > 1)
            {
                var tempVector = transform.position;
                if (transform.position.z <= -7)
                    {
                        VariableTemporaireDeplacement = Random.Range(2, 4);
                    }

                else if (transform.position.z >= 7)
                    {
                        VariableTemporaireDeplacement = Random.Range(1, 4);

                        if (VariableTemporaireDeplacement == 2)
                        {
                            VariableTemporaireDeplacement = 1;
                        }

                    }
                else
                    {
                        VariableTemporaireDeplacement = Random.Range(1, 4);
                    }

                if (VariableTemporaireDeplacement == 1)
                    {
                        Debug.Log("Je vais à gauche");
                        targetPosition = new Vector3(transform.position.x, transform.position.y, transform.position.z - 4);
                        JaiAttendu = false;
                    }
                else if (VariableTemporaireDeplacement == 2)
                    {
                        targetPosition = new Vector3(transform.position.x, transform.position.y, transform.position.z + 4);
                        Debug.Log("Je vais à droite");
                        JaiAttendu = false;
                    }
                else if (VariableTemporaireDeplacement == 3 && JaiAttendu == false)
                    {
                        Debug.Log("J'attends");
                        targetPosition = new Vector3(transform.position.x, transform.position.y, transform.position.z);
                        JaiAttendu = true;
                    }
                else if (VariableTemporaireDeplacement == 3 && JaiAttendu == true)
                    {
                        VariableTemporaireDeplacement = Random.Range(1, 3);

                        if (VariableTemporaireDeplacement == 1)
                        {
                            Debug.Log("Je vais à gauche");
                            targetPosition = new Vector3(transform.position.x, transform.position.y, transform.position.z - 4);
                            JaiAttendu = false;
                        }
                        else if (VariableTemporaireDeplacement == 2)
                        {
                            targetPosition = new Vector3(transform.position.x, transform.position.y, transform.position.z + 4);
                            Debug.Log("Je vais à droite");
                            JaiAttendu = false;
                        }
                    }
                else if (VariableTemporaireDeplacement == 4)
                    {
                        Debug.Log("là y'a un problème si ça fait ça");
                    }

                transform.position = new Vector3(Mathf.Clamp(tempVector.x, -8, 8), tempVector.y, tempVector.z);

            }
        }


        //************************************ INITIALISATION DE MON ATTENTE ************************************
        public IEnumerator Attente()
        {
            //Wait for 2 seconds
            yield return new WaitForSeconds(2.5f);
            OnFaitUnChoix = true;

            VerificationFin();
        }
        //************************************************************************

    }
}
