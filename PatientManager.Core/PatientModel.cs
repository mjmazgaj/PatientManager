namespace PatientManager.Core
{
    public class PatientModel : BaseModel
    {
        //TODO
        //JSON file contains only Treatment's Ids. Once the TreatmentModel is created List<TreatmentModel> is implemented.
        public List<int> Treatments { get; set; }
        public int? NumberOfTreatments { get => Treatments?.Count; }
        public string Description { get; set; }
    }
}
