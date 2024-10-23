using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManager : MonoBehaviour
{
    public static LevelManager main;//Armazena uma inst�ncia est�tica do LevelManager, permitindo que outras classes acessem facilmente as informa��es do n�vel

    public Transform PontoInicial;//Representa o ponto inicial do caminho, ou seja, o local onde os inimigos come�am a se mover
    public Transform[] path;//Um array de Transform que define o caminho que os inimigos devem seguir, com cada elemento representando um waypoint

    private void Awake()
    {
       main = this;// garantir que a inst�ncia do LevelManager seja atribu�da � vari�vel est�tica principal. Isso estabelece um ponto de acesso global para o LevelManager, permitindo que outras partes do jogo acessem seus dados (como o caminho dos inimigos) sem precisar criar novas inst�ncias ou passar refer�ncias manualmente

    }

}
