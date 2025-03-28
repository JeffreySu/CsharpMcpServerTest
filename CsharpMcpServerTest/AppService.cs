using ModelContextProtocol.Server;
using System.ComponentModel;

namespace CsharpMcpServerTest
{
    public interface IColorService
    {
        string GetColor();
    }   

    public class ColorService : IColorService
    {
        public string GetColor()
        {
            return "Red";
        }
    }

    [McpServerToolType]
    public class AppService(IColorService colorService)
    {
        [McpServerTool,Description("Get the name brand by given name")]
        public string GetNameBrand(string name)
        {
            return $"Hello {name} - {colorService.GetColor()}";
        }
    }


}
