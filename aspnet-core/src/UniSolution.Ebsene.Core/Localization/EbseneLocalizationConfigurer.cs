using Abp.Configuration.Startup;
using Abp.Localization.Dictionaries;
using Abp.Localization.Dictionaries.Xml;
using Abp.Reflection.Extensions;

namespace UniSolution.Ebsene.Localization
{
    public static class EbseneLocalizationConfigurer
    {
        public static void Configure(ILocalizationConfiguration localizationConfiguration)
        {
            localizationConfiguration.Sources.Add(
                new DictionaryBasedLocalizationSource(EbseneConsts.LocalizationSourceName,
                    new XmlEmbeddedFileLocalizationDictionaryProvider(
                        typeof(EbseneLocalizationConfigurer).GetAssembly(),
                        "UniSolution.Ebsene.Localization.SourceFiles"
                    )
                )
            );
        }
    }
}
