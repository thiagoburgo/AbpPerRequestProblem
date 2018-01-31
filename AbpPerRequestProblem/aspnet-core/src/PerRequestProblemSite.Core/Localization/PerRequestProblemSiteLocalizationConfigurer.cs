using Abp.Configuration.Startup;
using Abp.Localization.Dictionaries;
using Abp.Localization.Dictionaries.Xml;
using Abp.Reflection.Extensions;

namespace PerRequestProblemSite.Localization
{
    public static class PerRequestProblemSiteLocalizationConfigurer
    {
        public static void Configure(ILocalizationConfiguration localizationConfiguration)
        {
            localizationConfiguration.Sources.Add(
                new DictionaryBasedLocalizationSource(PerRequestProblemSiteConsts.LocalizationSourceName,
                    new XmlEmbeddedFileLocalizationDictionaryProvider(
                        typeof(PerRequestProblemSiteLocalizationConfigurer).GetAssembly(),
                        "PerRequestProblemSite.Localization.SourceFiles"
                    )
                )
            );
        }
    }
}
