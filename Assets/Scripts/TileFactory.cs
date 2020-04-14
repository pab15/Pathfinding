using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TileFactory
{
    private Dictionary<string, Tile> _tiles = new Dictionary<string, Tile>();
    private static TileFactory _instance = null;

    private TileFactory()
    {
        _tiles.Add("OutdoorsGround_0", new Tile() { 
            Name = "Grass",
            Weight = 10
        });
        _tiles.Add("OutdoorsGround_6", new Tile()
        {
            Name = "Road",
            Weight = 5
        });
        _tiles.Add("OutdoorsGround_15", new Tile()
        {
            Name = "Rough_Road",
            Weight = 25
        });
        _tiles.Add("OutdoorsGround_44", new Tile()
        {
            Name = "Lake",
            Weight = 100
        });
        _tiles.Add("OutdoorsGround_29", new Tile()
        {
            Name = "Pond",
            Weight = 50
        });
        _tiles.Add("OutdoorsGround_36", new Tile()
        {
            Name = "Pond_Edge",
            Weight = 25
        });
        _tiles.Add("OutdoorsGround_38", new Tile()
        {
            Name = "Pond_Edge",
            Weight = 25
        });
        _tiles.Add("OutdoorsGround_30", new Tile()
        {
            Name = "Pond_Edge",
            Weight = 25
        });
        _tiles.Add("OutdoorsGround_32", new Tile()
        {
            Name = "Pond_Edge",
            Weight = 25
        });
        _tiles.Add("OutdoorsGround_13", new Tile()
        {
            Name = "Path_Edge",
            Weight = 10
        });
        _tiles.Add("OutdoorsGround_18", new Tile()
        {
            Name = "Path_Edge",
            Weight = 10
        });
        _tiles.Add("OutdoorsGround_20", new Tile()
        {
            Name = "Path_Edge",
            Weight = 10
        });
        _tiles.Add("OutdoorsGround_22", new Tile()
        {
            Name = "Path_Edge",
            Weight = 10
        });
        _tiles.Add("OutdoorsGround_24", new Tile()
        {
            Name = "Path_Edge",
            Weight = 10
        });
        _tiles.Add("OutdoorsGround_25", new Tile()
        {
            Name = "Path_Edge",
            Weight = 10
        });
        _tiles.Add("Generic", new Tile()
        {
            Name = "Unknown",
            Weight = 10
        });
    }

    public static TileFactory GetInstance()
    {
        if(_instance == null)
        {
            _instance = new TileFactory();
        }
        return _instance;
    }

    public Tile GetTile(string tileName)
    {
        if (_tiles.ContainsKey(tileName))
        {
            return _tiles[tileName];
        }
        else
        {
            return _tiles["Generic"];
        }
    }
}
