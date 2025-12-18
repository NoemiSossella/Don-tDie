using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeSceneAtPointB : MonoBehaviour
{
    public Transform puntoB;
    public float distanzaMinima = 0.2f;
    public string nomeScenaDaCaricare;

    private bool scenaCambiata = false;

    void Update()
    {
        if (scenaCambiata || puntoB == null) return;

        float distanza = Vector2.Distance(transform.position, puntoB.position);

        if (distanza <= distanzaMinima)
        {
            scenaCambiata = true;
            SceneManager.LoadScene(nomeScenaDaCaricare);
        }
    }
}