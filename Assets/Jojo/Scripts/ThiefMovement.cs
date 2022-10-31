using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Jojo
{

    public class ThiefMovement : MonoBehaviour
    {
        public bool BigMove;
        public bool SmallMove;
        float pourcentageM = 0f;
        float pourcentageM2 = 0f;
        bool FinMove1 = false;
        Vector3 PoseBase;
        Vector3 PoseFin;
        Vector3 PoseBaseP;
        Vector3 PoseFinPB;
        Vector3 PoseFinPS;
        // Start is called before the first frame update
        void Start()
        {
            BigMove = false;
            SmallMove = false;
            PoseBaseP = new Vector3(transform.position.x, transform.position.y, transform.position.z);
            PoseFinPB = new Vector3(transform.position.x + 7, transform.position.y, transform.position.z);
            PoseFinPS = new Vector3(transform.position.x + 3, transform.position.y, transform.position.z);
        }

        // Update is called once per frame
        void Update()
        {
            if (BigMove == true && SmallMove == false)
            {
                if (FinMove1 == false)
                {
                    transform.position = Vector3.Lerp(PoseBaseP, PoseFinPB, pourcentageM);
                    pourcentageM += 0.02f;
                }
                if (pourcentageM >= 1f)
                {
                    pourcentageM = 0f;
                    PoseFin = PoseBaseP;
                    PoseBase = transform.position;
                    FinMove1 = true;
                }
                if (FinMove1 == true)
                {
                    transform.position = Vector3.Lerp(PoseBase, PoseFin, pourcentageM2);
                    pourcentageM2 += 0.02f;
                }
                if (pourcentageM2 >= 1f)
                {
                    pourcentageM2 = 0f;
                    BigMove = false;
                    FinMove1 = false;
                    PoseBase = PoseBaseP;
                    PoseFin = PoseFinPB;
                }
            }
            if (SmallMove == true && BigMove == false)
            {
                if (FinMove1 == false)
                {
                    transform.position = Vector3.Lerp(PoseBaseP, PoseFinPS, pourcentageM);
                    pourcentageM += 0.05f;
                }
                if (pourcentageM >= 1f)
                {
                    pourcentageM = 0f;
                    PoseFin = PoseBaseP;
                    PoseBase = transform.position;
                    FinMove1 = true;
                }
                if (FinMove1 == true)
                {
                    transform.position = Vector3.Lerp(PoseBase, PoseFin, pourcentageM2);
                    pourcentageM2 += 0.05f;
                }
                if (pourcentageM2 >= 1f)
                {
                    pourcentageM2 = 0f;
                    SmallMove = false;
                    FinMove1 = false;
                    PoseBase = PoseBaseP;
                    PoseFin = PoseFinPS;
                }
            }
        }
    }

}
