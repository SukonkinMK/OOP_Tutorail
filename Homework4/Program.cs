using Homework4;

Building building1 = new Building();
Building building2 = new Building(30,9,180,5);

//тест фабрики
Creator.CreateBuild();
Creator.CreateBuild(30, 9, 180, 5);
Dictionary<int, Building> buildings = Creator.GetCreatedBuildings();
Creator.RemoveBuild(4);

Console.ReadLine();