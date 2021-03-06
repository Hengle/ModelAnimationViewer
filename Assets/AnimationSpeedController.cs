﻿using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class AnimationSpeedController : MonoBehaviour
{
	public Text speed;

	void Start()
	{
		speed.text = "1";
	}

	public void OnValueChange (Slider slider)
	{
		Animator animator = GetComponentInChildren<Animator>();
		animator.speed = (slider.value - 0.5f) * 4;
	}

	public void OnAdd()
	{
		Animator animator = GetComponentInChildren<Animator>();
		animator.speed += 0.5f;
		speed.text = animator.speed + "";
	}

	public void OnMinus()
	{
		Animator animator = GetComponentInChildren<Animator>();
		animator.speed -= 0.5f;
		speed.text = animator.speed + "";
	}

	public void OnAnimationChange()
	{
		speed.text = "1";
    }
}