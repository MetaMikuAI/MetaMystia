namespace MetaMystia;

[AutoLog]
public static partial class DLCManager
{

    public static ResourceDataBase localDataBase { get; private set; } = new ResourceDataBase();
    public static ResourceDataBase remoteDataBase { get; private set; } = new ResourceDataBase();
    public static void Initialize()
    {
        localDataBase.LoadResourceIds();
    }

    public static void ClearPeer()
    {
        remoteDataBase.Clear();
    }

    public static bool FoodAvailable(int id) => remoteDataBase.Foods.Contains(id) && localDataBase.Foods.Contains(id);
    public static bool RecipeAvailable(int id) => remoteDataBase.Recipes.Contains(id) && localDataBase.Recipes.Contains(id);
    public static bool BeverageAvailable(int id) => remoteDataBase.Beverages.Contains(id) && localDataBase.Beverages.Contains(id);
    public static bool IngredientAvailable(int id) => remoteDataBase.Ingredients.Contains(id) && localDataBase.Ingredients.Contains(id);
    public static bool CookerAvailable(int id) => remoteDataBase.Cookers.Contains(id) && localDataBase.Cookers.Contains(id); // 注, [-1]空位 厨具已包含
    public static bool ItemAvailable(int id) => remoteDataBase.Items.Contains(id) && localDataBase.Items.Contains(id);
    public static bool IzakayaAvailable(int id) => remoteDataBase.Izakayas.Contains(id) && localDataBase.Izakayas.Contains(id);

    public static bool NormalGuestAvailable(int id) => remoteDataBase.NormalGuests.Contains(id) && localDataBase.NormalGuests.Contains(id);
    public static bool SpecialGuestAvailable(int id) => remoteDataBase.SpecialGuests.Contains(id) && localDataBase.SpecialGuests.Contains(id);


    public static void UpdateRemoteDataBase(ResourceDataBase newDataBase)
    {
        remoteDataBase = newDataBase;
    }
}
