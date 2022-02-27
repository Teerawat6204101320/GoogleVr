using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangAnimator : MonoBehaviour
{
    // Start is called before the first frame update
   public void getAnimatorDefeate(){
       this.GetComponent<Animator>().Play("Chicken Dance");
   }
    public void getAnimatorRumba(){
       this.GetComponent<Animator>().Play("Snake Hip Hop Dance");
   }

    public void getAnimatorstand(){
       this.GetComponent<Animator>().Play("mixamo_com");
   }
    public void getAnimatorrun(){
       this.GetComponent<Animator>().Play("mixamo_com1");
   }
}
