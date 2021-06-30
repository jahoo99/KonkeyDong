using UnityEngine;
using System.Collections;

public class AnimBehaviour : MonoBehaviour
{
	private int _negative = -1;
	private Animator _anim;
	void Start()
	{
		_anim = gameObject.GetComponent<Animator>();
		_anim.Play("Animation", _negative, float.NegativeInfinity);
	}

	
	

	public void Reverse()
	{


		_anim.SetFloat("Direction", _negative);
		_anim.Play("Animation", _negative, float.NegativeInfinity);
		_negative *= -1;
	}
}