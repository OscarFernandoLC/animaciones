using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TransitionAnimImportSettings : MonoBehaviour{
	Animator anim;
    // Start is called before the first frame update
    void Start(){
	anim = GetComponent<Animator>();
        
    }

    // Update is called once per frame
    void Update()
    {
	if(Input.GetKey("w")){
		anim.SetBool("isMove",true);
	}
	if(!Input.GetKey("w")){
		anim.SetBool("isMove",false);
	}

	if(Input.GetKey("e")){
		anim.SetBool("isDancing",true);
	}
	if(!Input.GetKey("e")){
		anim.SetBool("isDancing",false);
	}

	if(Input.GetKey("c")){
		anim.SetBool("isRun",true);
	}
	if(!Input.GetKey("c")){
		anim.SetBool("isRun",false);
	}

        
    }
}
