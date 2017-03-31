using System.Linq;
using System.Text;

namespace ApplicationParser
{
    public static class Writer
    {
        public static string WriteObjectTypeGuids(this Application app)
        {
            var str = new StringBuilder();
            str.AppendLine($"\t{GetClass("ObjectTypeGuids")}");
            str.AppendLine("\t{");
            foreach (var obj in app.Objects)
            {
                str.AppendLine($"\t\t{GetString(obj)}");
            }
            str.AppendLine("\t}");
            return str.ToString();
        }
        public static string WriteObjectGuids(this Application app)
        {
            var str = new StringBuilder();
            foreach (var obj in app.Objects)
            {
                str.AppendLine($"\t{GetClass(obj.Name + "Guids")}");
                str.AppendLine("\t{");
                foreach (var field in obj.Fields)
                {
                    str.AppendLine($"\t\t{GetString(field)}");
                }
                str.AppendLine("\t}");
            }
            return str.ToString();
        }
        public static string WriteChoiceGuids(this Application app)
        {
            var str = new StringBuilder();
            foreach (var obj in app.Objects)
            {
                foreach (var field in obj.Fields.Where(x => x.Choices.Any()))
                {
                    str.AppendLine($"\t{GetClass(field.Name + "Guids")}");
                    str.AppendLine("\t{");
                    foreach (var choice in field.Choices)
                    {
                        str.AppendLine($"\t\t{GetString(choice)}");
                    }
                    str.AppendLine("\t}");
                }
            }
            return str.ToString();
        }
        public static string WriteTabGuids(this Application app)
        {
            var str = new StringBuilder();
            str.AppendLine($"\t{GetClass("TabGuids")}");
            str.AppendLine("\t{");
            foreach (var tab in app.Tabs)
            {
                str.AppendLine($"\t\t{GetString(tab)}");
            }
            str.AppendLine("\t}");
            return str.ToString();
        }

        #region private parts
        private static string GetString(Artifact obj)
        {
            return $"public const string {obj.Name} = \"{obj.Guid}\";";
        }
        private static string GetClass(string name)
        {
            return $"public static class {name}";
        }
        #endregion

    }
}
