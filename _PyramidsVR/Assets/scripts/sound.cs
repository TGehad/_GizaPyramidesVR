using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Windows.Speech;
using System.Linq;
using System.Collections.Generic;


public class sound : MonoBehaviour
{
  
   public AudioSource[] audioSourceObject;

  


    void Update()
    {
         
        RaycastHit hit ;

      if(Physics.Raycast(transform.position,transform.forward,out hit)){
         
    
      if(hit.transform.name=="sphinx g")
        {
          
       audioSourceObject[0].Play();

        }
       
        if(hit.transform.name=="Gpyramid g")
        {
          audioSourceObject[0].Stop();
         audioSourceObject[1].Play();

        }
        if(hit.transform.name=="Mpyramid g")
        {
       audioSourceObject[1].Stop();
       audioSourceObject[2].Play();

        }
       if(hit.transform.name=="Spyramid g")
        {
      audioSourceObject[2].Stop();
       audioSourceObject[3].Play();

        }

      }
     }

 }

