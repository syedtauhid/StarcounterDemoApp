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

        void Handle(Input.AddNewExpense add)
        {
            Transaction.Commit();

            var expense = new Expense()
            {
                Spender = (Company) this.Data,
                Amount = 1
            };
            AddExpense(expense);
        }

        void AddExpense(Expense expense)
        {
            var expenseJson = Self.GET("/helloworld/partial/expense/" + expense.GetObjectID());
            this.Expenses.Add(expenseJson);
        }
    }
}
