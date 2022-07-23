using System.Collections;
using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class Game : MonoBehaviour
{

    private const int NUM_WOOD_PIECES = 4;
    private const int NUM_BRICK_PIECES = 3;
    private const int NUM_WHEAT_PIECES = 4;
    private const int NUM_STONE_PIECES = 3;
    private const int NUM_SHEEP_PIECES = 4;
    private const int NUM_DESERT_PIECES = 1;

    private Piece.Type[] create_pieces_type = { Piece.Type.Wood, Piece.Type.Brick, Piece.Type.Wheat, Piece.Type.Stone, Piece.Type.Sheep, Piece.Type.Desert };
    private int[] create_pieces_amount = { NUM_WOOD_PIECES, NUM_BRICK_PIECES, NUM_WHEAT_PIECES, NUM_STONE_PIECES, NUM_SHEEP_PIECES, NUM_DESERT_PIECES };
    private List<Piece> pieces = new List<Piece>();
    private List<Piece> playable_pieces = new List<Piece>();
    private int[] numbers_up_to_playable_pieces =
    {
        0,1,2,3,4,5,6,7,8,9,10,11,12,13,14,15,16,17
    };
    private int[] numbers = {2,3,3,4,4,5,5,6,6,8,8,9,9,10,10,11,12};


    private void create_board()
    {
        
    }

    private void create_pieces()
    {
        for (int i = 0; i < create_pieces_amount.Length; ++i)
        {
            for (int j = 0; j < create_pieces_amount[i]; ++j)
            {
                Piece piece = new Piece(create_pieces_type[i]);
                pieces.Add(piece); 
                if (create_pieces_type[i] != Piece.Type.Desert)
                {
                    playable_pieces.Add(piece);
                }
            }
        }    
    }

    public void shuffle_array(int[] array)
    {
        System.Random random = new System.Random();
        int n = array.Length;
        while (n > 1)
        {
            n--;
            int i = random.Next(n + 1);
            int temp = array[i];
            array[i] = array[n];
            array[n] = temp;
        }
    }

    private void randomize_piece_numbers()
    {
        int[] random_numbers = numbers_up_to_playable_pieces.ToArray();
        shuffle_array(random_numbers); 
        for (int i = 0; i < playable_pieces.Count; ++i)
        {
            playable_pieces[i].set_number(random_numbers[i]);
        }
    }

    private void randomize_piece_positions()
    {
        
    }

    // Start is called before the first frame update
    void Start()
    {
        create_board();
        create_pieces(); 
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
