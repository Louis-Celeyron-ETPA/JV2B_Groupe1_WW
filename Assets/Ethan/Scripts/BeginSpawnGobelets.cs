using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace BananaLover
{
    public class BeginSpawnGobelets : MonoBehaviour
    {
        [SerializeField]
        private GameObject spawnGobelets;
        [SerializeField]
        private GameObject gobelet;

        [SerializeField]
        private float max;
        float maxI;
        float maxJ;
        float offsetG = 0f;

        // Start is called before the first frame update
        void Start()
        {
            // Augmentation du nombre de gobelets en fonction de la difficulté
            //max = ManagerManager.DifficultyManager.GetDifficulty() + 4;
            maxI = max;
            maxJ = max;

            for (int i = 0; i < maxI; i++)
            {
                for (int j = 0; j < maxJ; j++)
                {
                    GameObject actualGobelet = Instantiate(gobelet, new Vector3(-max/5.0f + spawnGobelets.transform.position.x + (j / 2f) + offsetG, spawnGobelets.transform.position.y + (i / 1.5f), spawnGobelets.transform.position.z), Quaternion.identity) as GameObject;
                    actualGobelet.transform.eulerAngles += new Vector3(90, 0, 0);
                }
                maxJ -= 1;
                offsetG += 0.25f;
            }
        }

        // Update is called once per frame
        void Update()
        {

        }
    }
}
