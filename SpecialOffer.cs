//==========================================================
// Student Number : S10271061J
// Student Name : Nicole Tan
// Partner Name : Tan Jun Ming
//==========================================================

namespace S10271061_PRG2Assignment;

public class SpecialOffer
{
    public string OfferCode { get; set; }
    public string OfferDesc { get; set; }
    public double Discount { get; set; }

    public SpecialOffer(string offerCode, string offerDesc, double discount)
    {
        OfferCode = offerCode;
        OfferDesc = offerDesc;
        Discount = discount;
    }

    public override string ToString()
    {
        return "OfferCode: " + OfferCode + " OfferDesc: " + OfferDesc + " Discount: " + Discount;
    }
}
