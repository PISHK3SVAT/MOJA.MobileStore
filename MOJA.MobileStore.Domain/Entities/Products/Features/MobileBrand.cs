namespace MOJA.MobileStore.Domain.Entities.Products.Features
{
    public class MobileBrand : BaseProductFeatureEntity<int>
    {
        public string About { get; set; } = "";
        public string LogoPath { get; set; } = "";
    }
}
