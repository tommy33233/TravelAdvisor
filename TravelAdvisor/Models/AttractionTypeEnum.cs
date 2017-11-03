using System.ComponentModel;

namespace TravelAdvisor.Models
{
    public enum AttractionTypeEnum
    {
        [Description("Historical")] Historical = 1,

        [Description("Culture")] Culture = 2,

        [Description("Nature")] Nature = 3,

        [Description("Sport")] Sport = 4,

        [Description("Night Life")] NightLife = 5,

        [Description("Extreme")]  Extreme = 6
    }

}