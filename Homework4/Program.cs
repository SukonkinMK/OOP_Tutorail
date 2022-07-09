using ClassLibraryBuildings;

Dictionary<int, Building> buildings = Creator.GetCreatedBuildings();
Creator.CreateBuild();
Creator.CreateBuild(30, 9, 180, 5);
foreach(var item in buildings)
{
    Console.WriteLine($"{item.Key} - {item.Value.BuildingInfo()}");
}
Console.WriteLine("Удаляем дом №2");
Creator.RemoveBuild(2);
foreach (var item in buildings)
{
    Console.WriteLine($"{item.Key} - {item.Value.BuildingInfo()}");
}


Console.ReadLine();