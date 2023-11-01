using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BatFly : MonoBehaviour
{
    private Vector3 origPos;//储存位置

    private float elapse;//时间变量

    public float Interval = 0.05f;

    public float Range = 0.05f;
    // Start is called before the first frame update
    void Start()
    {
        origPos = transform.position;
    }

    // Update is called once per frame
    /// <summary>
    ///
    /// 
    /// </summary>
    void Update()
    {
        //经过了多少秒
        elapse += Time.deltaTime;//deltaTime该变量显示了距上一帧所经历的时间值（以秒计算）
        //每经过0.05f，当前位置加随机值，注意清空
        if (elapse > Interval)//
        {
            var pos = transform.position;
            pos.x = origPos.x + Random.Range(-Range, Range);
            pos.y = origPos.y + Random.Range(-Range, Range);
            transform.position = pos;
            elapse = 0.0f;
        }
    }
}
