using Ingredients;
using Enums;
using System.Collections.Generic;

public class IngredientRegistry {
    //SMALL
    public static readonly Ingredient SUNBURST_POD = new Ingredient("Sunburst Pod",
    "src/assets/icons/ingredients/sunburst_pod.png",
    new List<ResourceProperty>{ResourceProperty.HARD, ResourceProperty.YELLOW,
    ResourceProperty.SEED, ResourceProperty.COMMON});

    public static readonly Ingredient CITRON_DROP = new Ingredient("Citron Drop",
    "src/assets/icons/ingredients/citron_drop.png",
    new List<ResourceProperty>{ResourceProperty.SOFT, ResourceProperty.GREEN,
    ResourceProperty.FRUIT, ResourceProperty.RARE});

    public static readonly Ingredient BLOODY_MUSHROOM = new Ingredient("Bloody Mushroom",
    "src/assets/icons/ingredients/bloody_mushroom.png",
    new List<ResourceProperty>{ResourceProperty.SOFT, ResourceProperty.RED,
    ResourceProperty.FUNGUS, ResourceProperty.COMMON});

    public static readonly Ingredient PINK_CHERRY = new Ingredient("Pink Cherry",
    "src/assets/icons/ingredients/pink_cherry.png",
    new List<ResourceProperty>{ResourceProperty.SOFT, ResourceProperty.MAGENTA,
    ResourceProperty.FRUIT, ResourceProperty.RARE});

    public static readonly Ingredient FOSSILISED_BERRY = new Ingredient("Fossilised Berry",
    "src/assets/icons/ingredients/fossilised_berry.png",
    new List<ResourceProperty>{ResourceProperty.HARD, ResourceProperty.GRAY,
    ResourceProperty.MINERAL, ResourceProperty.COMMON});

    public static readonly Ingredient CULL_CARROT = new Ingredient("Cull Carrot",
    "src/assets/icons/ingredients/cull_carrot.png",
    new List<ResourceProperty>{ResourceProperty.HARD, ResourceProperty.BLUE,
    ResourceProperty.ROOT, ResourceProperty.RARE});

    //BIG
    public static readonly Ingredient HONEYCOMB = new Ingredient("Honeycomb",
    "src/assets/icons/ingredients/honeycomb.png",
    new List<ResourceProperty>{ResourceProperty.HARD; ResourceProperty.YELLOW,
    ResourceProperty.FRUIT, ResourceProperty.RARE});

    //public static readonly Ingredient
}