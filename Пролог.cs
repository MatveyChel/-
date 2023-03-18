using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tanks2 : MonoBehaviour
{
    public int armor = 1;
    public float speed = 0.3f;
    public int level = 1;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Создаём переменную вида Vector3 и сохраняем в неё позицию NPC
        Vector3 newPosition = transform.position;

        //Меняем позицию NPC по оси z согласно скорости NPC и времени между кадрами
        newPosition.x += speed * Time.deltaTime*-1;

        //Меняем позицию NPC на новое значение, рассчитанное выше
        transform.position = newPosition;
    }
}
