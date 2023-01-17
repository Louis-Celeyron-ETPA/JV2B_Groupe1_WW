using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Laury
{

    public class Poker : MonoBehaviour
    {
        public List<Cartes> cartes;
        public int currentIndex;

        // Start is called before the first frame update
        void Start()
        {
            SelectNewCard(0);
        }

        // Update is called once per frame
        void Update()
        {
            if(Input.GetKeyDown(KeyCode.RightArrow))
            {
                if (currentIndex == 3){ currentIndex = -1; }
                SelectNewCard(currentIndex + 1); 
            }
            if (Input.GetKeyDown(KeyCode.LeftArrow))
            {
                if (currentIndex == 0) { currentIndex = 4; }
                SelectNewCard(currentIndex - 1); 
            }
        }


        public void SelectNewCard(int index)
        {
            foreach (var card in cartes)
            {
                card.ChangeColor(Color.white);
                card.ResetPosition();
            }

            currentIndex = index;
            cartes[index].ChangeColor(Color.yellow);
            cartes[index].ChangePosition();
        }
    }
}
