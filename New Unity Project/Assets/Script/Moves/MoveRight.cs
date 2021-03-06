﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveRight : MonoBehaviour, IMoveBehaviour {

	private GameObject player;
	private funcoesDeMovimento funcs;
	private Vector3 direction = new Vector3(2f, 0, 0);

	public MoveRight(GameObject player){

		this.player = player;
		funcs = player.GetComponent<funcoesDeMovimento>();
	}

	public IMoveBehaviour GetMove(GameObject player){

		return new MoveRight(player);
	}
    
<<<<<<< HEAD
    public void Execute(){		
		funcs.AndarComecou(player);
=======
    public void Execute(){

		funcs.AndarComecou();
>>>>>>> parent of dc9bdad... Mudanças ULTRA mega SUPER Radicais
    	Vector3 pos = player.transform.position + direction;
        Collider2D col2d = Physics2D.OverlapBox(pos, new Vector2(1f, 1f), 1f, 1);
        bool isPossible = true;
        player.GetComponent<SpriteRenderer>().flipX = true;

    	if(col2d == null || ((col2d != null && (col2d.gameObject.tag == "Move" || col2d.gameObject.tag == "Box")))){

	    	if(!player.GetComponent<GridGravity>().onAir || (player.GetComponent<GridGravity>().onAir && !player.GetComponent<GridGravity>().hasMovedOnAir)){

	    		if(col2d != null && col2d.gameObject.tag == "Box"){
	        		isPossible = col2d.gameObject.GetComponent<BoxBehaviour>().MoveToDirection(direction);
	        	}

	        	if(isPossible){
		        	player.GetComponent<PlayerMovement>().movePoint.position += direction;
		        	player.GetComponent<GridGravity>().hasMovedOnAir = true;
		        }
	        }
	    }
    }

    public void PseudoUpdate(){}
}