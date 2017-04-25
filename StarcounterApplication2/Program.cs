using System;
using Starcounter;

namespace StarcounterApplication2
{
    [Database]
    public class Company
    {
        public string FirstName;
        public string LastName;
        public QueryResultRows<Expense> Spendings => Db.SQL<Expense>("SELECT e FROM Expense e WHERE e.Spender=?", this);
        public decimal CurrentBalance => Db.SQL<decimal>("SELECT SUM(e.Amount) FROM Expense e WHERE e.Spender=?", this).First;
    }

    [Database]
    public class Expense
    {
        public Company Spender;
        public string Description;
        public decimal Amount;
    }

    class Program
    {
        static void Main()
        {
            Db.Transact(()=> {
                var person = Db.SQL<Company>("select c from Company c").First;
                if (person == null)
                {
                    new Company
                    {
                        FirstName = "Tauhid",
                        LastName = "Ahmed"
                    };
                }
            });

            Application.Current.Use(new HtmlFromJsonProvider());
            Application.Current.Use(new PartialToStandaloneHtmlProvider());

            Handle.GET("/helloworld", () =>
            {
                return Db.Scope(() =>
                {
                    var person = Db.SQL<Company>("SELECT p FROM Company p").First;
                    var json = new CompanyJson
                    {
                        Data = person
                    };
                    if (Session.Current == null)
                    {
                        Session.Current = new Session(SessionOptions.PatchVersioning);
                    }
                    json.Session = Session.Current;
                    return json;
                });
            });

            Handle.GET("/helloworld/partial/expense/{?}", (string id) =>
            {
                var json = new ExpenseJson()
                {
                    Data = DbHelper.FromID(DbHelper.Base64DecodeObjectID(id))
                };
                return json;
            });

        }
    }
}