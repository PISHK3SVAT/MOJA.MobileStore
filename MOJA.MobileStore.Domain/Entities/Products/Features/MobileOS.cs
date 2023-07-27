namespace MOJA.MobileStore.Domain.Entities.Products.Features
{
    public class MobileOS : BaseProductFeatureEntity<int>
    {
        public string Version { get; set; } = string.Empty;
    }
}
