namespace CSPOO.ProductsApp {

    public enum Categories {
        Undefined,
        Analgesics,
        Antibiotics,
        Antidiabetics,
        Antihypertensives,
        Antipyrethics,
        Materials
    }

    public abstract class PharmacyStock {
        protected List<Categories> Category = new();
    }
}
