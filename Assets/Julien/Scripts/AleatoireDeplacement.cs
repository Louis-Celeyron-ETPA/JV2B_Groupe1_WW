using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Cunegonde
{
public class AleatoireDeplacement : MonoBehaviour
{

    public int test = 0;
    public int chrono = 7600;
    public float speed = 0.02f;
    public float time = 1f;
    public float sensitivity = 1.5f;
    public KeyCode avance;
    public KeyCode recule;
    public bool JaiAttendu;
    public bool OnFaitUnChoix;
    public float pourcentage = 0f;
    public int VariableTemporaireDeplacement;
    public Vector3 MDRjesaistoujourspas;
    Vector3 targetPosition;



        // Start is called before the first frame update
        void Start()
    {
            HonnetementJSP();
    }
        
    // Update is called once per frame
    void Update()
    {

            Debug.Log(VariableTemporaireDeplacement);
        transform.position = Vector3.MoveTowards(transform.position, targetPosition, speed);

    }

    public void HonnetementJSP()
        {
            if (chrono > 1 || OnFaitUnChoix == true)
            {
                OnFaitUnChoix = false;
                AleatoireDeplacementCapsule();
                StartCoroutine(Attente());
            }
        }
           
    


    
        public void AleatoireDeplacementCapsule()
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



        public IEnumerator Attente()
        {
            //Wait for 2 seconds
            yield return new WaitForSeconds(2.5f);
            OnFaitUnChoix = true;

            HonnetementJSP();
        }
        
    }
}
