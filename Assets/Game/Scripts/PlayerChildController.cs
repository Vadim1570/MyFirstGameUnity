using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class PlayerChildController : MonoBehaviour
{
    public PlayerController player; 
    //private Vector3 moveDir;

    public float watchPlayerDist = 100f; 
    public float speedRotation = 0.1f;
    public float speedMove = 0.1f;
    private Vector3 movement;

    private Rigidbody rb;

    private NavMeshAgent nma;

    #region Animator variables
	Animator anim;
	string animWalk = "Walk";
	string animRun = "Run";
	string animFly = "Run";
	string animEat = "Eat";
	string animTurnhead = "Turn Head";
	#endregion

	#region Audio variables
	AudioManager aud;
	string soundWalk = "Walk";
	string soundRun = "Run";
	string soundFly = "Fly";
	string soundEat = "Eat";
	string soundTurnhead = "Turn Head";	
	#endregion

    void  Start (){
		anim = GetComponent<Animator>();
		aud = FindObjectOfType<AudioManager>();
        nma = GetComponent<NavMeshAgent>();
	}

    void Awake () {
		rb = GetComponent<Rigidbody>();
		//rb.freezeRotation = true;
		//rb.useGravity = false;
	}

    void Update () { 
        anim.SetBool(animWalk, true);
        nma.SetDestination(player.transform.position);
    }
}
