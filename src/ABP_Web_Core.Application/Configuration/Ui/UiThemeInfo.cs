namespace ABP_Web_Core.Configuration.Ui
{
    public class UiThemeInfo
    {
        public string Name { get; }
        public string CssClass { get; }

        public UiThemeInfo(string name, string cssClass)
        {
            Name = name;
            CssClass = cssClass;
        }
    }
}
