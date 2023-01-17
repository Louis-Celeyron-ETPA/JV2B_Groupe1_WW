using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Laury
{

    public class Poker : MonoBehaviour
    {
        public List<Cartes> cartes;
        public int currentIndex;
        public int ChoixCarte;
        private int aleatoire;
        public Material Carte1, Carte2, Carte3, Carte4;
        public MeshRenderer CarteImite;
        void Start()
        {
            SelectionCarte(0);
            aleatoire = Random.Range(1, 5);
            print(aleatoire);
            ChoixCarte = aleatoire;
            AfficheCarte();
        }
        void Update()
        {
            

            if(Input.GetKeyDown(KeyCode.RightArrow))
            {
                if (currentIndex == 3){ currentIndex = -1; }
                SelectionCarte(currentIndex + 1); 
            }
            if (Input.GetKeyDown(KeyCode.LeftArrow))
            {
                if (currentIndex == 0) { currentIndex = 4; }
                SelectionCarte(currentIndex - 1); 
            }
        }
        public void SelectionCarte(int index)
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
        public void AfficheCarte()
        {
            if (ChoixCarte == 1)
            {
                CarteImite.material = Carte1;
            }
            if (ChoixCarte == 2)
            {
                CarteImite.material = Carte2;
            }
            if (ChoixCarte == 3)
            {
                CarteImite.material = Carte3;
            }
            if (ChoixCarte == 4)
            {
                CarteImite.material = Carte4;
            }
        }
    }
}
