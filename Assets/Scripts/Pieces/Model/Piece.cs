using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Piece : MonoBehaviour
{

    public enum Type
    {
        Brick,
        Wood,
        Stone,
        Sheep,
        Wheat,
        Desert
    }

    public Color get_color()
    {
        switch (this.type) {
            case Type.Brick:
                return new Color(0.75f, 0.2f, 0, 1);
            case Type.Wood:
                return new Color(0, 0.35f, 0, 1);
            case Type.Stone:
                return new Color(0.4f, 0.4f, 0.4f, 1);
            case Type.Wheat:
                return new Color(1, 0.8f, 0, 1);
            case Type.Sheep:
                return new Color(0.75f, 1, 0.5f, 1);
            default:
                return new Color(1, 1, 1, 1);
        }
    }

    private GameObject view;
    private int number;
    private Type type;
    private Vertex[] verts;
    private Edge[] edges;
    private List<Piece> adjacent_pieces = new List<Piece>();

    private const int NUM_EDGES = 6;
    private const int NUM_VERTS = 6;
    public Piece(Type type)
    {
        this.type = type;
        verts = new Vertex[NUM_VERTS];
        edges = new Edge[NUM_EDGES];
        for (int i = 0; i < NUM_VERTS; ++i)
        {
            verts[i] = new Vertex();
        }
        for (int i = 0; i < NUM_EDGES; ++i)
        {
            int v1_ind = i;
            int v2_ind = (i + 1) % NUM_VERTS;
            edges[i] = new Edge(verts[v1_ind], verts[v2_ind]);
        }
    }

    public Type get_type()
    {
        return type;
    }
    public void add_piece(Piece piece)
    {
        adjacent_pieces.Add(piece);
    }

    public void set_number(int number)
    {
        this.number = number;
    }


    public void set_view(GameObject view)
    {
        this.view = view;
    }

    public GameObject get_view()
    {
        return this.view;
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
