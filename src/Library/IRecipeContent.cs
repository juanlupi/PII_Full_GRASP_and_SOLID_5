
namespace Full_GRASP_And_SOLID
{
    //DIP
    //Utilizo la interfaz IRecipeContent con un método GetTextToPrint que utilizarán 
    //ConsolePrinter, FilePrinter y Recipe
    public interface IRecipeContent
    {
        string GetTextToPrint();
    }
}