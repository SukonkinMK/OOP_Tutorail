namespace Homework4;

public static class Creator
{
    private static Dictionary<int, Building> buildings = new Dictionary<int, Building>();
    public static Dictionary<int, Building> GetCreatedBuildings()
    {
        return buildings;
    }
    static public void CreateBuild() 
    {
        Building building =  new Building();
        buildings.Add(building.Id, building);
    }
    static public void CreateBuild(int heigth, int floors, int flats, int entrances)
    {
        Building building = new Building(heigth, floors, flats, entrances);
        buildings.Add(building.Id, building);
    }

    public static void RemoveBuild(int key)
    {
        buildings.Remove(key);
    }
}
