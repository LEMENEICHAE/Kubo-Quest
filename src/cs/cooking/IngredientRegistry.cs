using Ingredients;
using ResourceProperties;
using Enums;
using System.Collections.Generic;

public class IngredientRegistry {
    //SMALL
    public static readonly Ingredient SUNBURST_POD = new Ingredient("Sunburst Pod",
    "src/assets/icons/ingredients/sunburst_pod.png",
    new List<ResourceProperty>{ResourceProperty.HARD, ResourceProperty.YELLOW,
    ResourceProperty.SEED, ResourceProperty.COMMON, ResourceProperty.SAVORY});

    public static readonly Ingredient LIME_DROP = new Ingredient("Lime Drop",
    "src/assets/icons/ingredients/lime_drop.png",
    new List<ResourceProperty>{ResourceProperty.SOFT, ResourceProperty.GREEN,
    ResourceProperty.FRUIT, ResourceProperty.RARE, ResourceProperty.SOUR});

    public static readonly Ingredient BLOODY_MUSHROOM = new Ingredient("Bloody Mushroom",
    "src/assets/icons/ingredients/bloody_mushroom.png",
    new List<ResourceProperty>{ResourceProperty.SOFT, ResourceProperty.RED,
    ResourceProperty.FUNGUS, ResourceProperty.COMMON, ResourceProperty.SPICY});

    public static readonly Ingredient PINK_CHERRY = new Ingredient("Pink Cherry",
    "src/assets/icons/ingredients/pink_cherry.png",
    new List<ResourceProperty>{ResourceProperty.SOFT, ResourceProperty.MAGENTA,
    ResourceProperty.FRUIT, ResourceProperty.RARE, ResourceProperty.SWEET});

    public static readonly Ingredient FOSSILISED_BERRY = new Ingredient("Fossilised Berry",
    "src/assets/icons/ingredients/fossilised_berry.png",
    new List<ResourceProperty>{ResourceProperty.HARD, ResourceProperty.GRAY,
    ResourceProperty.MINERAL, ResourceProperty.COMMON, ResourceProperty.SAVORY});

    public static readonly Ingredient CULL_CARROT = new Ingredient("Cull Carrot",
    "src/assets/icons/ingredients/cull_carrot.png",
    new List<ResourceProperty>{ResourceProperty.HARD, ResourceProperty.BLUE,
    ResourceProperty.ROOT, ResourceProperty.RARE, ResourceProperty.SOUR});

    //BIG
    public static readonly Ingredient HONEYCOMB = new Ingredient("Honeycomb",
    "src/assets/icons/ingredients/honeycomb.png",
    new List<ResourceProperty>{ResourceProperty.SOFT, ResourceProperty.YELLOW,
    ResourceProperty.FRUIT, ResourceProperty.RARE, ResourceProperty.SWEET});

    public static readonly Ingredient APPLE_SEED = new Ingredient("Apple Seed",
    "src/assets/icons/ingredients/apple_seed.png",
    new List<ResourceProperty>{ResourceProperty.HARD, ResourceProperty.RED,
    ResourceProperty.SEED, ResourceProperty.COMMON, ResourceProperty.SWEET});

    public static readonly Ingredient ALP_CRYSTAL = new Ingredient("Alp Crystal",
    "src/assets/icons/ingredients/alp_crystal.png",
    new List<ResourceProperty>{ResourceProperty.HARD, ResourceProperty.GREEN,
    ResourceProperty.MINERAL, ResourceProperty.COMMON, ResourceProperty.SAVORY});

    public static readonly Ingredient AMBER_NECTAR = new Ingredient("Amber Nectar",
    "src/assets/icons/ingredients/amber_nectar.png",
    new List<ResourceProperty>{ResourceProperty.SOFT, ResourceProperty.MAGENTA,
    ResourceProperty.SLUDGE, ResourceProperty.EPIC, ResourceProperty.SWEET});

    public static readonly Ingredient FROZEN_MELON = new Ingredient("Frozen Melon",
    "src/assets/icons/ingredients/frozen_melon.png",
    new List<ResourceProperty>{ResourceProperty.HARD, ResourceProperty.BLUE,
    ResourceProperty.FRUIT, ResourceProperty.RARE, ResourceProperty.SAVORY});

    public static readonly Ingredient ROOTED_MUSHROOM = new Ingredient("Rooted Mushroom",
    "src/assets/icons/ingredients/rooted_mushroom.png",
    new List<ResourceProperty>{ResourceProperty.SOFT, ResourceProperty.GRAY,
    ResourceProperty.FUNGUS, ResourceProperty.RARE, ResourceProperty.SOUR});

    //LEGENDARY
    public static readonly Ingredient LUX_APPLE = new Ingredient("Lux Apple",
    "src/assets/icons/ingredients/lux_apple.png",
    new List<ResourceProperty>{ResourceProperty.SOFT, ResourceProperty.RAINBOW,
    ResourceProperty.FRUIT, ResourceProperty.LEGENDARY, ResourceProperty.SWEET});

    public static readonly Ingredient GLOWING_HEART = new Ingredient("Glowing Heart",
    "src/assets/icons/ingredients/glowing_heart.png",
    new List<ResourceProperty>{ResourceProperty.HARD, ResourceProperty.RAINBOW,
    ResourceProperty.ROOT, ResourceProperty.LEGENDARY, ResourceProperty.SWEET});
}