using Starcounter;

namespace StarcounterApplication2
{
    partial class CompanyJson : Json
    {
        public string FullName => FirstName + " " + LastName;
        void Handle(Input.SaveTrigger save)
        {
            Transaction.Commit();
        }
    }
}
