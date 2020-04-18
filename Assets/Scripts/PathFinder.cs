using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class PathFinder
{
    public static TilePath DiscoverPath(Tilemap map, Tilemap objects, Vector3Int start, Vector3Int end)
    {
        //you will return this path to the user.  It should be the shortest path between
        //the start and end vertices 
        TilePath discoveredPath = new TilePath();

        //TileFactory is how you get information on tiles that exist at a particular vector's
        //coordinates
        TileFactory tileFactory = TileFactory.GetInstance();

        //This is the priority queue of paths that you will use in your implementation of
        //Dijkstra's algorithm
        PriortyQueue<TilePath> pathQueue = new PriortyQueue<TilePath>();

        //You can slightly speed up your algorithm by remembering previously visited tiles.
        //This isn't strictly necessary.
        Dictionary<Vector3Int, int> discoveredTiles = new Dictionary<Vector3Int, int>();

        if (objects == null)
        {
            Debug.Log("Objects layer is null");
        }

        //quick sanity check
        if (map == null || objects == null || start == null || end == null)
        {
            return discoveredPath;
        }

        //This is how you get tile information for a particular map location
        //This gets the Unity tile, which contains a coordinate (.Position)
        var startingMapLocation = map.GetTile(start);
        var startingMapObsticle = objects.GetTile(start);
        //And this converts the Unity tile into an object model that tracks the
        //cost to visit the tile.
        var startingTile = tileFactory.GetTile(startingMapLocation.name);
        if (startingMapObsticle != null)
        {
            var startingObject = tileFactory.GetTile(startingMapObsticle.name);
            startingTile.Position = start;
            startingTile.Weight = startingTile.Weight + startingObject.Weight;
        }
        else
        {
            int startingObjWeight = 0;
            startingTile.Position = start;
            startingTile.Weight = startingTile.Weight + startingObjWeight;
            Debug.Log(startingTile.Weight);
        }
        
        //Any discovered path must start at the origin!
        discoveredPath.AddTileToPath(startingTile);

        //This adds the starting tile to the PQ and we start off from there...
        pathQueue.Enqueue(discoveredPath);
        bool found = false;

        int count = 0;
        while(found == false && pathQueue.IsEmpty() == false)
        {
            //TODO: Implement Dijkstra's algorithm!

            // Dequeue Top, 
            TilePath current_path = new TilePath(pathQueue.GetFirst());
            pathQueue.Dequeue();
            Tile current_tile = new Tile(current_path.GetMostRecentTile());
            Vector3Int current_position = new Vector3Int(current_tile.Position.x, current_tile.Position.y, current_tile.Position.z);

            List<Vector3Int> adjacent_tiles = new List<Vector3Int>();
            adjacent_tiles.Add(new Vector3Int(current_position.x, current_position.y + 1, current_position.z));
            adjacent_tiles.Add(new Vector3Int(current_position.x, current_position.y - 1, current_position.z));
            adjacent_tiles.Add(new Vector3Int(current_position.x + 1, current_position.y, current_position.z));
            adjacent_tiles.Add(new Vector3Int(current_position.x - 1, current_position.y, current_position.z));
            for (int i = 0; i < adjacent_tiles.Count; i++)
            {
                TilePath new_path = new TilePath(current_path);
                Vector3Int neighbor_position = new Vector3Int(adjacent_tiles[i].x, adjacent_tiles[i].y, adjacent_tiles[i].z);
                //Get Neighbor node and set equal to visited_node
                int objectWeight = 0;
                var visited_node_location = map.GetTile(neighbor_position);
                var visited_node_object = objects.GetTile(neighbor_position);
                if (visited_node_location == null)
                {
                    continue;
                }
                if (visited_node_object != null)
                {
                    var visited_object = tileFactory.GetTile(visited_node_object.name);
                    objectWeight = visited_object.Weight;
                    if (objectWeight == -1)
                    {
                        continue;
                    }
                }
                var visited_node = tileFactory.GetTile(visited_node_location.name);
                if (visited_node.Weight == -1)
                {
                    continue;
                }
                visited_node.Position = neighbor_position;
                visited_node.Weight = visited_node.Weight + objectWeight;
                if (visited_node.Position == end)
                {
                    new_path.AddTileToPath(visited_node);
                    discoveredPath = new_path;
                    found = true;
                    break;
                }
                else if (discoveredTiles.ContainsKey(neighbor_position) == false)
                {
                    new_path.AddTileToPath(visited_node);
                    pathQueue.Enqueue(new_path);
                    discoveredTiles.Add(neighbor_position, 1);
                    count++;
                }
            }
        }
        Debug.Log(discoveredPath.Weight);
        return discoveredPath;
    }
}
