using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    // Fonction jouer à l'appui du bouton
    public void BoutonJouer()
    {
        SceneManager.LoadScene(1);
    }
}
