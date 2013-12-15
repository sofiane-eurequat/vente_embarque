namespace vente_embarque.Core.Domain
{
    public class BusinessRule
    {
        public BusinessRule(string property, string rule)
        {
        Property = property;
        Rule = rule;
        }

        public string Property { get; set; }

        public string Rule { get; set; }
    }
}
