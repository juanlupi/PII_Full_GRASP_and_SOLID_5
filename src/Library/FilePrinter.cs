using System.IO;

namespace Full_GRASP_And_SOLID
{
    public class FilePrinter : IPrinter
    {
        public void PrintRecipe(IRecipeContent salecontent)
        {
            File.WriteAllText("Recipe.txt", salecontent.GetTextToPrint());
        }
    }
}