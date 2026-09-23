using UnityEngine;
using UnityEngine.UI;

public class TricarGrupo : MonoBehaviour
{
    [Header("Botão")]
    [SerializeField] private Button botaoTrocar;

    [Header("Grupos")]
    [SerializeField] private GameObject grupoA;
    [SerializeField] private GameObject grupoB;

    private bool mostrandoGrupoA = true;

    private void Start()
    {
        grupoA.SetActive(true);
        grupoB.SetActive(false);

        botaoTrocar.onClick.AddListener(Trocar);
    }

    public void Trocar()
    {
        mostrandoGrupoA = !mostrandoGrupoA;

        grupoA.SetActive(mostrandoGrupoA);
        grupoB.SetActive(!mostrandoGrupoA);
    }
}
