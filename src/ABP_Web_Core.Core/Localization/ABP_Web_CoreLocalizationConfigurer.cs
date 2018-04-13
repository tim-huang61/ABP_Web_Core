using Abp.Configuration.Startup;
using Abp.Localization.Dictionaries;
using Abp.Localization.Dictionaries.Xml;
using Abp.Reflection.Extensions;

namespace ABP_Web_Core.Localization
{
    public static class ABP_Web_CoreLocalizationConfigurer
    {
        public static void Configure(ILocalizationConfiguration localizationConfiguration)
        {
            localizationConfiguration.Sources.Add(
                new DictionaryBasedLocalizationSource(ABP_Web_CoreConsts.LocalizationSourceName,
                    new XmlEmbeddedFileLocalizationDictionaryProvider(
                        typeof(ABP_Web_CoreLocalizationConfigurer).GetAssembly(),
                        "ABP_Web_Core.Localization.SourceFiles"
                    )
                )
            );
        }
    }
}
