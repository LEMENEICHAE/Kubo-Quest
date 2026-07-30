using System.Collections.Generic;

namespace Ingredients {
    public class Ingredient {
        public string Name {get; set;}
        public string Path {get; private set;}
        List<ResourceProperty> RscProperties {get; protected set;}

        public Ingredient(string name, string path, List<ResourceProperty> rsList){
            Name = name;
            Path = path;
            RscProperties = rsList;
        }

    }
}