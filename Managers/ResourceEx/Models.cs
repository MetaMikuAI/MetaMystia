using System.Collections.Generic;

namespace MetaMystia.ResourceEx.Models;

public class CharacterConfig
{
    public int id { get; set; }
    public string name { get; set; }
    public string label { get; set; }
    public List<string> descriptions { get; set; }
    public string type { get; set; }
    public List<PortraitConfig> portraits { get; set; }
    public GuestConfig guest { get; set; }
    public CharacterSpriteSetCompactConfig characterSpriteSetCompact { get; set; }
    public string ModRoot { get; set; }
}

public class GuestConfig
{
    public int fundRangeLower { get; set; }
    public int fundRangeUpper { get; set; }
    public List<string> evaluation { get; set; }
    public List<string> conversation { get; set; }
    public List<RequestConfig> foodRequests { get; set; }
    public List<RequestConfig> bevRequests { get; set; }
    public List<int> hateFoodTag { get; set; }
    public List<WeightedTagConfig> likeFoodTag { get; set; }
    public List<WeightedTagConfig> likeBevTag { get; set; }
    public List<SpawnConfig> spawn { get; set; }
}

public class SpawnConfig
{
    public int izakayaId { get; set; }
    public float relativeProb { get; set; }
    public bool onlySpawnAfterUnlocking { get; set; }
    public bool onlySpawnWhenPlaceBeRecorded { get; set; }
}

public class RequestConfig
{
    public int tagId { get; set; }
    public string request { get; set; }
}

public class WeightedTagConfig
{
    public int tagId { get; set; }
    public int weight { get; set; }
}

public class CharacterSpriteSetCompactConfig
{
    public string name { get; set; }
    public List<string> mainSprite { get; set; }
    public List<string> eyeSprite { get; set; }
}

public class PortraitConfig
{
    public int pid { get; set; }
    public string path { get; set; }
}

public class ResourceConfig
{
    public List<CharacterConfig> characters { get; set; }
    public List<DialogPackageConfig> dialogPackages { get; set; }
    public List<IngredientConfig> ingredients { get; set; }
    public List<RecipeConfig> recipes { get; set; }
    public List<FoodConfig> foods { get; set; }
}

public class DialogConfig
{
    public int characterId { get; set; }
    public string characterType { get; set; }
    public int pid { get; set; }
    public string position { get; set; }
    public string text { get; set; }
}

public class DialogPackageConfig
{
    public string name { get; set; }
    public List<DialogConfig> dialogList { get; set; }
}

public class IngredientConfig
{
    public int id { get; set; }
    public string name { get; set; }
    public string description { get; set; }
    public int level { get; set; }
    public int prefix { get; set; }
    public bool isFish { get; set; }
    public bool isMeat { get; set; }
    public bool isVeg { get; set; }
    public int baseValue { get; set; }
    public List<int> tags { get; set; }

    public string spritePath { get; set; }
    public string ModRoot { get; set; }
}

public class RecipeConfig
{
    public int id { get; set; }
    public int foodId { get; set; }
    public GameData.Core.Collections.Cooker.CookerType cookerType { get; set; }
    public float cookTime { get; set; }
    public List<int> ingredients { get; set; }
}

public class FoodConfig
{
    public int id { get; set; }
    public string name { get; set; }
    public string description { get; set; }
    public int level { get; set; }
    public int baseValue { get; set; }
    public List<int> tags { get; set; }
    public List<int> banTags { get; set; }
    public string spritePath { get; set; }
    public string ModRoot { get; set; }
}