using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class controller : MonoBehaviour
{
    private Animator animator;
    [SerializeField]int possibility;
    
    // Start is called before the first frame update
    void Start()
    {
        animator = this.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
         AnimatorStateInfo info =animator.GetCurrentAnimatorStateInfo(0);
        // 判断动画是否播放完成
        if (info.normalizedTime >= 1f )
        {
            
            if(Random.Range(0,100) < possibility)
            {
            GetComponent<Animator>().SetFloat("Ins", -1);
            
            }

        }
        if(info.normalizedTime <0f)
        {
            if(Random.Range(0,100) < possibility)
            {
            GetComponent<Animator>().SetFloat("Ins", 1);
            
            }
        }

    }


}
