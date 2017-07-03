namespace Zukini.API.Examples.Features.Ccmsi.MobileApi.Response
{
    public class EntityItemList
    {
        public string clientValue { get; set; }
        public string clientName { get; set; }
        public string claimNumber { get; set; }
        public string msiClaimNumber { get; set; }
        public string claimantLastName { get; set; }
        public string claimantFirstName { get; set; }
        public string claimantAddress { get; set; }
        public string claimStatus { get; set; }
        public string claimType { get; set; }
        public string coverageCode { get; set; }
        public double totalPaid { get; set; }
        public double outstandingReserve { get; set; }
        public double totalIncurred { get; set; }
        public string primaryInsuranceCompany { get; set; }
        public string issuingInsuranceCompany { get; set; }
        public string policyNumber { get; set; }
        public string policyEffectiveDate { get; set; }
        public double sirOrDeductibleAmount { get; set; }
        public string adjuster { get; set; }
        public string adjusterEmail { get; set; }
        public string lossType { get; set; }
        public string bodyPart { get; set; }
        public string causeCode { get; set; }
        public double currentAge { get; set; }
        public double craScore { get; set; }
        public string dateOfHire { get; set; }
        public double awwRate { get; set; }
        public double ttdRate { get; set; }
        public double ppdRate { get; set; }
        public string stateOfJurisdiction { get; set; }
        public string medicareEligibilityStatus { get; set; }
        public double ageAtTimeOfAccident { get; set; }
        public string accidentDescription { get; set; }
        public string dateOfLoss { get; set; }
        public string claimantReportDate { get; set; }
        public string claimSubmittedDate { get; set; }
        public string claimEntryDate { get; set; }
        public object dateOpened { get; set; }
        public object dateClosed { get; set; }
        public string claimDenied { get; set; }
        public string underInvestigation { get; set; }
        public string claimControverted { get; set; }
        public string attorneyRepresented { get; set; }
        public string plaintiffAttorney { get; set; }
        public string defenseAttorney { get; set; }
        public string memberNumber { get; set; }
    }
}