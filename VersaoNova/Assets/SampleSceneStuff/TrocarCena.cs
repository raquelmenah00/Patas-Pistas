using UnityEngine;
using UnityEngine.SceneManagement; // Necess�rio para trocar de cena

public class TrocarCena : MonoBehaviour
{
    public void MudarParaEncaixarPecas() // O nome precisa ser exatamente esse
    {
        SceneManager.LoadScene("EncaixarPecas"); // Nome exato da cena
    }
}
