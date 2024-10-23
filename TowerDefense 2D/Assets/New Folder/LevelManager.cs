using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManager : MonoBehaviour
{
    public static LevelManager main;//Armazena uma instância estática do LevelManager, permitindo que outras classes acessem facilmente as informações do nível

    public Transform PontoInicial;//Representa o ponto inicial do caminho, ou seja, o local onde os inimigos começam a se mover
    public Transform[] path;//Um array de Transform que define o caminho que os inimigos devem seguir, com cada elemento representando um waypoint

    private void Awake()
    {
       main = this;// garantir que a instância do LevelManager seja atribuída à variável estática principal. Isso estabelece um ponto de acesso global para o LevelManager, permitindo que outras partes do jogo acessem seus dados (como o caminho dos inimigos) sem precisar criar novas instâncias ou passar referências manualmente

    }

}
