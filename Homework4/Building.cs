namespace Homework4;

public class Building
{
    static int CurrentAmountOfBuildings = 0;

    /// <summary>
    /// Подсчет уникального номера зданий
    /// </summary>
    /// <returns>уникальный номер здания</returns>
    static int IncreaseBuildingNumber()
    {
        CurrentAmountOfBuildings++;
        return CurrentAmountOfBuildings;
    }

    public int Id { get; private set; }
    public double Height { get; set; }
    public int NumberOfFloors { get; set; }
    public int NumberOfFlats { get; set; }
    public int NumberOfEntrances { get; set; }

    /// <summary>
    /// Вычисление высоты этажа
    /// </summary>
    /// <returns>высота каждого этажа здания</returns>
    public double HeightOfFloor()
    {
        return this.Height / this.NumberOfFloors;
    }

    /// <summary>
    /// Вычисление количества квартир в подъезде
    /// </summary>
    /// <returns>количество квартир в каждом подъезде</returns>
    public int FlatsInEntrance()
    {
        return this.NumberOfFlats / this.NumberOfEntrances;
    }

    /// <summary>
    /// Вычисление количества квартир на этаже
    /// </summary>
    /// <returns>Количество квартир на каждом этаже</returns>
    public int FlatsOnFloor()
    {
        return FlatsInEntrance() / this.NumberOfFloors;
    }

    public Building() : this(3, 1, 1, 1) { }

    public Building(int heigth, int floors, int flats, int entrances)
    {
        this.Id = IncreaseBuildingNumber();
        this.Height = heigth;
        this.NumberOfFloors = floors;
        this.NumberOfFlats = flats;
        this.NumberOfEntrances = entrances;
    }
}
