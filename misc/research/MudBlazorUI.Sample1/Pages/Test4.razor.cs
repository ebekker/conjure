// Conjure application framework.
// Copyright (C) Conjure.

using ConjureApp.Data.Entities;

namespace MudBlazorUI.Sample1.Pages;

public partial class Test4
{
    private static int _id = 0;
    private readonly MyCustomer[] myLocalCustomers = new[]
    {
        new MyCustomer { CustomerID = ++_id, FirstName = "John" + _id, LastName = "Doe" + _id, },
        new MyCustomer { CustomerID = ++_id, FirstName = "Jane" + _id, LastName = "Doe" + _id, },
        new MyCustomer { CustomerID = ++_id, FirstName = "Jorg" + _id, LastName = "Dia" + _id, },
        new MyCustomer { CustomerID = ++_id, FirstName = "Jess" + _id, LastName = "Dia" + _id, },
        new MyCustomer { CustomerID = ++_id, FirstName = "John" + _id, LastName = "Doe" + _id, },
        new MyCustomer { CustomerID = ++_id, FirstName = "Jane" + _id, LastName = "Doe" + _id, },
        new MyCustomer { CustomerID = ++_id, FirstName = "Jorg" + _id, LastName = "Dia" + _id, },
        new MyCustomer { CustomerID = ++_id, FirstName = "Jess" + _id, LastName = "Dia" + _id, },
        new MyCustomer { CustomerID = ++_id, FirstName = "John" + _id, LastName = "Doe" + _id, },
        new MyCustomer { CustomerID = ++_id, FirstName = "Jane" + _id, LastName = "Doe" + _id, },
        new MyCustomer { CustomerID = ++_id, FirstName = "Jorg" + _id, LastName = "Dia" + _id, },
        new MyCustomer { CustomerID = ++_id, FirstName = "Jess" + _id, LastName = "Dia" + _id, },
        new MyCustomer { CustomerID = ++_id, FirstName = "John" + _id, LastName = "Doe" + _id, },
        new MyCustomer { CustomerID = ++_id, FirstName = "Jane" + _id, LastName = "Doe" + _id, },
        new MyCustomer { CustomerID = ++_id, FirstName = "Jorg" + _id, LastName = "Dia" + _id, },
        new MyCustomer { CustomerID = ++_id, FirstName = "Jess" + _id, LastName = "Dia" + _id, },
        new MyCustomer { CustomerID = ++_id, FirstName = "John" + _id, LastName = "Doe" + _id, },
        new MyCustomer { CustomerID = ++_id, FirstName = "Jane" + _id, LastName = "Doe" + _id, },
        new MyCustomer { CustomerID = ++_id, FirstName = "Jorg" + _id, LastName = "Dia" + _id, },
        new MyCustomer { CustomerID = ++_id, FirstName = "Jess" + _id, LastName = "Dia" + _id, },
        new MyCustomer { CustomerID = ++_id, FirstName = "John" + _id, LastName = "Doe" + _id, },
        new MyCustomer { CustomerID = ++_id, FirstName = "Jane" + _id, LastName = "Doe" + _id, },
        new MyCustomer { CustomerID = ++_id, FirstName = "Jorg" + _id, LastName = "Dia" + _id, },
        new MyCustomer { CustomerID = ++_id, FirstName = "Jess" + _id, LastName = "Dia" + _id, },
        new MyCustomer { CustomerID = ++_id, FirstName = "John" + _id, LastName = "Doe" + _id, },
        new MyCustomer { CustomerID = ++_id, FirstName = "Jane" + _id, LastName = "Doe" + _id, },
        new MyCustomer { CustomerID = ++_id, FirstName = "Jorg" + _id, LastName = "Dia" + _id, },
        new MyCustomer { CustomerID = ++_id, FirstName = "Jess" + _id, LastName = "Dia" + _id, },
        new MyCustomer { CustomerID = ++_id, FirstName = "John" + _id, LastName = "Doe" + _id, },
        new MyCustomer { CustomerID = ++_id, FirstName = "Jane" + _id, LastName = "Doe" + _id, },
        new MyCustomer { CustomerID = ++_id, FirstName = "Jorg" + _id, LastName = "Dia" + _id, },
        new MyCustomer { CustomerID = ++_id, FirstName = "Jess" + _id, LastName = "Dia" + _id, },
        new MyCustomer { CustomerID = ++_id, FirstName = "John" + _id, LastName = "Doe" + _id, },
        new MyCustomer { CustomerID = ++_id, FirstName = "Jane" + _id, LastName = "Doe" + _id, },
        new MyCustomer { CustomerID = ++_id, FirstName = "Jorg" + _id, LastName = "Dia" + _id, },
        new MyCustomer { CustomerID = ++_id, FirstName = "Jess" + _id, LastName = "Dia" + _id, },
        new MyCustomer { CustomerID = ++_id, FirstName = "John" + _id, LastName = "Doe" + _id, },
        new MyCustomer { CustomerID = ++_id, FirstName = "Jane" + _id, LastName = "Doe" + _id, },
        new MyCustomer { CustomerID = ++_id, FirstName = "Jorg" + _id, LastName = "Dia" + _id, },
        new MyCustomer { CustomerID = ++_id, FirstName = "Jess" + _id, LastName = "Dia" + _id, },
        new MyCustomer { CustomerID = ++_id, FirstName = "John" + _id, LastName = "Doe" + _id, },
        new MyCustomer { CustomerID = ++_id, FirstName = "Jane" + _id, LastName = "Doe" + _id, },
        new MyCustomer { CustomerID = ++_id, FirstName = "Jorg" + _id, LastName = "Dia" + _id, },
        new MyCustomer { CustomerID = ++_id, FirstName = "Jess" + _id, LastName = "Dia" + _id, },
    };
}

class MyCustomer : Customer
{
    public override string ToString()
    {
        return $"{{ID={CustomerID},FirstName={FirstName},LastName={LastName}}}";
    }
}
